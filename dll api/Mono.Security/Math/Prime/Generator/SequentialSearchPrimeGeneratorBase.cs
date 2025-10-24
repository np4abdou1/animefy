using System;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x0200005B RID: 91
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0000E727 File Offset: 0x0000C927
		protected virtual BigInteger GenerateSearchBase(int bits, object context)
		{
			BigInteger bigInteger = BigInteger.GenerateRandom(bits);
			bigInteger.SetBit(0U);
			return bigInteger;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000E736 File Offset: 0x0000C936
		public override BigInteger GenerateNewPrime(int bits)
		{
			return this.GenerateNewPrime(bits, null);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000E740 File Offset: 0x0000C940
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

		// Token: 0x06000221 RID: 545 RVA: 0x0000E808 File Offset: 0x0000CA08
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context)
		{
			return true;
		}
	}
}
