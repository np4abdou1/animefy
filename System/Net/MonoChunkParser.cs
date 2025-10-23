using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.Net
{
	// Token: 0x020001B6 RID: 438
	internal class MonoChunkParser
	{
		// Token: 0x06000BEC RID: 3052 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		public MonoChunkParser(WebHeaderCollection headers)
		{
			this.headers = headers;
			this.saved = new StringBuilder();
			this.chunks = new ArrayList();
			this.chunkSize = -1;
			this.totalWritten = 0;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0003EB5F File Offset: 0x0003CD5F
		public int Read(byte[] buffer, int offset, int size)
		{
			return this.ReadFromChunks(buffer, offset, size);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0003EB6C File Offset: 0x0003CD6C
		private int ReadFromChunks(byte[] buffer, int offset, int size)
		{
			int count = this.chunks.Count;
			int num = 0;
			List<MonoChunkParser.Chunk> list = new List<MonoChunkParser.Chunk>(count);
			for (int i = 0; i < count; i++)
			{
				MonoChunkParser.Chunk chunk = (MonoChunkParser.Chunk)this.chunks[i];
				if (chunk.Offset == chunk.Bytes.Length)
				{
					list.Add(chunk);
				}
				else
				{
					num += chunk.Read(buffer, offset + num, size - num);
					if (num == size)
					{
						break;
					}
				}
			}
			foreach (MonoChunkParser.Chunk obj in list)
			{
				this.chunks.Remove(obj);
			}
			return num;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0003EC28 File Offset: 0x0003CE28
		public void Write(byte[] buffer, int offset, int size)
		{
			if (offset < size)
			{
				this.InternalWrite(buffer, ref offset, size);
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0003EC38 File Offset: 0x0003CE38
		private void InternalWrite(byte[] buffer, ref int offset, int size)
		{
			if (this.state == MonoChunkParser.State.None || this.state == MonoChunkParser.State.PartialSize)
			{
				this.state = this.GetChunkSize(buffer, ref offset, size);
				if (this.state == MonoChunkParser.State.PartialSize)
				{
					return;
				}
				this.saved.Length = 0;
				this.sawCR = false;
				this.gotit = false;
			}
			if (this.state == MonoChunkParser.State.Body && offset < size)
			{
				this.state = this.ReadBody(buffer, ref offset, size);
				if (this.state == MonoChunkParser.State.Body)
				{
					return;
				}
			}
			if (this.state == MonoChunkParser.State.BodyFinished && offset < size)
			{
				this.state = this.ReadCRLF(buffer, ref offset, size);
				if (this.state == MonoChunkParser.State.BodyFinished)
				{
					return;
				}
				this.sawCR = false;
			}
			if (this.state == MonoChunkParser.State.Trailer && offset < size)
			{
				this.state = this.ReadTrailer(buffer, ref offset, size);
				if (this.state == MonoChunkParser.State.Trailer)
				{
					return;
				}
				this.saved.Length = 0;
				this.sawCR = false;
				this.gotit = false;
			}
			if (offset < size)
			{
				this.InternalWrite(buffer, ref offset, size);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0003ED2D File Offset: 0x0003CF2D
		public bool WantMore
		{
			get
			{
				return this.chunkRead != this.chunkSize || this.chunkSize != 0 || this.state > MonoChunkParser.State.None;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0003ED50 File Offset: 0x0003CF50
		public bool DataAvailable
		{
			get
			{
				int count = this.chunks.Count;
				for (int i = 0; i < count; i++)
				{
					MonoChunkParser.Chunk chunk = (MonoChunkParser.Chunk)this.chunks[i];
					if (chunk != null && chunk.Bytes != null && chunk.Bytes.Length != 0 && chunk.Offset < chunk.Bytes.Length)
					{
						return this.state != MonoChunkParser.State.Body;
					}
				}
				return false;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0003EDB9 File Offset: 0x0003CFB9
		public int ChunkLeft
		{
			get
			{
				return this.chunkSize - this.chunkRead;
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
		private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size)
		{
			if (this.chunkSize == 0)
			{
				return MonoChunkParser.State.BodyFinished;
			}
			int num = size - offset;
			if (num + this.chunkRead > this.chunkSize)
			{
				num = this.chunkSize - this.chunkRead;
			}
			byte[] array = new byte[num];
			Buffer.BlockCopy(buffer, offset, array, 0, num);
			this.chunks.Add(new MonoChunkParser.Chunk(array));
			offset += num;
			this.chunkRead += num;
			this.totalWritten += num;
			if (this.chunkRead != this.chunkSize)
			{
				return MonoChunkParser.State.Body;
			}
			return MonoChunkParser.State.BodyFinished;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0003EE5C File Offset: 0x0003D05C
		private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size)
		{
			this.chunkRead = 0;
			this.chunkSize = 0;
			char c = '\0';
			while (offset < size)
			{
				int num = offset;
				offset = num + 1;
				c = (char)buffer[num];
				if (c == '\r')
				{
					if (this.sawCR)
					{
						MonoChunkParser.ThrowProtocolViolation("2 CR found");
					}
					this.sawCR = true;
				}
				else
				{
					if (this.sawCR && c == '\n')
					{
						break;
					}
					if (c == ' ')
					{
						this.gotit = true;
					}
					if (!this.gotit)
					{
						this.saved.Append(c);
					}
					if (this.saved.Length > 20)
					{
						MonoChunkParser.ThrowProtocolViolation("chunk size too long.");
					}
				}
			}
			if (!this.sawCR || c != '\n')
			{
				if (offset < size)
				{
					MonoChunkParser.ThrowProtocolViolation("Missing \\n");
				}
				try
				{
					if (this.saved.Length > 0)
					{
						this.chunkSize = int.Parse(MonoChunkParser.RemoveChunkExtension(this.saved.ToString()), NumberStyles.HexNumber);
					}
				}
				catch (Exception)
				{
					MonoChunkParser.ThrowProtocolViolation("Cannot parse chunk size.");
				}
				return MonoChunkParser.State.PartialSize;
			}
			this.chunkRead = 0;
			try
			{
				this.chunkSize = int.Parse(MonoChunkParser.RemoveChunkExtension(this.saved.ToString()), NumberStyles.HexNumber);
			}
			catch (Exception)
			{
				MonoChunkParser.ThrowProtocolViolation("Cannot parse chunk size.");
			}
			if (this.chunkSize == 0)
			{
				this.trailerState = 2;
				return MonoChunkParser.State.Trailer;
			}
			return MonoChunkParser.State.Body;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0003EFB4 File Offset: 0x0003D1B4
		private static string RemoveChunkExtension(string input)
		{
			int num = input.IndexOf(';');
			if (num == -1)
			{
				return input;
			}
			return input.Substring(0, num);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0003EFD8 File Offset: 0x0003D1D8
		private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size)
		{
			if (!this.sawCR)
			{
				int num = offset;
				offset = num + 1;
				if (buffer[num] != 13)
				{
					MonoChunkParser.ThrowProtocolViolation("Expecting \\r");
				}
				this.sawCR = true;
				if (offset == size)
				{
					return MonoChunkParser.State.BodyFinished;
				}
			}
			if (this.sawCR)
			{
				int num = offset;
				offset = num + 1;
				if (buffer[num] != 10)
				{
					MonoChunkParser.ThrowProtocolViolation("Expecting \\n");
				}
			}
			return MonoChunkParser.State.None;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0003F038 File Offset: 0x0003D238
		private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size)
		{
			if (this.trailerState == 2 && buffer[offset] == 13 && this.saved.Length == 0)
			{
				offset++;
				if (offset < size && buffer[offset] == 10)
				{
					offset++;
					return MonoChunkParser.State.None;
				}
				offset--;
			}
			int num = this.trailerState;
			while (offset < size && num < 4)
			{
				int num2 = offset;
				offset = num2 + 1;
				char c = (char)buffer[num2];
				if ((num == 0 || num == 2) && c == '\r')
				{
					num++;
				}
				else if ((num == 1 || num == 3) && c == '\n')
				{
					num++;
				}
				else if (num >= 0)
				{
					this.saved.Append(c);
					num = 0;
					if (this.saved.Length > 4196)
					{
						MonoChunkParser.ThrowProtocolViolation("Error reading trailer (too long).");
					}
				}
			}
			if (num < 4)
			{
				this.trailerState = num;
				if (offset < size)
				{
					MonoChunkParser.ThrowProtocolViolation("Error reading trailer.");
				}
				return MonoChunkParser.State.Trailer;
			}
			StringReader stringReader = new StringReader(this.saved.ToString());
			string text;
			while ((text = stringReader.ReadLine()) != null && text != "")
			{
				this.headers.Add(text);
			}
			return MonoChunkParser.State.None;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0003F14E File Offset: 0x0003D34E
		private static void ThrowProtocolViolation(string message)
		{
			throw new WebException(message, null, WebExceptionStatus.ServerProtocolViolation, null);
		}

		// Token: 0x040008AB RID: 2219
		private WebHeaderCollection headers;

		// Token: 0x040008AC RID: 2220
		private int chunkSize;

		// Token: 0x040008AD RID: 2221
		private int chunkRead;

		// Token: 0x040008AE RID: 2222
		private int totalWritten;

		// Token: 0x040008AF RID: 2223
		private MonoChunkParser.State state;

		// Token: 0x040008B0 RID: 2224
		private StringBuilder saved;

		// Token: 0x040008B1 RID: 2225
		private bool sawCR;

		// Token: 0x040008B2 RID: 2226
		private bool gotit;

		// Token: 0x040008B3 RID: 2227
		private int trailerState;

		// Token: 0x040008B4 RID: 2228
		private ArrayList chunks;

		// Token: 0x020001B7 RID: 439
		private enum State
		{
			// Token: 0x040008B6 RID: 2230
			None,
			// Token: 0x040008B7 RID: 2231
			PartialSize,
			// Token: 0x040008B8 RID: 2232
			Body,
			// Token: 0x040008B9 RID: 2233
			BodyFinished,
			// Token: 0x040008BA RID: 2234
			Trailer
		}

		// Token: 0x020001B8 RID: 440
		private class Chunk
		{
			// Token: 0x06000BFA RID: 3066 RVA: 0x0003F15A File Offset: 0x0003D35A
			public Chunk(byte[] chunk)
			{
				this.Bytes = chunk;
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x0003F16C File Offset: 0x0003D36C
			public int Read(byte[] buffer, int offset, int size)
			{
				int num = (size > this.Bytes.Length - this.Offset) ? (this.Bytes.Length - this.Offset) : size;
				Buffer.BlockCopy(this.Bytes, this.Offset, buffer, offset, num);
				this.Offset += num;
				return num;
			}

			// Token: 0x040008BB RID: 2235
			public byte[] Bytes;

			// Token: 0x040008BC RID: 2236
			public int Offset;
		}
	}
}
