using System;
using System.Collections;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data.Common
{
	// Token: 0x020000F6 RID: 246
	internal sealed class SqlCharsStorage : DataStorage
	{
		// Token: 0x0600108D RID: 4237 RVA: 0x00051D34 File Offset: 0x0004FF34
		public SqlCharsStorage(DataColumn column) : base(column, typeof(SqlChars), SqlChars.Null, SqlChars.Null, StorageType.SqlChars)
		{
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00051D54 File Offset: 0x0004FF54
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
				throw ExprException.Overflow(typeof(SqlChars));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000020BC File Offset: 0x000002BC
		public override int Compare(int recordNo1, int recordNo2)
		{
			return 0;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x000020BC File Offset: 0x000002BC
		public override int CompareValueTo(int recordNo, object value)
		{
			return 0;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00051DDC File Offset: 0x0004FFDC
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00051DEE File Offset: 0x0004FFEE
		public override object Get(int record)
		{
			return this._values[record];
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00051DF8 File Offset: 0x0004FFF8
		public override bool IsNull(int record)
		{
			return this._values[record].IsNull;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00051E07 File Offset: 0x00050007
		public override void Set(int record, object value)
		{
			if (value == DBNull.Value || value == null)
			{
				this._values[record] = SqlChars.Null;
				return;
			}
			this._values[record] = (SqlChars)value;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00051E30 File Offset: 0x00050030
		public override void SetCapacity(int capacity)
		{
			SqlChars[] array = new SqlChars[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00051E70 File Offset: 0x00050070
		public override object ConvertXmlToObject(string s)
		{
			SqlString sqlString = default(SqlString);
			TextReader input = new StringReader("<col>" + s + "</col>");
			IXmlSerializable xmlSerializable = sqlString;
			using (XmlTextReader xmlTextReader = new XmlTextReader(input))
			{
				xmlSerializable.ReadXml(xmlTextReader);
			}
			return new SqlChars((SqlString)xmlSerializable);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00051ED8 File Offset: 0x000500D8
		public override string ConvertObjectToXml(object value)
		{
			StringWriter stringWriter = new StringWriter(base.FormatProvider);
			using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
			{
				((IXmlSerializable)value).WriteXml(xmlTextWriter);
			}
			return stringWriter.ToString();
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00051F28 File Offset: 0x00050128
		protected override object GetEmptyStorage(int recordCount)
		{
			return new SqlChars[recordCount];
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00051F30 File Offset: 0x00050130
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((SqlChars[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00051F52 File Offset: 0x00050152
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (SqlChars[])store;
		}

		// Token: 0x04000520 RID: 1312
		private SqlChars[] _values;
	}
}
