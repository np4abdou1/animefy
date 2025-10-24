using System;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Specifies the level of automatic deserialization for .NET Framework remoting.</summary>
	// Token: 0x020003BB RID: 955
	public enum TypeFilterLevel
	{
		/// <summary>The low deserialization level for .NET Framework remoting. It supports types associated with basic remoting functionality.</summary>
		// Token: 0x04000C63 RID: 3171
		Low = 2,
		/// <summary>The full deserialization level for .NET Framework remoting. It supports all types that remoting supports in all situations.</summary>
		// Token: 0x04000C64 RID: 3172
		Full
	}
}
