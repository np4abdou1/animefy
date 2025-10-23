using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000F7 RID: 247
	internal sealed class SqlDateTimeStorage : DataStorage
	{
		// Token: 0x0600109B RID: 4251 RVA: 0x00051F60 File Offset: 0x00050160
		public SqlDateTimeStorage(DataColumn column) : base(column, typeof(SqlDateTime), SqlDateTime.Null, SqlDateTime.Null, StorageType.SqlDateTime)
		{
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00051F8C File Offset: 0x0005018C
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Min:
				{
					SqlDateTime sqlDateTime = SqlDateTime.MaxValue;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							if (SqlDateTime.LessThan(this._values[num], sqlDateTime).IsTrue)
							{
								sqlDateTime = this._values[num];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDateTime;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					SqlDateTime sqlDateTime2 = SqlDateTime.MinValue;
					foreach (int num2 in records)
					{
						if (!this.IsNull(num2))
						{
							if (SqlDateTime.GreaterThan(this._values[num2], sqlDateTime2).IsTrue)
							{
								sqlDateTime2 = this._values[num2];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDateTime2;
					}
					return this._nullValue;
				}
				case AggregateType.First:
					if (records.Length != 0)
					{
						return this._values[records[0]];
					}
					return null;
				case AggregateType.Count:
				{
					int num3 = 0;
					for (int k = 0; k < records.Length; k++)
					{
						if (!this.IsNull(records[k]))
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
				throw ExprException.Overflow(typeof(SqlDateTime));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00052124 File Offset: 0x00050324
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00052143 File Offset: 0x00050343
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlDateTime)value);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0005215C File Offset: 0x0005035C
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlDateTime(value);
			}
			return this._nullValue;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00052173 File Offset: 0x00050373
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0005218D File Offset: 0x0005038D
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000521A0 File Offset: 0x000503A0
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000521B3 File Offset: 0x000503B3
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlDateTime(value);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000521C8 File Offset: 0x000503C8
		public override void SetCapacity(int capacity)
		{
			SqlDateTime[] array = new SqlDateTime[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00052208 File Offset: 0x00050408
		public override object ConvertXmlToObject(string s)
		{
			SqlDateTime sqlDateTime = default(SqlDateTime);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlDateTime;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlDateTime)xmlSerializable;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00052270 File Offset: 0x00050470
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x000522C0 File Offset: 0x000504C0
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlDateTime[recordCount];
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000522C8 File Offset: 0x000504C8
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlDateTime[])store)[storeIndex] = this._values[record];
			nullbits.Set(record, this.IsNull(record));
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000522F1 File Offset: 0x000504F1
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlDateTime[])store;
		}

		// Token: 0x04000521 RID: 1313
		private SqlDateTime[] _values;
	}
}
