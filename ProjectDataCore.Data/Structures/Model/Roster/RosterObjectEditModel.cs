﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataCore.Data.Structures.Model.Roster;

public class RosterObjectEditModel
{
    public string? Name { get; set; }
    public Optional<Guid?> ParentRosterId { get; set; }
    public int? Order { get; set; }
}
