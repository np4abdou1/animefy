using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000122 RID: 290
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00028784 File Offset: 0x00026984
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x0002878C File Offset: 0x0002698C
		internal PrimitiveTypeCode TypeCode { get; set; }

		// Token: 0x06000864 RID: 2148 RVA: 0x00028798 File Offset: 0x00026998
		public JsonPrimitiveContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Primitive;
			this.TypeCode = ConvertUtils.GetTypeCode(underlyingType);
			this.IsReadOnlyOrFixedSize = true;
			ReadType internalReadType;
			if (JsonPrimitiveContract.ReadTypeMap.TryGetValue(this.NonNullableUnderlyingType, out internalReadType))
			{
				this.InternalReadType = internalReadType;
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000287E4 File Offset: 0x000269E4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPrimitiveContract()
		{
			Dictionary<Type, ReadType> dictionary = new Dictionary<Type, ReadType>();
			Type typeFromHandle = typeof(byte[]);
			dictionary[typeFromHandle] = ReadType.ReadAsBytes;
			Type typeFromHandle2 = typeof(byte);
			dictionary[typeFromHandle2] = ReadType.ReadAsInt32;
			Type typeFromHandle3 = typeof(short);
			dictionary[typeFromHandle3] = ReadType.ReadAsInt32;
			Type typeFromHandle4 = typeof(int);
			dictionary[typeFromHandle4] = ReadType.ReadAsInt32;
			Type typeFromHandle5 = typeof(decimal);
			dictionary[typeFromHandle5] = ReadType.ReadAsDecimal;
			Type typeFromHandle6 = typeof(bool);
			dictionary[typeFromHandle6] = ReadType.ReadAsBoolean;
			Type typeFromHandle7 = typeof(string);
			dictionary[typeFromHandle7] = ReadType.ReadAsString;
			Type typeFromHandle8 = typeof(DateTime);
			dictionary[typeFromHandle8] = ReadType.ReadAsDateTime;
			Type typeFromHandle9 = typeof(DateTimeOffset);
			dictionary[typeFromHandle9] = ReadType.ReadAsDateTimeOffset;
			Type typeFromHandle10 = typeof(float);
			dictionary[typeFromHandle10] = ReadType.ReadAsDouble;
			Type typeFromHandle11 = typeof(double);
			dictionary[typeFromHandle11] = ReadType.ReadAsDouble;
			Type typeFromHandle12 = typeof(long);
			dictionary[typeFromHandle12] = ReadType.ReadAsInt64;
			JsonPrimitiveContract.ReadTypeMap = dictionary;
		}

		// Token: 0x04000568 RID: 1384
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;
	}
}
