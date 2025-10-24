using System;
using System.Threading;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000A1 RID: 161
	internal sealed class ExclusiveReference
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x000166FC File Offset: 0x000148FC
		public RegexRunner Get()
		{
			if (Interlocked.Exchange(ref this._locked, 1) != 0)
			{
				return null;
			}
			RegexRunner @ref = this._ref;
			if (@ref == null)
			{
				this._locked = 0;
				return null;
			}
			this._obj = @ref;
			return @ref;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00016738 File Offset: 0x00014938
		public void Release(RegexRunner obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (this._obj == obj)
			{
				this._obj = null;
				this._locked = 0;
				return;
			}
			if (this._obj == null && Interlocked.Exchange(ref this._locked, 1) == 0)
			{
				if (this._ref == null)
				{
					this._ref = obj;
				}
				this._locked = 0;
				return;
			}
		}

		// Token: 0x040002B1 RID: 689
		private RegexRunner _ref;

		// Token: 0x040002B2 RID: 690
		private RegexRunner _obj;

		// Token: 0x040002B3 RID: 691
		private volatile int _locked;
	}
}
