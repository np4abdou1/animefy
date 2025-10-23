using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the value to pass to a property to cause the property to get its value from another source. This is known as ambience. This class cannot be inherited.</summary>
	// Token: 0x02000248 RID: 584
	[AttributeUsage(AttributeTargets.All)]
	public sealed class AmbientValueAttribute : Attribute
	{
		/// <summary>Gets the object that is the value of this <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</summary>
		/// <returns>The object that is the value of this <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</returns>
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0004D826 File Offset: 0x0004BA26
		public object Value { get; }
	}
}
