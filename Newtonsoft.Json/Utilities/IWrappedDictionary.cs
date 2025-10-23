using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A3 RID: 163
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000568 RID: 1384
		[Nullable(1)]
		object UnderlyingDictionary { [NullableContext(1)] get; }
	}
}
