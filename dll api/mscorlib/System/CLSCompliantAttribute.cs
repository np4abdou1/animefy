using System;

namespace System
{
	/// <summary>Indicates whether a program element is compliant with the Common Language Specification (CLS). This class cannot be inherited.</summary>
	// Token: 0x02000089 RID: 137
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[Serializable]
	public sealed class CLSCompliantAttribute : Attribute
	{
		/// <summary>Initializes an instance of the <see cref="T:System.CLSCompliantAttribute" /> class with a Boolean value indicating whether the indicated program element is CLS-compliant.</summary>
		/// <param name="isCompliant">
		///       <see langword="true" /> if CLS-compliant; otherwise, <see langword="false" />. </param>
		// Token: 0x06000321 RID: 801 RVA: 0x0000F711 File Offset: 0x0000D911
		public CLSCompliantAttribute(bool isCompliant)
		{
			this._compliant = isCompliant;
		}

		// Token: 0x040001D2 RID: 466
		private bool _compliant;
	}
}
