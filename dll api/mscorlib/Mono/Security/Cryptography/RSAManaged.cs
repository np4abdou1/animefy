using System;
using System.Security.Cryptography;
using System.Text;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004C RID: 76
	internal class RSAManaged : RSA
	{
		// Token: 0x06000174 RID: 372 RVA: 0x0000A4CE File Offset: 0x000086CE
		public RSAManaged(int keySize)
		{
			this.LegalKeySizesValue = new KeySizes[1];
			this.LegalKeySizesValue[0] = new KeySizes(384, 16384, 8);
			base.KeySize = keySize;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000A508 File Offset: 0x00008708
		~RSAManaged()
		{
			this.Dispose(false);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000A538 File Offset: 0x00008738
		private void GenerateKeyPair()
		{
			int num = this.KeySize + 1 >> 1;
			int bits = this.KeySize - num;
			this.e = 65537U;
			do
			{
				this.p = BigInteger.GeneratePseudoPrime(num);
			}
			while (this.p % 65537U == 1U);
			for (;;)
			{
				this.q = BigInteger.GeneratePseudoPrime(bits);
				if (this.q % 65537U != 1U && this.p != this.q)
				{
					this.n = this.p * this.q;
					if (this.n.BitCount() == this.KeySize)
					{
						break;
					}
					if (this.p < this.q)
					{
						this.p = this.q;
					}
				}
			}
			BigInteger bigInteger = this.p - 1;
			BigInteger bi = this.q - 1;
			BigInteger modulus = bigInteger * bi;
			this.d = this.e.ModInverse(modulus);
			this.dp = this.d % bigInteger;
			this.dq = this.d % bi;
			this.qInv = this.q.ModInverse(this.p);
			this.keypairGenerated = true;
			this.isCRTpossible = true;
			if (this.KeyGenerated != null)
			{
				this.KeyGenerated(this, null);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000A6A4 File Offset: 0x000088A4
		public override int KeySize
		{
			get
			{
				if (this.m_disposed)
				{
					throw new ObjectDisposedException(Locale.GetText("Keypair was disposed"));
				}
				if (this.keypairGenerated)
				{
					int num = this.n.BitCount();
					if ((num & 7) != 0)
					{
						num += 8 - (num & 7);
					}
					return num;
				}
				return base.KeySize;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000A6F2 File Offset: 0x000088F2
		public bool PublicOnly
		{
			get
			{
				return this.keypairGenerated && (this.d == null || this.n == null);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000A71C File Offset: 0x0000891C
		public override byte[] EncryptValue(byte[] rgb)
		{
			if (this.m_disposed)
			{
				throw new ObjectDisposedException("public key");
			}
			if (!this.keypairGenerated)
			{
				this.GenerateKeyPair();
			}
			BigInteger bigInteger = new BigInteger(rgb);
			BigInteger bigInteger2 = bigInteger.ModPow(this.e, this.n);
			byte[] paddedValue = this.GetPaddedValue(bigInteger2, this.KeySize >> 3);
			bigInteger.Clear();
			bigInteger2.Clear();
			return paddedValue;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000A780 File Offset: 0x00008980
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			if (this.m_disposed)
			{
				throw new ObjectDisposedException(Locale.GetText("Keypair was disposed"));
			}
			if (!this.keypairGenerated)
			{
				this.GenerateKeyPair();
			}
			RSAParameters rsaparameters = default(RSAParameters);
			rsaparameters.Exponent = this.e.GetBytes();
			rsaparameters.Modulus = this.n.GetBytes();
			if (includePrivateParameters)
			{
				if (this.d == null)
				{
					throw new CryptographicException("Missing private key");
				}
				rsaparameters.D = this.d.GetBytes();
				if (rsaparameters.D.Length != rsaparameters.Modulus.Length)
				{
					byte[] array = new byte[rsaparameters.Modulus.Length];
					Buffer.BlockCopy(rsaparameters.D, 0, array, array.Length - rsaparameters.D.Length, rsaparameters.D.Length);
					rsaparameters.D = array;
				}
				if (this.p != null && this.q != null && this.dp != null && this.dq != null && this.qInv != null)
				{
					int length = this.KeySize >> 4;
					rsaparameters.P = this.GetPaddedValue(this.p, length);
					rsaparameters.Q = this.GetPaddedValue(this.q, length);
					rsaparameters.DP = this.GetPaddedValue(this.dp, length);
					rsaparameters.DQ = this.GetPaddedValue(this.dq, length);
					rsaparameters.InverseQ = this.GetPaddedValue(this.qInv, length);
				}
			}
			return rsaparameters;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000A918 File Offset: 0x00008B18
		public override void ImportParameters(RSAParameters parameters)
		{
			if (this.m_disposed)
			{
				throw new ObjectDisposedException(Locale.GetText("Keypair was disposed"));
			}
			if (parameters.Exponent == null)
			{
				throw new CryptographicException(Locale.GetText("Missing Exponent"));
			}
			if (parameters.Modulus == null)
			{
				throw new CryptographicException(Locale.GetText("Missing Modulus"));
			}
			this.e = new BigInteger(parameters.Exponent);
			this.n = new BigInteger(parameters.Modulus);
			this.d = (this.dp = (this.dq = (this.qInv = (this.p = (this.q = null)))));
			if (parameters.D != null)
			{
				this.d = new BigInteger(parameters.D);
			}
			if (parameters.DP != null)
			{
				this.dp = new BigInteger(parameters.DP);
			}
			if (parameters.DQ != null)
			{
				this.dq = new BigInteger(parameters.DQ);
			}
			if (parameters.InverseQ != null)
			{
				this.qInv = new BigInteger(parameters.InverseQ);
			}
			if (parameters.P != null)
			{
				this.p = new BigInteger(parameters.P);
			}
			if (parameters.Q != null)
			{
				this.q = new BigInteger(parameters.Q);
			}
			this.keypairGenerated = true;
			bool flag = this.p != null && this.q != null && this.dp != null;
			this.isCRTpossible = (flag && this.dq != null && this.qInv != null);
			if (!flag)
			{
				return;
			}
			bool flag2 = this.n == this.p * this.q;
			if (flag2)
			{
				BigInteger bigInteger = this.p - 1;
				BigInteger bi = this.q - 1;
				BigInteger modulus = bigInteger * bi;
				BigInteger bigInteger2 = this.e.ModInverse(modulus);
				flag2 = (this.d == bigInteger2);
				if (!flag2 && this.isCRTpossible)
				{
					flag2 = (this.dp == bigInteger2 % bigInteger && this.dq == bigInteger2 % bi && this.qInv == this.q.ModInverse(this.p));
				}
			}
			if (!flag2)
			{
				throw new CryptographicException(Locale.GetText("Private/public key mismatch"));
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000AB90 File Offset: 0x00008D90
		protected override void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (this.d != null)
				{
					this.d.Clear();
					this.d = null;
				}
				if (this.p != null)
				{
					this.p.Clear();
					this.p = null;
				}
				if (this.q != null)
				{
					this.q.Clear();
					this.q = null;
				}
				if (this.dp != null)
				{
					this.dp.Clear();
					this.dp = null;
				}
				if (this.dq != null)
				{
					this.dq.Clear();
					this.dq = null;
				}
				if (this.qInv != null)
				{
					this.qInv.Clear();
					this.qInv = null;
				}
				if (disposing)
				{
					if (this.e != null)
					{
						this.e.Clear();
						this.e = null;
					}
					if (this.n != null)
					{
						this.n.Clear();
						this.n = null;
					}
				}
			}
			this.m_disposed = true;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600017D RID: 381 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		// (remove) Token: 0x0600017E RID: 382 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public event RSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x0600017F RID: 383 RVA: 0x0000AD24 File Offset: 0x00008F24
		public override string ToXmlString(bool includePrivateParameters)
		{
			StringBuilder stringBuilder = new StringBuilder();
			RSAParameters rsaparameters = this.ExportParameters(includePrivateParameters);
			try
			{
				stringBuilder.Append("<RSAKeyValue>");
				stringBuilder.Append("<Modulus>");
				stringBuilder.Append(Convert.ToBase64String(rsaparameters.Modulus));
				stringBuilder.Append("</Modulus>");
				stringBuilder.Append("<Exponent>");
				stringBuilder.Append(Convert.ToBase64String(rsaparameters.Exponent));
				stringBuilder.Append("</Exponent>");
				if (includePrivateParameters)
				{
					if (rsaparameters.P != null)
					{
						stringBuilder.Append("<P>");
						stringBuilder.Append(Convert.ToBase64String(rsaparameters.P));
						stringBuilder.Append("</P>");
					}
					if (rsaparameters.Q != null)
					{
						stringBuilder.Append("<Q>");
						stringBuilder.Append(Convert.ToBase64String(rsaparameters.Q));
						stringBuilder.Append("</Q>");
					}
					if (rsaparameters.DP != null)
					{
						stringBuilder.Append("<DP>");
						stringBuilder.Append(Convert.ToBase64String(rsaparameters.DP));
						stringBuilder.Append("</DP>");
					}
					if (rsaparameters.DQ != null)
					{
						stringBuilder.Append("<DQ>");
						stringBuilder.Append(Convert.ToBase64String(rsaparameters.DQ));
						stringBuilder.Append("</DQ>");
					}
					if (rsaparameters.InverseQ != null)
					{
						stringBuilder.Append("<InverseQ>");
						stringBuilder.Append(Convert.ToBase64String(rsaparameters.InverseQ));
						stringBuilder.Append("</InverseQ>");
					}
					stringBuilder.Append("<D>");
					stringBuilder.Append(Convert.ToBase64String(rsaparameters.D));
					stringBuilder.Append("</D>");
				}
				stringBuilder.Append("</RSAKeyValue>");
			}
			catch
			{
				if (rsaparameters.P != null)
				{
					Array.Clear(rsaparameters.P, 0, rsaparameters.P.Length);
				}
				if (rsaparameters.Q != null)
				{
					Array.Clear(rsaparameters.Q, 0, rsaparameters.Q.Length);
				}
				if (rsaparameters.DP != null)
				{
					Array.Clear(rsaparameters.DP, 0, rsaparameters.DP.Length);
				}
				if (rsaparameters.DQ != null)
				{
					Array.Clear(rsaparameters.DQ, 0, rsaparameters.DQ.Length);
				}
				if (rsaparameters.InverseQ != null)
				{
					Array.Clear(rsaparameters.InverseQ, 0, rsaparameters.InverseQ.Length);
				}
				if (rsaparameters.D != null)
				{
					Array.Clear(rsaparameters.D, 0, rsaparameters.D.Length);
				}
				throw;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000AFA8 File Offset: 0x000091A8
		private byte[] GetPaddedValue(BigInteger value, int length)
		{
			byte[] bytes = value.GetBytes();
			if (bytes.Length >= length)
			{
				return bytes;
			}
			byte[] array = new byte[length];
			Buffer.BlockCopy(bytes, 0, array, length - bytes.Length, bytes.Length);
			Array.Clear(bytes, 0, bytes.Length);
			return array;
		}

		// Token: 0x04000170 RID: 368
		private bool isCRTpossible;

		// Token: 0x04000171 RID: 369
		private bool keyBlinding = true;

		// Token: 0x04000172 RID: 370
		private bool keypairGenerated;

		// Token: 0x04000173 RID: 371
		private bool m_disposed;

		// Token: 0x04000174 RID: 372
		private BigInteger d;

		// Token: 0x04000175 RID: 373
		private BigInteger p;

		// Token: 0x04000176 RID: 374
		private BigInteger q;

		// Token: 0x04000177 RID: 375
		private BigInteger dp;

		// Token: 0x04000178 RID: 376
		private BigInteger dq;

		// Token: 0x04000179 RID: 377
		private BigInteger qInv;

		// Token: 0x0400017A RID: 378
		private BigInteger n;

		// Token: 0x0400017B RID: 379
		private BigInteger e;

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000182 RID: 386
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e);
	}
}
