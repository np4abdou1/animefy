﻿using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA384" /> hash for the input data using the managed library. </summary>
	// Token: 0x020002D4 RID: 724
	[ComVisible(true)]
	public class SHA384Managed : SHA384
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SHA384Managed" /> class.</summary>
		/// <exception cref="T:System.InvalidOperationException">The Federal Information Processing Standards (FIPS) security setting is enabled. This implementation is not part of the Windows Platform FIPS-validated cryptographic algorithms.</exception>
		// Token: 0x06001811 RID: 6161 RVA: 0x0006687C File Offset: 0x00064A7C
		public SHA384Managed()
		{
			if (CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				throw new InvalidOperationException(Environment.GetResourceString("This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms."));
			}
			this._stateSHA384 = new ulong[8];
			this._buffer = new byte[128];
			this._W = new ulong[80];
			this.InitializeState();
		}

		/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.SHA384Managed" />.</summary>
		// Token: 0x06001812 RID: 6162 RVA: 0x000668D5 File Offset: 0x00064AD5
		public override void Initialize()
		{
			this.InitializeState();
			Array.Clear(this._buffer, 0, this._buffer.Length);
			Array.Clear(this._W, 0, this._W.Length);
		}

		/// <summary>When overridden in a derived class, routes data written to the object into the <see cref="T:System.Security.Cryptography.SHA384Managed" /> hash algorithm for computing the hash.</summary>
		/// <param name="rgb">The input data. </param>
		/// <param name="ibStart">The offset into the byte array from which to begin using data. </param>
		/// <param name="cbSize">The number of bytes in the array to use as data. </param>
		// Token: 0x06001813 RID: 6163 RVA: 0x00066905 File Offset: 0x00064B05
		[SecuritySafeCritical]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			this._HashData(rgb, ibStart, cbSize);
		}

		/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
		/// <returns>The computed hash code.</returns>
		// Token: 0x06001814 RID: 6164 RVA: 0x00066910 File Offset: 0x00064B10
		[SecuritySafeCritical]
		protected override byte[] HashFinal()
		{
			return this._EndHash();
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00066918 File Offset: 0x00064B18
		private void InitializeState()
		{
			this._count = 0UL;
			this._stateSHA384[0] = 14680500436340154072UL;
			this._stateSHA384[1] = 7105036623409894663UL;
			this._stateSHA384[2] = 10473403895298186519UL;
			this._stateSHA384[3] = 1526699215303891257UL;
			this._stateSHA384[4] = 7436329637833083697UL;
			this._stateSHA384[5] = 10282925794625328401UL;
			this._stateSHA384[6] = 15784041429090275239UL;
			this._stateSHA384[7] = 5167115440072839076UL;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000669B8 File Offset: 0x00064BB8
		[SecurityCritical]
		private unsafe void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			int i = cbSize;
			int num = ibStart;
			int num2 = (int)(this._count & 127UL);
			this._count += (ulong)((long)i);
			ulong[] array;
			ulong* state;
			if ((array = this._stateSHA384) == null || array.Length == 0)
			{
				state = null;
			}
			else
			{
				state = &array[0];
			}
			byte[] array2;
			byte* block;
			if ((array2 = this._buffer) == null || array2.Length == 0)
			{
				block = null;
			}
			else
			{
				block = &array2[0];
			}
			ulong[] array3;
			ulong* expandedBuffer;
			if ((array3 = this._W) == null || array3.Length == 0)
			{
				expandedBuffer = null;
			}
			else
			{
				expandedBuffer = &array3[0];
			}
			if (num2 > 0 && num2 + i >= 128)
			{
				Buffer.InternalBlockCopy(partIn, num, this._buffer, num2, 128 - num2);
				num += 128 - num2;
				i -= 128 - num2;
				SHA384Managed.SHATransform(expandedBuffer, state, block);
				num2 = 0;
			}
			while (i >= 128)
			{
				Buffer.InternalBlockCopy(partIn, num, this._buffer, 0, 128);
				num += 128;
				i -= 128;
				SHA384Managed.SHATransform(expandedBuffer, state, block);
			}
			if (i > 0)
			{
				Buffer.InternalBlockCopy(partIn, num, this._buffer, num2, i);
			}
			array3 = null;
			array2 = null;
			array = null;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00066AE4 File Offset: 0x00064CE4
		[SecurityCritical]
		private byte[] _EndHash()
		{
			byte[] array = new byte[48];
			int num = 128 - (int)(this._count & 127UL);
			if (num <= 16)
			{
				num += 128;
			}
			byte[] array2 = new byte[num];
			array2[0] = 128;
			ulong num2 = this._count * 8UL;
			array2[num - 8] = (byte)(num2 >> 56 & 255UL);
			array2[num - 7] = (byte)(num2 >> 48 & 255UL);
			array2[num - 6] = (byte)(num2 >> 40 & 255UL);
			array2[num - 5] = (byte)(num2 >> 32 & 255UL);
			array2[num - 4] = (byte)(num2 >> 24 & 255UL);
			array2[num - 3] = (byte)(num2 >> 16 & 255UL);
			array2[num - 2] = (byte)(num2 >> 8 & 255UL);
			array2[num - 1] = (byte)(num2 & 255UL);
			this._HashData(array2, 0, array2.Length);
			Utils.QuadWordToBigEndian(array, this._stateSHA384, 6);
			this.HashValue = array;
			return array;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00066BD8 File Offset: 0x00064DD8
		[SecurityCritical]
		private unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
		{
			ulong num = *state;
			ulong num2 = state[1];
			ulong num3 = state[2];
			ulong num4 = state[3];
			ulong num5 = state[4];
			ulong num6 = state[5];
			ulong num7 = state[6];
			ulong num8 = state[7];
			Utils.QuadWordFromBigEndian(expandedBuffer, 16, block);
			SHA384Managed.SHA384Expand(expandedBuffer);
			for (int i = 0; i < 80; i++)
			{
				ulong num9 = num8 + SHA384Managed.Sigma_1(num5) + SHA384Managed.Ch(num5, num6, num7) + SHA384Managed._K[i] + expandedBuffer[i];
				ulong num10 = num4 + num9;
				ulong num11 = num9 + SHA384Managed.Sigma_0(num) + SHA384Managed.Maj(num, num2, num3);
				i++;
				num9 = num7 + SHA384Managed.Sigma_1(num10) + SHA384Managed.Ch(num10, num5, num6) + SHA384Managed._K[i] + expandedBuffer[i];
				ulong num12 = num3 + num9;
				ulong num13 = num9 + SHA384Managed.Sigma_0(num11) + SHA384Managed.Maj(num11, num, num2);
				i++;
				num9 = num6 + SHA384Managed.Sigma_1(num12) + SHA384Managed.Ch(num12, num10, num5) + SHA384Managed._K[i] + expandedBuffer[i];
				ulong num14 = num2 + num9;
				ulong num15 = num9 + SHA384Managed.Sigma_0(num13) + SHA384Managed.Maj(num13, num11, num);
				i++;
				num9 = num5 + SHA384Managed.Sigma_1(num14) + SHA384Managed.Ch(num14, num12, num10) + SHA384Managed._K[i] + expandedBuffer[i];
				ulong num16 = num + num9;
				ulong num17 = num9 + SHA384Managed.Sigma_0(num15) + SHA384Managed.Maj(num15, num13, num11);
				i++;
				num9 = num10 + SHA384Managed.Sigma_1(num16) + SHA384Managed.Ch(num16, num14, num12) + SHA384Managed._K[i] + expandedBuffer[i];
				num8 = num11 + num9;
				num4 = num9 + SHA384Managed.Sigma_0(num17) + SHA384Managed.Maj(num17, num15, num13);
				i++;
				num9 = num12 + SHA384Managed.Sigma_1(num8) + SHA384Managed.Ch(num8, num16, num14) + SHA384Managed._K[i] + expandedBuffer[i];
				num7 = num13 + num9;
				num3 = num9 + SHA384Managed.Sigma_0(num4) + SHA384Managed.Maj(num4, num17, num15);
				i++;
				num9 = num14 + SHA384Managed.Sigma_1(num7) + SHA384Managed.Ch(num7, num8, num16) + SHA384Managed._K[i] + expandedBuffer[i];
				num6 = num15 + num9;
				num2 = num9 + SHA384Managed.Sigma_0(num3) + SHA384Managed.Maj(num3, num4, num17);
				i++;
				num9 = num16 + SHA384Managed.Sigma_1(num6) + SHA384Managed.Ch(num6, num7, num8) + SHA384Managed._K[i] + expandedBuffer[i];
				num5 = num17 + num9;
				num = num9 + SHA384Managed.Sigma_0(num2) + SHA384Managed.Maj(num2, num3, num4);
			}
			*state += num;
			state[1] += num2;
			state[2] += num3;
			state[3] += num4;
			state[4] += num5;
			state[5] += num6;
			state[6] += num7;
			state[7] += num8;
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00066EF5 File Offset: 0x000650F5
		private static ulong RotateRight(ulong x, int n)
		{
			return x >> n | x << 64 - n;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00066F07 File Offset: 0x00065107
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			return (x & y) ^ ((x ^ ulong.MaxValue) & z);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0006676E File Offset: 0x0006496E
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			return (x & y) ^ (x & z) ^ (y & z);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00066F13 File Offset: 0x00065113
		private static ulong Sigma_0(ulong x)
		{
			return SHA384Managed.RotateRight(x, 28) ^ SHA384Managed.RotateRight(x, 34) ^ SHA384Managed.RotateRight(x, 39);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00066F2F File Offset: 0x0006512F
		private static ulong Sigma_1(ulong x)
		{
			return SHA384Managed.RotateRight(x, 14) ^ SHA384Managed.RotateRight(x, 18) ^ SHA384Managed.RotateRight(x, 41);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00066F4B File Offset: 0x0006514B
		private static ulong sigma_0(ulong x)
		{
			return SHA384Managed.RotateRight(x, 1) ^ SHA384Managed.RotateRight(x, 8) ^ x >> 7;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00066F60 File Offset: 0x00065160
		private static ulong sigma_1(ulong x)
		{
			return SHA384Managed.RotateRight(x, 19) ^ SHA384Managed.RotateRight(x, 61) ^ x >> 6;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00066F78 File Offset: 0x00065178
		[SecurityCritical]
		private unsafe static void SHA384Expand(ulong* x)
		{
			for (int i = 16; i < 80; i++)
			{
				x[i] = SHA384Managed.sigma_1(x[i - 2]) + x[i - 7] + SHA384Managed.sigma_0(x[i - 15]) + x[i - 16];
			}
		}

		// Token: 0x040009F2 RID: 2546
		private byte[] _buffer;

		// Token: 0x040009F3 RID: 2547
		private ulong _count;

		// Token: 0x040009F4 RID: 2548
		private ulong[] _stateSHA384;

		// Token: 0x040009F5 RID: 2549
		private ulong[] _W;

		// Token: 0x040009F6 RID: 2550
		private static readonly ulong[] _K = new ulong[]
		{
			4794697086780616226UL,
			8158064640168781261UL,
			13096744586834688815UL,
			16840607885511220156UL,
			4131703408338449720UL,
			6480981068601479193UL,
			10538285296894168987UL,
			12329834152419229976UL,
			15566598209576043074UL,
			1334009975649890238UL,
			2608012711638119052UL,
			6128411473006802146UL,
			8268148722764581231UL,
			9286055187155687089UL,
			11230858885718282805UL,
			13951009754708518548UL,
			16472876342353939154UL,
			17275323862435702243UL,
			1135362057144423861UL,
			2597628984639134821UL,
			3308224258029322869UL,
			5365058923640841347UL,
			6679025012923562964UL,
			8573033837759648693UL,
			10970295158949994411UL,
			12119686244451234320UL,
			12683024718118986047UL,
			13788192230050041572UL,
			14330467153632333762UL,
			15395433587784984357UL,
			489312712824947311UL,
			1452737877330783856UL,
			2861767655752347644UL,
			3322285676063803686UL,
			5560940570517711597UL,
			5996557281743188959UL,
			7280758554555802590UL,
			8532644243296465576UL,
			9350256976987008742UL,
			10552545826968843579UL,
			11727347734174303076UL,
			12113106623233404929UL,
			14000437183269869457UL,
			14369950271660146224UL,
			15101387698204529176UL,
			15463397548674623760UL,
			17586052441742319658UL,
			1182934255886127544UL,
			1847814050463011016UL,
			2177327727835720531UL,
			2830643537854262169UL,
			3796741975233480872UL,
			4115178125766777443UL,
			5681478168544905931UL,
			6601373596472566643UL,
			7507060721942968483UL,
			8399075790359081724UL,
			8693463985226723168UL,
			9568029438360202098UL,
			10144078919501101548UL,
			10430055236837252648UL,
			11840083180663258601UL,
			13761210420658862357UL,
			14299343276471374635UL,
			14566680578165727644UL,
			15097957966210449927UL,
			16922976911328602910UL,
			17689382322260857208UL,
			500013540394364858UL,
			748580250866718886UL,
			1242879168328830382UL,
			1977374033974150939UL,
			2944078676154940804UL,
			3659926193048069267UL,
			4368137639120453308UL,
			4836135668995329356UL,
			5532061633213252278UL,
			6448918945643986474UL,
			6902733635092675308UL,
			7801388544844847127UL
		};
	}
}
