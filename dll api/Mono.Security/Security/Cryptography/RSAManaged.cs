using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004F RID: 79
	public class RSAManaged : RSA
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0000B47D File Offset: 0x0000967D
		public RSAManaged() : this(1024)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000B48A File Offset: 0x0000968A
		public RSAManaged(int keySize)
		{
			this.LegalKeySizesValue = new KeySizes[1];
			this.LegalKeySizesValue[0] = new KeySizes(384, 16384, 8);
			base.KeySize = keySize;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000B4C4 File Offset: 0x000096C4
		~RSAManaged()
		{
			this.Dispose(false);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000B4F4 File Offset: 0x000096F4
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000B660 File Offset: 0x00009860
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000B6AE File Offset: 0x000098AE
		public bool PublicOnly
		{
			get
			{
				return this.keypairGenerated && (this.d == null || this.n == null);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000B6D8 File Offset: 0x000098D8
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

		// Token: 0x060001B9 RID: 441 RVA: 0x0000B73C File Offset: 0x0000993C
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

		// Token: 0x060001BA RID: 442 RVA: 0x0000B8D4 File Offset: 0x00009AD4
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

		// Token: 0x060001BB RID: 443 RVA: 0x0000BB4C File Offset: 0x00009D4C
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

		// Token: 0x060001BC RID: 444 RVA: 0x0000BC70 File Offset: 0x00009E70
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

		// Token: 0x060001BD RID: 445 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
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

		// Token: 0x04000218 RID: 536
		private bool isCRTpossible;

		// Token: 0x04000219 RID: 537
		private bool keyBlinding = true;

		// Token: 0x0400021A RID: 538
		private bool keypairGenerated;

		// Token: 0x0400021B RID: 539
		private bool m_disposed;

		// Token: 0x0400021C RID: 540
		private BigInteger d;

		// Token: 0x0400021D RID: 541
		private BigInteger p;

		// Token: 0x0400021E RID: 542
		private BigInteger q;

		// Token: 0x0400021F RID: 543
		private BigInteger dp;

		// Token: 0x04000220 RID: 544
		private BigInteger dq;

		// Token: 0x04000221 RID: 545
		private BigInteger qInv;

		// Token: 0x04000222 RID: 546
		private BigInteger n;

		// Token: 0x04000223 RID: 547
		private BigInteger e;

		// Token: 0x04000224 RID: 548
		[CompilerGenerated]
		private RSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060001BF RID: 447
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e);
	}
}
