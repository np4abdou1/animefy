using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000F9 RID: 249
	internal sealed class SqlDoubleStorage : DataStorage
	{
		// Token: 0x060010B9 RID: 4281 RVA: 0x00052930 File Offset: 0x00050B30
		public SqlDoubleStorage(DataColumn column) : base(column, typeof(SqlDouble), SqlDouble.Null, SqlDouble.Null, StorageType.SqlDouble)
		{
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0005295C File Offset: 0x00050B5C
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					SqlDouble sqlDouble = 0.0;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							sqlDouble += this._values[num];
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDouble;
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
							x += this._values[num3];
							num2++;
							flag = true;
						}
					}
					if (flag)
					{
						0.0;
						return x / (double)num2;
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					SqlDouble sqlDouble2 = SqlDouble.MaxValue;
					foreach (int num4 in records)
					{
						if (!this.IsNull(num4))
						{
							if (SqlDouble.LessThan(this._values[num4], sqlDouble2).IsTrue)
							{
								sqlDouble2 = this._values[num4];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDouble2;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					SqlDouble sqlDouble3 = SqlDouble.MinValue;
					foreach (int num5 in records)
					{
						if (!this.IsNull(num5))
						{
							if (SqlDouble.GreaterThan(this._values[num5], sqlDouble3).IsTrue)
							{
								sqlDouble3 = this._values[num5];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlDouble3;
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
					SqlDouble sqlDouble4 = 0.0;
					0.0;
					SqlDouble sqlDouble5 = 0.0;
					SqlDouble sqlDouble6 = 0.0;
					foreach (int num7 in records)
					{
						if (!this.IsNull(num7))
						{
							sqlDouble5 += this._values[num7];
							sqlDouble6 += this._values[num7] * this._values[num7];
							num6++;
						}
					}
					if (num6 <= 1)
					{
						return this._nullValue;
					}
					sqlDouble4 = (double)num6 * sqlDouble6 - sqlDouble5 * sqlDouble5;
					SqlBoolean sqlBoolean = sqlDouble4 / (sqlDouble5 * sqlDouble5) < 1E-15;
					if (sqlBoolean ? sqlBoolean : (sqlBoolean | sqlDouble4 < 0.0))
					{
						sqlDouble4 = 0.0;
					}
					else
					{
						sqlDouble4 /= (double)(num6 * (num6 - 1));
					}
					if (kind == AggregateType.StDev)
					{
						return Math.Sqrt(sqlDouble4.Value);
					}
					return sqlDouble4;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(SqlDouble));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00052D8C File Offset: 0x00050F8C
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00052DAB File Offset: 0x00050FAB
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlDouble)value);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00052DC4 File Offset: 0x00050FC4
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlDouble(value);
			}
			return this._nullValue;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00052DDB File Offset: 0x00050FDB
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00052DF5 File Offset: 0x00050FF5
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00052E08 File Offset: 0x00051008
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00052E1B File Offset: 0x0005101B
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlDouble(value);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00052E30 File Offset: 0x00051030
		public override void SetCapacity(int capacity)
		{
			SqlDouble[] array = new SqlDouble[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00052E70 File Offset: 0x00051070
		public override object ConvertXmlToObject(string s)
		{
			SqlDouble sqlDouble = default(SqlDouble);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlDouble;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlDouble)xmlSerializable;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00052ED8 File Offset: 0x000510D8
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00052F28 File Offset: 0x00051128
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlDouble[recordCount];
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00052F30 File Offset: 0x00051130
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlDouble[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00052F5A File Offset: 0x0005115A
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlDouble[])store;
		}

		// Token: 0x04000523 RID: 1315
		private SqlDouble[] _values;
	}
}
