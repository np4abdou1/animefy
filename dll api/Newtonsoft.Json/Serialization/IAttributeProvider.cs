using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010C RID: 268
	[NullableContext(1)]
	public interface IAttributeProvider
	{
		// Token: 0x060007C3 RID: 1987
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x060007C4 RID: 1988
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
