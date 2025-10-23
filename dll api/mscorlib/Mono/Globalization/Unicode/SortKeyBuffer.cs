using System;
using System.Globalization;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000041 RID: 65
	internal class SortKeyBuffer
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00003ACD File Offset: 0x00001CCD
		public SortKeyBuffer(int lcid)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006EA0 File Offset: 0x000050A0
		public void Reset()
		{
			this.l1 = (this.l2 = (this.l3 = (this.l4s = (this.l4t = (this.l4k = (this.l4w = (this.l5 = 0)))))));
			this.frenchSorted = false;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006EFC File Offset: 0x000050FC
		internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort)
		{
			this.source = s;
			this.lcid = lcid;
			this.options = options;
			int length = s.Length;
			this.processLevel2 = ((options & CompareOptions.IgnoreNonSpace) == CompareOptions.None);
			this.frenchSort = frenchSort;
			if (this.l1b == null || this.l1b.Length < length)
			{
				this.l1b = new byte[length * 2 + 10];
			}
			if (this.processLevel2 && (this.l2b == null || this.l2b.Length < length))
			{
				this.l2b = new byte[length + 10];
			}
			if (this.l3b == null || this.l3b.Length < length)
			{
				this.l3b = new byte[length + 10];
			}
			if (this.l4sb == null)
			{
				this.l4sb = new byte[10];
			}
			if (this.l4tb == null)
			{
				this.l4tb = new byte[10];
			}
			if (this.l4kb == null)
			{
				this.l4kb = new byte[10];
			}
			if (this.l4wb == null)
			{
				this.l4wb = new byte[10];
			}
			if (this.l5b == null)
			{
				this.l5b = new byte[10];
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007014 File Offset: 0x00005214
		internal void AppendCJKExtension(byte lv1msb, byte lv1lsb)
		{
			this.AppendBufferPrimitive(254, ref this.l1b, ref this.l1);
			this.AppendBufferPrimitive(byte.MaxValue, ref this.l1b, ref this.l1);
			this.AppendBufferPrimitive(lv1msb, ref this.l1b, ref this.l1);
			this.AppendBufferPrimitive(lv1lsb, ref this.l1b, ref this.l1);
			if (this.processLevel2)
			{
				this.AppendBufferPrimitive(2, ref this.l2b, ref this.l2);
			}
			this.AppendBufferPrimitive(2, ref this.l3b, ref this.l3);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000070A4 File Offset: 0x000052A4
		internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth)
		{
			this.AppendNormal(category, lv1, lv2, lv3);
			this.AppendBufferPrimitive(isSmallKana ? 196 : 228, ref this.l4sb, ref this.l4s);
			this.AppendBufferPrimitive(markType, ref this.l4tb, ref this.l4t);
			this.AppendBufferPrimitive(isKatakana ? 196 : 228, ref this.l4kb, ref this.l4k);
			this.AppendBufferPrimitive(isHalfWidth ? 196 : 228, ref this.l4wb, ref this.l4w);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000713C File Offset: 0x0000533C
		internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3)
		{
			if (lv2 == 0)
			{
				lv2 = 2;
			}
			if (lv3 == 0)
			{
				lv3 = 2;
			}
			if (category == 6 && (this.options & CompareOptions.StringSort) == CompareOptions.None)
			{
				this.AppendLevel5(category, lv1);
				return;
			}
			if (this.processLevel2 && category == 1 && this.l1 > 0)
			{
				byte b = lv2;
				byte[] array = this.l2b;
				int num = this.l2 - 1;
				this.l2 = num;
				lv2 = b + array[num];
				byte[] array2 = this.l3b;
				num = this.l3 - 1;
				this.l3 = num;
				lv3 = array2[num];
			}
			if (category != 1)
			{
				this.AppendBufferPrimitive(category, ref this.l1b, ref this.l1);
				this.AppendBufferPrimitive(lv1, ref this.l1b, ref this.l1);
			}
			if (this.processLevel2)
			{
				this.AppendBufferPrimitive(lv2, ref this.l2b, ref this.l2);
			}
			this.AppendBufferPrimitive(lv3, ref this.l3b, ref this.l3);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007218 File Offset: 0x00005418
		private void AppendLevel5(byte category, byte lv1)
		{
			int num = (this.l2 + 1) % 8192;
			this.AppendBufferPrimitive((byte)(num / 64 + 128), ref this.l5b, ref this.l5);
			this.AppendBufferPrimitive((byte)(num % 64 * 4 + 3), ref this.l5b, ref this.l5);
			this.AppendBufferPrimitive(category, ref this.l5b, ref this.l5);
			this.AppendBufferPrimitive(lv1, ref this.l5b, ref this.l5);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007294 File Offset: 0x00005494
		private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx)
		{
			byte[] array = buf;
			int num = bidx;
			bidx = num + 1;
			array[num] = value;
			if (bidx == buf.Length)
			{
				byte[] array2 = new byte[bidx * 2];
				Array.Copy(buf, array2, buf.Length);
				buf = array2;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000072CF File Offset: 0x000054CF
		public SortKey GetResultAndReset()
		{
			SortKey result = this.GetResult();
			this.Reset();
			return result;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000072E0 File Offset: 0x000054E0
		private int GetOptimizedLength(byte[] data, int len, byte defaultValue)
		{
			int num = -1;
			for (int i = 0; i < len; i++)
			{
				if (data[i] != defaultValue)
				{
					num = i;
				}
			}
			return num + 1;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007308 File Offset: 0x00005508
		public SortKey GetResult()
		{
			if (this.source.Length == 0)
			{
				return new SortKey(this.lcid, this.source, new byte[0], this.options, 0, 0, 0, 0, 0, 0, 0, 0);
			}
			if (this.frenchSort && !this.frenchSorted && this.l2b != null)
			{
				int num = 0;
				while (num < this.l2b.Length && this.l2b[num] != 0)
				{
					num++;
				}
				Array.Reverse<byte>(this.l2b, 0, num);
				this.frenchSorted = true;
			}
			this.l2 = this.GetOptimizedLength(this.l2b, this.l2, 2);
			this.l3 = this.GetOptimizedLength(this.l3b, this.l3, 2);
			bool flag = this.l4s > 0;
			this.l4s = this.GetOptimizedLength(this.l4sb, this.l4s, 228);
			this.l4t = this.GetOptimizedLength(this.l4tb, this.l4t, 3);
			this.l4k = this.GetOptimizedLength(this.l4kb, this.l4k, 228);
			this.l4w = this.GetOptimizedLength(this.l4wb, this.l4w, 228);
			this.l5 = this.GetOptimizedLength(this.l5b, this.l5, 2);
			int num2 = this.l1 + this.l2 + this.l3 + this.l5 + 5;
			int num3 = this.l4s + this.l4t + this.l4k + this.l4w;
			if (flag)
			{
				num2 += num3 + 4;
			}
			byte[] array = new byte[num2];
			Array.Copy(this.l1b, array, this.l1);
			array[this.l1] = 1;
			int num4 = this.l1 + 1;
			if (this.l2 > 0)
			{
				Array.Copy(this.l2b, 0, array, num4, this.l2);
			}
			num4 += this.l2;
			array[num4++] = 1;
			if (this.l3 > 0)
			{
				Array.Copy(this.l3b, 0, array, num4, this.l3);
			}
			num4 += this.l3;
			array[num4++] = 1;
			if (flag)
			{
				Array.Copy(this.l4sb, 0, array, num4, this.l4s);
				num4 += this.l4s;
				array[num4++] = byte.MaxValue;
				Array.Copy(this.l4tb, 0, array, num4, this.l4t);
				num4 += this.l4t;
				array[num4++] = 2;
				Array.Copy(this.l4kb, 0, array, num4, this.l4k);
				num4 += this.l4k;
				array[num4++] = byte.MaxValue;
				Array.Copy(this.l4wb, 0, array, num4, this.l4w);
				num4 += this.l4w;
				array[num4++] = byte.MaxValue;
			}
			array[num4++] = 1;
			if (this.l5 > 0)
			{
				Array.Copy(this.l5b, 0, array, num4, this.l5);
			}
			num4 += this.l5;
			array[num4++] = 0;
			return new SortKey(this.lcid, this.source, array, this.options, this.l1, this.l2, this.l3, this.l4s, this.l4t, this.l4k, this.l4w, this.l5);
		}

		// Token: 0x04000126 RID: 294
		private byte[] l1b;

		// Token: 0x04000127 RID: 295
		private byte[] l2b;

		// Token: 0x04000128 RID: 296
		private byte[] l3b;

		// Token: 0x04000129 RID: 297
		private byte[] l4sb;

		// Token: 0x0400012A RID: 298
		private byte[] l4tb;

		// Token: 0x0400012B RID: 299
		private byte[] l4kb;

		// Token: 0x0400012C RID: 300
		private byte[] l4wb;

		// Token: 0x0400012D RID: 301
		private byte[] l5b;

		// Token: 0x0400012E RID: 302
		private string source;

		// Token: 0x0400012F RID: 303
		private int l1;

		// Token: 0x04000130 RID: 304
		private int l2;

		// Token: 0x04000131 RID: 305
		private int l3;

		// Token: 0x04000132 RID: 306
		private int l4s;

		// Token: 0x04000133 RID: 307
		private int l4t;

		// Token: 0x04000134 RID: 308
		private int l4k;

		// Token: 0x04000135 RID: 309
		private int l4w;

		// Token: 0x04000136 RID: 310
		private int l5;

		// Token: 0x04000137 RID: 311
		private int lcid;

		// Token: 0x04000138 RID: 312
		private CompareOptions options;

		// Token: 0x04000139 RID: 313
		private bool processLevel2;

		// Token: 0x0400013A RID: 314
		private bool frenchSort;

		// Token: 0x0400013B RID: 315
		private bool frenchSorted;
	}
}
