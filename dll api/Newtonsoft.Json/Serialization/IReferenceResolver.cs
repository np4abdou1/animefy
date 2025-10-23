using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010E RID: 270
	[NullableContext(1)]
	public interface IReferenceResolver
	{
		// Token: 0x060007C6 RID: 1990
		object ResolveReference(object context, string reference);

		// Token: 0x060007C7 RID: 1991
		string GetReference(object context, object value);

		// Token: 0x060007C8 RID: 1992
		bool IsReferenced(object context, object value);

		// Token: 0x060007C9 RID: 1993
		void AddReference(object context, string reference, object value);
	}
}
