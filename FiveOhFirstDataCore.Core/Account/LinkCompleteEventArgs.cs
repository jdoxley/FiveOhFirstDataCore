﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveOhFirstDataCore.Core.Account
{
	public class LinkCompleteEventArgs
	{
		public bool Complete { get; internal set; }
		public ulong Guild { get; internal set; }
		public Trooper? LinkedTrooper { get; internal set; }
	}
}
