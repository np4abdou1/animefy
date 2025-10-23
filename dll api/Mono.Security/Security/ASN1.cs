using System;
using System.Collections;
using System.Text;

namespace Mono.Security
{
	// Token: 0x02000003 RID: 3
	public class ASN1
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
		public ASN1(byte tag) : this(tag, null)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		public ASN1(byte tag, byte[] data)
		{
			this.m_nTag = tag;
			this.m_aValue = data;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000207C File Offset: 0x0000027C
		public ASN1(byte[] data)
		{
			this.m_nTag = data[0];
			int num = 0;
			int num2 = (int)data[1];
			if (num2 > 128)
			{
				num = num2 - 128;
				num2 = 0;
				for (int i = 0; i < num; i++)
				{
					num2 *= 256;
					num2 += (int)data[i + 2];
				}
			}
			else if (num2 == 128)
			{
				throw new NotSupportedException("Undefined length encoding.");
			}
			this.m_aValue = new byte[num2];
			Buffer.BlockCopy(data, 2 + num, this.m_aValue, 0, num2);
			if ((this.m_nTag & 32) == 32)
			{
				int num3 = 0;
				this.Decode(this.m_aValue, ref num3, this.m_aValue.Length);
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002123 File Offset: 0x00000323
		public int Count
		{
			get
			{
				if (this.elist == null)
				{
					return 0;
				}
				return this.elist.Count;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000213A File Offset: 0x0000033A
		public byte Tag
		{
			get
			{
				return this.m_nTag;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002142 File Offset: 0x00000342
		public int Length
		{
			get
			{
				if (this.m_aValue != null)
				{
					return this.m_aValue.Length;
				}
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002177 File Offset: 0x00000377
		public byte[] Value
		{
			get
			{
				if (this.m_aValue == null)
				{
					this.GetBytes();
				}
				return (byte[])this.m_aValue.Clone();
			}
			set
			{
				if (value != null)
				{
					this.m_aValue = (byte[])value.Clone();
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002190 File Offset: 0x00000390
		private bool CompareArray(byte[] array1, byte[] array2)
		{
			bool flag = array1.Length == array2.Length;
			if (flag)
			{
				for (int i = 0; i < array1.Length; i++)
				{
					if (array1[i] != array2[i])
					{
						return false;
					}
				}
			}
			return flag;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021C2 File Offset: 0x000003C2
		public bool CompareValue(byte[] value)
		{
			return this.CompareArray(this.m_aValue, value);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021D1 File Offset: 0x000003D1
		public ASN1 Add(ASN1 asn1)
		{
			if (asn1 != null)
			{
				if (this.elist == null)
				{
					this.elist = new ArrayList();
				}
				this.elist.Add(asn1);
			}
			return asn1;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021F8 File Offset: 0x000003F8
		public virtual byte[] GetBytes()
		{
			byte[] array = null;
			if (this.Count > 0)
			{
				int num = 0;
				ArrayList arrayList = new ArrayList();
				foreach (object obj in this.elist)
				{
					byte[] bytes = ((ASN1)obj).GetBytes();
					arrayList.Add(bytes);
					num += bytes.Length;
				}
				array = new byte[num];
				int num2 = 0;
				for (int i = 0; i < this.elist.Count; i++)
				{
					byte[] array2 = (byte[])arrayList[i];
					Buffer.BlockCopy(array2, 0, array, num2, array2.Length);
					num2 += array2.Length;
				}
			}
			else if (this.m_aValue != null)
			{
				array = this.m_aValue;
			}
			int num3 = 0;
			byte[] array3;
			if (array != null)
			{
				int num4 = array.Length;
				if (num4 > 127)
				{
					if (num4 <= 255)
					{
						array3 = new byte[3 + num4];
						Buffer.BlockCopy(array, 0, array3, 3, num4);
						num3 = 129;
						array3[2] = (byte)num4;
					}
					else if (num4 <= 65535)
					{
						array3 = new byte[4 + num4];
						Buffer.BlockCopy(array, 0, array3, 4, num4);
						num3 = 130;
						array3[2] = (byte)(num4 >> 8);
						array3[3] = (byte)num4;
					}
					else if (num4 <= 16777215)
					{
						array3 = new byte[5 + num4];
						Buffer.BlockCopy(array, 0, array3, 5, num4);
						num3 = 131;
						array3[2] = (byte)(num4 >> 16);
						array3[3] = (byte)(num4 >> 8);
						array3[4] = (byte)num4;
					}
					else
					{
						array3 = new byte[6 + num4];
						Buffer.BlockCopy(array, 0, array3, 6, num4);
						num3 = 132;
						array3[2] = (byte)(num4 >> 24);
						array3[3] = (byte)(num4 >> 16);
						array3[4] = (byte)(num4 >> 8);
						array3[5] = (byte)num4;
					}
				}
				else
				{
					array3 = new byte[2 + num4];
					Buffer.BlockCopy(array, 0, array3, 2, num4);
					num3 = num4;
				}
				if (this.m_aValue == null)
				{
					this.m_aValue = array;
				}
			}
			else
			{
				array3 = new byte[2];
			}
			array3[0] = this.m_nTag;
			array3[1] = (byte)num3;
			return array3;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002414 File Offset: 0x00000614
		protected void Decode(byte[] asn1, ref int anPos, int anLength)
		{
			while (anPos < anLength - 1)
			{
				byte b;
				int num;
				byte[] data;
				this.DecodeTLV(asn1, ref anPos, out b, out num, out data);
				if (b != 0)
				{
					ASN1 asn2 = this.Add(new ASN1(b, data));
					if ((b & 32) == 32)
					{
						int num2 = anPos;
						asn2.Decode(asn1, ref num2, num2 + num);
					}
					anPos += num;
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002468 File Offset: 0x00000668
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content)
		{
			int num = pos;
			pos = num + 1;
			tag = asn1[num];
			num = pos;
			pos = num + 1;
			length = (int)asn1[num];
			if ((length & 128) == 128)
			{
				int num2 = length & 127;
				length = 0;
				for (int i = 0; i < num2; i++)
				{
					int num3 = length * 256;
					num = pos;
					pos = num + 1;
					length = num3 + (int)asn1[num];
				}
			}
			content = new byte[length];
			Buffer.BlockCopy(asn1, pos, content, 0, length);
		}

		// Token: 0x17000005 RID: 5
		public ASN1 this[int index]
		{
			get
			{
				ASN1 result;
				try
				{
					if (this.elist == null || index >= this.elist.Count)
					{
						result = null;
					}
					else
					{
						result = (ASN1)this.elist[index];
					}
				}
				catch (ArgumentOutOfRangeException)
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002540 File Offset: 0x00000740
		public ASN1 Element(int index, byte anTag)
		{
			ASN1 result;
			try
			{
				if (this.elist == null || index >= this.elist.Count)
				{
					result = null;
				}
				else
				{
					ASN1 asn = (ASN1)this.elist[index];
					if (asn.Tag == anTag)
					{
						result = asn;
					}
					else
					{
						result = null;
					}
				}
			}
			catch (ArgumentOutOfRangeException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000025A0 File Offset: 0x000007A0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Tag: {0} {1}", this.m_nTag.ToString("X2"), Environment.NewLine);
			stringBuilder.AppendFormat("Length: {0} {1}", this.Value.Length, Environment.NewLine);
			stringBuilder.Append("Value: ");
			stringBuilder.Append(Environment.NewLine);
			for (int i = 0; i < this.Value.Length; i++)
			{
				stringBuilder.AppendFormat("{0} ", this.Value[i].ToString("X2"));
				if ((i + 1) % 16 == 0)
				{
					stringBuilder.AppendFormat(Environment.NewLine, Array.Empty<object>());
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000001 RID: 1
		private byte m_nTag;

		// Token: 0x04000002 RID: 2
		private byte[] m_aValue;

		// Token: 0x04000003 RID: 3
		private ArrayList elist;
	}
}
