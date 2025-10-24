using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000F8 RID: 248
	internal sealed class SqlDecimalStorage : DataStorage
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x000522FF File Offset: 0x000504FF
		public SqlDecimalStorage(DataColumn column) : base(column, typeof(SqlDecimal), SqlDecimal.Null, SqlDecimal.Null, StorageType.SqlDecimal)
		{
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00052328 File Offset: 0x00050528
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					SqlDecimal sqlDecimal = 0L;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							sqlDecimal += this._values[num];
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDecimal;
					}
					return this._nullValue;
				}
				case AggregateType.Mean:
				{
					SqlDecimal x = 0L;
					int num2 = 0;
					foreach (int num3 in records)
					{
						if (!this.IsNull(num3))
						{
							x += this._values[num3];
							num2++;
							flag = true;
						}
					}
					if (flag)
					{
						0L;
						return x / (long)num2;
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					SqlDecimal sqlDecimal2 = SqlDecimal.MaxValue;
					foreach (int num4 in records)
					{
						if (!this.IsNull(num4))
						{
							if (SqlDecimal.LessThan(this._values[num4], sqlDecimal2).IsTrue)
							{
								sqlDecimal2 = this._values[num4];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDecimal2;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					SqlDecimal sqlDecimal3 = SqlDecimal.MinValue;
					foreach (int num5 in records)
					{
						if (!this.IsNull(num5))
						{
							if (SqlDecimal.GreaterThan(this._values[num5], sqlDecimal3).IsTrue)
							{
								sqlDecimal3 = this._values[num5];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDecimal3;
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
					int num6 = 0;
					for (int l = 0; l < records.Length; l++)
					{
						if (!this.IsNull(records[l]))
						{
							num6++;
						}
					}
					return num6;
				}
				case AggregateType.Var:
				case AggregateType.StDev:
				{
					int num6 = 0;
					SqlDouble sqlDouble = 0.0;
					0.0;
					SqlDouble sqlDouble2 = 0.0;
					SqlDouble sqlDouble3 = 0.0;
					foreach (int num7 in records)
					{
						if (!this.IsNull(num7))
						{
							sqlDouble2 += this._values[num7].ToSqlDouble();
							sqlDouble3 += this._values[num7].ToSqlDouble() * this._values[num7].ToSqlDouble();
							num6++;
						}
					}
					if (num6 <= 1)
					{
						return this._nullValue;
					}
					sqlDouble = (double)num6 * sqlDouble3 - sqlDouble2 * sqlDouble2;
					SqlBoolean sqlBoolean = sqlDouble / (sqlDouble2 * sqlDouble2) < 1E-15;
					if (sqlBoolean ? sqlBoolean : (sqlBoolean | sqlDouble < 0.0))
					{
						sqlDouble = 0.0;
					}
					else
					{
						sqlDouble /= (double)(num6 * (num6 - 1));
					}
					if (kind == AggregateType.StDev)
					{
						return Math.Sqrt(sqlDouble.Value);
					}
					return sqlDouble;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(SqlDecimal));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00052754 File Offset: 0x00050954
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00052773 File Offset: 0x00050973
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlDecimal)value);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0005278C File Offset: 0x0005098C
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlDecimal(value);
			}
			return this._nullValue;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x000527A3 File Offset: 0x000509A3
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x000527BD File Offset: 0x000509BD
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x000527D0 File Offset: 0x000509D0
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x000527E3 File Offset: 0x000509E3
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlDecimal(value);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x000527F8 File Offset: 0x000509F8
		public override void SetCapacity(int capacity)
		{
			SqlDecimal[] array = new SqlDecimal[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00052838 File Offset: 0x00050A38
		public override object ConvertXmlToObject(string s)
		{
			SqlDecimal sqlDecimal = default(SqlDecimal);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlDecimal;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlDecimal)xmlSerializable;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x000528A0 File Offset: 0x00050AA0
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000528F0 File Offset: 0x00050AF0
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlDecimal[recordCount];
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x000528F8 File Offset: 0x00050AF8
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlDecimal[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00052922 File Offset: 0x00050B22
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlDecimal[])store;
		}

		// Token: 0x04000522 RID: 1314
		private SqlDecimal[] _values;
	}
}
