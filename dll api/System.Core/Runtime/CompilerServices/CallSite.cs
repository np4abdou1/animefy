using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>A dynamic call site base class. This type is used as a parameter type to the dynamic site targets.</summary>
	// Token: 0x02000102 RID: 258
	public class CallSite
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0002169A File Offset: 0x0001F89A
		internal CallSite(CallSiteBinder binder)
		{
			this._binder = binder;
		}

		/// <summary>Class responsible for binding dynamic operations on the dynamic site.</summary>
		/// <returns>The <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" /> object responsible for binding dynamic operations.</returns>
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000216A9 File Offset: 0x0001F8A9
		public CallSiteBinder Binder
		{
			get
			{
				return this._binder;
			}
		}

		// Token: 0x0400028F RID: 655
		internal readonly CallSiteBinder _binder;

		// Token: 0x04000290 RID: 656
		internal bool _match;
	}
}
