using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that a property or method is viewable in an editor. This class cannot be inherited.</summary>
	// Token: 0x02000231 RID: 561
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class EditorBrowsableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EditorBrowsableAttribute" /> class with an <see cref="T:System.ComponentModel.EditorBrowsableState" />.</summary>
		/// <param name="state">The <see cref="T:System.ComponentModel.EditorBrowsableState" /> to set <see cref="P:System.ComponentModel.EditorBrowsableAttribute.State" /> to. </param>
		// Token: 0x06000F65 RID: 3941 RVA: 0x0004CFCA File Offset: 0x0004B1CA
		public EditorBrowsableAttribute(EditorBrowsableState state)
		{
			this.browsableState = state;
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.EditorBrowsableAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F66 RID: 3942 RVA: 0x0004CFDC File Offset: 0x0004B1DC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			EditorBrowsableAttribute editorBrowsableAttribute = obj as EditorBrowsableAttribute;
			return editorBrowsableAttribute != null && editorBrowsableAttribute.browsableState == this.browsableState;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F67 RID: 3943 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000BF8 RID: 3064
		private EditorBrowsableState browsableState;
	}
}
