using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000F3 RID: 243
	internal sealed class SqlBinaryStorage : DataStorage
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x0005122F File Offset: 0x0004F42F
		public SqlBinaryStorage(DataColumn column) : base(column, typeof(SqlBinary), SqlBinary.Null, SqlBinary.Null, StorageType.SqlBinary)
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00051258 File Offset: 0x0004F458
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
				throw ExprException.Overflow(typeof(SqlBinary));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x000512E8 File Offset: 0x0004F4E8
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00051307 File Offset: 0x0004F507
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlBinary)value);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00051320 File Offset: 0x0004F520
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlBinary(value);
			}
			return this._nullValue;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00051337 File Offset: 0x0004F537
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00051351 File Offset: 0x0004F551
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00051364 File Offset: 0x0004F564
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00051377 File Offset: 0x0004F577
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlBinary(value);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0005138C File Offset: 0x0004F58C
		public override void SetCapacity(int capacity)
		{
			SqlBinary[] array = new SqlBinary[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x000513CC File Offset: 0x0004F5CC
		public override object ConvertXmlToObject(string s)
		{
			SqlBinary sqlBinary = default(SqlBinary);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlBinary;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlBinary)xmlSerializable;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00051434 File Offset: 0x0004F634
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00051484 File Offset: 0x0004F684
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlBinary[recordCount];
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0005148C File Offset: 0x0004F68C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlBinary[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000514B6 File Offset: 0x0004F6B6
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlBinary[])store;
		}

		// Token: 0x0400051D RID: 1309
		private SqlBinary[] _values;
	}
}
