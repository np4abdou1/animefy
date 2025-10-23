using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Specifies whether to wrap exceptions that do not derive from the <see cref="T:System.Exception" /> class with a <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" /> object. This class cannot be inherited.</summary>
	// Token: 0x0200044F RID: 1103
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		/// <summary>Gets or sets a value that indicates whether to wrap exceptions that do not derive from the <see cref="T:System.Exception" /> class with a <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" /> object.</summary>
		/// <returns>
		///     <see langword="true" /> if exceptions that do not derive from the <see cref="T:System.Exception" /> class should appear wrapped with a <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" /> object; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000405 RID: 1029
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x00087F66 File Offset: 0x00086166
		public bool WrapNonExceptionThrows
		{
			[CompilerGenerated]
			set
			{
				this.<WrapNonExceptionThrows>k__BackingField = value;
			}
		}
	}
}
