using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace System.Security.Cryptography
{
	// Token: 0x020000D8 RID: 216
	internal class DerSequenceReader
	{
		// Token: 0x170000E0 RID: 224
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00025498 File Offset: 0x00023698
		private int ContentLength
		{
			[CompilerGenerated]
			set
			{
				this.<ContentLength>k__BackingField = value;
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x000254A1 File Offset: 0x000236A1
		internal DerSequenceReader(byte[] data) : this(data, 0, data.Length)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000254AE File Offset: 0x000236AE
		internal DerSequenceReader(byte[] data, int offset, int length) : this(DerSequenceReader.DerTag.Sequence, data, offset, length)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000254BC File Offset: 0x000236BC
		private DerSequenceReader(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length)
		{
			if (offset < 0 || length < 2 || length > data.Length - offset)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			this._data = data;
			this._end = offset + length;
			this._position = offset;
			this.EatTag(tagToEat);
			int num = this.EatLength();
			this.ContentLength = num;
			this._end = this._position + num;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00025527 File Offset: 0x00023727
		internal bool HasData
		{
			get
			{
				return this._position < this._end;
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00025537 File Offset: 0x00023737
		internal byte PeekTag()
		{
			if (!this.HasData)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			byte b = this._data[this._position];
			if ((b & 31) == 31)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			return b;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0002556C File Offset: 0x0002376C
		internal void SkipValue()
		{
			this.EatTag((DerSequenceReader.DerTag)this.PeekTag());
			int num = this.EatLength();
			this._position += num;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0002559C File Offset: 0x0002379C
		internal byte[] ReadNextEncodedValue()
		{
			this.PeekTag();
			int num2;
			int num = DerSequenceReader.ScanContentLength(this._data, this._position + 1, this._end, out num2);
			int num3 = 1 + num2 + num;
			byte[] array = new byte[num3];
			Buffer.BlockCopy(this._data, this._position, array, 0, num3);
			this._position += num3;
			return array;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000255FC File Offset: 0x000237FC
		internal bool ReadBoolean()
		{
			this.EatTag(DerSequenceReader.DerTag.Boolean);
			int num = this.EatLength();
			if (num != 1)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			bool result = this._data[this._position] > 0;
			this._position += num;
			return result;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00025644 File Offset: 0x00023844
		internal int ReadInteger()
		{
			byte[] array = this.ReadIntegerBytes();
			Array.Reverse<byte>(array);
			return (int)new BigInteger(array);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00025669 File Offset: 0x00023869
		internal byte[] ReadIntegerBytes()
		{
			this.EatTag(DerSequenceReader.DerTag.Integer);
			return this.ReadContentAsBytes();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00025678 File Offset: 0x00023878
		internal byte[] ReadBitString()
		{
			this.EatTag(DerSequenceReader.DerTag.BitString);
			int num = this.EatLength();
			if (num < 1)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			if (this._data[this._position] > 7)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			num--;
			this._position++;
			byte[] array = new byte[num];
			Buffer.BlockCopy(this._data, this._position, array, 0, num);
			this._position += num;
			return array;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000256F9 File Offset: 0x000238F9
		internal byte[] ReadOctetString()
		{
			this.EatTag(DerSequenceReader.DerTag.OctetString);
			return this.ReadContentAsBytes();
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00025708 File Offset: 0x00023908
		internal string ReadOidAsString()
		{
			this.EatTag(DerSequenceReader.DerTag.ObjectIdentifier);
			int num = this.EatLength();
			if (num < 1)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			StringBuilder stringBuilder = new StringBuilder(num * 4);
			byte b = this._data[this._position];
			byte value = b / 40;
			byte value2 = b % 40;
			stringBuilder.Append(value);
			stringBuilder.Append('.');
			stringBuilder.Append(value2);
			bool flag = true;
			BigInteger bigInteger = new BigInteger(0);
			for (int i = 1; i < num; i++)
			{
				byte b2 = this._data[this._position + i];
				byte b3 = b2 & 127;
				if (flag)
				{
					stringBuilder.Append('.');
					flag = false;
				}
				bigInteger <<= 7;
				bigInteger += b3;
				if (b2 == b3)
				{
					stringBuilder.Append(bigInteger);
					bigInteger = 0;
					flag = true;
				}
			}
			this._position += num;
			return stringBuilder.ToString();
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000257FC File Offset: 0x000239FC
		internal string ReadUtf8String()
		{
			this.EatTag(DerSequenceReader.DerTag.UTF8String);
			int num = this.EatLength();
			string @string = Encoding.UTF8.GetString(this._data, this._position, num);
			this._position += num;
			return DerSequenceReader.TrimTrailingNulls(@string);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00025844 File Offset: 0x00023A44
		private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected)
		{
			DerSequenceReader.CheckTag(expected, this._data, this._position);
			int num2;
			int num = DerSequenceReader.ScanContentLength(this._data, this._position + 1, this._end, out num2);
			int num3 = 1 + num2 + num;
			DerSequenceReader result = new DerSequenceReader(expected, this._data, this._position, num3);
			this._position += num3;
			return result;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000258A6 File Offset: 0x00023AA6
		internal DerSequenceReader ReadSequence()
		{
			return this.ReadCollectionWithTag(DerSequenceReader.DerTag.Sequence);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000258B0 File Offset: 0x00023AB0
		internal DerSequenceReader ReadSet()
		{
			return this.ReadCollectionWithTag(DerSequenceReader.DerTag.Set);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000258BC File Offset: 0x00023ABC
		internal string ReadPrintableString()
		{
			this.EatTag(DerSequenceReader.DerTag.PrintableString);
			int num = this.EatLength();
			string @string = Encoding.ASCII.GetString(this._data, this._position, num);
			this._position += num;
			return DerSequenceReader.TrimTrailingNulls(@string);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00025904 File Offset: 0x00023B04
		internal string ReadIA5String()
		{
			this.EatTag(DerSequenceReader.DerTag.IA5String);
			int num = this.EatLength();
			string @string = Encoding.ASCII.GetString(this._data, this._position, num);
			this._position += num;
			return DerSequenceReader.TrimTrailingNulls(@string);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002594C File Offset: 0x00023B4C
		internal string ReadT61String()
		{
			this.EatTag(DerSequenceReader.DerTag.T61String);
			int num = this.EatLength();
			Encoding encoding = LazyInitializer.EnsureInitialized<Encoding>(ref DerSequenceReader.s_utf8EncodingWithExceptionFallback, () => new UTF8Encoding(false, true));
			Encoding encoding2 = LazyInitializer.EnsureInitialized<Encoding>(ref DerSequenceReader.s_latin1Encoding, () => Encoding.GetEncoding("iso-8859-1"));
			string @string;
			try
			{
				@string = encoding.GetString(this._data, this._position, num);
			}
			catch (DecoderFallbackException)
			{
				@string = encoding2.GetString(this._data, this._position, num);
			}
			this._position += num;
			return DerSequenceReader.TrimTrailingNulls(@string);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00025A10 File Offset: 0x00023C10
		internal DateTime ReadX509Date()
		{
			DerSequenceReader.DerTag derTag = (DerSequenceReader.DerTag)this.PeekTag();
			if (derTag == DerSequenceReader.DerTag.UTCTime)
			{
				return this.ReadUtcTime();
			}
			if (derTag != DerSequenceReader.DerTag.GeneralizedTime)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			return this.ReadGeneralizedTime();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00025A48 File Offset: 0x00023C48
		internal DateTime ReadUtcTime()
		{
			return this.ReadTime(DerSequenceReader.DerTag.UTCTime, "yyMMddHHmmss'Z'");
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00025A57 File Offset: 0x00023C57
		internal DateTime ReadGeneralizedTime()
		{
			return this.ReadTime(DerSequenceReader.DerTag.GeneralizedTime, "yyyyMMddHHmmss'Z'");
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00025A68 File Offset: 0x00023C68
		internal string ReadBMPString()
		{
			this.EatTag(DerSequenceReader.DerTag.BMPString);
			int num = this.EatLength();
			string @string = Encoding.BigEndianUnicode.GetString(this._data, this._position, num);
			this._position += num;
			return DerSequenceReader.TrimTrailingNulls(@string);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00025AB0 File Offset: 0x00023CB0
		private static string TrimTrailingNulls(string value)
		{
			if (value != null && value.Length > 0)
			{
				int num = value.Length;
				while (num > 0 && value[num - 1] == '\0')
				{
					num--;
				}
				if (num != value.Length)
				{
					return value.Substring(0, num);
				}
			}
			return value;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00025AF8 File Offset: 0x00023CF8
		private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString)
		{
			this.EatTag(timeTag);
			int num = this.EatLength();
			string @string = Encoding.ASCII.GetString(this._data, this._position, num);
			this._position += num;
			DateTimeFormatInfo provider = LazyInitializer.EnsureInitialized<DateTimeFormatInfo>(ref DerSequenceReader.s_validityDateTimeFormatInfo, delegate()
			{
				DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)CultureInfo.InvariantCulture.DateTimeFormat.Clone();
				dateTimeFormatInfo.Calendar.TwoDigitYearMax = 2049;
				return dateTimeFormatInfo;
			});
			DateTime result;
			if (!DateTime.TryParseExact(@string, formatString, provider, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out result))
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			return result;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00025B7C File Offset: 0x00023D7C
		private byte[] ReadContentAsBytes()
		{
			int num = this.EatLength();
			byte[] array = new byte[num];
			Buffer.BlockCopy(this._data, this._position, array, 0, num);
			this._position += num;
			return array;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00025BBA File Offset: 0x00023DBA
		private void EatTag(DerSequenceReader.DerTag expected)
		{
			if (!this.HasData)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			DerSequenceReader.CheckTag(expected, this._data, this._position);
			this._position++;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00025BF0 File Offset: 0x00023DF0
		private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position)
		{
			if (position >= data.Length)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			byte b = data[position];
			byte b2 = b & 31;
			if (b2 == 31)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			if ((b & 128) != 0)
			{
				return;
			}
			if ((byte)(expected & (DerSequenceReader.DerTag)31) != b2)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00025C44 File Offset: 0x00023E44
		private int EatLength()
		{
			int num;
			int result = DerSequenceReader.ScanContentLength(this._data, this._position, this._end, out num);
			this._position += num;
			return result;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00025C78 File Offset: 0x00023E78
		private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed)
		{
			if (offset >= end)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			byte b = data[offset];
			if (b < 128)
			{
				bytesConsumed = 1;
				if ((int)b > end - offset - bytesConsumed)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				return (int)b;
			}
			else
			{
				int num = (int)(b & 127);
				if (num > 4)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				bytesConsumed = 1 + num;
				if (bytesConsumed > end - offset)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				if (bytesConsumed == 1)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				int num2 = offset + bytesConsumed;
				int num3 = 0;
				for (int i = offset + 1; i < num2; i++)
				{
					num3 <<= 8;
					num3 |= (int)data[i];
				}
				if (num3 < 0)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				if (num3 > end - offset - bytesConsumed)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				return num3;
			}
		}

		// Token: 0x04000419 RID: 1049
		internal static DateTimeFormatInfo s_validityDateTimeFormatInfo;

		// Token: 0x0400041A RID: 1050
		private static Encoding s_utf8EncodingWithExceptionFallback;

		// Token: 0x0400041B RID: 1051
		private static Encoding s_latin1Encoding;

		// Token: 0x0400041C RID: 1052
		private readonly byte[] _data;

		// Token: 0x0400041D RID: 1053
		private readonly int _end;

		// Token: 0x0400041E RID: 1054
		private int _position;

		// Token: 0x020000D9 RID: 217
		internal enum DerTag : byte
		{
			// Token: 0x04000421 RID: 1057
			Boolean = 1,
			// Token: 0x04000422 RID: 1058
			Integer,
			// Token: 0x04000423 RID: 1059
			BitString,
			// Token: 0x04000424 RID: 1060
			OctetString,
			// Token: 0x04000425 RID: 1061
			Null,
			// Token: 0x04000426 RID: 1062
			ObjectIdentifier,
			// Token: 0x04000427 RID: 1063
			UTF8String = 12,
			// Token: 0x04000428 RID: 1064
			Sequence = 16,
			// Token: 0x04000429 RID: 1065
			Set,
			// Token: 0x0400042A RID: 1066
			PrintableString = 19,
			// Token: 0x0400042B RID: 1067
			T61String,
			// Token: 0x0400042C RID: 1068
			IA5String = 22,
			// Token: 0x0400042D RID: 1069
			UTCTime,
			// Token: 0x0400042E RID: 1070
			GeneralizedTime,
			// Token: 0x0400042F RID: 1071
			BMPString = 30
		}
	}
}
