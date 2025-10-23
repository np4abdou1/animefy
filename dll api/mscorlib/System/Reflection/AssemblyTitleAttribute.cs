using System;

namespace System.Reflection
{
	/// <summary>Specifies a description for an assembly.</summary>
	// Token: 0x0200048F RID: 1167
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTitleAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyTitleAttribute" /> class.</summary>
		/// <param name="title">The assembly title. </param>
		// Token: 0x060020CE RID: 8398 RVA: 0x00089AE6 File Offset: 0x00087CE6
		public AssemblyTitleAttribute(string title)
		{
			this.<Title>k__BackingField = title;
		}
	}
}
