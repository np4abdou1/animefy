using System;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000059 RID: 89
	internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x06000201 RID: 513 RVA: 0x0000E10B File Offset: 0x0000C30B
		protected virtual BigInteger GenerateSearchBase(int bits, object context)
		{
			BigInteger bigInteger = BigInteger.GenerateRandom(bits);
			bigInteger.SetBit(0U);
			return bigInteger;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000E11A File Offset: 0x0000C31A
		public override BigInteger GenerateNewPrime(int bits)
		{
			return this.GenerateNewPrime(bits, null);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000E124 File Offset: 0x0000C324
		public virtual BigInteger GenerateNewPrime(int bits, object context)
		{
			BigInteger bigInteger = this.GenerateSearchBase(bits, context);
			uint num = bigInteger % 3234846615U;
			int trialDivisionBounds = this.TrialDivisionBounds;
			uint[] smallPrimes = BigInteger.smallPrimes;
			for (;;)
			{
				if (num % 3U != 0U && num % 5U != 0U && num % 7U != 0U && num % 11U != 0U && num % 13U != 0U && num % 17U != 0U && num % 19U != 0U && num % 23U != 0U && num % 29U != 0U)
				{
					int num2 = 10;
					while (num2 < smallPrimes.Length && (ulong)smallPrimes[num2] <= (ulong)((long)trialDivisionBounds))
					{
						if (bigInteger % smallPrimes[num2] == 0U)
						{
							goto IL_9D;
						}
						num2++;
					}
					if (this.IsPrimeAcceptable(bigInteger, context) && this.PrimalityTest(bigInteger, this.Confidence))
					{
						break;
					}
				}
				IL_9D:
				num += 2U;
				if (num >= 3234846615U)
				{
					num -= 3234846615U;
				}
				bigInteger.Incr2();
			}
			return bigInteger;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000B18D File Offset: 0x0000938D
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context)
		{
			return true;
		}
	}
}
