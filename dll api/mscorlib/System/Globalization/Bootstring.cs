using System;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020005B2 RID: 1458
	internal class Bootstring
	{
		// Token: 0x06002C1D RID: 11293 RVA: 0x000B700C File Offset: 0x000B520C
		public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
		{
			this.delimiter = delimiter;
			this.base_num = baseNum;
			this.tmin = tmin;
			this.tmax = tmax;
			this.skew = skew;
			this.damp = damp;
			this.initial_bias = initialBias;
			this.initial_n = initialN;
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000B705C File Offset: 0x000B525C
		public string Encode(string s, int offset)
		{
			int num = this.initial_n;
			int num2 = 0;
			int num3 = this.initial_bias;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] < '\u0080')
				{
					stringBuilder.Append(s[i]);
				}
			}
			int length;
			int j = length = stringBuilder.Length;
			if (length > 0)
			{
				stringBuilder.Append(this.delimiter);
			}
			while (j < s.Length)
			{
				int num4 = int.MaxValue;
				for (int k = 0; k < s.Length; k++)
				{
					if ((int)s[k] >= num && (int)s[k] < num4)
					{
						num4 = (int)s[k];
					}
				}
				checked
				{
					num2 += (num4 - num) * (j + 1);
					num = num4;
					foreach (char c in s)
					{
						if ((int)c < num || c < '\u0080')
						{
							num2++;
						}
						unchecked
						{
							if ((int)c == num)
							{
								int num5 = num2;
								int num6 = this.base_num;
								for (;;)
								{
									int num7 = (num6 <= num3 + this.tmin) ? this.tmin : ((num6 >= num3 + this.tmax) ? this.tmax : (num6 - num3));
									if (num5 < num7)
									{
										break;
									}
									stringBuilder.Append(this.EncodeDigit(num7 + (num5 - num7) % (this.base_num - num7)));
									num5 = (num5 - num7) / (this.base_num - num7);
									num6 += this.base_num;
								}
								stringBuilder.Append(this.EncodeDigit(num5));
								num3 = this.Adapt(num2, j + 1, j == length);
								num2 = 0;
								j++;
							}
						}
					}
				}
				num2++;
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000B722B File Offset: 0x000B542B
		private char EncodeDigit(int d)
		{
			return (char)((d < 26) ? (d + 97) : (d - 26 + 48));
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000B7240 File Offset: 0x000B5440
		private int DecodeDigit(char c)
		{
			if (c - '0' < '\n')
			{
				return (int)(c - '\u0016');
			}
			if (c - 'A' < '\u001a')
			{
				return (int)(c - 'A');
			}
			if (c - 'a' >= '\u001a')
			{
				return this.base_num;
			}
			return (int)(c - 'a');
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000B7270 File Offset: 0x000B5470
		private int Adapt(int delta, int numPoints, bool firstTime)
		{
			if (firstTime)
			{
				delta /= this.damp;
			}
			else
			{
				delta /= 2;
			}
			delta += delta / numPoints;
			int num = 0;
			while (delta > (this.base_num - this.tmin) * this.tmax / 2)
			{
				delta /= this.base_num - this.tmin;
				num += this.base_num;
			}
			return num + (this.base_num - this.tmin + 1) * delta / (delta + this.skew);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000B72EC File Offset: 0x000B54EC
		public string Decode(string s, int offset)
		{
			int num = this.initial_n;
			int num2 = 0;
			int num3 = this.initial_bias;
			int num4 = 0;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == this.delimiter)
				{
					num4 = i;
				}
			}
			if (num4 < 0)
			{
				return s;
			}
			stringBuilder.Append(s, 0, num4);
			int j = (num4 > 0) ? (num4 + 1) : 0;
			while (j < s.Length)
			{
				int num5 = num2;
				int num6 = 1;
				int num7 = this.base_num;
				for (;;)
				{
					int num8 = this.DecodeDigit(s[j++]);
					num2 += num8 * num6;
					int num9 = (num7 <= num3 + this.tmin) ? this.tmin : ((num7 >= num3 + this.tmax) ? this.tmax : (num7 - num3));
					if (num8 < num9)
					{
						break;
					}
					num6 *= this.base_num - num9;
					num7 += this.base_num;
				}
				num3 = this.Adapt(num2 - num5, stringBuilder.Length + 1, num5 == 0);
				num += num2 / (stringBuilder.Length + 1);
				num2 %= stringBuilder.Length + 1;
				if (num < 128)
				{
					throw new ArgumentException(string.Format("Invalid Bootstring decode result, at {0}", offset + j));
				}
				stringBuilder.Insert(num2, (char)num);
				num2++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001803 RID: 6147
		private readonly char delimiter;

		// Token: 0x04001804 RID: 6148
		private readonly int base_num;

		// Token: 0x04001805 RID: 6149
		private readonly int tmin;

		// Token: 0x04001806 RID: 6150
		private readonly int tmax;

		// Token: 0x04001807 RID: 6151
		private readonly int skew;

		// Token: 0x04001808 RID: 6152
		private readonly int damp;

		// Token: 0x04001809 RID: 6153
		private readonly int initial_bias;

		// Token: 0x0400180A RID: 6154
		private readonly int initial_n;
	}
}
