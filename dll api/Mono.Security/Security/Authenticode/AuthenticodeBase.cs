﻿using System;
using System.IO;
using System.Security.Cryptography;

namespace Mono.Security.Authenticode
{
	// Token: 0x02000051 RID: 81
	public class AuthenticodeBase
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x0000BF32 File Offset: 0x0000A132
		public AuthenticodeBase()
		{
			this.fileblock = new byte[4096];
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000BF4A File Offset: 0x0000A14A
		internal int PEOffset
		{
			get
			{
				if (this.blockNo < 1)
				{
					this.ReadFirstBlock();
				}
				return this.peOffset;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000BF61 File Offset: 0x0000A161
		internal void Open(string filename)
		{
			if (this.fs != null)
			{
				this.Close();
			}
			this.fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
			this.blockNo = 0;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000BF87 File Offset: 0x0000A187
		internal void Open(byte[] rawdata)
		{
			if (this.fs != null)
			{
				this.Close();
			}
			this.fs = new MemoryStream(rawdata, false);
			this.blockNo = 0;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000BFAB File Offset: 0x0000A1AB
		internal void Close()
		{
			if (this.fs != null)
			{
				this.fs.Close();
				this.fs = null;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		internal void ReadFirstBlock()
		{
			int num = this.ProcessFirstBlock();
			if (num != 0)
			{
				throw new NotSupportedException(Locale.GetText("Cannot sign non PE files, e.g. .CAB or .MSI files (error {0}).", new object[]
				{
					num
				}));
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000C000 File Offset: 0x0000A200
		internal int ProcessFirstBlock()
		{
			if (this.fs == null)
			{
				return 1;
			}
			this.fs.Position = 0L;
			this.blockLength = this.fs.Read(this.fileblock, 0, this.fileblock.Length);
			this.blockNo = 1;
			if (this.blockLength < 64)
			{
				return 2;
			}
			if (BitConverterLE.ToUInt16(this.fileblock, 0) != 23117)
			{
				return 3;
			}
			this.peOffset = BitConverterLE.ToInt32(this.fileblock, 60);
			if (this.peOffset > this.fileblock.Length)
			{
				throw new NotSupportedException(string.Format(Locale.GetText("Header size too big (> {0} bytes)."), this.fileblock.Length));
			}
			if ((long)this.peOffset > this.fs.Length)
			{
				return 4;
			}
			if (BitConverterLE.ToUInt32(this.fileblock, this.peOffset) != 17744U)
			{
				return 5;
			}
			ushort num = BitConverterLE.ToUInt16(this.fileblock, this.peOffset + 24);
			this.pe64 = (num == 523);
			if (this.pe64)
			{
				this.dirSecurityOffset = BitConverterLE.ToInt32(this.fileblock, this.peOffset + 168);
				this.dirSecuritySize = BitConverterLE.ToInt32(this.fileblock, this.peOffset + 168 + 4);
			}
			else
			{
				this.dirSecurityOffset = BitConverterLE.ToInt32(this.fileblock, this.peOffset + 152);
				this.dirSecuritySize = BitConverterLE.ToInt32(this.fileblock, this.peOffset + 156);
			}
			this.coffSymbolTableOffset = BitConverterLE.ToInt32(this.fileblock, this.peOffset + 12);
			return 0;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		internal byte[] GetSecurityEntry()
		{
			if (this.blockNo < 1)
			{
				this.ReadFirstBlock();
			}
			if (this.dirSecuritySize > 8)
			{
				byte[] array = new byte[this.dirSecuritySize - 8];
				this.fs.Position = (long)(this.dirSecurityOffset + 8);
				this.fs.Read(array, 0, array.Length);
				return array;
			}
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		internal byte[] GetHash(HashAlgorithm hash)
		{
			if (this.blockNo < 1)
			{
				this.ReadFirstBlock();
			}
			this.fs.Position = (long)this.blockLength;
			int num = 0;
			long num2;
			if (this.dirSecurityOffset > 0)
			{
				if (this.dirSecurityOffset < this.blockLength)
				{
					this.blockLength = this.dirSecurityOffset;
					num2 = 0L;
				}
				else
				{
					num2 = (long)(this.dirSecurityOffset - this.blockLength);
				}
			}
			else if (this.coffSymbolTableOffset > 0)
			{
				this.fileblock[this.PEOffset + 12] = 0;
				this.fileblock[this.PEOffset + 13] = 0;
				this.fileblock[this.PEOffset + 14] = 0;
				this.fileblock[this.PEOffset + 15] = 0;
				this.fileblock[this.PEOffset + 16] = 0;
				this.fileblock[this.PEOffset + 17] = 0;
				this.fileblock[this.PEOffset + 18] = 0;
				this.fileblock[this.PEOffset + 19] = 0;
				if (this.coffSymbolTableOffset < this.blockLength)
				{
					this.blockLength = this.coffSymbolTableOffset;
					num2 = 0L;
				}
				else
				{
					num2 = (long)(this.coffSymbolTableOffset - this.blockLength);
				}
			}
			else
			{
				num = (int)(this.fs.Length & 7L);
				if (num > 0)
				{
					num = 8 - num;
				}
				num2 = this.fs.Length - (long)this.blockLength;
			}
			int num3 = this.peOffset + 88;
			hash.TransformBlock(this.fileblock, 0, num3, this.fileblock, 0);
			num3 += 4;
			if (this.pe64)
			{
				hash.TransformBlock(this.fileblock, num3, 76, this.fileblock, num3);
				num3 += 84;
			}
			else
			{
				hash.TransformBlock(this.fileblock, num3, 60, this.fileblock, num3);
				num3 += 68;
			}
			if (num2 == 0L)
			{
				hash.TransformFinalBlock(this.fileblock, num3, this.blockLength - num3);
			}
			else
			{
				hash.TransformBlock(this.fileblock, num3, this.blockLength - num3, this.fileblock, num3);
				long num4 = num2 >> 12;
				int num5 = (int)(num2 - (num4 << 12));
				if (num5 == 0)
				{
					num4 -= 1L;
					num5 = 4096;
				}
				for (;;)
				{
					long num6 = num4;
					num4 = num6 - 1L;
					if (num6 <= 0L)
					{
						break;
					}
					this.fs.Read(this.fileblock, 0, this.fileblock.Length);
					hash.TransformBlock(this.fileblock, 0, this.fileblock.Length, this.fileblock, 0);
				}
				if (this.fs.Read(this.fileblock, 0, num5) != num5)
				{
					return null;
				}
				if (num > 0)
				{
					hash.TransformBlock(this.fileblock, 0, num5, this.fileblock, 0);
					hash.TransformFinalBlock(new byte[num], 0, num);
				}
				else
				{
					hash.TransformFinalBlock(this.fileblock, 0, num5);
				}
			}
			return hash.Hash;
		}

		// Token: 0x04000225 RID: 549
		private byte[] fileblock;

		// Token: 0x04000226 RID: 550
		private Stream fs;

		// Token: 0x04000227 RID: 551
		private int blockNo;

		// Token: 0x04000228 RID: 552
		private int blockLength;

		// Token: 0x04000229 RID: 553
		private int peOffset;

		// Token: 0x0400022A RID: 554
		private int dirSecurityOffset;

		// Token: 0x0400022B RID: 555
		private int dirSecuritySize;

		// Token: 0x0400022C RID: 556
		private int coffSymbolTableOffset;

		// Token: 0x0400022D RID: 557
		private bool pe64;
	}
}
