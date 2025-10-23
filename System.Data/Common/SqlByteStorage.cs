using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000F4 RID: 244
	internal sealed class SqlByteStorage : DataStorage
	{
		// Token: 0x06001070 RID: 4208 RVA: 0x000514C4 File Offset: 0x0004F6C4
		public SqlByteStorage(DataColumn column) : base(column, typeof(SqlByte), SqlByte.Null, SqlByte.Null, StorageType.SqlByte)
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000514F0 File Offset: 0x0004F6F0
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
						return (x / (long)num2).ToSqlByte();
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					SqlByte sqlByte = SqlByte.MaxValue;
					foreach (int num4 in records)
					{
						if (!this.IsNull(num4))
						{
							if (SqlByte.LessThan(this._values[num4], sqlByte).IsTrue)
							{
								sqlByte = this._values[num4];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlByte;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					SqlByte sqlByte2 = SqlByte.MinValue;
					foreach (int num5 in records)
					{
						if (!this.IsNull(num5))
						{
							if (SqlByte.GreaterThan(this._values[num5], sqlByte2).IsTrue)
							{
								sqlByte2 = this._values[num5];
							}
							flag = true;
						}
					}
					if (flag)
					{
						return sqlByte2;
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
				throw ExprException.Overflow(typeof(SqlByte));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0005192C File Offset: 0x0004FB2C
		public override int Compare(int recordNo1, int recordNo2)
		{
			return this._values[recordNo1].CompareTo(this._values[recordNo2]);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0005194B File Offset: 0x0004FB4B
		public override int CompareValueTo(int recordNo, object value)
		{
			return this._values[recordNo].CompareTo((SqlByte)value);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00051964 File Offset: 0x0004FB64
		public override object ConvertValue(object value)
		{
			if (value != null)
			{
				return SqlConvert.ConvertToSqlByte(value);
			}
			return this._nullValue;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0005197B File Offset: 0x0004FB7B
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00051995 File Offset: 0x0004FB95
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000519A8 File Offset: 0x0004FBA8
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000519BB File Offset: 0x0004FBBB
		public override void Set(int record, object value)
		{
			this._values[record] = SqlConvert.ConvertToSqlByte(value);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x000519D0 File Offset: 0x0004FBD0
		public override void SetCapacity(int capacity)
		{
			SqlByte[] array = new SqlByte[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00051A10 File Offset: 0x0004FC10
		public override object ConvertXmlToObject(string s)
		{
			SqlByte sqlByte = default(SqlByte);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlByte;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return (SqlByte)xmlSerializable;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00051A78 File Offset: 0x0004FC78
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlByte[recordCount];
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00051AD0 File Offset: 0x0004FCD0
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlByte[])store)[storeIndex] = this._values[record];
			nullbits.Set(record, this.IsNull(record));
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00051AF9 File Offset: 0x0004FCF9
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlByte[])store;
		}

		// Token: 0x0400051E RID: 1310
		private SqlByte[] _values;
	}
}
