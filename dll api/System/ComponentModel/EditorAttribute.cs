using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the editor to use to change a property. This class cannot be inherited.</summary>
	// Token: 0x02000260 RID: 608
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class EditorAttribute : Attribute
	{
		/// <summary>Gets the name of the base class or interface serving as a lookup key for this editor.</summary>
		/// <returns>The name of the base class or interface serving as a lookup key for this editor.</returns>
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0004FB09 File Offset: 0x0004DD09
		public string EditorBaseTypeName { get; }

		/// <summary>Gets the name of the editor class in the <see cref="P:System.Type.AssemblyQualifiedName" /> format.</summary>
		/// <returns>The name of the editor class in the <see cref="P:System.Type.AssemblyQualifiedName" /> format.</returns>
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0004FB11 File Offset: 0x0004DD11
		public string EditorTypeName { get; }
	}
}
