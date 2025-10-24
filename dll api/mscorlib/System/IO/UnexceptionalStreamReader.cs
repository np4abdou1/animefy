using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.IO
{
	// Token: 0x02000566 RID: 1382
	internal class UnexceptionalStreamReader : StreamReader
	{
		// Token: 0x06002959 RID: 10585 RVA: 0x000A527C File Offset: 0x000A347C
		static UnexceptionalStreamReader()
		{
			string newLine = Environment.NewLine;
			if (newLine.Length == 1)
			{
				UnexceptionalStreamReader.newlineChar = newLine[0];
			}
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000A52B8 File Offset: 0x000A34B8
		public UnexceptionalStreamReader(Stream stream, Encoding encoding) : base(stream, encoding)
		{
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000A52C4 File Offset: 0x000A34C4
		public override int Peek()
		{
			try
			{
				return base.Peek();
			}
			catch (IOException)
			{
			}
			return -1;
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000A52F0 File Offset: 0x000A34F0
		public override int Read()
		{
			try
			{
				return base.Read();
			}
			catch (IOException)
			{
			}
			return -1;
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000A531C File Offset: 0x000A351C
		public override int Read([In] [Out] char[] dest_buffer, int index, int count)
		{
			if (dest_buffer == null)
			{
				throw new ArgumentNullException("dest_buffer");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "< 0");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "< 0");
			}
			if (index > dest_buffer.Length - count)
			{
				throw new ArgumentException("index + count > dest_buffer.Length");
			}
			int num = 0;
			char c = UnexceptionalStreamReader.newlineChar;
			try
			{
				while (count > 0)
				{
					int num2 = base.Read();
					if (num2 < 0)
					{
						break;
					}
					num++;
					count--;
					dest_buffer[index] = (char)num2;
					if (c != '\0')
					{
						if ((char)num2 == c)
						{
							return num;
						}
					}
					else if (this.CheckEOL((char)num2))
					{
						return num;
					}
					index++;
				}
			}
			catch (IOException)
			{
			}
			return num;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000A53D0 File Offset: 0x000A35D0
		private bool CheckEOL(char current)
		{
			int i = 0;
			while (i < UnexceptionalStreamReader.newline.Length)
			{
				if (!UnexceptionalStreamReader.newline[i])
				{
					if (current == Environment.NewLine[i])
					{
						UnexceptionalStreamReader.newline[i] = true;
						return i == UnexceptionalStreamReader.newline.Length - 1;
					}
					break;
				}
				else
				{
					i++;
				}
			}
			for (int j = 0; j < UnexceptionalStreamReader.newline.Length; j++)
			{
				UnexceptionalStreamReader.newline[j] = false;
			}
			return false;
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000A5438 File Offset: 0x000A3638
		public override string ReadLine()
		{
			try
			{
				return base.ReadLine();
			}
			catch (IOException)
			{
			}
			return null;
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000A5464 File Offset: 0x000A3664
		public override string ReadToEnd()
		{
			try
			{
				return base.ReadToEnd();
			}
			catch (IOException)
			{
			}
			return null;
		}

		// Token: 0x04001591 RID: 5521
		private static bool[] newline = new bool[Environment.NewLine.Length];

		// Token: 0x04001592 RID: 5522
		private static char newlineChar;
	}
}
