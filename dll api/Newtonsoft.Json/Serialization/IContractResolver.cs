﻿using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010D RID: 269
	[NullableContext(1)]
	public interface IContractResolver
	{
		// Token: 0x060007C5 RID: 1989
		JsonContract ResolveContract(Type type);
	}
}
