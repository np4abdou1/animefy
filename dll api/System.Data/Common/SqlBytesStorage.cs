using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000F5 RID: 245
	internal sealed class SqlBytesStorage : DataStorage
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x00051B07 File Offset: 0x0004FD07
		public SqlBytesStorage(DataColumn column) : base(column, typeof(SqlBytes), SqlBytes.Null, SqlBytes.Null, StorageType.SqlBytes)
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00051B28 File Offset: 0x0004FD28
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
				throw ExprException.Overflow(typeof(SqlBytes));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000020BC File Offset: 0x000002BC
		public override int Compare(int recordNo1, int recordNo2)
		{
			return 0;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000020BC File Offset: 0x000002BC
		public override int CompareValueTo(int recordNo, object value)
		{
			return 0;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00051BB0 File Offset: 0x0004FDB0
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00051BC2 File Offset: 0x0004FDC2
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00051BCC File Offset: 0x0004FDCC
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00051BDB File Offset: 0x0004FDDB
		public override void Set(int record, object value)
		{
			if (value == DBNull.Value || value == null)
			{
				this._values[record] = SqlBytes.Null;
				return;
			}
			this._values[record] = (SqlBytes)value;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00051C04 File Offset: 0x0004FE04
		public override void SetCapacity(int capacity)
		{
			SqlBytes[] array = new SqlBytes[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00051C44 File Offset: 0x0004FE44
		public override object ConvertXmlToObject(string s)
		{
			SqlBinary sqlBinary = default(SqlBinary);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlBinary;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return new SqlBytes((SqlBinary)xmlSerializable);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00051CAC File Offset: 0x0004FEAC
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00051CFC File Offset: 0x0004FEFC
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlBytes[recordCount];
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00051D04 File Offset: 0x0004FF04
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlBytes[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00051D26 File Offset: 0x0004FF26
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlBytes[])store;
		}

		// Token: 0x0400051F RID: 1311
		private SqlBytes[] _values;
	}
}
