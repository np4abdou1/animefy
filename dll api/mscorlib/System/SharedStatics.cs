using System;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Util;
using System.Threading;

namespace System
{
	// Token: 0x02000153 RID: 339
	internal sealed class SharedStatics
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x00003ACD File Offset: 0x00001CCD
		private SharedStatics()
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00038EE0 File Offset: 0x000370E0
		[SecuritySafeCritical]
		public static Tokenizer.StringMaker GetSharedStringMaker()
		{
			Tokenizer.StringMaker stringMaker = null;
			bool flag = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				Monitor.Enter(SharedStatics._sharedStatics, ref flag);
				if (SharedStatics._sharedStatics._maker != null)
				{
					stringMaker = SharedStatics._sharedStatics._maker;
					SharedStatics._sharedStatics._maker = null;
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(SharedStatics._sharedStatics);
				}
			}
			if (stringMaker == null)
			{
				stringMaker = new Tokenizer.StringMaker();
			}
			return stringMaker;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00038F50 File Offset: 0x00037150
		[SecuritySafeCritical]
		public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker)
		{
			bool flag = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				Monitor.Enter(SharedStatics._sharedStatics, ref flag);
				SharedStatics._sharedStatics._maker = maker;
				maker = null;
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(SharedStatics._sharedStatics);
				}
			}
		}

		// Token: 0x0400046A RID: 1130
		private static readonly SharedStatics _sharedStatics = new SharedStatics();

		// Token: 0x0400046B RID: 1131
		private Tokenizer.StringMaker _maker;
	}
}
