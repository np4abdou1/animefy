using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DE RID: 478
	internal class BsonValue : BsonToken
	{
		// Token: 0x06001017 RID: 4119 RVA: 0x000469B7 File Offset: 0x00044BB7
		public BsonValue(object value, BsonType type)
		{
			this._value = value;
			this._type = type;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x000469CD File Offset: 0x00044BCD
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000469D5 File Offset: 0x00044BD5
		public override BsonType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x0400085B RID: 2139
		private readonly object _value;

		// Token: 0x0400085C RID: 2140
		private readonly BsonType _type;
	}
}
