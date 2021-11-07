﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataCore.Data.Structures.Roster;

/// <summary>
/// A section on the roster, such as a platoon or squad.
/// </summary>
public class RosterTree : DataObject<Guid>
{
    public List<RosterTree> ChildRosters { get; set; } = new();
    public List<RosterPosition> RosterPositions { get; set; } = new();
    public string RosterName { get; set; }

    public RosterTree ParentRoster { get; set; }
    public Guid ParentRosterId { get; set; }
}
