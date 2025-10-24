using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Creates or associates parameter information.</summary>
	// Token: 0x02000514 RID: 1300
	[StructLayout(0)]
	public class ParameterBuilder
	{
		// Token: 0x060025F5 RID: 9717 RVA: 0x00095508 File Offset: 0x00093708
		internal ParameterBuilder(MethodBase mb, int pos, ParameterAttributes attributes, string strParamName)
		{
			this.name = strParamName;
			this.position = pos;
			this.attrs = attributes;
			this.methodb = mb;
			if (mb is DynamicMethod)
			{
				this.table_idx = 0;
				return;
			}
			this.table_idx = mb.get_next_table_index(this, 8, 1);
		}

		/// <summary>Retrieves the attributes for this parameter.</summary>
		/// <returns>Read-only. Retrieves the attributes for this parameter.</returns>
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x00095557 File Offset: 0x00093757
		public virtual int Attributes
		{
			get
			{
				return (int)this.attrs;
			}
		}

		/// <summary>Retrieves the name of this parameter.</summary>
		/// <returns>Read-only. Retrieves the name of this parameter.</returns>
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x0009555F File Offset: 0x0009375F
		public virtual string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Retrieves the signature position for this parameter.</summary>
		/// <returns>Read-only. Retrieves the signature position for this parameter.</returns>
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x00095567 File Offset: 0x00093767
		public virtual int Position
		{
			get
			{
				return this.position;
			}
		}

		// Token: 0x04001392 RID: 5010
		private MethodBase methodb;

		// Token: 0x04001393 RID: 5011
		private string name;

		// Token: 0x04001394 RID: 5012
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04001395 RID: 5013
		private UnmanagedMarshal marshal_info;

		// Token: 0x04001396 RID: 5014
		private ParameterAttributes attrs;

		// Token: 0x04001397 RID: 5015
		private int position;

		// Token: 0x04001398 RID: 5016
		private int table_idx;

		// Token: 0x04001399 RID: 5017
		private object def_value;
	}
}
