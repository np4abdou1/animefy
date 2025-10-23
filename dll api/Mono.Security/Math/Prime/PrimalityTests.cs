﻿using System;

namespace Mono.Math.Prime
{
	// Token: 0x02000059 RID: 89
	public sealed class PrimalityTests
	{
		// Token: 0x06000217 RID: 535 RVA: 0x0000E518 File Offset: 0x0000C718
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
		{
			int num = bi.BitCount();
			int num2;
			if (num <= 100)
			{
				num2 = 27;
			}
			else if (num <= 150)
			{
				num2 = 18;
			}
			else if (num <= 200)
			{
				num2 = 15;
			}
			else if (num <= 250)
			{
				num2 = 12;
			}
			else if (num <= 300)
			{
				num2 = 9;
			}
			else if (num <= 350)
			{
				num2 = 8;
			}
			else if (num <= 400)
			{
				num2 = 7;
			}
			else if (num <= 500)
			{
				num2 = 6;
			}
			else if (num <= 600)
			{
				num2 = 5;
			}
			else if (num <= 800)
			{
				num2 = 4;
			}
			else if (num <= 1250)
			{
				num2 = 3;
			}
			else
			{
				num2 = 2;
			}
			switch (confidence)
			{
			case ConfidenceFactor.ExtraLow:
				num2 >>= 2;
				if (num2 == 0)
				{
					return 1;
				}
				return num2;
			case ConfidenceFactor.Low:
				num2 >>= 1;
				if (num2 == 0)
				{
					return 1;
				}
				return num2;
			case ConfidenceFactor.Medium:
				return num2;
			case ConfidenceFactor.High:
				return num2 << 1;
			case ConfidenceFactor.ExtraHigh:
				return num2 << 2;
			case ConfidenceFactor.Provable:
				throw new Exception("The Rabin-Miller test can not be executed in a way such that its results are provable");
			default:
				throw new ArgumentOutOfRangeException("confidence");
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000E60C File Offset: 0x0000C80C
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
		{
			int num = n.BitCount();
			int spprounds = PrimalityTests.GetSPPRounds(num, confidence);
			BigInteger bigInteger = n - 1;
			int num2 = bigInteger.LowestSetBit();
			BigInteger bigInteger2 = bigInteger >> num2;
			BigInteger.ModulusRing modulusRing = new BigInteger.ModulusRing(n);
			BigInteger bigInteger3 = null;
			if (n.BitCount() > 100)
			{
				bigInteger3 = modulusRing.Pow(2U, bigInteger2);
			}
			for (int i = 0; i < spprounds; i++)
			{
				if (i > 0 || bigInteger3 == null)
				{
					BigInteger bigInteger4;
					do
					{
						bigInteger4 = BigInteger.GenerateRandom(num);
					}
					while (bigInteger4 <= 2 && bigInteger4 >= bigInteger);
					bigInteger3 = modulusRing.Pow(bigInteger4, bigInteger2);
				}
				if (!(bigInteger3 == 1U))
				{
					int num3 = 0;
					while (num3 < num2 && bigInteger3 != bigInteger)
					{
						bigInteger3 = modulusRing.Pow(bigInteger3, 2);
						if (bigInteger3 == 1U)
						{
							return false;
						}
						num3++;
					}
					if (bigInteger3 != bigInteger)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
