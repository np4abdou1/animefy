﻿using System;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Indicates the method that will be used during deserialization for locating and loading assemblies.</summary>
	// Token: 0x020003BA RID: 954
	public enum FormatterAssemblyStyle
	{
		/// <summary>In simple mode, the assembly used during deserialization need not match exactly the assembly used during serialization. Specifically, the version numbers need not match as the <see cref="Overload:System.Reflection.Assembly.LoadWithPartialName" /> method is used to load the assembly.</summary>
		// Token: 0x04000C60 RID: 3168
		Simple,
		/// <summary>In full mode, the assembly used during deserialization must match exactly the assembly used during serialization. The <see cref="Overload:System.Reflection.Assembly.Load" /> method of the <see cref="T:System.Reflection.Assembly" /> class is used to load the assembly.</summary>
		// Token: 0x04000C61 RID: 3169
		Full
	}
}
