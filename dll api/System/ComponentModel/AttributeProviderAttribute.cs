using System;

namespace System.ComponentModel
{
	/// <summary>Enables attribute redirection. This class cannot be inherited.</summary>
	// Token: 0x0200024C RID: 588
	[AttributeUsage(AttributeTargets.Property)]
	public class AttributeProviderAttribute : Attribute
	{
		/// <summary>Gets the assembly qualified type name passed into the constructor.</summary>
		/// <returns>The assembly qualified name of the type specified in the constructor.</returns>
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0004DC10 File Offset: 0x0004BE10
		public string TypeName { get; }

		/// <summary>Gets the name of the property for which attributes will be retrieved.</summary>
		/// <returns>The name of the property for which attributes will be retrieved.</returns>
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0004DC18 File Offset: 0x0004BE18
		public string PropertyName { get; }
	}
}
