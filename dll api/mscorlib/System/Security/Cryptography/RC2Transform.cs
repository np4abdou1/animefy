﻿using System;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x020002E6 RID: 742
	internal class RC2Transform : SymmetricTransform
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x0006B110 File Offset: 0x00069310
		public RC2Transform(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) : base(rc2Algo, encryption, iv)
		{
			int num = rc2Algo.EffectiveKeySize;
			if (key == null)
			{
				key = KeyBuilder.Key(rc2Algo.KeySize >> 3);
			}
			else
			{
				key = (byte[])key.Clone();
				num = Math.Min(num, key.Length << 3);
			}
			int num2 = key.Length;
			if (!KeySizes.IsLegalKeySize(rc2Algo.LegalKeySizes, num2 << 3))
			{
				throw new CryptographicException(Locale.GetText("Key is too small ({0} bytes), it should be between {1} and {2} bytes long.", new object[]
				{
					num2,
					5,
					16
				}));
			}
			byte[] array = new byte[128];
			int num3 = num + 7 >> 3;
			int num4 = 255 % (2 << 8 + num - (num3 << 3) - 1);
			for (int i = 0; i < num2; i++)
			{
				array[i] = key[i];
			}
			for (int j = num2; j < 128; j++)
			{
				array[j] = RC2Transform.pitable[(int)(array[j - 1] + array[j - num2] & byte.MaxValue)];
			}
			array[128 - num3] = RC2Transform.pitable[(int)array[128 - num3] & num4];
			for (int k = 127 - num3; k >= 0; k--)
			{
				array[k] = RC2Transform.pitable[(int)(array[k + 1] ^ array[k + num3])];
			}
			this.K = new ushort[64];
			int num5 = 0;
			for (int l = 0; l < 64; l++)
			{
				this.K[l] = (ushort)((int)array[num5++] + ((int)array[num5++] << 8));
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0006B298 File Offset: 0x00069498
		protected override void ECB(byte[] input, byte[] output)
		{
			this.R0 = (ushort)((int)input[0] | (int)input[1] << 8);
			this.R1 = (ushort)((int)input[2] | (int)input[3] << 8);
			this.R2 = (ushort)((int)input[4] | (int)input[5] << 8);
			this.R3 = (ushort)((int)input[6] | (int)input[7] << 8);
			if (this.encrypt)
			{
				this.j = 0;
				while (this.j <= 16)
				{
					ushort r = this.R0;
					ushort[] k = this.K;
					int num = this.j;
					this.j = num + 1;
					this.R0 = r + (k[num] + (this.R3 & this.R2) + (~this.R3 & this.R1));
					this.R0 = (ushort)((int)this.R0 << 1 | this.R0 >> 15);
					ushort r2 = this.R1;
					ushort[] k2 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R1 = r2 + (k2[num] + (this.R0 & this.R3) + (~this.R0 & this.R2));
					this.R1 = (ushort)((int)this.R1 << 2 | this.R1 >> 14);
					ushort r3 = this.R2;
					ushort[] k3 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R2 = r3 + (k3[num] + (this.R1 & this.R0) + (~this.R1 & this.R3));
					this.R2 = (ushort)((int)this.R2 << 3 | this.R2 >> 13);
					ushort r4 = this.R3;
					ushort[] k4 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R3 = r4 + (k4[num] + (this.R2 & this.R1) + (~this.R2 & this.R0));
					this.R3 = (ushort)((int)this.R3 << 5 | this.R3 >> 11);
				}
				this.R0 += this.K[(int)(this.R3 & 63)];
				this.R1 += this.K[(int)(this.R0 & 63)];
				this.R2 += this.K[(int)(this.R1 & 63)];
				this.R3 += this.K[(int)(this.R2 & 63)];
				while (this.j <= 40)
				{
					ushort r5 = this.R0;
					ushort[] k5 = this.K;
					int num = this.j;
					this.j = num + 1;
					this.R0 = r5 + (k5[num] + (this.R3 & this.R2) + (~this.R3 & this.R1));
					this.R0 = (ushort)((int)this.R0 << 1 | this.R0 >> 15);
					ushort r6 = this.R1;
					ushort[] k6 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R1 = r6 + (k6[num] + (this.R0 & this.R3) + (~this.R0 & this.R2));
					this.R1 = (ushort)((int)this.R1 << 2 | this.R1 >> 14);
					ushort r7 = this.R2;
					ushort[] k7 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R2 = r7 + (k7[num] + (this.R1 & this.R0) + (~this.R1 & this.R3));
					this.R2 = (ushort)((int)this.R2 << 3 | this.R2 >> 13);
					ushort r8 = this.R3;
					ushort[] k8 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R3 = r8 + (k8[num] + (this.R2 & this.R1) + (~this.R2 & this.R0));
					this.R3 = (ushort)((int)this.R3 << 5 | this.R3 >> 11);
				}
				this.R0 += this.K[(int)(this.R3 & 63)];
				this.R1 += this.K[(int)(this.R0 & 63)];
				this.R2 += this.K[(int)(this.R1 & 63)];
				this.R3 += this.K[(int)(this.R2 & 63)];
				while (this.j < 64)
				{
					ushort r9 = this.R0;
					ushort[] k9 = this.K;
					int num = this.j;
					this.j = num + 1;
					this.R0 = r9 + (k9[num] + (this.R3 & this.R2) + (~this.R3 & this.R1));
					this.R0 = (ushort)((int)this.R0 << 1 | this.R0 >> 15);
					ushort r10 = this.R1;
					ushort[] k10 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R1 = r10 + (k10[num] + (this.R0 & this.R3) + (~this.R0 & this.R2));
					this.R1 = (ushort)((int)this.R1 << 2 | this.R1 >> 14);
					ushort r11 = this.R2;
					ushort[] k11 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R2 = r11 + (k11[num] + (this.R1 & this.R0) + (~this.R1 & this.R3));
					this.R2 = (ushort)((int)this.R2 << 3 | this.R2 >> 13);
					ushort r12 = this.R3;
					ushort[] k12 = this.K;
					num = this.j;
					this.j = num + 1;
					this.R3 = r12 + (k12[num] + (this.R2 & this.R1) + (~this.R2 & this.R0));
					this.R3 = (ushort)((int)this.R3 << 5 | this.R3 >> 11);
				}
			}
			else
			{
				this.j = 63;
				while (this.j >= 44)
				{
					this.R3 = (ushort)(this.R3 >> 5 | (int)this.R3 << 11);
					ushort r13 = this.R3;
					ushort[] k13 = this.K;
					int num = this.j;
					this.j = num - 1;
					this.R3 = r13 - (k13[num] + (this.R2 & this.R1) + (~this.R2 & this.R0));
					this.R2 = (ushort)(this.R2 >> 3 | (int)this.R2 << 13);
					ushort r14 = this.R2;
					ushort[] k14 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R2 = r14 - (k14[num] + (this.R1 & this.R0) + (~this.R1 & this.R3));
					this.R1 = (ushort)(this.R1 >> 2 | (int)this.R1 << 14);
					ushort r15 = this.R1;
					ushort[] k15 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R1 = r15 - (k15[num] + (this.R0 & this.R3) + (~this.R0 & this.R2));
					this.R0 = (ushort)(this.R0 >> 1 | (int)this.R0 << 15);
					ushort r16 = this.R0;
					ushort[] k16 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R0 = r16 - (k16[num] + (this.R3 & this.R2) + (~this.R3 & this.R1));
				}
				this.R3 -= this.K[(int)(this.R2 & 63)];
				this.R2 -= this.K[(int)(this.R1 & 63)];
				this.R1 -= this.K[(int)(this.R0 & 63)];
				this.R0 -= this.K[(int)(this.R3 & 63)];
				while (this.j >= 20)
				{
					this.R3 = (ushort)(this.R3 >> 5 | (int)this.R3 << 11);
					ushort r17 = this.R3;
					ushort[] k17 = this.K;
					int num = this.j;
					this.j = num - 1;
					this.R3 = r17 - (k17[num] + (this.R2 & this.R1) + (~this.R2 & this.R0));
					this.R2 = (ushort)(this.R2 >> 3 | (int)this.R2 << 13);
					ushort r18 = this.R2;
					ushort[] k18 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R2 = r18 - (k18[num] + (this.R1 & this.R0) + (~this.R1 & this.R3));
					this.R1 = (ushort)(this.R1 >> 2 | (int)this.R1 << 14);
					ushort r19 = this.R1;
					ushort[] k19 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R1 = r19 - (k19[num] + (this.R0 & this.R3) + (~this.R0 & this.R2));
					this.R0 = (ushort)(this.R0 >> 1 | (int)this.R0 << 15);
					ushort r20 = this.R0;
					ushort[] k20 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R0 = r20 - (k20[num] + (this.R3 & this.R2) + (~this.R3 & this.R1));
				}
				this.R3 -= this.K[(int)(this.R2 & 63)];
				this.R2 -= this.K[(int)(this.R1 & 63)];
				this.R1 -= this.K[(int)(this.R0 & 63)];
				this.R0 -= this.K[(int)(this.R3 & 63)];
				while (this.j >= 0)
				{
					this.R3 = (ushort)(this.R3 >> 5 | (int)this.R3 << 11);
					ushort r21 = this.R3;
					ushort[] k21 = this.K;
					int num = this.j;
					this.j = num - 1;
					this.R3 = r21 - (k21[num] + (this.R2 & this.R1) + (~this.R2 & this.R0));
					this.R2 = (ushort)(this.R2 >> 3 | (int)this.R2 << 13);
					ushort r22 = this.R2;
					ushort[] k22 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R2 = r22 - (k22[num] + (this.R1 & this.R0) + (~this.R1 & this.R3));
					this.R1 = (ushort)(this.R1 >> 2 | (int)this.R1 << 14);
					ushort r23 = this.R1;
					ushort[] k23 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R1 = r23 - (k23[num] + (this.R0 & this.R3) + (~this.R0 & this.R2));
					this.R0 = (ushort)(this.R0 >> 1 | (int)this.R0 << 15);
					ushort r24 = this.R0;
					ushort[] k24 = this.K;
					num = this.j;
					this.j = num - 1;
					this.R0 = r24 - (k24[num] + (this.R3 & this.R2) + (~this.R3 & this.R1));
				}
			}
			output[0] = (byte)this.R0;
			output[1] = (byte)(this.R0 >> 8);
			output[2] = (byte)this.R1;
			output[3] = (byte)(this.R1 >> 8);
			output[4] = (byte)this.R2;
			output[5] = (byte)(this.R2 >> 8);
			output[6] = (byte)this.R3;
			output[7] = (byte)(this.R3 >> 8);
		}

		// Token: 0x04000A29 RID: 2601
		private ushort R0;

		// Token: 0x04000A2A RID: 2602
		private ushort R1;

		// Token: 0x04000A2B RID: 2603
		private ushort R2;

		// Token: 0x04000A2C RID: 2604
		private ushort R3;

		// Token: 0x04000A2D RID: 2605
		private ushort[] K;

		// Token: 0x04000A2E RID: 2606
		private int j;

		// Token: 0x04000A2F RID: 2607
		private static readonly byte[] pitable = new byte[]
		{
			217,
			120,
			249,
			196,
			25,
			221,
			181,
			237,
			40,
			233,
			253,
			121,
			74,
			160,
			216,
			157,
			198,
			126,
			55,
			131,
			43,
			118,
			83,
			142,
			98,
			76,
			100,
			136,
			68,
			139,
			251,
			162,
			23,
			154,
			89,
			245,
			135,
			179,
			79,
			19,
			97,
			69,
			109,
			141,
			9,
			129,
			125,
			50,
			189,
			143,
			64,
			235,
			134,
			183,
			123,
			11,
			240,
			149,
			33,
			34,
			92,
			107,
			78,
			130,
			84,
			214,
			101,
			147,
			206,
			96,
			178,
			28,
			115,
			86,
			192,
			20,
			167,
			140,
			241,
			220,
			18,
			117,
			202,
			31,
			59,
			190,
			228,
			209,
			66,
			61,
			212,
			48,
			163,
			60,
			182,
			38,
			111,
			191,
			14,
			218,
			70,
			105,
			7,
			87,
			39,
			242,
			29,
			155,
			188,
			148,
			67,
			3,
			248,
			17,
			199,
			246,
			144,
			239,
			62,
			231,
			6,
			195,
			213,
			47,
			200,
			102,
			30,
			215,
			8,
			232,
			234,
			222,
			128,
			82,
			238,
			247,
			132,
			170,
			114,
			172,
			53,
			77,
			106,
			42,
			150,
			26,
			210,
			113,
			90,
			21,
			73,
			116,
			75,
			159,
			208,
			94,
			4,
			24,
			164,
			236,
			194,
			224,
			65,
			110,
			15,
			81,
			203,
			204,
			36,
			145,
			175,
			80,
			161,
			244,
			112,
			57,
			153,
			124,
			58,
			133,
			35,
			184,
			180,
			122,
			252,
			2,
			54,
			91,
			37,
			85,
			151,
			49,
			45,
			93,
			250,
			152,
			227,
			138,
			146,
			174,
			5,
			223,
			41,
			16,
			103,
			108,
			186,
			201,
			211,
			0,
			230,
			207,
			225,
			158,
			168,
			44,
			99,
			22,
			1,
			63,
			88,
			226,
			137,
			169,
			13,
			56,
			52,
			27,
			171,
			51,
			byte.MaxValue,
			176,
			187,
			72,
			12,
			95,
			185,
			177,
			205,
			46,
			197,
			243,
			219,
			71,
			229,
			165,
			156,
			119,
			10,
			166,
			32,
			104,
			254,
			127,
			193,
			173
		};
	}
}
