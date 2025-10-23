using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Data.SqlTypes;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x02000105 RID: 261
	internal sealed class SqlUdtStorage : DataStorage
	{
		// Token: 0x06001152 RID: 4434 RVA: 0x00055F33 File Offset: 0x00054133
		public SqlUdtStorage(DataColumn column, Type type) : this(column, type, SqlUdtStorage.GetStaticNullForUdtType(type))
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00055F44 File Offset: 0x00054144
		private SqlUdtStorage(DataColumn column, Type type, object nullValue) : base(column, type, nullValue, nullValue, typeof(ICloneable).IsAssignableFrom(type), DataStorage.GetStorageType(type))
		{
			this._implementsIXmlSerializable = typeof(IXmlSerializable).IsAssignableFrom(type);
			this._implementsIComparable = typeof(IComparable).IsAssignableFrom(type);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00055FA0 File Offset: 0x000541A0
		internal static object GetStaticNullForUdtType(Type type)
		{
			return SqlUdtStorage.s_typeToNull.GetOrAdd(type, delegate(Type t)
			{
				PropertyInfo property = type.GetProperty("Null", BindingFlags.Static | BindingFlags.Public);
				if (property != null)
				{
					return property.GetValue(null, null);
				}
				FieldInfo field = type.GetField("Null", BindingFlags.Static | BindingFlags.Public);
				if (field != null)
				{
					return field.GetValue(null);
				}
				throw ExceptionBuilder.INullableUDTwithoutStaticNull(type.AssemblyQualifiedName);
			});
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00055FD6 File Offset: 0x000541D6
		public override bool IsNull(int record)
		{
			return ((INullable)this._values[record]).IsNull;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00048CFC File Offset: 0x00046EFC
		public override object Aggregate(int[] records, AggregateType kind)
		{
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00055FEA File Offset: 0x000541EA
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this.CompareValueTo(recordNo1, this._values[recordNo2]);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00055FFC File Offset: 0x000541FC
		public override int CompareValueTo(int recordNo1, object value)
		{
			if (DBNull.Value == value)
			{
				value = this._nullValue;
			}
			if (this._implementsIComparable)
			{
				return ((IComparable)this._values[recordNo1]).CompareTo(value);
			}
			if (this._nullValue != value)
			{
				throw ExceptionBuilder.IComparableNotImplemented(this._dataType.AssemblyQualifiedName);
			}
			if (!((INullable)this._values[recordNo1]).IsNull)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00056066 File Offset: 0x00054266
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00056080 File Offset: 0x00054280
		public override object Get(int recordNo)
		{
			return this._values[recordNo];
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0005608C File Offset: 0x0005428C
		public override void Set(int recordNo, object value)
		{
			if (DBNull.Value == value)
			{
				this._values[recordNo] = this._nullValue;
				base.SetNullBit(recordNo, true);
				return;
			}
			if (value == null)
			{
				if (this._isValueType)
				{
					throw ExceptionBuilder.StorageSetFailed();
				}
				this._values[recordNo] = this._nullValue;
				base.SetNullBit(recordNo, true);
				return;
			}
			else
			{
				if (!this._dataType.IsInstanceOfType(value))
				{
					throw ExceptionBuilder.StorageSetFailed();
				}
				this._values[recordNo] = value;
				base.SetNullBit(recordNo, false);
				return;
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00056108 File Offset: 0x00054308
		public override void SetCapacity(int capacity)
		{
			object[] array = new object[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00056150 File Offset: 0x00054350
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ConvertXmlToObject(string s)
		{
			if (this._implementsIXmlSerializable)
			{
				object obj = Activator.CreateInstance(this._dataType, true);
				using (XmlTextReader xmlTextReader = new XmlTextReader(new StringReader("<col>" + s + "</col>")))
				{
					((IXmlSerializable)obj).ReadXml(xmlTextReader);
				}
				return obj;
			}
			StringReader textReader = new StringReader(s);
			return ObjectStorage.GetXmlSerializer(this._dataType).Deserialize(textReader);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000561D0 File Offset: 0x000543D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			if (xmlAttrib == null)
			{
				string text = xmlReader.GetAttribute("InstanceType", "urn:schemas-microsoft-com:xml-msdata");
				if (text == null)
				{
					string attribute = xmlReader.GetAttribute("InstanceType", "http://www.w3.org/2001/XMLSchema-instance");
					if (attribute != null)
					{
						text = XSDSchema.XsdtoClr(attribute).FullName;
					}
				}
				object obj = Activator.CreateInstance((text == null) ? this._dataType : Type.GetType(text), true);
				((IXmlSerializable)obj).ReadXml(xmlReader);
				return obj;
			}
			return ObjectStorage.GetXmlSerializer(this._dataType, xmlAttrib).Deserialize(xmlReader);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0005624C File Offset: 0x0005444C
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			if (this._implementsIXmlSerializable)
			{
				using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
				{
					((IXmlSerializable)value).WriteXml(xmlTextWriter);
					goto IL_45;
				}
			}
			ObjectStorage.GetXmlSerializer(value.GetType()).Serialize(stringWriter, value);
			IL_45:
			return stringWriter.ToString();
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000562B4 File Offset: 0x000544B4
		public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
			if (xmlAttrib == null)
			{
				((IXmlSerializable)value).WriteXml(xmlWriter);
				return;
			}
			ObjectStorage.GetXmlSerializer(this._dataType, xmlAttrib).Serialize(xmlWriter, value);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0004F351 File Offset: 0x0004D551
		protected override object GetEmptyStorage(int recordCount)
		{
			return new object[recordCount];
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x000562D9 File Offset: 0x000544D9
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((object[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x000562FB File Offset: 0x000544FB
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (object[])store;
		}

		// Token: 0x0400054C RID: 1356
		private object[] _values;

		// Token: 0x0400054D RID: 1357
		private readonly bool _implementsIXmlSerializable;

		// Token: 0x0400054E RID: 1358
		private readonly bool _implementsIComparable;

		// Token: 0x0400054F RID: 1359
		private static readonly ConcurrentDictionary<Type, object> s_typeToNull = new ConcurrentDictionary<Type, object>();
	}
}
