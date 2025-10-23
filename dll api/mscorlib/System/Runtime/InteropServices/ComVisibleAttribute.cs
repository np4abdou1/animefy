using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Controls accessibility of an individual managed type or member, or of all types within an assembly, to COM.</summary>
	// Token: 0x02000409 RID: 1033
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComVisibleAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see langword="ComVisibleAttribute" /> class.</summary>
		/// <param name="visibility">
		///       <see langword="true" /> to indicate that the type is visible to COM; otherwise, <see langword="false" />. The default is <see langword="true" />. </param>
		// Token: 0x06001F43 RID: 8003 RVA: 0x000866FF File Offset: 0x000848FF
		public ComVisibleAttribute(bool visibility)
		{
			this._val = visibility;
		}

		// Token: 0x04000E96 RID: 3734
		internal bool _val;
	}
}
