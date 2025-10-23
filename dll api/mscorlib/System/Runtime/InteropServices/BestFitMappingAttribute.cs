using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Controls whether Unicode characters are converted to the closest matching ANSI characters.</summary>
	// Token: 0x02000418 RID: 1048
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class BestFitMappingAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.BestFitMappingAttribute" /> class set to the value of the <see cref="P:System.Runtime.InteropServices.BestFitMappingAttribute.BestFitMapping" /> property.</summary>
		/// <param name="BestFitMapping">
		///       <see langword="true" /> to indicate that best-fit mapping is enabled; otherwise, <see langword="false" />. The default is <see langword="true" />. </param>
		// Token: 0x06001F52 RID: 8018 RVA: 0x000868FF File Offset: 0x00084AFF
		public BestFitMappingAttribute(bool BestFitMapping)
		{
			this._bestFitMapping = BestFitMapping;
		}

		// Token: 0x04000F04 RID: 3844
		internal bool _bestFitMapping;
	}
}
