using System;
using System.Collections.Generic;

namespace System.Diagnostics
{
	/// <summary>Provides an abstract base class to create new debugging and tracing switches.</summary>
	// Token: 0x020000BE RID: 190
	public abstract class Switch
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class.</summary>
		/// <param name="displayName">The name of the switch. </param>
		/// <param name="description">The description for the switch. </param>
		// Token: 0x060005AF RID: 1455 RVA: 0x00023E9A File Offset: 0x0002209A
		protected Switch(string displayName, string description) : this(displayName, description, "0")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Switch" /> class, specifying the display name, description, and default value for the switch. </summary>
		/// <param name="displayName">The name of the switch. </param>
		/// <param name="description">The description of the switch. </param>
		/// <param name="defaultSwitchValue">The default value for the switch.</param>
		// Token: 0x060005B0 RID: 1456 RVA: 0x00023EAC File Offset: 0x000220AC
		protected Switch(string displayName, string description, string defaultSwitchValue)
		{
			if (displayName == null)
			{
				displayName = string.Empty;
			}
			this.displayName = displayName;
			this.description = description;
			List<WeakReference> obj = Switch.switches;
			lock (obj)
			{
				Switch._pruneCachedSwitches();
				Switch.switches.Add(new WeakReference(this));
			}
			this.defaultValue = defaultSwitchValue;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00023F2C File Offset: 0x0002212C
		private static void _pruneCachedSwitches()
		{
			List<WeakReference> obj = Switch.switches;
			lock (obj)
			{
				if (Switch.s_LastCollectionCount != GC.CollectionCount(2))
				{
					List<WeakReference> list = new List<WeakReference>(Switch.switches.Count);
					for (int i = 0; i < Switch.switches.Count; i++)
					{
						if ((Switch)Switch.switches[i].Target != null)
						{
							list.Add(Switch.switches[i]);
						}
					}
					if (list.Count < Switch.switches.Count)
					{
						Switch.switches.Clear();
						Switch.switches.AddRange(list);
						Switch.switches.TrimExcess();
					}
					Switch.s_LastCollectionCount = GC.CollectionCount(2);
				}
			}
		}

		// Token: 0x0400039E RID: 926
		private readonly string description;

		// Token: 0x0400039F RID: 927
		private readonly string displayName;

		// Token: 0x040003A0 RID: 928
		private volatile string switchValueString = string.Empty;

		// Token: 0x040003A1 RID: 929
		private string defaultValue;

		// Token: 0x040003A2 RID: 930
		private static List<WeakReference> switches = new List<WeakReference>();

		// Token: 0x040003A3 RID: 931
		private static int s_LastCollectionCount;
	}
}
