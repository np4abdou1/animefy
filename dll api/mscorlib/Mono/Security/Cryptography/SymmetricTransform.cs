using System;
using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004E RID: 78
	internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
	{
		// Token: 0x06000185 RID: 389 RVA: 0x0000AFE8 File Offset: 0x000091E8
		public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV)
		{
			this.algo = symmAlgo;
			this.encrypt = encryption;
			this.BlockSizeByte = this.algo.BlockSize >> 3;
			if (rgbIV == null)
			{
				rgbIV = KeyBuilder.IV(this.BlockSizeByte);
			}
			else
			{
				rgbIV = (byte[])rgbIV.Clone();
			}
			if (rgbIV.Length < this.BlockSizeByte)
			{
				throw new CryptographicException(Locale.GetText("IV is too small ({0} bytes), it should be {1} bytes long.", new object[]
				{
					rgbIV.Length,
					this.BlockSizeByte
				}));
			}
			this.padmode = this.algo.Padding;
			this.temp = new byte[this.BlockSizeByte];
			Buffer.BlockCopy(rgbIV, 0, this.temp, 0, Math.Min(this.BlockSizeByte, rgbIV.Length));
			this.temp2 = new byte[this.BlockSizeByte];
			this.FeedBackByte = this.algo.FeedbackSize >> 3;
			this.workBuff = new byte[this.BlockSizeByte];
			this.workout = new byte[this.BlockSizeByte];
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000B0FC File Offset: 0x000092FC
		~SymmetricTransform()
		{
			this.Dispose(false);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000B12C File Offset: 0x0000932C
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000B13C File Offset: 0x0000933C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (disposing)
				{
					Array.Clear(this.temp, 0, this.BlockSizeByte);
					this.temp = null;
					Array.Clear(this.temp2, 0, this.BlockSizeByte);
					this.temp2 = null;
				}
				this.m_disposed = true;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000B18D File Offset: 0x0000938D
		public virtual bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000B190 File Offset: 0x00009390
		public virtual int InputBlockSize
		{
			get
			{
				return this.BlockSizeByte;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000B190 File Offset: 0x00009390
		public virtual int OutputBlockSize
		{
			get
			{
				return this.BlockSizeByte;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000B198 File Offset: 0x00009398
		protected virtual void Transform(byte[] input, byte[] output)
		{
			switch (this.algo.Mode)
			{
			case CipherMode.CBC:
				this.CBC(input, output);
				return;
			case CipherMode.ECB:
				this.ECB(input, output);
				return;
			case CipherMode.OFB:
				this.OFB(input, output);
				return;
			case CipherMode.CFB:
				this.CFB(input, output);
				return;
			case CipherMode.CTS:
				this.CTS(input, output);
				return;
			default:
				throw new NotImplementedException("Unkown CipherMode" + this.algo.Mode.ToString());
			}
		}

		// Token: 0x0600018D RID: 397
		protected abstract void ECB(byte[] input, byte[] output);

		// Token: 0x0600018E RID: 398 RVA: 0x0000B224 File Offset: 0x00009424
		protected virtual void CBC(byte[] input, byte[] output)
		{
			if (this.encrypt)
			{
				for (int i = 0; i < this.BlockSizeByte; i++)
				{
					byte[] array = this.temp;
					int num = i;
					array[num] ^= input[i];
				}
				this.ECB(this.temp, output);
				Buffer.BlockCopy(output, 0, this.temp, 0, this.BlockSizeByte);
				return;
			}
			Buffer.BlockCopy(input, 0, this.temp2, 0, this.BlockSizeByte);
			this.ECB(input, output);
			for (int j = 0; j < this.BlockSizeByte; j++)
			{
				int num2 = j;
				output[num2] ^= this.temp[j];
			}
			Buffer.BlockCopy(this.temp2, 0, this.temp, 0, this.BlockSizeByte);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000B2DC File Offset: 0x000094DC
		protected virtual void CFB(byte[] input, byte[] output)
		{
			if (this.encrypt)
			{
				for (int i = 0; i < this.BlockSizeByte; i++)
				{
					this.ECB(this.temp, this.temp2);
					output[i] = (this.temp2[0] ^ input[i]);
					Buffer.BlockCopy(this.temp, 1, this.temp, 0, this.BlockSizeByte - 1);
					Buffer.BlockCopy(output, i, this.temp, this.BlockSizeByte - 1, 1);
				}
				return;
			}
			for (int j = 0; j < this.BlockSizeByte; j++)
			{
				this.encrypt = true;
				this.ECB(this.temp, this.temp2);
				this.encrypt = false;
				Buffer.BlockCopy(this.temp, 1, this.temp, 0, this.BlockSizeByte - 1);
				Buffer.BlockCopy(input, j, this.temp, this.BlockSizeByte - 1, 1);
				output[j] = (this.temp2[0] ^ input[j]);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000B3C8 File Offset: 0x000095C8
		protected virtual void OFB(byte[] input, byte[] output)
		{
			throw new CryptographicException("OFB isn't supported by the framework");
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000B3D4 File Offset: 0x000095D4
		protected virtual void CTS(byte[] input, byte[] output)
		{
			throw new CryptographicException("CTS isn't supported by the framework");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000B3E0 File Offset: 0x000095E0
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException("inputBuffer");
			}
			if (inputOffset < 0)
			{
				throw new ArgumentOutOfRangeException("inputOffset", "< 0");
			}
			if (inputCount < 0)
			{
				throw new ArgumentOutOfRangeException("inputCount", "< 0");
			}
			if (inputOffset > inputBuffer.Length - inputCount)
			{
				throw new ArgumentException("inputBuffer", Locale.GetText("Overflow"));
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000B440 File Offset: 0x00009640
		public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (this.m_disposed)
			{
				throw new ObjectDisposedException("Object is disposed");
			}
			this.CheckInput(inputBuffer, inputOffset, inputCount);
			if (outputBuffer == null)
			{
				throw new ArgumentNullException("outputBuffer");
			}
			if (outputOffset < 0)
			{
				throw new ArgumentOutOfRangeException("outputOffset", "< 0");
			}
			int num = outputBuffer.Length - inputCount - outputOffset;
			if (!this.encrypt && 0 > num && (this.padmode == PaddingMode.None || this.padmode == PaddingMode.Zeros))
			{
				throw new CryptographicException("outputBuffer", Locale.GetText("Overflow"));
			}
			if (this.KeepLastBlock)
			{
				if (0 > num + this.BlockSizeByte)
				{
					throw new CryptographicException("outputBuffer", Locale.GetText("Overflow"));
				}
			}
			else if (0 > num)
			{
				if (inputBuffer.Length - inputOffset - outputBuffer.Length != this.BlockSizeByte)
				{
					throw new CryptographicException("outputBuffer", Locale.GetText("Overflow"));
				}
				inputCount = outputBuffer.Length - outputOffset;
			}
			return this.InternalTransformBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000B535 File Offset: 0x00009735
		private bool KeepLastBlock
		{
			get
			{
				return !this.encrypt && this.padmode != PaddingMode.None && this.padmode != PaddingMode.Zeros;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000B558 File Offset: 0x00009758
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			int num = inputOffset;
			int num2;
			if (inputCount != this.BlockSizeByte)
			{
				if (inputCount % this.BlockSizeByte != 0)
				{
					throw new CryptographicException("Invalid input block size.");
				}
				num2 = inputCount / this.BlockSizeByte;
			}
			else
			{
				num2 = 1;
			}
			if (this.KeepLastBlock)
			{
				num2--;
			}
			int num3 = 0;
			if (this.lastBlock)
			{
				this.Transform(this.workBuff, this.workout);
				Buffer.BlockCopy(this.workout, 0, outputBuffer, outputOffset, this.BlockSizeByte);
				outputOffset += this.BlockSizeByte;
				num3 += this.BlockSizeByte;
				this.lastBlock = false;
			}
			for (int i = 0; i < num2; i++)
			{
				Buffer.BlockCopy(inputBuffer, num, this.workBuff, 0, this.BlockSizeByte);
				this.Transform(this.workBuff, this.workout);
				Buffer.BlockCopy(this.workout, 0, outputBuffer, outputOffset, this.BlockSizeByte);
				num += this.BlockSizeByte;
				outputOffset += this.BlockSizeByte;
				num3 += this.BlockSizeByte;
			}
			if (this.KeepLastBlock)
			{
				Buffer.BlockCopy(inputBuffer, num, this.workBuff, 0, this.BlockSizeByte);
				this.lastBlock = true;
			}
			return num3;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000B674 File Offset: 0x00009874
		private void Random(byte[] buffer, int start, int length)
		{
			if (this._rng == null)
			{
				this._rng = RandomNumberGenerator.Create();
			}
			byte[] array = new byte[length];
			this._rng.GetBytes(array);
			Buffer.BlockCopy(array, 0, buffer, start, length);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000B6B4 File Offset: 0x000098B4
		private void ThrowBadPaddingException(PaddingMode padding, int length, int position)
		{
			string text = string.Format(Locale.GetText("Bad {0} padding."), padding);
			if (length >= 0)
			{
				text += string.Format(Locale.GetText(" Invalid length {0}."), length);
			}
			if (position >= 0)
			{
				text += string.Format(Locale.GetText(" Error found at position {0}."), position);
			}
			throw new CryptographicException(text);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000B720 File Offset: 0x00009920
		protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			int num = inputCount / this.BlockSizeByte * this.BlockSizeByte;
			int num2 = inputCount - num;
			int i = num;
			PaddingMode paddingMode = this.padmode;
			if (paddingMode == PaddingMode.PKCS7 || paddingMode - PaddingMode.ANSIX923 <= 1)
			{
				i += this.BlockSizeByte;
			}
			else
			{
				if (inputCount == 0)
				{
					return new byte[0];
				}
				if (num2 != 0)
				{
					if (this.padmode == PaddingMode.None)
					{
						throw new CryptographicException("invalid block length");
					}
					byte[] array = new byte[num + this.BlockSizeByte];
					Buffer.BlockCopy(inputBuffer, inputOffset, array, 0, inputCount);
					inputBuffer = array;
					inputOffset = 0;
					inputCount = array.Length;
					i = inputCount;
				}
			}
			byte[] array2 = new byte[i];
			int num3 = 0;
			while (i > this.BlockSizeByte)
			{
				this.InternalTransformBlock(inputBuffer, inputOffset, this.BlockSizeByte, array2, num3);
				inputOffset += this.BlockSizeByte;
				num3 += this.BlockSizeByte;
				i -= this.BlockSizeByte;
			}
			byte b = (byte)(this.BlockSizeByte - num2);
			switch (this.padmode)
			{
			case PaddingMode.PKCS7:
			{
				int num4 = array2.Length;
				while (--num4 >= array2.Length - (int)b)
				{
					array2[num4] = b;
				}
				Buffer.BlockCopy(inputBuffer, inputOffset, array2, num, num2);
				this.InternalTransformBlock(array2, num, this.BlockSizeByte, array2, num);
				return array2;
			}
			case PaddingMode.ANSIX923:
				array2[array2.Length - 1] = b;
				Buffer.BlockCopy(inputBuffer, inputOffset, array2, num, num2);
				this.InternalTransformBlock(array2, num, this.BlockSizeByte, array2, num);
				return array2;
			case PaddingMode.ISO10126:
				this.Random(array2, array2.Length - (int)b, (int)(b - 1));
				array2[array2.Length - 1] = b;
				Buffer.BlockCopy(inputBuffer, inputOffset, array2, num, num2);
				this.InternalTransformBlock(array2, num, this.BlockSizeByte, array2, num);
				return array2;
			}
			this.InternalTransformBlock(inputBuffer, inputOffset, this.BlockSizeByte, array2, num3);
			return array2;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			int i = inputCount;
			int num = inputCount;
			if (this.lastBlock)
			{
				num += this.BlockSizeByte;
			}
			byte[] array = new byte[num];
			int num2 = 0;
			while (i > 0)
			{
				int num3 = this.InternalTransformBlock(inputBuffer, inputOffset, this.BlockSizeByte, array, num2);
				inputOffset += this.BlockSizeByte;
				num2 += num3;
				i -= this.BlockSizeByte;
			}
			if (this.lastBlock)
			{
				this.Transform(this.workBuff, this.workout);
				Buffer.BlockCopy(this.workout, 0, array, num2, this.BlockSizeByte);
				num2 += this.BlockSizeByte;
				this.lastBlock = false;
			}
			byte b = (num > 0) ? array[num - 1] : 0;
			switch (this.padmode)
			{
			case PaddingMode.PKCS7:
				if (b == 0 || (int)b > this.BlockSizeByte)
				{
					this.ThrowBadPaddingException(this.padmode, (int)b, -1);
				}
				for (int j = (int)(b - 1); j > 0; j--)
				{
					if (array[num - 1 - j] != b)
					{
						this.ThrowBadPaddingException(this.padmode, -1, j);
					}
				}
				num -= (int)b;
				break;
			case PaddingMode.ANSIX923:
				if (b == 0 || (int)b > this.BlockSizeByte)
				{
					this.ThrowBadPaddingException(this.padmode, (int)b, -1);
				}
				for (int k = (int)(b - 1); k > 0; k--)
				{
					if (array[num - 1 - k] != 0)
					{
						this.ThrowBadPaddingException(this.padmode, -1, k);
					}
				}
				num -= (int)b;
				break;
			case PaddingMode.ISO10126:
				if (b == 0 || (int)b > this.BlockSizeByte)
				{
					this.ThrowBadPaddingException(this.padmode, (int)b, -1);
				}
				num -= (int)b;
				break;
			}
			if (num > 0)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				Array.Clear(array, 0, array.Length);
				return array2;
			}
			return new byte[0];
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000BA8F File Offset: 0x00009C8F
		public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (this.m_disposed)
			{
				throw new ObjectDisposedException("Object is disposed");
			}
			this.CheckInput(inputBuffer, inputOffset, inputCount);
			if (this.encrypt)
			{
				return this.FinalEncrypt(inputBuffer, inputOffset, inputCount);
			}
			return this.FinalDecrypt(inputBuffer, inputOffset, inputCount);
		}

		// Token: 0x0400017D RID: 381
		protected SymmetricAlgorithm algo;

		// Token: 0x0400017E RID: 382
		protected bool encrypt;

		// Token: 0x0400017F RID: 383
		protected int BlockSizeByte;

		// Token: 0x04000180 RID: 384
		protected byte[] temp;

		// Token: 0x04000181 RID: 385
		protected byte[] temp2;

		// Token: 0x04000182 RID: 386
		private byte[] workBuff;

		// Token: 0x04000183 RID: 387
		private byte[] workout;

		// Token: 0x04000184 RID: 388
		protected PaddingMode padmode;

		// Token: 0x04000185 RID: 389
		protected int FeedBackByte;

		// Token: 0x04000186 RID: 390
		private bool m_disposed;

		// Token: 0x04000187 RID: 391
		protected bool lastBlock;

		// Token: 0x04000188 RID: 392
		private RandomNumberGenerator _rng;
	}
}
