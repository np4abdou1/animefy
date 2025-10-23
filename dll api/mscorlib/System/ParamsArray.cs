using System;

namespace System
{
	// Token: 0x020000E8 RID: 232
	internal readonly struct ParamsArray
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00022F99 File Offset: 0x00021199
		public ParamsArray(object arg0)
		{
			this._arg0 = arg0;
			this._arg1 = null;
			this._arg2 = null;
			this._args = ParamsArray.s_oneArgArray;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00022FBB File Offset: 0x000211BB
		public ParamsArray(object arg0, object arg1)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = null;
			this._args = ParamsArray.s_twoArgArray;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00022FDD File Offset: 0x000211DD
		public ParamsArray(object arg0, object arg1, object arg2)
		{
			this._arg0 = arg0;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._args = ParamsArray.s_threeArgArray;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00023000 File Offset: 0x00021200
		public ParamsArray(object[] args)
		{
			int num = args.Length;
			this._arg0 = ((num > 0) ? args[0] : null);
			this._arg1 = ((num > 1) ? args[1] : null);
			this._arg2 = ((num > 2) ? args[2] : null);
			this._args = args;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00023048 File Offset: 0x00021248
		public int Length
		{
			get
			{
				return this._args.Length;
			}
		}

		// Token: 0x17000085 RID: 133
		public object this[int index]
		{
			get
			{
				if (index != 0)
				{
					return this.GetAtSlow(index);
				}
				return this._arg0;
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00023065 File Offset: 0x00021265
		private object GetAtSlow(int index)
		{
			if (index == 1)
			{
				return this._arg1;
			}
			if (index == 2)
			{
				return this._arg2;
			}
			return this._args[index];
		}

		// Token: 0x04000349 RID: 841
		private static readonly object[] s_oneArgArray = new object[1];

		// Token: 0x0400034A RID: 842
		private static readonly object[] s_twoArgArray = new object[2];

		// Token: 0x0400034B RID: 843
		private static readonly object[] s_threeArgArray = new object[3];

		// Token: 0x0400034C RID: 844
		private readonly object _arg0;

		// Token: 0x0400034D RID: 845
		private readonly object _arg1;

		// Token: 0x0400034E RID: 846
		private readonly object _arg2;

		// Token: 0x0400034F RID: 847
		private readonly object[] _args;
	}
}
