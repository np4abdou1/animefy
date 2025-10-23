﻿using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010F RID: 271
	[NullableContext(1)]
	public interface ISerializationBinder
	{
		// Token: 0x060007CA RID: 1994
		Type BindToType([Nullable(2)] string assemblyName, string typeName);

		// Token: 0x060007CB RID: 1995
		[NullableContext(2)]
		void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName);
	}
}
