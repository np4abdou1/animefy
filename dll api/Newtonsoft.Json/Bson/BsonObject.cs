using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DB RID: 475
	internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		// Token: 0x0600100A RID: 4106 RVA: 0x000468EB File Offset: 0x00044AEB
		public void Add(string name, BsonToken token)
		{
			this._children.Add(new BsonProperty
			{
				Name = new BsonString(name, false),
				Value = token
			});
			token.Parent = this;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00034429 File Offset: 0x00032629
		public override BsonType Type
		{
			get
			{
				return BsonType.Object;
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00046918 File Offset: 0x00044B18
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0004692A File Offset: 0x00044B2A
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000856 RID: 2134
		private readonly List<BsonProperty> _children = new List<BsonProperty>();
	}
}
