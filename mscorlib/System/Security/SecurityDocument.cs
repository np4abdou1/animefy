using System;
using System.Security.Util;
using System.Text;

namespace System.Security
{
	// Token: 0x0200027F RID: 639
	[Serializable]
	internal sealed class SecurityDocument
	{
		// Token: 0x06001643 RID: 5699 RVA: 0x0005B178 File Offset: 0x00059378
		public SecurityDocument(int numData)
		{
			this.m_data = new byte[numData];
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0005B18C File Offset: 0x0005938C
		public void GuaranteeSize(int size)
		{
			if (this.m_data.Length < size)
			{
				byte[] array = new byte[(size / 32 + 1) * 32];
				Array.Copy(this.m_data, 0, array, 0, this.m_data.Length);
				this.m_data = array;
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0005B1D0 File Offset: 0x000593D0
		public void AddString(string str, ref int position)
		{
			this.GuaranteeSize(position + str.Length * 2 + 2);
			for (int i = 0; i < str.Length; i++)
			{
				this.m_data[position + 2 * i] = (byte)(str[i] >> 8);
				this.m_data[position + 2 * i + 1] = (byte)(str[i] & 'ÿ');
			}
			this.m_data[position + str.Length * 2] = 0;
			this.m_data[position + str.Length * 2 + 1] = 0;
			position += str.Length * 2 + 2;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0005B26C File Offset: 0x0005946C
		public void AppendString(string str, ref int position)
		{
			if (position <= 1 || this.m_data[position - 1] != 0 || this.m_data[position - 2] != 0)
			{
				throw new XmlSyntaxException();
			}
			position -= 2;
			this.AddString(str, ref position);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0005B2A1 File Offset: 0x000594A1
		public static int EncodedStringSize(string str)
		{
			return str.Length * 2 + 2;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0005B2B0 File Offset: 0x000594B0
		public string GetString(ref int position, bool bCreate)
		{
			int num = position;
			while (num < this.m_data.Length - 1 && (this.m_data[num] != 0 || this.m_data[num + 1] != 0))
			{
				num += 2;
			}
			Tokenizer.StringMaker sharedStringMaker = SharedStatics.GetSharedStringMaker();
			string result;
			try
			{
				if (bCreate)
				{
					sharedStringMaker._outStringBuilder = null;
					sharedStringMaker._outIndex = 0;
					for (int i = position; i < num; i += 2)
					{
						char c = (char)((int)this.m_data[i] << 8 | (int)this.m_data[i + 1]);
						if (sharedStringMaker._outIndex < 512)
						{
							char[] outChars = sharedStringMaker._outChars;
							Tokenizer.StringMaker stringMaker = sharedStringMaker;
							int outIndex = stringMaker._outIndex;
							stringMaker._outIndex = outIndex + 1;
							outChars[outIndex] = c;
						}
						else
						{
							if (sharedStringMaker._outStringBuilder == null)
							{
								sharedStringMaker._outStringBuilder = new StringBuilder();
							}
							sharedStringMaker._outStringBuilder.Append(sharedStringMaker._outChars, 0, 512);
							sharedStringMaker._outChars[0] = c;
							sharedStringMaker._outIndex = 1;
						}
					}
				}
				position = num + 2;
				if (bCreate)
				{
					result = sharedStringMaker.MakeString();
				}
				else
				{
					result = null;
				}
			}
			finally
			{
				SharedStatics.ReleaseSharedStringMaker(ref sharedStringMaker);
			}
			return result;
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0005B3C4 File Offset: 0x000595C4
		public void AddToken(byte b, ref int position)
		{
			this.GuaranteeSize(position + 1);
			byte[] data = this.m_data;
			int num = position;
			position = num + 1;
			data[num] = b;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0005B3EC File Offset: 0x000595EC
		public SecurityElement GetRootElement()
		{
			return this.GetElement(0, true);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0005B3F6 File Offset: 0x000595F6
		public SecurityElement GetElement(int position, bool bCreate)
		{
			return this.InternalGetElement(ref position, bCreate);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0005B404 File Offset: 0x00059604
		internal SecurityElement InternalGetElement(ref int position, bool bCreate)
		{
			if (this.m_data.Length <= position)
			{
				throw new XmlSyntaxException();
			}
			byte[] data = this.m_data;
			int num = position;
			position = num + 1;
			if (data[num] != 1)
			{
				throw new XmlSyntaxException();
			}
			SecurityElement securityElement = null;
			string @string = this.GetString(ref position, bCreate);
			if (bCreate)
			{
				securityElement = new SecurityElement(@string);
			}
			while (this.m_data[position] == 2)
			{
				position++;
				string string2 = this.GetString(ref position, bCreate);
				string string3 = this.GetString(ref position, bCreate);
				if (bCreate)
				{
					securityElement.AddAttribute(string2, string3);
				}
			}
			if (this.m_data[position] == 3)
			{
				position++;
				string string4 = this.GetString(ref position, bCreate);
				if (bCreate)
				{
					securityElement.m_strText = string4;
				}
			}
			while (this.m_data[position] != 4)
			{
				SecurityElement child = this.InternalGetElement(ref position, bCreate);
				if (bCreate)
				{
					securityElement.AddChild(child);
				}
			}
			position++;
			return securityElement;
		}

		// Token: 0x040008AD RID: 2221
		internal byte[] m_data;
	}
}
