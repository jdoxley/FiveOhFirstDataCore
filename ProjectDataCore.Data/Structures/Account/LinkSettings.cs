﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataCore.Data.Structures.Account;
public class LinkSettings : DataObject<Guid>
{
    public bool RequireDiscordLink { get; set; } = false;
    public bool RequireSteamLink { get; set; } = false;
}