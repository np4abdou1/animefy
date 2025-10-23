using System;
using System.Collections;

namespace System.Data.Common
{
	// Token: 0x02000107 RID: 263
	internal sealed class StringStorage : DataStorage
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x0005637E File Offset: 0x0005457E
		public StringStorage(DataColumn column) : base(column, typeof(string), string.Empty, StorageType.String)
		{
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00056398 File Offset: 0x00054598
		public override object Aggregate(int[] recordNos, AggregateType kind)
		{
			switch (kind)
			{
			case AggregateType.Min:
			{
				int num = -1;
				int i;
				for (i = 0; i < recordNos.Length; i++)
				{
					if (!this.IsNull(recordNos[i]))
					{
						num = recordNos[i];
						break;
					}
				}
				if (num >= 0)
				{
					for (i++; i < recordNos.Length; i++)
					{
						if (!this.IsNull(recordNos[i]) && this.Compare(num, recordNos[i]) > 0)
						{
							num = recordNos[i];
						}
					}
					return this.Get(num);
				}
				return this._nullValue;
			}
			case AggregateType.Max:
			{
				int num2 = -1;
				int i;
				for (i = 0; i < recordNos.Length; i++)
				{
					if (!this.IsNull(recordNos[i]))
					{
						num2 = recordNos[i];
						break;
					}
				}
				if (num2 >= 0)
				{
					for (i++; i < recordNos.Length; i++)
					{
						if (this.Compare(num2, recordNos[i]) < 0)
						{
							num2 = recordNos[i];
						}
					}
					return this.Get(num2);
				}
				return this._nullValue;
			}
			case AggregateType.Count:
			{
				int num3 = 0;
				for (int i = 0; i < recordNos.Length; i++)
				{
					if (this._values[recordNos[i]] != null)
					{
						num3++;
					}
				}
				return num3;
			}
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000564AC File Offset: 0x000546AC
		public override int Compare(int recordNo1, int recordNo2)
		{
			string text = this._values[recordNo1];
			string text2 = this._values[recordNo2];
			if (text == text2)
			{
				return 0;
			}
			if (text == null)
			{
				return -1;
			}
			if (text2 == null)
			{
				return 1;
			}
			return this._table.Compare(text, text2);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000564E8 File Offset: 0x000546E8
		public override int CompareValueTo(int recordNo, object value)
		{
			string text = this._values[recordNo];
			if (text == null)
			{
				if (this._nullValue == value)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (this._nullValue == value)
				{
					return 1;
				}
				return this._table.Compare(text, (string)value);
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0005652B File Offset: 0x0005472B
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = value.ToString();
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0005654C File Offset: 0x0005474C
		public override void Copy(int recordNo1, int recordNo2)
		{
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00056560 File Offset: 0x00054760
		public override object Get(int recordNo)
		{
			string text = this._values[recordNo];
			if (text != null)
			{
				return text;
			}
			return this._nullValue;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00056584 File Offset: 0x00054784
		public override int GetStringLength(int record)
		{
			string text = this._values[record];
			if (text == null)
			{
				return 0;
			}
			return text.Length;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x000565A5 File Offset: 0x000547A5
		public override bool IsNull(int record)
		{
			return this._values[record] == null;
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000565B2 File Offset: 0x000547B2
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = null;
				return;
			}
			this._values[record] = value.ToString();
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000565D8 File Offset: 0x000547D8
		public override void SetCapacity(int capacity)
		{
			string[] array = new string[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0004B3A0 File Offset: 0x000495A0
		public override object ConvertXmlToObject(string s)
		{
			return s;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00056617 File Offset: 0x00054817
		public override string ConvertObjectToXml(object value)
		{
			return (string)value;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0005661F File Offset: 0x0005481F
		protected override object GetEmptyStorage(int recordCount)
		{
			return new string[recordCount];
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00056627 File Offset: 0x00054827
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((string[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00056649 File Offset: 0x00054849
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (string[])store;
		}

		// Token: 0x04000551 RID: 1361
		private string[] _values;
	}
}
