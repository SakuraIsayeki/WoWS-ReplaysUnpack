﻿using Razorvine.Pickle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodsoft.WowsReplaysUnpack;

internal class CamouflageInfo : IObjectConstructor
{
	public object construct(object[] args)
	{
		//Console.WriteLine("{0}, {1}", args);
		return string.Format("{0}, {1}", args);
	}
}