using System;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000058 RID: 88
	internal abstract class PrimeGeneratorBase
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		public virtual ConfidenceFactor Confidence
		{
			get
			{
				return ConfidenceFactor.Medium;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		public virtual PrimalityTest PrimalityTest
		{
			get
			{
				return new PrimalityTest(PrimalityTests.RabinMillerTest);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000E104 File Offset: 0x0000C304
		public virtual int TrialDivisionBounds
		{
			get
			{
				return 4000;
			}
		}

		// Token: 0x060001FF RID: 511
		public abstract BigInteger GenerateNewPrime(int bits);
	}
}
