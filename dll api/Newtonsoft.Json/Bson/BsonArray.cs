using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DC RID: 476
	internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		// Token: 0x0600100F RID: 4111 RVA: 0x00046945 File Offset: 0x00044B45
		public void Add(BsonToken token)
		{
			this._children.Add(token);
			token.Parent = this;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00037A58 File Offset: 0x00035C58
		public override BsonType Type
		{
			get
			{
				return BsonType.Array;
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0004695A File Offset: 0x00044B5A
		public IEnumerator<BsonToken> GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0004696C File Offset: 0x00044B6C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000857 RID: 2135
		private readonly List<BsonToken> _children = new List<BsonToken>();
	}
}
