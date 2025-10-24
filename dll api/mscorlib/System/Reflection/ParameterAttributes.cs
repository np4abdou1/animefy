using System;

namespace System.Reflection
{
	/// <summary>Defines the attributes that can be associated with a parameter. These are defined in CorHdr.h.</summary>
	// Token: 0x020004AE RID: 1198
	[Flags]
	public enum ParameterAttributes
	{
		/// <summary>Specifies that there is no parameter attribute.</summary>
		// Token: 0x04001030 RID: 4144
		None = 0,
		/// <summary>Specifies that the parameter is an input parameter.</summary>
		// Token: 0x04001031 RID: 4145
		In = 1,
		/// <summary>Specifies that the parameter is an output parameter.</summary>
		// Token: 0x04001032 RID: 4146
		Out = 2,
		/// <summary>Specifies that the parameter is a locale identifier (lcid).</summary>
		// Token: 0x04001033 RID: 4147
		Lcid = 4,
		/// <summary>Specifies that the parameter is a return value.</summary>
		// Token: 0x04001034 RID: 4148
		Retval = 8,
		/// <summary>Specifies that the parameter is optional.</summary>
		// Token: 0x04001035 RID: 4149
		Optional = 16,
		/// <summary>Specifies that the parameter has a default value.</summary>
		// Token: 0x04001036 RID: 4150
		HasDefault = 4096,
		/// <summary>Specifies that the parameter has field marshaling information.</summary>
		// Token: 0x04001037 RID: 4151
		HasFieldMarshal = 8192,
		/// <summary>Reserved.</summary>
		// Token: 0x04001038 RID: 4152
		Reserved3 = 16384,
		/// <summary>Reserved.</summary>
		// Token: 0x04001039 RID: 4153
		Reserved4 = 32768,
		/// <summary>Specifies that the parameter is reserved.</summary>
		// Token: 0x0400103A RID: 4154
		ReservedMask = 61440
	}
}
