using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000FB RID: 251
	internal sealed class SqlInt16Storage : DataStorage
	{
		// Token: 0x060010D7 RID: 4311 RVA: 0x00053200 File Offset: 0x00051400
		public SqlInt16Storage(DataColumn column) : base(column, typeof(SqlInt16), SqlInt16.Null, SqlInt16.Null, StorageType.SqlInt16)
		{
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0005322C File Offset: 0x0005142C
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					SqlInt64 sqlInt = 0L;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							sqlInt += this._values[num];
							flag = true;
						}
					}
					if (flag)
					{
						return sqlInt;
					}
					return this._nullValue;
				}
				case AggregateType.Mean:
				{
					SqlInt64 x = 0L;
					int num2 = 0;
					foreach (int num3 in records)
					{
						if (!this.IsNull(num3))
						{
							x += this._values[num3].ToSqlInt64();
							num2++;
							flag = true;
						}
					}
					if (flag)
					{
						0;
						return (x / (long)num2).ToSqlInt16();
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					SqlInt16 sqlInt2 = SqlInt16.MaxValue;
					foreach (int num4 in records)
					{
						if (!this.IsNull(num4))
						{
							if (SqlInt16.LessThan(this._values[num4], sqlInt2).IsTrue)
							{
								sqlInt2 = this._values[num4];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlInt2;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					SqlInt16 sqlInt3 = SqlInt16.MinValue;
					foreach (int num5 in records)
					{
						if (!this.IsNull(num5))
						{
							if (SqlInt16.GreaterThan(this._values[num5], sqlInt3).IsTrue)
							{
								sqlInt3 = this._values[num5];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlInt3;
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
				throw ExprException.Overflow(typeof(SqlInt16));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00053668 File Offset: 0x00051868
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00053687 File Offset: 0x00051887
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlInt16)value);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x000536A0 File Offset: 0x000518A0
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlInt16(value);
			}
			return this._nullValue;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x000536B7 File Offset: 0x000518B7
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000536D1 File Offset: 0x000518D1
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x000536E4 File Offset: 0x000518E4
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x000536F7 File Offset: 0x000518F7
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlInt16(value);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0005370C File Offset: 0x0005190C
		public override void SetCapacity(int capacity)
		{
			SqlInt16[] array = new SqlInt16[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0005374C File Offset: 0x0005194C
		public override object ConvertXmlToObject(string s)
		{
			SqlInt16 sqlInt = default(SqlInt16);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlInt;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlInt16)xmlSerializable;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000537B4 File Offset: 0x000519B4
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00053804 File Offset: 0x00051A04
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlInt16[recordCount];
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0005380C File Offset: 0x00051A0C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlInt16[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00053836 File Offset: 0x00051A36
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlInt16[])store;
		}

		// Token: 0x04000525 RID: 1317
		private SqlInt16[] _values;
	}
}
