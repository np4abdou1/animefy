using System;

namespace System.Reflection
{
	/// <summary>Marks each type of member that is defined as a derived class of <see cref="T:System.Reflection.MemberInfo" />.</summary>
	// Token: 0x020004A7 RID: 1191
	[Flags]
	public enum MemberTypes
	{
		/// <summary>Specifies that the member is a constructor</summary>
		// Token: 0x04000FF8 RID: 4088
		Constructor = 1,
		/// <summary>Specifies that the member is an event.</summary>
		// Token: 0x04000FF9 RID: 4089
		Event = 2,
		/// <summary>Specifies that the member is a field.</summary>
		// Token: 0x04000FFA RID: 4090
		Field = 4,
		/// <summary>Specifies that the member is a method.</summary>
		// Token: 0x04000FFB RID: 4091
		Method = 8,
		/// <summary>Specifies that the member is a property.</summary>
		// Token: 0x04000FFC RID: 4092
		Property = 16,
		/// <summary>Specifies that the member is a type.</summary>
		// Token: 0x04000FFD RID: 4093
		TypeInfo = 32,
		/// <summary>Specifies that the member is a custom member type. </summary>
		// Token: 0x04000FFE RID: 4094
		Custom = 64,
		/// <summary>Specifies that the member is a nested type.</summary>
		// Token: 0x04000FFF RID: 4095
		NestedType = 128,
		/// <summary>Specifies all member types.</summary>
		// Token: 0x04001000 RID: 4096
		All = 191
	}
}
