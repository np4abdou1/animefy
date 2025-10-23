using System;
using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Numerics;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000DF RID: 223
	internal abstract class DataStorage
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x0004B256 File Offset: 0x00049456
		protected DataStorage(DataColumn column, Type type, object defaultValue, StorageType storageType) : this(column, type, defaultValue, DBNull.Value, false, storageType)
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004B269 File Offset: 0x00049469
		protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) : this(column, type, defaultValue, nullValue, false, storageType)
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0004B27C File Offset: 0x0004947C
		protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType)
		{
			this._column = column;
			this._table = column.Table;
			this._dataType = type;
			this._storageTypeCode = storageType;
			this._defaultValue = defaultValue;
			this._nullValue = nullValue;
			this._isCloneable = isICloneable;
			this._isCustomDefinedType = DataStorage.IsTypeCustomType(this._storageTypeCode);
			this._isStringType = (StorageType.String == this._storageTypeCode || StorageType.SqlString == this._storageTypeCode);
			this._isValueType = DataStorage.DetermineIfValueType(this._storageTypeCode, type);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x0004B308 File Offset: 0x00049508
		internal DataSetDateTime DateTimeMode
		{
			get
			{
				return this._column.DateTimeMode;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0004B315 File Offset: 0x00049515
		internal IFormatProvider FormatProvider
		{
			get
			{
				return this._table.FormatProvider;
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0004B322 File Offset: 0x00049522
		public virtual object Aggregate(int[] recordNos, AggregateType kind)
		{
			if (AggregateType.Count == kind)
			{
				return this.AggregateCount(recordNos);
			}
			return null;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0004B334 File Offset: 0x00049534
		public object AggregateCount(int[] recordNos)
		{
			int num = 0;
			for (int i = 0; i < recordNos.Length; i++)
			{
				if (!this._dbNullBits.Get(recordNos[i]))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0004B36C File Offset: 0x0004956C
		protected int CompareBits(int recordNo1, int recordNo2)
		{
			bool flag = this._dbNullBits.Get(recordNo1);
			bool flag2 = this._dbNullBits.Get(recordNo2);
			if (!(flag ^ flag2))
			{
				return 0;
			}
			if (flag)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06000F31 RID: 3889
		public abstract int Compare(int recordNo1, int recordNo2);

		// Token: 0x06000F32 RID: 3890
		public abstract int CompareValueTo(int recordNo1, object value);

		// Token: 0x06000F33 RID: 3891 RVA: 0x0004B3A0 File Offset: 0x000495A0
		public virtual object ConvertValue(object value)
		{
			return value;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0004B3A3 File Offset: 0x000495A3
		protected void CopyBits(int srcRecordNo, int dstRecordNo)
		{
			this._dbNullBits.Set(dstRecordNo, this._dbNullBits.Get(srcRecordNo));
		}

		// Token: 0x06000F35 RID: 3893
		public abstract void Copy(int recordNo1, int recordNo2);

		// Token: 0x06000F36 RID: 3894
		public abstract object Get(int recordNo);

		// Token: 0x06000F37 RID: 3895 RVA: 0x0004B3BD File Offset: 0x000495BD
		protected object GetBits(int recordNo)
		{
			if (this._dbNullBits.Get(recordNo))
			{
				return this._nullValue;
			}
			return this._defaultValue;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0004B3DA File Offset: 0x000495DA
		public virtual int GetStringLength(int record)
		{
			return int.MaxValue;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0004B3E1 File Offset: 0x000495E1
		protected bool HasValue(int recordNo)
		{
			return !this._dbNullBits.Get(recordNo);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0004B3F2 File Offset: 0x000495F2
		public virtual bool IsNull(int recordNo)
		{
			return this._dbNullBits.Get(recordNo);
		}

		// Token: 0x06000F3B RID: 3899
		public abstract void Set(int recordNo, object value);

		// Token: 0x06000F3C RID: 3900 RVA: 0x0004B400 File Offset: 0x00049600
		protected void SetNullBit(int recordNo, bool flag)
		{
			this._dbNullBits.Set(recordNo, flag);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0004B40F File Offset: 0x0004960F
		public virtual void SetCapacity(int capacity)
		{
			if (this._dbNullBits == null)
			{
				this._dbNullBits = new BitArray(capacity);
				return;
			}
			this._dbNullBits.Length = capacity;
		}

		// Token: 0x06000F3E RID: 3902
		public abstract object ConvertXmlToObject(string s);

		// Token: 0x06000F3F RID: 3903 RVA: 0x0004B432 File Offset: 0x00049632
		public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			return this.ConvertXmlToObject(xmlReader.Value);
		}

		// Token: 0x06000F40 RID: 3904
		public abstract string ConvertObjectToXml(object value);

		// Token: 0x06000F41 RID: 3905 RVA: 0x0004B440 File Offset: 0x00049640
		public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
			xmlWriter.WriteString(this.ConvertObjectToXml(value));
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0004B450 File Offset: 0x00049650
		public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode)
		{
			if (typeCode != StorageType.Empty || !(null != dataType))
			{
				switch (typeCode)
				{
				case StorageType.Empty:
					throw ExceptionBuilder.InvalidStorageType(TypeCode.Empty);
				case StorageType.DBNull:
					throw ExceptionBuilder.InvalidStorageType(TypeCode.DBNull);
				case StorageType.Boolean:
					return new BooleanStorage(column);
				case StorageType.Char:
					return new CharStorage(column);
				case StorageType.SByte:
					return new SByteStorage(column);
				case StorageType.Byte:
					return new ByteStorage(column);
				case StorageType.Int16:
					return new Int16Storage(column);
				case StorageType.UInt16:
					return new UInt16Storage(column);
				case StorageType.Int32:
					return new Int32Storage(column);
				case StorageType.UInt32:
					return new UInt32Storage(column);
				case StorageType.Int64:
					return new Int64Storage(column);
				case StorageType.UInt64:
					return new UInt64Storage(column);
				case StorageType.Single:
					return new SingleStorage(column);
				case StorageType.Double:
					return new DoubleStorage(column);
				case StorageType.Decimal:
					return new DecimalStorage(column);
				case StorageType.DateTime:
					return new DateTimeStorage(column);
				case StorageType.TimeSpan:
					return new TimeSpanStorage(column);
				case StorageType.String:
					return new StringStorage(column);
				case StorageType.Guid:
					return new ObjectStorage(column, dataType);
				case StorageType.ByteArray:
					return new ObjectStorage(column, dataType);
				case StorageType.CharArray:
					return new ObjectStorage(column, dataType);
				case StorageType.Type:
					return new ObjectStorage(column, dataType);
				case StorageType.DateTimeOffset:
					return new DateTimeOffsetStorage(column);
				case StorageType.BigInteger:
					return new BigIntegerStorage(column);
				case StorageType.Uri:
					return new ObjectStorage(column, dataType);
				case StorageType.SqlBinary:
					return new SqlBinaryStorage(column);
				case StorageType.SqlBoolean:
					return new SqlBooleanStorage(column);
				case StorageType.SqlByte:
					return new SqlByteStorage(column);
				case StorageType.SqlBytes:
					return new SqlBytesStorage(column);
				case StorageType.SqlChars:
					return new SqlCharsStorage(column);
				case StorageType.SqlDateTime:
					return new SqlDateTimeStorage(column);
				case StorageType.SqlDecimal:
					return new SqlDecimalStorage(column);
				case StorageType.SqlDouble:
					return new SqlDoubleStorage(column);
				case StorageType.SqlGuid:
					return new SqlGuidStorage(column);
				case StorageType.SqlInt16:
					return new SqlInt16Storage(column);
				case StorageType.SqlInt32:
					return new SqlInt32Storage(column);
				case StorageType.SqlInt64:
					return new SqlInt64Storage(column);
				case StorageType.SqlMoney:
					return new SqlMoneyStorage(column);
				case StorageType.SqlSingle:
					return new SqlSingleStorage(column);
				case StorageType.SqlString:
					return new SqlStringStorage(column);
				}
				return new ObjectStorage(column, dataType);
			}
			if (typeof(INullable).IsAssignableFrom(dataType))
			{
				return new SqlUdtStorage(column, dataType);
			}
			return new ObjectStorage(column, dataType);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0004B65C File Offset: 0x0004985C
		internal static StorageType GetStorageType(Type dataType)
		{
			for (int i = 0; i < DataStorage.s_storageClassType.Length; i++)
			{
				if (dataType == DataStorage.s_storageClassType[i])
				{
					return (StorageType)i;
				}
			}
			TypeCode typeCode = Type.GetTypeCode(dataType);
			if (TypeCode.Object != typeCode)
			{
				return (StorageType)typeCode;
			}
			return StorageType.Empty;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0004B69A File Offset: 0x0004989A
		internal static Type GetTypeStorage(StorageType storageType)
		{
			return DataStorage.s_storageClassType[(int)storageType];
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0004B6A3 File Offset: 0x000498A3
		internal static bool IsTypeCustomType(Type type)
		{
			return DataStorage.IsTypeCustomType(DataStorage.GetStorageType(type));
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0004B6B0 File Offset: 0x000498B0
		internal static bool IsTypeCustomType(StorageType typeCode)
		{
			return StorageType.Object == typeCode || typeCode == StorageType.Empty || StorageType.CharArray == typeCode;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0004B6C0 File Offset: 0x000498C0
		internal static bool IsSqlType(StorageType storageType)
		{
			return StorageType.SqlBinary <= storageType;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0004B6CC File Offset: 0x000498CC
		public static bool IsSqlType(Type dataType)
		{
			for (int i = 26; i < DataStorage.s_storageClassType.Length; i++)
			{
				if (dataType == DataStorage.s_storageClassType[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0004B700 File Offset: 0x00049900
		private static bool DetermineIfValueType(StorageType typeCode, Type dataType)
		{
			bool result;
			switch (typeCode)
			{
			case StorageType.Boolean:
			case StorageType.Char:
			case StorageType.SByte:
			case StorageType.Byte:
			case StorageType.Int16:
			case StorageType.UInt16:
			case StorageType.Int32:
			case StorageType.UInt32:
			case StorageType.Int64:
			case StorageType.UInt64:
			case StorageType.Single:
			case StorageType.Double:
			case StorageType.Decimal:
			case StorageType.DateTime:
			case StorageType.TimeSpan:
			case StorageType.Guid:
			case StorageType.DateTimeOffset:
			case StorageType.BigInteger:
			case StorageType.SqlBinary:
			case StorageType.SqlBoolean:
			case StorageType.SqlByte:
			case StorageType.SqlDateTime:
			case StorageType.SqlDecimal:
			case StorageType.SqlDouble:
			case StorageType.SqlGuid:
			case StorageType.SqlInt16:
			case StorageType.SqlInt32:
			case StorageType.SqlInt64:
			case StorageType.SqlMoney:
			case StorageType.SqlSingle:
			case StorageType.SqlString:
				result = true;
				break;
			case StorageType.String:
			case StorageType.ByteArray:
			case StorageType.CharArray:
			case StorageType.Type:
			case StorageType.Uri:
			case StorageType.SqlBytes:
			case StorageType.SqlChars:
				result = false;
				break;
			default:
				result = dataType.IsValueType;
				break;
			}
			return result;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0004B7C0 File Offset: 0x000499C0
		internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking)
		{
			if (DataStorage.IsSqlType(typeCode))
			{
				sqlType = true;
				nullable = true;
				changeTracking = false;
				revertibleChangeTracking = false;
				xmlSerializable = true;
				return;
			}
			if (typeCode != StorageType.Empty)
			{
				sqlType = false;
				nullable = false;
				changeTracking = false;
				revertibleChangeTracking = false;
				xmlSerializable = false;
				return;
			}
			Tuple<bool, bool, bool, bool> orAdd = DataStorage.s_typeImplementsInterface.GetOrAdd(dataType, DataStorage.s_inspectTypeForInterfaces);
			sqlType = false;
			nullable = orAdd.Item1;
			changeTracking = orAdd.Item2;
			revertibleChangeTracking = orAdd.Item3;
			xmlSerializable = orAdd.Item4;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0004B838 File Offset: 0x00049A38
		private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType)
		{
			return new Tuple<bool, bool, bool, bool>(typeof(INullable).IsAssignableFrom(dataType), typeof(IChangeTracking).IsAssignableFrom(dataType), typeof(IRevertibleChangeTracking).IsAssignableFrom(dataType), typeof(IXmlSerializable).IsAssignableFrom(dataType));
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0004B88A File Offset: 0x00049A8A
		internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType)
		{
			return typeCode == StorageType.Empty && dataType.IsGenericType && dataType.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0004B8AE File Offset: 0x00049AAE
		public static bool IsObjectNull(object value)
		{
			return value == null || DBNull.Value == value || DataStorage.IsObjectSqlNull(value);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0004B8C4 File Offset: 0x00049AC4
		public static bool IsObjectSqlNull(object value)
		{
			INullable nullable = value as INullable;
			return nullable != null && nullable.IsNull;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0004B8E3 File Offset: 0x00049AE3
		internal object GetEmptyStorageInternal(int recordCount)
		{
			return this.GetEmptyStorage(recordCount);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0004B8EC File Offset: 0x00049AEC
		internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex)
		{
			this.CopyValue(record, store, nullbits, storeIndex);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0004B8F9 File Offset: 0x00049AF9
		internal void SetStorageInternal(object store, BitArray nullbits)
		{
			this.SetStorage(store, nullbits);
		}

		// Token: 0x06000F52 RID: 3922
		protected abstract object GetEmptyStorage(int recordCount);

		// Token: 0x06000F53 RID: 3923
		protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

		// Token: 0x06000F54 RID: 3924
		protected abstract void SetStorage(object store, BitArray nullbits);

		// Token: 0x06000F55 RID: 3925 RVA: 0x0004B903 File Offset: 0x00049B03
		protected void SetNullStorage(BitArray nullbits)
		{
			this._dbNullBits = nullbits;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004B90C File Offset: 0x00049B0C
		internal static Type GetType(string value)
		{
			Type type = Type.GetType(value);
			if (null == type && "System.Numerics.BigInteger" == value)
			{
				type = typeof(BigInteger);
			}
			ObjectStorage.VerifyIDynamicMetaObjectProvider(type);
			return type;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0004B948 File Offset: 0x00049B48
		internal static string GetQualifiedName(Type type)
		{
			ObjectStorage.VerifyIDynamicMetaObjectProvider(type);
			return type.AssemblyQualifiedName;
		}

		// Token: 0x040004EA RID: 1258
		private static readonly Type[] s_storageClassType = new Type[]
		{
			null,
			typeof(object),
			typeof(DBNull),
			typeof(bool),
			typeof(char),
			typeof(sbyte),
			typeof(byte),
			typeof(short),
			typeof(ushort),
			typeof(int),
			typeof(uint),
			typeof(long),
			typeof(ulong),
			typeof(float),
			typeof(double),
			typeof(decimal),
			typeof(DateTime),
			typeof(TimeSpan),
			typeof(string),
			typeof(Guid),
			typeof(byte[]),
			typeof(char[]),
			typeof(Type),
			typeof(DateTimeOffset),
			typeof(BigInteger),
			typeof(Uri),
			typeof(SqlBinary),
			typeof(SqlBoolean),
			typeof(SqlByte),
			typeof(SqlBytes),
			typeof(SqlChars),
			typeof(SqlDateTime),
			typeof(SqlDecimal),
			typeof(SqlDouble),
			typeof(SqlGuid),
			typeof(SqlInt16),
			typeof(SqlInt32),
			typeof(SqlInt64),
			typeof(SqlMoney),
			typeof(SqlSingle),
			typeof(SqlString)
		};

		// Token: 0x040004EB RID: 1259
		internal readonly DataColumn _column;

		// Token: 0x040004EC RID: 1260
		internal readonly DataTable _table;

		// Token: 0x040004ED RID: 1261
		internal readonly Type _dataType;

		// Token: 0x040004EE RID: 1262
		internal readonly StorageType _storageTypeCode;

		// Token: 0x040004EF RID: 1263
		private BitArray _dbNullBits;

		// Token: 0x040004F0 RID: 1264
		private readonly object _defaultValue;

		// Token: 0x040004F1 RID: 1265
		internal readonly object _nullValue;

		// Token: 0x040004F2 RID: 1266
		internal readonly bool _isCloneable;

		// Token: 0x040004F3 RID: 1267
		internal readonly bool _isCustomDefinedType;

		// Token: 0x040004F4 RID: 1268
		internal readonly bool _isStringType;

		// Token: 0x040004F5 RID: 1269
		internal readonly bool _isValueType;

		// Token: 0x040004F6 RID: 1270
		private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces = new Func<Type, Tuple<bool, bool, bool, bool>>(DataStorage.InspectTypeForInterfaces);

		// Token: 0x040004F7 RID: 1271
		private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface = new ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>>();
	}
}
