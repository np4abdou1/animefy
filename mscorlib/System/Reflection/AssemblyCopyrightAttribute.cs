using System;

namespace System.Reflection
{
	/// <summary>Defines a copyright custom attribute for an assembly manifest.</summary>
	// Token: 0x02000485 RID: 1157
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyCopyrightAttribute" /> class.</summary>
		/// <param name="copyright">The copyright information. </param>
		// Token: 0x060020C5 RID: 8389 RVA: 0x00089A4A File Offset: 0x00087C4A
		public AssemblyCopyrightAttribute(string copyright)
		{
			this.<Copyright>k__BackingField = copyright;
		}
	}
}
