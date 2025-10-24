using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes a Message Authentication Code (MAC) using <see cref="T:System.Security.Cryptography.TripleDES" /> for the input data <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
	// Token: 0x020002C0 RID: 704
	[ComVisible(true)]
	public class MACTripleDES : KeyedHashAlgorithm
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.MACTripleDES" /> class.</summary>
		// Token: 0x06001783 RID: 6019 RVA: 0x000609A8 File Offset: 0x0005EBA8
		public MACTripleDES()
		{
			this.KeyValue = new byte[24];
			Utils.StaticRandomNumberGenerator.GetBytes(this.KeyValue);
			this.des = TripleDES.Create();
			this.HashSizeValue = this.des.BlockSize;
			this.m_bytesPerBlock = this.des.BlockSize / 8;
			this.des.IV = new byte[this.m_bytesPerBlock];
			this.des.Padding = PaddingMode.Zeros;
			this.m_encryptor = null;
		}

		/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.MACTripleDES" />.</summary>
		// Token: 0x06001784 RID: 6020 RVA: 0x00060A30 File Offset: 0x0005EC30
		public override void Initialize()
		{
			this.m_encryptor = null;
		}

		/// <summary>Routes data written to the object into the <see cref="T:System.Security.Cryptography.TripleDES" /> encryptor for computing the Message Authentication Code (MAC).</summary>
		/// <param name="rgbData">The input data. </param>
		/// <param name="ibStart">The offset into the byte array from which to begin using data. </param>
		/// <param name="cbSize">The number of bytes in the array to use as data. </param>
		// Token: 0x06001785 RID: 6021 RVA: 0x00060A3C File Offset: 0x0005EC3C
		protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
		{
			if (this.m_encryptor == null)
			{
				this.des.Key = this.Key;
				this.m_encryptor = this.des.CreateEncryptor();
				this._ts = new TailStream(this.des.BlockSize / 8);
				this._cs = new CryptoStream(this._ts, this.m_encryptor, CryptoStreamMode.Write);
			}
			this._cs.Write(rgbData, ibStart, cbSize);
		}

		/// <summary>Returns the computed Message Authentication Code (MAC) after all data is written to the object.</summary>
		/// <returns>The computed MAC.</returns>
		// Token: 0x06001786 RID: 6022 RVA: 0x00060AB4 File Offset: 0x0005ECB4
		protected override byte[] HashFinal()
		{
			if (this.m_encryptor == null)
			{
				this.des.Key = this.Key;
				this.m_encryptor = this.des.CreateEncryptor();
				this._ts = new TailStream(this.des.BlockSize / 8);
				this._cs = new CryptoStream(this._ts, this.m_encryptor, CryptoStreamMode.Write);
			}
			this._cs.FlushFinalBlock();
			return this._ts.Buffer;
		}

		/// <summary>Releases the resources used by the <see cref="T:System.Security.Cryptography.MACTripleDES" /> instance.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> if the method is called from an <see cref="M:System.IDisposable.Dispose" /> implementation; otherwise, <see langword="false" />. </param>
		// Token: 0x06001787 RID: 6023 RVA: 0x00060B34 File Offset: 0x0005ED34
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.des != null)
				{
					this.des.Clear();
				}
				if (this.m_encryptor != null)
				{
					this.m_encryptor.Dispose();
				}
				if (this._cs != null)
				{
					this._cs.Clear();
				}
				if (this._ts != null)
				{
					this._ts.Clear();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x040009AB RID: 2475
		private ICryptoTransform m_encryptor;

		// Token: 0x040009AC RID: 2476
		private CryptoStream _cs;

		// Token: 0x040009AD RID: 2477
		private TailStream _ts;

		// Token: 0x040009AE RID: 2478
		private int m_bytesPerBlock;

		// Token: 0x040009AF RID: 2479
		private TripleDES des;
	}
}
