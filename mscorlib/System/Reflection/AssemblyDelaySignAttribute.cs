using System;

namespace System.Reflection
{
	/// <summary>Specifies that the assembly is not fully signed when created.</summary>
	// Token: 0x02000487 RID: 1159
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyDelaySignAttribute" /> class.</summary>
		/// <param name="delaySign">
		///       <see langword="true" /> if the feature this attribute represents is activated; otherwise, <see langword="false" />. </param>
		// Token: 0x060020C7 RID: 8391 RVA: 0x00089A68 File Offset: 0x00087C68
		public AssemblyDelaySignAttribute(bool delaySign)
		{
			this.<DelaySign>k__BackingField = delaySign;
		}
	}
}
