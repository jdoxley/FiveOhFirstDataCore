﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectDataCore.Data.Database;

#nullable disable

namespace ProjectDataCore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectDataCore.Data.Account.DataCoreRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("ProjectDataCore.Data.Account.DataCoreUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AccessCode")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<decimal?>("DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("DisplayId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("SteamLink")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("AllowMultiple")
                        .HasColumnType("boolean");

                    b.Property<int>("AllowedInput")
                        .HasColumnType("integer");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.ToTable("AssignableConfigurations");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseAssignableConfiguration");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AssignableConfigurationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ForUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Key");

                    b.HasIndex("AssignableConfigurationId");

                    b.HasIndex("ForUserId");

                    b.ToTable("AssignableValues");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseAssignableValue");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.PageComponentSettingsBase", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ParentLayoutId")
                        .HasColumnType("uuid");

                    b.Property<string>("QualifiedTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.HasIndex("ParentLayoutId");

                    b.ToTable("PageComponentSettingsBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PageComponentSettingsBase");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.CustomPageSettings", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("LayoutId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.HasIndex("Route")
                        .IsUnique();

                    b.ToTable("CustomPageSettings");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterDisplaySettings", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("HostRosterId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.HasIndex("HostRosterId");

                    b.ToTable("RosterDisplaySettings");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterObject", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.ToTable("RosterObject");

                    b.HasDiscriminator<string>("Discriminator").HasValue("RosterObject");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterOrder", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<Guid>("ParentObjectId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("SlotToOrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TreeToOrderId")
                        .HasColumnType("uuid");

                    b.HasKey("Key");

                    b.HasIndex("ParentObjectId");

                    b.HasIndex("SlotToOrderId")
                        .IsUnique();

                    b.HasIndex("TreeToOrderId");

                    b.ToTable("RosterOrders");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Util.DataCoreUserProperty", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Alias")
                        .HasColumnType("integer");

                    b.Property<string>("FormatString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("RosterComponentDefaultDisplayId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RosterComponentUserListingDisplayId")
                        .HasColumnType("uuid");

                    b.HasKey("Key");

                    b.HasIndex("RosterComponentDefaultDisplayId");

                    b.HasIndex("RosterComponentUserListingDisplayId");

                    b.ToTable("DataCoreUserProperty");
                });

            modelBuilder.Entity("RosterComponentSettingsRosterDisplaySettings", b =>
                {
                    b.Property<Guid>("AvalibleRostersKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DisplayComponentsKey")
                        .HasColumnType("uuid");

                    b.HasKey("AvalibleRostersKey", "DisplayComponentsKey");

                    b.HasIndex("DisplayComponentsKey");

                    b.ToTable("RosterComponentSettingsRosterDisplaySettings");
                });

            modelBuilder.Entity("RosterTreeRosterTree", b =>
                {
                    b.Property<Guid>("ChildRostersKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ParentRostersKey")
                        .HasColumnType("uuid");

                    b.HasKey("ChildRostersKey", "ParentRostersKey");

                    b.HasIndex("ParentRostersKey");

                    b.ToTable("RosterTreeRosterTree");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.DateOnlyValueAssignableConfiguration", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration");

                    b.Property<List<DateOnly>>("AllowedValues")
                        .IsRequired()
                        .HasColumnType("date[]");

                    b.HasDiscriminator().HasValue("DateOnlyValueAssignableConfiguration");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.DateTimeValueAssignableConfiguration", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration");

                    b.Property<List<DateTime>>("AllowedValues")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone[]")
                        .HasColumnName("DateTimeValueAssignableConfiguration_AllowedValues");

                    b.HasDiscriminator().HasValue("DateTimeValueAssignableConfiguration");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.DoubleValueAssignableConfiguration", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration");

                    b.Property<List<double>>("AllowedValues")
                        .IsRequired()
                        .HasColumnType("double precision[]")
                        .HasColumnName("DoubleValueAssignableConfiguration_AllowedValues");

                    b.HasDiscriminator().HasValue("DoubleValueAssignableConfiguration");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.IntegerValueAssignableConfiguration", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration");

                    b.Property<List<int>>("AllowedValues")
                        .IsRequired()
                        .HasColumnType("integer[]")
                        .HasColumnName("IntegerValueAssignableConfiguration_AllowedValues");

                    b.HasDiscriminator().HasValue("IntegerValueAssignableConfiguration");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.StringValueAssignableConfiguration", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration");

                    b.Property<List<string>>("AllowedValues")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("StringValueAssignableConfiguration_AllowedValues");

                    b.HasDiscriminator().HasValue("StringValueAssignableConfiguration");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.TimeOnlyValueAssignableConfiguration", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration");

                    b.Property<List<TimeOnly>>("AllowedValues")
                        .IsRequired()
                        .HasColumnType("time without time zone[]")
                        .HasColumnName("TimeOnlyValueAssignableConfiguration_AllowedValues");

                    b.HasDiscriminator().HasValue("TimeOnlyValueAssignableConfiguration");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.DateOnlyAssignableValue", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue");

                    b.Property<List<DateOnly>>("SetValue")
                        .IsRequired()
                        .HasColumnType("date[]");

                    b.HasDiscriminator().HasValue("DateOnlyAssignableValue");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.DateTimeAssignableValue", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue");

                    b.Property<List<DateTime>>("SetValue")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone[]")
                        .HasColumnName("DateTimeAssignableValue_SetValue");

                    b.HasDiscriminator().HasValue("DateTimeAssignableValue");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.DoubleAssignableValue", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue");

                    b.Property<List<double>>("SetValue")
                        .IsRequired()
                        .HasColumnType("double precision[]")
                        .HasColumnName("DoubleAssignableValue_SetValue");

                    b.HasDiscriminator().HasValue("DoubleAssignableValue");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.IntegerAssignableValue", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue");

                    b.Property<List<int>>("SetValue")
                        .IsRequired()
                        .HasColumnType("integer[]")
                        .HasColumnName("IntegerAssignableValue_SetValue");

                    b.HasDiscriminator().HasValue("IntegerAssignableValue");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.StringAssignableValue", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue");

                    b.Property<List<string>>("SetValue")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("StringAssignableValue_SetValue");

                    b.HasDiscriminator().HasValue("StringAssignableValue");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.TimeOnlyAssignableValue", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue");

                    b.Property<List<TimeOnly>>("SetValue")
                        .IsRequired()
                        .HasColumnType("time without time zone[]")
                        .HasColumnName("TimeOnlyAssignableValue_SetValue");

                    b.HasDiscriminator().HasValue("TimeOnlyAssignableValue");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.LayoutComponentSettings", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Page.Components.PageComponentSettingsBase");

                    b.Property<int>("MaxChildComponents")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ParentPageId")
                        .HasColumnType("uuid");

                    b.HasIndex("ParentPageId")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("LayoutComponentSettings");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.ParameterComponentSettingsBase", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Page.Components.PageComponentSettingsBase");

                    b.Property<string>("Label")
                        .HasColumnType("text");

                    b.Property<string>("PropertyToEdit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("StaticProperty")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("UserScopeId")
                        .HasColumnType("uuid");

                    b.HasIndex("UserScopeId");

                    b.HasDiscriminator().HasValue("ParameterComponentSettingsBase");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.RosterComponentSettings", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Page.Components.PageComponentSettingsBase");

                    b.Property<bool>("AllowUserLisiting")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("DefaultRoster")
                        .HasColumnType("uuid");

                    b.Property<int>("Depth")
                        .HasColumnType("integer");

                    b.Property<int>("LevelFromTop")
                        .HasColumnType("integer");

                    b.Property<bool>("Scoped")
                        .HasColumnType("boolean");

                    b.HasDiscriminator().HasValue("RosterComponentSettings");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterSlot", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Roster.RosterObject");

                    b.Property<Guid?>("OccupiedById")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ParentRosterId")
                        .HasColumnType("uuid");

                    b.HasIndex("OccupiedById");

                    b.HasIndex("ParentRosterId");

                    b.HasDiscriminator().HasValue("RosterSlot");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterTree", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Roster.RosterObject");

                    b.HasDiscriminator().HasValue("RosterTree");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.DisplayComponentSettings", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Page.Components.ParameterComponentSettingsBase");

                    b.Property<string>("FormatString")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("DisplayComponentSettings");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.EditableComponentSettings", b =>
                {
                    b.HasBaseType("ProjectDataCore.Data.Structures.Page.Components.ParameterComponentSettingsBase");

                    b.Property<string>("Placeholder")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("EditableComponentSettings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Account.DataCoreRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Account.DataCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Account.DataCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Account.DataCoreRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectDataCore.Data.Account.DataCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Account.DataCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Value.BaseAssignableValue", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration", "AssignableConfiguration")
                        .WithMany("AssignableValues")
                        .HasForeignKey("AssignableConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectDataCore.Data.Account.DataCoreUser", "ForUser")
                        .WithMany("AssignableValues")
                        .HasForeignKey("ForUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignableConfiguration");

                    b.Navigation("ForUser");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.PageComponentSettingsBase", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Page.Components.LayoutComponentSettings", "ParentLayout")
                        .WithMany("ChildComponents")
                        .HasForeignKey("ParentLayoutId");

                    b.Navigation("ParentLayout");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterDisplaySettings", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterTree", "HostRoster")
                        .WithMany("DisplaySettings")
                        .HasForeignKey("HostRosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HostRoster");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterOrder", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterTree", "ParentObject")
                        .WithMany("OrderChildren")
                        .HasForeignKey("ParentObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterSlot", "SlotToOrder")
                        .WithOne("Order")
                        .HasForeignKey("ProjectDataCore.Data.Structures.Roster.RosterOrder", "SlotToOrderId");

                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterTree", "TreeToOrder")
                        .WithMany("Order")
                        .HasForeignKey("TreeToOrderId");

                    b.Navigation("ParentObject");

                    b.Navigation("SlotToOrder");

                    b.Navigation("TreeToOrder");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Util.DataCoreUserProperty", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Page.Components.RosterComponentSettings", null)
                        .WithMany("DefaultDisplayedProperties")
                        .HasForeignKey("RosterComponentDefaultDisplayId");

                    b.HasOne("ProjectDataCore.Data.Structures.Page.Components.RosterComponentSettings", null)
                        .WithMany("UserListDisplayedProperties")
                        .HasForeignKey("RosterComponentUserListingDisplayId")
                        .HasConstraintName("FK_DataCoreUserProperty_PageComponentSettingsBase_RosterCompo~1");
                });

            modelBuilder.Entity("RosterComponentSettingsRosterDisplaySettings", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterDisplaySettings", null)
                        .WithMany()
                        .HasForeignKey("AvalibleRostersKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectDataCore.Data.Structures.Page.Components.RosterComponentSettings", null)
                        .WithMany()
                        .HasForeignKey("DisplayComponentsKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RosterTreeRosterTree", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterTree", null)
                        .WithMany()
                        .HasForeignKey("ChildRostersKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterTree", null)
                        .WithMany()
                        .HasForeignKey("ParentRostersKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.LayoutComponentSettings", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Page.CustomPageSettings", "ParentPage")
                        .WithOne("Layout")
                        .HasForeignKey("ProjectDataCore.Data.Structures.Page.Components.LayoutComponentSettings", "ParentPageId");

                    b.Navigation("ParentPage");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.ParameterComponentSettingsBase", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Structures.Page.Components.PageComponentSettingsBase", "UserScope")
                        .WithMany("AttachedScopes")
                        .HasForeignKey("UserScopeId");

                    b.Navigation("UserScope");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterSlot", b =>
                {
                    b.HasOne("ProjectDataCore.Data.Account.DataCoreUser", "OccupiedBy")
                        .WithMany("RosterSlots")
                        .HasForeignKey("OccupiedById");

                    b.HasOne("ProjectDataCore.Data.Structures.Roster.RosterTree", "ParentRoster")
                        .WithMany("RosterPositions")
                        .HasForeignKey("ParentRosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OccupiedBy");

                    b.Navigation("ParentRoster");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Account.DataCoreUser", b =>
                {
                    b.Navigation("AssignableValues");

                    b.Navigation("RosterSlots");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Assignable.Configuration.BaseAssignableConfiguration", b =>
                {
                    b.Navigation("AssignableValues");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.PageComponentSettingsBase", b =>
                {
                    b.Navigation("AttachedScopes");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.CustomPageSettings", b =>
                {
                    b.Navigation("Layout");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.LayoutComponentSettings", b =>
                {
                    b.Navigation("ChildComponents");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Page.Components.RosterComponentSettings", b =>
                {
                    b.Navigation("DefaultDisplayedProperties");

                    b.Navigation("UserListDisplayedProperties");
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterSlot", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectDataCore.Data.Structures.Roster.RosterTree", b =>
                {
                    b.Navigation("DisplaySettings");

                    b.Navigation("Order");

                    b.Navigation("OrderChildren");

                    b.Navigation("RosterPositions");
                });
#pragma warning restore 612, 618
        }
    }
}
