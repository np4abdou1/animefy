using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000FF RID: 255
	internal sealed class SqlSingleStorage : DataStorage
	{
		// Token: 0x06001113 RID: 4371 RVA: 0x00054B10 File Offset: 0x00052D10
		public SqlSingleStorage(DataColumn column) : base(column, typeof(SqlSingle), SqlSingle.Null, SqlSingle.Null, StorageType.SqlSingle)
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00054B3C File Offset: 0x00052D3C
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					SqlSingle sqlSingle = 0f;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							sqlSingle += this._values[num];
							flag = true;
						}
					}
					if (flag)
					{
						return sqlSingle;
					}
					return this._nullValue;
				}
				case AggregateType.Mean:
				{
					SqlDouble x = 0.0;
					int num2 = 0;
					foreach (int num3 in records)
					{
						if (!this.IsNull(num3))
						{
							x += this._values[num3].ToSqlDouble();
							num2++;
							flag = true;
						}
					}
					if (flag)
					{
						0f;
						return (x / (double)num2).ToSqlSingle();
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					SqlSingle sqlSingle2 = SqlSingle.MaxValue;
					foreach (int num4 in records)
					{
						if (!this.IsNull(num4))
						{
							if (SqlSingle.LessThan(this._values[num4], sqlSingle2).IsTrue)
							{
								sqlSingle2 = this._values[num4];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlSingle2;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					SqlSingle sqlSingle3 = SqlSingle.MinValue;
					foreach (int num5 in records)
					{
						if (!this.IsNull(num5))
						{
							if (SqlSingle.GreaterThan(this._values[num5], sqlSingle3).IsTrue)
							{
								sqlSingle3 = this._values[num5];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlSingle3;
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
				throw ExprException.Overflow(typeof(SqlSingle));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00054F84 File Offset: 0x00053184
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00054FA3 File Offset: 0x000531A3
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlSingle)value);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00054FBC File Offset: 0x000531BC
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlSingle(value);
			}
			return this._nullValue;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00054FD3 File Offset: 0x000531D3
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00054FED File Offset: 0x000531ED
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00055000 File Offset: 0x00053200
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00055013 File Offset: 0x00053213
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlSingle(value);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00055028 File Offset: 0x00053228
		public override void SetCapacity(int capacity)
		{
			SqlSingle[] array = new SqlSingle[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00055068 File Offset: 0x00053268
		public override object ConvertXmlToObject(string s)
		{
			SqlSingle sqlSingle = default(SqlSingle);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlSingle;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlSingle)xmlSerializable;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000550D0 File Offset: 0x000532D0
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00055120 File Offset: 0x00053320
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlSingle[recordCount];
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00055128 File Offset: 0x00053328
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlSingle[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00055152 File Offset: 0x00053352
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlSingle[])store;
		}

		// Token: 0x04000529 RID: 1321
		private SqlSingle[] _values;
	}
}
