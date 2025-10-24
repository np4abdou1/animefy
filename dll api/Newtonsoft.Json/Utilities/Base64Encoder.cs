using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000092 RID: 146
	[NullableContext(1)]
	[Nullable(0)]
	internal class Base64Encoder
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x0001A72A File Offset: 0x0001892A
		public Base64Encoder(TextWriter writer)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = writer;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001A754 File Offset: 0x00018954
		private void ValidateEncode(byte[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count > buffer.Length - index)
			{
				throw new ArgumentOutOfRangeException("count");
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001A7A0 File Offset: 0x000189A0
		public void Encode(byte[] buffer, int index, int count)
		{
			this.ValidateEncode(buffer, index, count);
			if (this._leftOverBytesCount > 0)
			{
				if (this.FulfillFromLeftover(buffer, index, ref count))
				{
					return;
				}
				int count2 = Convert.ToBase64CharArray(this._leftOverBytes, 0, 3, this._charsLine, 0);
				this.WriteChars(this._charsLine, 0, count2);
			}
			this.StoreLeftOverBytes(buffer, index, ref count);
			int num = index + count;
			int num2 = 57;
			while (index < num)
			{
				if (index + num2 > num)
				{
					num2 = num - index;
				}
				int count3 = Convert.ToBase64CharArray(buffer, index, num2, this._charsLine, 0);
				this.WriteChars(this._charsLine, 0, count3);
				index += num2;
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001A834 File Offset: 0x00018A34
		private void StoreLeftOverBytes(byte[] buffer, int index, ref int count)
		{
			int num = count % 3;
			if (num > 0)
			{
				count -= num;
				if (this._leftOverBytes == null)
				{
					this._leftOverBytes = new byte[3];
				}
				for (int i = 0; i < num; i++)
				{
					this._leftOverBytes[i] = buffer[index + count + i];
				}
			}
			this._leftOverBytesCount = num;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001A888 File Offset: 0x00018A88
		private bool FulfillFromLeftover(byte[] buffer, int index, ref int count)
		{
			int leftOverBytesCount = this._leftOverBytesCount;
			while (leftOverBytesCount < 3 && count > 0)
			{
				this._leftOverBytes[leftOverBytesCount++] = buffer[index++];
				count--;
			}
			if (count == 0 && leftOverBytesCount < 3)
			{
				this._leftOverBytesCount = leftOverBytesCount;
				return true;
			}
			return false;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001A8D4 File Offset: 0x00018AD4
		public void Flush()
		{
			if (this._leftOverBytesCount > 0)
			{
				int count = Convert.ToBase64CharArray(this._leftOverBytes, 0, this._leftOverBytesCount, this._charsLine, 0);
				this.WriteChars(this._charsLine, 0, count);
				this._leftOverBytesCount = 0;
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001A919 File Offset: 0x00018B19
		private void WriteChars(char[] chars, int index, int count)
		{
			this._writer.Write(chars, index, count);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0001A92C File Offset: 0x00018B2C
		public Task EncodeAsync(byte[] buffer, int index, int count, CancellationToken cancellationToken)
		{
			Base64Encoder.<EncodeAsync>d__13 <EncodeAsync>d__;
			<EncodeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<EncodeAsync>d__.<>4__this = this;
			<EncodeAsync>d__.buffer = buffer;
			<EncodeAsync>d__.index = index;
			<EncodeAsync>d__.count = count;
			<EncodeAsync>d__.cancellationToken = cancellationToken;
			<EncodeAsync>d__.<>1__state = -1;
			<EncodeAsync>d__.<>t__builder.Start<Base64Encoder.<EncodeAsync>d__13>(ref <EncodeAsync>d__);
			return <EncodeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0001A990 File Offset: 0x00018B90
		private Task WriteCharsAsync(char[] chars, int index, int count, CancellationToken cancellationToken)
		{
			return this._writer.WriteAsync(chars, index, count, cancellationToken);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001A9A4 File Offset: 0x00018BA4
		public Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			if (this._leftOverBytesCount > 0)
			{
				int count = Convert.ToBase64CharArray(this._leftOverBytes, 0, this._leftOverBytesCount, this._charsLine, 0);
				this._leftOverBytesCount = 0;
				return this.WriteCharsAsync(this._charsLine, 0, count, cancellationToken);
			}
			return AsyncUtils.CompletedTask;
		}

		// Token: 0x04000367 RID: 871
		private const int Base64LineSize = 76;

		// Token: 0x04000368 RID: 872
		private const int LineSizeInBytes = 57;

		// Token: 0x04000369 RID: 873
		private readonly char[] _charsLine = new char[76];

		// Token: 0x0400036A RID: 874
		private readonly TextWriter _writer;

		// Token: 0x0400036B RID: 875
		[Nullable(2)]
		private byte[] _leftOverBytes;

		// Token: 0x0400036C RID: 876
		private int _leftOverBytesCount;
	}
}
