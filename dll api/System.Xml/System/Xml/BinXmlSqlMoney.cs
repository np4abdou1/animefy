using System;
using System.Globalization;

namespace System.Xml
{
	// Token: 0x02000012 RID: 18
	internal struct BinXmlSqlMoney
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000033B2 File Offset: 0x000015B2
		public BinXmlSqlMoney(int v)
		{
			this.data = (long)v;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000033BC File Offset: 0x000015BC
		public BinXmlSqlMoney(long v)
		{
			this.data = v;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000033C8 File Offset: 0x000015C8
		public decimal ToDecimal()
		{
			bool isNegative;
			ulong num;
			if (this.data < 0L)
			{
				isNegative = true;
				num = (ulong)(-(ulong)this.data);
			}
			else
			{
				isNegative = false;
				num = (ulong)this.data;
			}
			return new decimal((int)num, (int)(num >> 32), 0, isNegative, 4);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003404 File Offset: 0x00001604
		public override string ToString()
		{
			return this.ToDecimal().ToString("#0.00##", CultureInfo.InvariantCulture);
		}

		// Token: 0x04000087 RID: 135
		private long data;
	}
}
