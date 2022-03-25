﻿using ProjectDataCore.Data.Structures.Nav;

namespace ProjectDataCore.Data.Services.Nav;

public class NavModuleService : INavModuleService
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public NavModuleService(IDbContextFactory<ApplicationDbContext> dbContextFactory) => _dbContextFactory = dbContextFactory;
    
    public async Task<List<NavModule>> GetAllModules()
    {
        await using var _dbContext = await _dbContextFactory.CreateDbContextAsync();
        return await _dbContext.NavModules.ToListAsync();
    }

    public async Task<List<NavModule>> GetAllModulesWithChildren()
    {
        await using var _dbContext = await _dbContextFactory.CreateDbContextAsync();
        var modules =  await _dbContext.NavModules.Where(e => e.ParentId == null).ToListAsync();
        foreach(var module in modules)
            await LoadNavModule(module);
        return modules;
    }

    protected async Task LoadNavModule(NavModule item)
    {
        await using var _dbContext = await _dbContextFactory.CreateDbContextAsync();
        var obj = _dbContext.Attach(item);
            await obj.Collection(e => e.SubModules)
                .LoadAsync();

            Queue<NavModule> navModules = new();
            foreach (var t in item.SubModules)
                navModules.Enqueue(t);

            while (navModules.TryDequeue(out var module))
            {
                obj = _dbContext.Entry(module);
                await obj.Collection(e => e.SubModules)
                    .LoadAsync();

                foreach (var t in module.SubModules)
                    navModules.Enqueue(t);
            }
    }

    public async Task<ActionResult<Guid>> CreateNavModuleAsync(string displayName, string href, bool hasMainPage, Guid? parent = null)
    {
        await using var _dbContext = await _dbContextFactory.CreateDbContextAsync();

        try
        {
            var module = new NavModule(displayName, href, hasMainPage) { ParentId = parent };
            _dbContext.Add(module);
            await _dbContext.SaveChangesAsync();
            return new(true, result: module.Key);
        }
        catch (Exception ex)
        {
            return new(false, new() { ex.Message });
        }

    }

    public async Task<ActionResult> CreateNavModuleAsync(NavModule module)
    {
        await using var _dbContext = await _dbContextFactory.CreateDbContextAsync();

        try
        {
            if (module.PageId != null)
                module.Href = (await _dbContext.CustomPageSettings.FindAsync(module.PageId)).Route;
            _dbContext.Add(module);
            await _dbContext.SaveChangesAsync();
            return new(true);
        }
        catch (Exception ex)
        {
            return new(false, new() { ex.Message });
        }
    }

    public async Task<ActionResult> DeleteNavModule(Guid key)
    {
        await using var _dbContext = await _dbContextFactory.CreateDbContextAsync();
        NavModule module = await _dbContext.NavModules.FindAsync(key);
        await LoadNavModule(module);
        if (module.SubModules.Any())
            foreach (var subModule in module.SubModules)
            {
                _dbContext.Remove(subModule);
            }
        _dbContext.Remove(module);
        _dbContext.SaveChanges();
        return new(true);
    }

    public async Task<ActionResult> UpdateNavModuleAsync(NavModule navModule)
    {
        if (navModule == null)
        {
            return new(false, new() {"Paramater is null"});
        }
        await using var _dbContext = await _dbContextFactory.CreateDbContextAsync();
        NavModule module = await _dbContext.FindAsync<NavModule>(navModule.Key);
        if (module is null)
        {
            return new(false, new() { "Module not found" });
        }
        if (module.HasMainPage != navModule.HasMainPage)
            module.HasMainPage = navModule.HasMainPage;
        if (module.Href != navModule.Href)
            module.Href = navModule.Href;
        if (module.ParentId!= navModule.ParentId)
            module.ParentId = navModule.ParentId;
        if (module.DisplayName != navModule.DisplayName)
            module.DisplayName = navModule.DisplayName;
        if (module.PageId != navModule.PageId)
        {
            module.PageId = navModule.PageId;
            if (module.PageId is not null)
            {
                module.Href = (await _dbContext.CustomPageSettings.FindAsync(module.PageId)).Route;
            }
        }
        await _dbContext.SaveChangesAsync();
        return new(true);
    }
}