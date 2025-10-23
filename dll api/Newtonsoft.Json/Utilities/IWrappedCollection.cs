using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000098 RID: 152
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000509 RID: 1289
		[Nullable(1)]
		object UnderlyingCollection { [NullableContext(1)] get; }
	}
}
