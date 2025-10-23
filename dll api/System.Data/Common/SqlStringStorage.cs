using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x02000100 RID: 256
	internal sealed class SqlStringStorage : DataStorage
	{
		// Token: 0x06001122 RID: 4386 RVA: 0x00055160 File Offset: 0x00053360
		public SqlStringStorage(DataColumn column) : base(column, typeof(SqlString), SqlString.Null, SqlString.Null, StorageType.SqlString)
		{
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0005518C File Offset: 0x0005338C
		public override object Aggregate(int[] recordNos, AggregateType kind)
		{
			try
			{
				switch (kind)
				{
				case AggregateType.Min:
				{
					int num = -1;
					int i;
					for (i = 0; i < recordNos.Length; i++)
					{
						if (!this.IsNull(recordNos[i]))
						{
							num = recordNos[i];
							break;
						}
					}
					if (num >= 0)
					{
						for (i++; i < recordNos.Length; i++)
						{
							if (!this.IsNull(recordNos[i]) && this.Compare(num, recordNos[i]) > 0)
							{
								num = recordNos[i];
							}
						}
						return this.Get(num);
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					int num2 = -1;
					int i;
					for (i = 0; i < recordNos.Length; i++)
					{
						if (!this.IsNull(recordNos[i]))
						{
							num2 = recordNos[i];
							break;
						}
					}
					if (num2 >= 0)
					{
						for (i++; i < recordNos.Length; i++)
						{
							if (this.Compare(num2, recordNos[i]) < 0)
							{
								num2 = recordNos[i];
							}
						}
						return this.Get(num2);
					}
					return this._nullValue;
				}
				case AggregateType.Count:
				{
					int num3 = 0;
					for (int i = 0; i < recordNos.Length; i++)
					{
						if (!this.IsNull(recordNos[i]))
						{
							num3++;
						}
					}
					return num3;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(SqlString));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000552E4 File Offset: 0x000534E4
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this.Compare(this._values[recordNo1], this._values[recordNo2]);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00055304 File Offset: 0x00053504
		public int Compare(SqlString valueNo1, SqlString valueNo2)
		{
			if (valueNo1.IsNull && valueNo2.IsNull)
			{
				return 0;
			}
			if (valueNo1.IsNull)
			{
				return -1;
			}
			if (valueNo2.IsNull)
			{
				return 1;
			}
			return this._table.Compare(valueNo1.Value, valueNo2.Value);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00055354 File Offset: 0x00053554
		public override int CompareValueTo(int recordNo, object value)
		{
			return this.Compare(this._values[recordNo], (SqlString)value);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0005536E File Offset: 0x0005356E
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlString(value);
			}
			return this._nullValue;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00055385 File Offset: 0x00053585
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0005539F File Offset: 0x0005359F
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000553B4 File Offset: 0x000535B4
		public override int GetStringLength(int record)
		{
			SqlString sqlString = this._values[record];
			if (!sqlString.IsNull)
			{
				return sqlString.Value.Length;
			}
			return 0;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000553E5 File Offset: 0x000535E5
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x000553F8 File Offset: 0x000535F8
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlString(value);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0005540C File Offset: 0x0005360C
		public override void SetCapacity(int capacity)
		{
			SqlString[] array = new SqlString[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0005544C File Offset: 0x0005364C
		public override object ConvertXmlToObject(string s)
		{
			SqlString sqlString = default(SqlString);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlString;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlString)xmlSerializable;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x000554B4 File Offset: 0x000536B4
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00055504 File Offset: 0x00053704
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlString[recordCount];
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0005550C File Offset: 0x0005370C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlString[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00055536 File Offset: 0x00053736
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlString[])store;
		}

		// Token: 0x0400052A RID: 1322
		private SqlString[] _values;
	}
}
