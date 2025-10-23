using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000FA RID: 250
	internal sealed class SqlGuidStorage : DataStorage
	{
		// Token: 0x060010C8 RID: 4296 RVA: 0x00052F68 File Offset: 0x00051168
		public SqlGuidStorage(DataColumn column) : base(column, typeof(SqlGuid), SqlGuid.Null, SqlGuid.Null, StorageType.SqlGuid)
		{
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00052F94 File Offset: 0x00051194
		public override object Aggregate(int[] records, AggregateType kind)
		{
			try
			{
				if (kind != AggregateType.First)
				{
					if (kind == AggregateType.Count)
					{
						int num = 0;
						for (int i = 0; i < records.Length; i++)
						{
							if (!this.IsNull(records[i]))
							{
								num++;
							}
						}
						return num;
					}
				}
				else
				{
					if (records.Length != 0)
					{
						return this._values[records[0]];
					}
					return null;
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(SqlGuid));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00053024 File Offset: 0x00051224
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00053043 File Offset: 0x00051243
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlGuid)value);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0005305C File Offset: 0x0005125C
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlGuid(value);
			}
			return this._nullValue;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00053073 File Offset: 0x00051273
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0005308D File Offset: 0x0005128D
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000530A0 File Offset: 0x000512A0
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000530B3 File Offset: 0x000512B3
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlGuid(value);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000530C8 File Offset: 0x000512C8
		public override void SetCapacity(int capacity)
		{
			SqlGuid[] array = new SqlGuid[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00053108 File Offset: 0x00051308
		public override object ConvertXmlToObject(string s)
		{
			SqlGuid sqlGuid = default(SqlGuid);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlGuid;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlGuid)xmlSerializable;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00053170 File Offset: 0x00051370
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000531C0 File Offset: 0x000513C0
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlGuid[recordCount];
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x000531C8 File Offset: 0x000513C8
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlGuid[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000531F2 File Offset: 0x000513F2
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlGuid[])store;
		}

		// Token: 0x04000524 RID: 1316
		private SqlGuid[] _values;
	}
}
