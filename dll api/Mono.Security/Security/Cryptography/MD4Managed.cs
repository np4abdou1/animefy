using System;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004A RID: 74
	public class MD4Managed : MD4
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000A138 File Offset: 0x00008338
		public MD4Managed()
		{
			this.state = new uint[4];
			this.count = new uint[2];
			this.buffer = new byte[64];
			this.digest = new byte[16];
			this.x = new uint[16];
			this.Initialize();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000A190 File Offset: 0x00008390
		public override void Initialize()
		{
			this.count[0] = 0U;
			this.count[1] = 0U;
			this.state[0] = 1732584193U;
			this.state[1] = 4023233417U;
			this.state[2] = 2562383102U;
			this.state[3] = 271733878U;
			Array.Clear(this.buffer, 0, 64);
			Array.Clear(this.x, 0, 16);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000A200 File Offset: 0x00008400
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			int num = (int)(this.count[0] >> 3 & 63U);
			this.count[0] += (uint)((uint)cbSize << 3);
			if ((ulong)this.count[0] < (ulong)((long)((long)cbSize << 3)))
			{
				this.count[1] += 1U;
			}
			this.count[1] += (uint)(cbSize >> 29);
			int num2 = 64 - num;
			int num3 = 0;
			if (cbSize >= num2)
			{
				Buffer.BlockCopy(array, ibStart, this.buffer, num, num2);
				this.MD4Transform(this.state, this.buffer, 0);
				num3 = num2;
				while (num3 + 63 < cbSize)
				{
					this.MD4Transform(this.state, array, ibStart + num3);
					num3 += 64;
				}
				num = 0;
			}
			Buffer.BlockCopy(array, ibStart + num3, this.buffer, num, cbSize - num3);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000A2C4 File Offset: 0x000084C4
		protected override byte[] HashFinal()
		{
			byte[] array = new byte[8];
			this.Encode(array, this.count);
			uint num = this.count[0] >> 3 & 63U;
			int num2 = (int)((num < 56U) ? (56U - num) : (120U - num));
			this.HashCore(this.Padding(num2), 0, num2);
			this.HashCore(array, 0, 8);
			this.Encode(this.digest, this.state);
			this.Initialize();
			return this.digest;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000A339 File Offset: 0x00008539
		private byte[] Padding(int nLength)
		{
			if (nLength > 0)
			{
				byte[] array = new byte[nLength];
				array[0] = 128;
				return array;
			}
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000A34F File Offset: 0x0000854F
		private uint F(uint x, uint y, uint z)
		{
			return (x & y) | (~x & z);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000A359 File Offset: 0x00008559
		private uint G(uint x, uint y, uint z)
		{
			return (x & y) | (x & z) | (y & z);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000A366 File Offset: 0x00008566
		private uint H(uint x, uint y, uint z)
		{
			return x ^ y ^ z;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000A36D File Offset: 0x0000856D
		private uint ROL(uint x, byte n)
		{
			return x << (int)n | x >> (int)(32 - n);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000A37F File Offset: 0x0000857F
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			a += this.F(b, c, d) + x;
			a = this.ROL(a, s);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000A39F File Offset: 0x0000859F
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			a += this.G(b, c, d) + x + 1518500249U;
			a = this.ROL(a, s);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000A3C5 File Offset: 0x000085C5
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
			a += this.H(b, c, d) + x + 1859775393U;
			a = this.ROL(a, s);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000A3EC File Offset: 0x000085EC
		private void Encode(byte[] output, uint[] input)
		{
			int num = 0;
			for (int i = 0; i < output.Length; i += 4)
			{
				output[i] = (byte)input[num];
				output[i + 1] = (byte)(input[num] >> 8);
				output[i + 2] = (byte)(input[num] >> 16);
				output[i + 3] = (byte)(input[num] >> 24);
				num++;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000A438 File Offset: 0x00008638
		private void Decode(uint[] output, byte[] input, int index)
		{
			int i = 0;
			int num = index;
			while (i < output.Length)
			{
				output[i] = (uint)((int)input[num] | (int)input[num + 1] << 8 | (int)input[num + 2] << 16 | (int)input[num + 3] << 24);
				i++;
				num += 4;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000A47C File Offset: 0x0000867C
		private void MD4Transform(uint[] state, byte[] block, int index)
		{
			uint num = state[0];
			uint num2 = state[1];
			uint num3 = state[2];
			uint num4 = state[3];
			this.Decode(this.x, block, index);
			this.FF(ref num, num2, num3, num4, this.x[0], 3);
			this.FF(ref num4, num, num2, num3, this.x[1], 7);
			this.FF(ref num3, num4, num, num2, this.x[2], 11);
			this.FF(ref num2, num3, num4, num, this.x[3], 19);
			this.FF(ref num, num2, num3, num4, this.x[4], 3);
			this.FF(ref num4, num, num2, num3, this.x[5], 7);
			this.FF(ref num3, num4, num, num2, this.x[6], 11);
			this.FF(ref num2, num3, num4, num, this.x[7], 19);
			this.FF(ref num, num2, num3, num4, this.x[8], 3);
			this.FF(ref num4, num, num2, num3, this.x[9], 7);
			this.FF(ref num3, num4, num, num2, this.x[10], 11);
			this.FF(ref num2, num3, num4, num, this.x[11], 19);
			this.FF(ref num, num2, num3, num4, this.x[12], 3);
			this.FF(ref num4, num, num2, num3, this.x[13], 7);
			this.FF(ref num3, num4, num, num2, this.x[14], 11);
			this.FF(ref num2, num3, num4, num, this.x[15], 19);
			this.GG(ref num, num2, num3, num4, this.x[0], 3);
			this.GG(ref num4, num, num2, num3, this.x[4], 5);
			this.GG(ref num3, num4, num, num2, this.x[8], 9);
			this.GG(ref num2, num3, num4, num, this.x[12], 13);
			this.GG(ref num, num2, num3, num4, this.x[1], 3);
			this.GG(ref num4, num, num2, num3, this.x[5], 5);
			this.GG(ref num3, num4, num, num2, this.x[9], 9);
			this.GG(ref num2, num3, num4, num, this.x[13], 13);
			this.GG(ref num, num2, num3, num4, this.x[2], 3);
			this.GG(ref num4, num, num2, num3, this.x[6], 5);
			this.GG(ref num3, num4, num, num2, this.x[10], 9);
			this.GG(ref num2, num3, num4, num, this.x[14], 13);
			this.GG(ref num, num2, num3, num4, this.x[3], 3);
			this.GG(ref num4, num, num2, num3, this.x[7], 5);
			this.GG(ref num3, num4, num, num2, this.x[11], 9);
			this.GG(ref num2, num3, num4, num, this.x[15], 13);
			this.HH(ref num, num2, num3, num4, this.x[0], 3);
			this.HH(ref num4, num, num2, num3, this.x[8], 9);
			this.HH(ref num3, num4, num, num2, this.x[4], 11);
			this.HH(ref num2, num3, num4, num, this.x[12], 15);
			this.HH(ref num, num2, num3, num4, this.x[2], 3);
			this.HH(ref num4, num, num2, num3, this.x[10], 9);
			this.HH(ref num3, num4, num, num2, this.x[6], 11);
			this.HH(ref num2, num3, num4, num, this.x[14], 15);
			this.HH(ref num, num2, num3, num4, this.x[1], 3);
			this.HH(ref num4, num, num2, num3, this.x[9], 9);
			this.HH(ref num3, num4, num, num2, this.x[5], 11);
			this.HH(ref num2, num3, num4, num, this.x[13], 15);
			this.HH(ref num, num2, num3, num4, this.x[3], 3);
			this.HH(ref num4, num, num2, num3, this.x[11], 9);
			this.HH(ref num3, num4, num, num2, this.x[7], 11);
			this.HH(ref num2, num3, num4, num, this.x[15], 15);
			state[0] += num;
			state[1] += num2;
			state[2] += num3;
			state[3] += num4;
		}

		// Token: 0x0400020B RID: 523
		private uint[] state;

		// Token: 0x0400020C RID: 524
		private byte[] buffer;

		// Token: 0x0400020D RID: 525
		private uint[] count;

		// Token: 0x0400020E RID: 526
		private uint[] x;

		// Token: 0x0400020F RID: 527
		private byte[] digest;
	}
}
