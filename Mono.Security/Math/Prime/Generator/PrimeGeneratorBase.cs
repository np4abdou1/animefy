using System;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x0200005A RID: 90
	public abstract class PrimeGeneratorBase
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000E70F File Offset: 0x0000C90F
		public virtual ConfidenceFactor Confidence
		{
			get
			{
				return ConfidenceFactor.Medium;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000E712 File Offset: 0x0000C912
		public virtual PrimalityTest PrimalityTest
		{
			get
			{
				return new PrimalityTest(PrimalityTests.RabinMillerTest);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000E720 File Offset: 0x0000C920
		public virtual int TrialDivisionBounds
		{
			get
			{
				return 4000;
			}
		}

		// Token: 0x0600021C RID: 540
		public abstract BigInteger GenerateNewPrime(int bits);
	}
}
