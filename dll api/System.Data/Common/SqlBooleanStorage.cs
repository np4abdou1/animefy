using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x02000101 RID: 257
	internal sealed class SqlBooleanStorage : DataStorage
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x00055544 File Offset: 0x00053744
		public SqlBooleanStorage(DataColumn column) : base(column, typeof(SqlBoolean), SqlBoolean.Null, SqlBoolean.Null, StorageType.SqlBoolean)
		{
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00055570 File Offset: 0x00053770
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Min:
				{
					SqlBoolean sqlBoolean = true;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							sqlBoolean = SqlBoolean.And(this._values[num], sqlBoolean);
							flag = true;
						}
					}
					if (flag)
					{
						return sqlBoolean;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					SqlBoolean sqlBoolean2 = false;
					foreach (int num2 in records)
					{
						if (!this.IsNull(num2))
						{
							sqlBoolean2 = SqlBoolean.Or(this._values[num2], sqlBoolean2);
							flag = true;
						}
					}
					if (flag)
					{
						return sqlBoolean2;
					}
					return this._nullValue;
				}
				case AggregateType.First:
					if (records.Length != 0)
					{
						return this._values[records[0]];
					}
					return this._nullValue;
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
				throw ExprException.Overflow(typeof(SqlBoolean));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x000556E0 File Offset: 0x000538E0
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000556FF File Offset: 0x000538FF
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlBoolean)value);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00055718 File Offset: 0x00053918
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlBoolean(value);
			}
			return this._nullValue;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0005572F File Offset: 0x0005392F
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00055749 File Offset: 0x00053949
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0005575C File Offset: 0x0005395C
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0005576F File Offset: 0x0005396F
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlBoolean(value);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00055784 File Offset: 0x00053984
		public override void SetCapacity(int capacity)
		{
			SqlBoolean[] array = new SqlBoolean[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000557C4 File Offset: 0x000539C4
		public override object ConvertXmlToObject(string s)
		{
			SqlBoolean sqlBoolean = default(SqlBoolean);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlBoolean;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlBoolean)xmlSerializable;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0005582C File Offset: 0x00053A2C
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0005587C File Offset: 0x00053A7C
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlBoolean[recordCount];
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00055884 File Offset: 0x00053A84
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlBoolean[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000558AE File Offset: 0x00053AAE
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlBoolean[])store;
		}

		// Token: 0x0400052B RID: 1323
		private SqlBoolean[] _values;
	}
}
