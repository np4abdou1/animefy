using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000EE RID: 238
	internal sealed class ObjectStorage : DataStorage
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x0004E922 File Offset: 0x0004CB22
		internal ObjectStorage(DataColumn column, Type type) : base(column, type, ObjectStorage.s_defaultValue, DBNull.Value, typeof(ICloneable).IsAssignableFrom(type), DataStorage.GetStorageType(type))
		{
			this._implementsIXmlSerializable = typeof(IXmlSerializable).IsAssignableFrom(type);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00048CFC File Offset: 0x00046EFC
		public override object Aggregate(int[] records, AggregateType kind)
		{
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0004E964 File Offset: 0x0004CB64
		public override int Compare(int recordNo1, int recordNo2)
		{
			object obj = this._values[recordNo1];
			object obj2 = this._values[recordNo2];
			if (obj == obj2)
			{
				return 0;
			}
			if (obj == null)
			{
				return -1;
			}
			if (obj2 == null)
			{
				return 1;
			}
			IComparable comparable = obj as IComparable;
			if (comparable != null)
			{
				try
				{
					return comparable.CompareTo(obj2);
				}
				catch (ArgumentException e)
				{
					ExceptionBuilder.TraceExceptionWithoutRethrow(e);
				}
			}
			return this.CompareWithFamilies(obj, obj2);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0004E9CC File Offset: 0x0004CBCC
		public override int CompareValueTo(int recordNo1, object value)
		{
			object obj = this.Get(recordNo1);
			if (obj is IComparable && value.GetType() == obj.GetType())
			{
				return ((IComparable)obj).CompareTo(value);
			}
			if (obj == value)
			{
				return 0;
			}
			if (obj == null)
			{
				if (this._nullValue == value)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (this._nullValue == value || value == null)
				{
					return 1;
				}
				return this.CompareWithFamilies(obj, value);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0004EA38 File Offset: 0x0004CC38
		private int CompareTo(object valueNo1, object valueNo2)
		{
			if (valueNo1 == null)
			{
				return -1;
			}
			if (valueNo2 == null)
			{
				return 1;
			}
			if (valueNo1 == valueNo2)
			{
				return 0;
			}
			if (valueNo1 == this._nullValue)
			{
				return -1;
			}
			if (valueNo2 == this._nullValue)
			{
				return 1;
			}
			if (valueNo1 is IComparable)
			{
				try
				{
					return ((IComparable)valueNo1).CompareTo(valueNo2);
				}
				catch (ArgumentException e)
				{
					ExceptionBuilder.TraceExceptionWithoutRethrow(e);
				}
			}
			return this.CompareWithFamilies(valueNo1, valueNo2);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0004EAA4 File Offset: 0x0004CCA4
		private int CompareWithFamilies(object valueNo1, object valueNo2)
		{
			ObjectStorage.Families family = this.GetFamily(valueNo1.GetType());
			ObjectStorage.Families family2 = this.GetFamily(valueNo2.GetType());
			if (family < family2)
			{
				return -1;
			}
			if (family > family2)
			{
				return 1;
			}
			switch (family)
			{
			case ObjectStorage.Families.DATETIME:
				valueNo1 = Convert.ToDateTime(valueNo1, base.FormatProvider);
				valueNo2 = Convert.ToDateTime(valueNo1, base.FormatProvider);
				goto IL_137;
			case ObjectStorage.Families.NUMBER:
				valueNo1 = Convert.ToDouble(valueNo1, base.FormatProvider);
				valueNo2 = Convert.ToDouble(valueNo2, base.FormatProvider);
				goto IL_137;
			case ObjectStorage.Families.BOOLEAN:
				valueNo1 = Convert.ToBoolean(valueNo1, base.FormatProvider);
				valueNo2 = Convert.ToBoolean(valueNo2, base.FormatProvider);
				goto IL_137;
			case ObjectStorage.Families.ARRAY:
			{
				Array array = (Array)valueNo1;
				Array array2 = (Array)valueNo2;
				if (array.Length > array2.Length)
				{
					return 1;
				}
				if (array.Length < array2.Length)
				{
					return -1;
				}
				for (int i = 0; i < array.Length; i++)
				{
					int num = this.CompareTo(array.GetValue(i), array2.GetValue(i));
					if (num != 0)
					{
						return num;
					}
				}
				return 0;
			}
			}
			valueNo1 = valueNo1.ToString();
			valueNo2 = valueNo2.ToString();
			IL_137:
			return ((IComparable)valueNo1).CompareTo(valueNo2);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0004EBF4 File Offset: 0x0004CDF4
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0004EC08 File Offset: 0x0004CE08
		public override object Get(int recordNo)
		{
			object obj = this._values[recordNo];
			if (obj != null)
			{
				return obj;
			}
			return this._nullValue;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004EC2C File Offset: 0x0004CE2C
		private ObjectStorage.Families GetFamily(Type dataType)
		{
			switch (Type.GetTypeCode(dataType))
			{
			case TypeCode.Boolean:
				return ObjectStorage.Families.BOOLEAN;
			case TypeCode.Char:
				return ObjectStorage.Families.STRING;
			case TypeCode.SByte:
				return ObjectStorage.Families.STRING;
			case TypeCode.Byte:
				return ObjectStorage.Families.STRING;
			case TypeCode.Int16:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.UInt16:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.Int32:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.UInt32:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.Int64:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.UInt64:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.Single:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.Double:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.Decimal:
				return ObjectStorage.Families.NUMBER;
			case TypeCode.DateTime:
				return ObjectStorage.Families.DATETIME;
			case TypeCode.String:
				return ObjectStorage.Families.STRING;
			}
			if (typeof(TimeSpan) == dataType)
			{
				return ObjectStorage.Families.DATETIME;
			}
			if (dataType.IsArray)
			{
				return ObjectStorage.Families.ARRAY;
			}
			return ObjectStorage.Families.STRING;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0004ECC7 File Offset: 0x0004CEC7
		public override bool IsNull(int record)
		{
			return this._values[record] == null;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0004ECD4 File Offset: 0x0004CED4
		public override void Set(int recordNo, object value)
		{
			if (this._nullValue == value)
			{
				this._values[recordNo] = null;
				return;
			}
			if (this._dataType == typeof(object) || this._dataType.IsInstanceOfType(value))
			{
				this._values[recordNo] = value;
				return;
			}
			Type type = value.GetType();
			if (this._dataType == typeof(Guid) && type == typeof(string))
			{
				this._values[recordNo] = new Guid((string)value);
				return;
			}
			if (!(this._dataType == typeof(byte[])))
			{
				throw ExceptionBuilder.StorageSetFailed();
			}
			if (type == typeof(bool))
			{
				this._values[recordNo] = BitConverter.GetBytes((bool)value);
				return;
			}
			if (type == typeof(char))
			{
				this._values[recordNo] = BitConverter.GetBytes((char)value);
				return;
			}
			if (type == typeof(short))
			{
				this._values[recordNo] = BitConverter.GetBytes((short)value);
				return;
			}
			if (type == typeof(int))
			{
				this._values[recordNo] = BitConverter.GetBytes((int)value);
				return;
			}
			if (type == typeof(long))
			{
				this._values[recordNo] = BitConverter.GetBytes((long)value);
				return;
			}
			if (type == typeof(ushort))
			{
				this._values[recordNo] = BitConverter.GetBytes((ushort)value);
				return;
			}
			if (type == typeof(uint))
			{
				this._values[recordNo] = BitConverter.GetBytes((uint)value);
				return;
			}
			if (type == typeof(ulong))
			{
				this._values[recordNo] = BitConverter.GetBytes((ulong)value);
				return;
			}
			if (type == typeof(float))
			{
				this._values[recordNo] = BitConverter.GetBytes((float)value);
				return;
			}
			if (type == typeof(double))
			{
				this._values[recordNo] = BitConverter.GetBytes((double)value);
				return;
			}
			throw ExceptionBuilder.StorageSetFailed();
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0004EF10 File Offset: 0x0004D110
		public override void SetCapacity(int capacity)
		{
			object[] array = new object[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0004EF50 File Offset: 0x0004D150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ConvertXmlToObject(string s)
		{
			Type dataType = this._dataType;
			if (dataType == typeof(byte[]))
			{
				return Convert.FromBase64String(s);
			}
			if (dataType == typeof(Type))
			{
				return Type.GetType(s);
			}
			if (dataType == typeof(Guid))
			{
				return new Guid(s);
			}
			if (dataType == typeof(Uri))
			{
				return new Uri(s);
			}
			if (this._implementsIXmlSerializable)
			{
				object obj = Activator.CreateInstance(this._dataType, true);
				using (XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(s)))
				{
					((IXmlSerializable)obj).ReadXml(xmlTextReader);
				}
				return obj;
			}
			StringReader textReader = new StringReader(s);
			return ObjectStorage.GetXmlSerializer(dataType).Deserialize(textReader);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0004F02C File Offset: 0x0004D22C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			bool flag = false;
			bool flag2 = false;
			object obj;
			if (xmlAttrib == null)
			{
				Type type = null;
				string attribute = xmlReader.GetAttribute("InstanceType", "urn:schemas-microsoft-com:xml-msdata");
				if (attribute == null || attribute.Length == 0)
				{
					string text = xmlReader.GetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance");
					if (text != null && text.Length > 0)
					{
						string[] array = text.Split(':', StringSplitOptions.None);
						if (array.Length == 2 && xmlReader.LookupNamespace(array[0]) == "http://www.w3.org/2001/XMLSchema")
						{
							text = array[1];
						}
						type = XSDSchema.XsdtoClr(text);
						flag = true;
					}
					else if (this._dataType == typeof(object))
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					obj = xmlReader.ReadString();
				}
				else if (attribute == "Type")
				{
					obj = Type.GetType(xmlReader.ReadString());
					xmlReader.Read();
				}
				else
				{
					if (null == type)
					{
						type = ((attribute == null) ? this._dataType : DataStorage.GetType(attribute));
					}
					if (type == typeof(char) || type == typeof(Guid))
					{
						flag = true;
					}
					if (type == typeof(object))
					{
						throw ExceptionBuilder.CanNotDeserializeObjectType();
					}
					if (!flag)
					{
						obj = Activator.CreateInstance(type, true);
						((IXmlSerializable)obj).ReadXml(xmlReader);
					}
					else
					{
						if (type == typeof(string) && xmlReader.NodeType == XmlNodeType.Element && xmlReader.IsEmptyElement)
						{
							obj = string.Empty;
						}
						else
						{
							obj = xmlReader.ReadString();
							if (type != typeof(byte[]))
							{
								obj = SqlConvert.ChangeTypeForXML(obj, type);
							}
							else
							{
								obj = Convert.FromBase64String(obj.ToString());
							}
						}
						xmlReader.Read();
					}
				}
			}
			else
			{
				obj = ObjectStorage.GetXmlSerializer(this._dataType, xmlAttrib).Deserialize(xmlReader);
			}
			return obj;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0004F1FC File Offset: 0x0004D3FC
		public override string ConvertObjectToXml(object value)
		{
			if (value == null || value == this._nullValue)
			{
				return string.Empty;
			}
			Type dataType = this._dataType;
			if (dataType == typeof(byte[]) || (dataType == typeof(object) && value is byte[]))
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (dataType == typeof(Type) || (dataType == typeof(object) && value is Type))
			{
				return ((Type)value).AssemblyQualifiedName;
			}
			if (!DataStorage.IsTypeCustomType(value.GetType()))
			{
				return (string)SqlConvert.ChangeTypeForXML(value, typeof(string));
			}
			if (Type.GetTypeCode(value.GetType()) != TypeCode.Object)
			{
				return value.ToString();
			}
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			if (this._implementsIXmlSerializable)
			{
				using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
				{
					((IXmlSerializable)value).WriteXml(xmlTextWriter);
				}
				return stringWriter.ToString();
			}
			ObjectStorage.GetXmlSerializer(value.GetType()).Serialize(stringWriter, value);
			return stringWriter.ToString();
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0004F32C File Offset: 0x0004D52C
		public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
			if (xmlAttrib == null)
			{
				((IXmlSerializable)value).WriteXml(xmlWriter);
				return;
			}
			ObjectStorage.GetXmlSerializer(value.GetType(), xmlAttrib).Serialize(xmlWriter, value);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0004F351 File Offset: 0x0004D551
		protected override object GetEmptyStorage(int recordCount)
		{
			return new object[recordCount];
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0004F35C File Offset: 0x0004D55C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			object[] array = (object[])store;
			array[storeIndex] = this._values[record];
			bool flag = this.IsNull(record);
			nullbits.Set(storeIndex, flag);
			if (!flag && array[storeIndex] is DateTime)
			{
				DateTime dateTime = (DateTime)array[storeIndex];
				if (dateTime.Kind == DateTimeKind.Local)
				{
					array[storeIndex] = DateTime.SpecifyKind(dateTime.ToUniversalTime(), DateTimeKind.Local);
				}
			}
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (object[])store;
			for (int i = 0; i < this._values.Length; i++)
			{
				if (this._values[i] is DateTime)
				{
					DateTime value = (DateTime)this._values[i];
					if (value.Kind == DateTimeKind.Local)
					{
						this._values[i] = DateTime.SpecifyKind(value, DateTimeKind.Utc).ToLocalTime();
					}
				}
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0004F437 File Offset: 0x0004D637
		internal static void VerifyIDynamicMetaObjectProvider(Type type)
		{
			if (typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type) && !typeof(IXmlSerializable).IsAssignableFrom(type))
			{
				throw ADP.InvalidOperation("DataSet will not serialize types that implement IDynamicMetaObjectProvider but do not also implement IXmlSerializable.");
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0004F468 File Offset: 0x0004D668
		internal static XmlSerializer GetXmlSerializer(Type type)
		{
			ObjectStorage.VerifyIDynamicMetaObjectProvider(type);
			return ObjectStorage.s_serializerFactory.CreateSerializer(type);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0004F47C File Offset: 0x0004D67C
		internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute)
		{
			XmlSerializer xmlSerializer = null;
			KeyValuePair<Type, XmlRootAttribute> key = new KeyValuePair<Type, XmlRootAttribute>(type, attribute);
			Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> dictionary = ObjectStorage.s_tempAssemblyCache;
			if (dictionary == null || !dictionary.TryGetValue(key, out xmlSerializer))
			{
				object obj = ObjectStorage.s_tempAssemblyCacheLock;
				lock (obj)
				{
					dictionary = ObjectStorage.s_tempAssemblyCache;
					if (dictionary == null || !dictionary.TryGetValue(key, out xmlSerializer))
					{
						ObjectStorage.VerifyIDynamicMetaObjectProvider(type);
						if (dictionary != null)
						{
							Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> dictionary2 = new Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer>(1 + dictionary.Count, ObjectStorage.TempAssemblyComparer.s_default);
							foreach (KeyValuePair<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> keyValuePair in dictionary)
							{
								dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
							}
							dictionary = dictionary2;
						}
						else
						{
							dictionary = new Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer>(ObjectStorage.TempAssemblyComparer.s_default);
						}
						key = new KeyValuePair<Type, XmlRootAttribute>(type, new XmlRootAttribute());
						key.Value.ElementName = attribute.ElementName;
						key.Value.Namespace = attribute.Namespace;
						key.Value.DataType = attribute.DataType;
						key.Value.IsNullable = attribute.IsNullable;
						xmlSerializer = ObjectStorage.s_serializerFactory.CreateSerializer(type, attribute);
						dictionary.Add(key, xmlSerializer);
						ObjectStorage.s_tempAssemblyCache = dictionary;
					}
				}
			}
			return xmlSerializer;
		}

		// Token: 0x0400050F RID: 1295
		private static readonly object s_defaultValue = null;

		// Token: 0x04000510 RID: 1296
		private object[] _values;

		// Token: 0x04000511 RID: 1297
		private readonly bool _implementsIXmlSerializable;

		// Token: 0x04000512 RID: 1298
		private static readonly object s_tempAssemblyCacheLock = new object();

		// Token: 0x04000513 RID: 1299
		private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache;

		// Token: 0x04000514 RID: 1300
		private static readonly XmlSerializerFactory s_serializerFactory = new XmlSerializerFactory();

		// Token: 0x020000EF RID: 239
		private enum Families
		{
			// Token: 0x04000516 RID: 1302
			DATETIME,
			// Token: 0x04000517 RID: 1303
			NUMBER,
			// Token: 0x04000518 RID: 1304
			STRING,
			// Token: 0x04000519 RID: 1305
			BOOLEAN,
			// Token: 0x0400051A RID: 1306
			ARRAY
		}

		// Token: 0x020000F0 RID: 240
		private class TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>>
		{
			// Token: 0x0600103C RID: 4156 RVA: 0x000020FA File Offset: 0x000002FA
			private TempAssemblyComparer()
			{
			}

			// Token: 0x0600103D RID: 4157 RVA: 0x0004F5F8 File Offset: 0x0004D7F8
			public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y)
			{
				return x.Key == y.Key && ((x.Value == null && y.Value == null) || (x.Value != null && y.Value != null && x.Value.ElementName == y.Value.ElementName && x.Value.Namespace == y.Value.Namespace && x.Value.DataType == y.Value.DataType && x.Value.IsNullable == y.Value.IsNullable));
			}

			// Token: 0x0600103E RID: 4158 RVA: 0x0004F6C4 File Offset: 0x0004D8C4
			public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj)
			{
				return obj.Key.GetHashCode() + obj.Value.ElementName.GetHashCode();
			}

			// Token: 0x0400051B RID: 1307
			internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default = new ObjectStorage.TempAssemblyComparer();
		}
	}
}
