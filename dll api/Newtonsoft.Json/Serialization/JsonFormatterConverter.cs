using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011E RID: 286
	[NullableContext(1)]
	[Nullable(0)]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x000283B1 File Offset: 0x000265B1
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, [Nullable(2)] JsonProperty member)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			ValidationUtils.ArgumentNotNull(contract, "contract");
			this._reader = reader;
			this._contract = contract;
			this._member = member;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000283E4 File Offset: 0x000265E4
		private T GetTokenValue<[Nullable(2)] T>(object value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			return (T)((object)System.Convert.ChangeType(((JValue)value).Value, typeof(T), CultureInfo.InvariantCulture));
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00028418 File Offset: 0x00026618
		public object Convert(object value, Type type)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			JToken jtoken = value as JToken;
			if (jtoken == null)
			{
				throw new ArgumentException("Value is not a JToken.", "value");
			}
			return this._reader.CreateISerializableItem(jtoken, type, this._contract, this._member);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00028464 File Offset: 0x00026664
		public object Convert(object value, TypeCode typeCode)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			JValue jvalue = value as JValue;
			return System.Convert.ChangeType((jvalue != null) ? jvalue.Value : value, typeCode, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0002849A File Offset: 0x0002669A
		public bool ToBoolean(object value)
		{
			return this.GetTokenValue<bool>(value);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000284A3 File Offset: 0x000266A3
		public byte ToByte(object value)
		{
			return this.GetTokenValue<byte>(value);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000284AC File Offset: 0x000266AC
		public char ToChar(object value)
		{
			return this.GetTokenValue<char>(value);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000284B5 File Offset: 0x000266B5
		public DateTime ToDateTime(object value)
		{
			return this.GetTokenValue<DateTime>(value);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000284BE File Offset: 0x000266BE
		public decimal ToDecimal(object value)
		{
			return this.GetTokenValue<decimal>(value);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000284C7 File Offset: 0x000266C7
		public double ToDouble(object value)
		{
			return this.GetTokenValue<double>(value);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000284D0 File Offset: 0x000266D0
		public short ToInt16(object value)
		{
			return this.GetTokenValue<short>(value);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000284D9 File Offset: 0x000266D9
		public int ToInt32(object value)
		{
			return this.GetTokenValue<int>(value);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000284E2 File Offset: 0x000266E2
		public long ToInt64(object value)
		{
			return this.GetTokenValue<long>(value);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000284EB File Offset: 0x000266EB
		public sbyte ToSByte(object value)
		{
			return this.GetTokenValue<sbyte>(value);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000284F4 File Offset: 0x000266F4
		public float ToSingle(object value)
		{
			return this.GetTokenValue<float>(value);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000284FD File Offset: 0x000266FD
		public string ToString(object value)
		{
			return this.GetTokenValue<string>(value);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00028506 File Offset: 0x00026706
		public ushort ToUInt16(object value)
		{
			return this.GetTokenValue<ushort>(value);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0002850F File Offset: 0x0002670F
		public uint ToUInt32(object value)
		{
			return this.GetTokenValue<uint>(value);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00028518 File Offset: 0x00026718
		public ulong ToUInt64(object value)
		{
			return this.GetTokenValue<ulong>(value);
		}

		// Token: 0x04000555 RID: 1365
		private readonly JsonSerializerInternalReader _reader;

		// Token: 0x04000556 RID: 1366
		private readonly JsonISerializableContract _contract;

		// Token: 0x04000557 RID: 1367
		[Nullable(2)]
		private readonly JsonProperty _member;
	}
}
