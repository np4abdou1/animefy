using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the type of persistence to use when serializing a property on a component at design time.</summary>
	// Token: 0x0200023B RID: 571
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerSerializationVisibilityAttribute" /> class using the specified <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> value.</summary>
		/// <param name="visibility">One of the <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> values. </param>
		// Token: 0x06000F92 RID: 3986 RVA: 0x0004D49D File Offset: 0x0004B69D
		public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
		{
			this.Visibility = visibility;
		}

		/// <summary>Gets a value indicating the basic serialization mode a serializer should use when determining whether and how to persist the value of a property.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> values. The default is <see cref="F:System.ComponentModel.DesignerSerializationVisibility.Visible" />.</returns>
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x0004D4AC File Offset: 0x0004B6AC
		public DesignerSerializationVisibility Visibility { get; }

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <param name="obj">Another object to compare to. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F94 RID: 3988 RVA: 0x0004D4B4 File Offset: 0x0004B6B4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignerSerializationVisibilityAttribute designerSerializationVisibilityAttribute = obj as DesignerSerializationVisibilityAttribute;
			DesignerSerializationVisibility? designerSerializationVisibility = (designerSerializationVisibilityAttribute != null) ? new DesignerSerializationVisibility?(designerSerializationVisibilityAttribute.Visibility) : null;
			DesignerSerializationVisibility visibility = this.Visibility;
			return designerSerializationVisibility.GetValueOrDefault() == visibility & designerSerializationVisibility != null;
		}

		/// <summary>Returns the hash code for this object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F95 RID: 3989 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute is set to the default value; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F96 RID: 3990 RVA: 0x0004D500 File Offset: 0x0004B700
		public override bool IsDefaultAttribute()
		{
			return this.Equals(DesignerSerializationVisibilityAttribute.Default);
		}

		/// <summary>Specifies that a serializer should serialize the contents of the property, rather than the property itself. This field is read-only.</summary>
		// Token: 0x04000C13 RID: 3091
		public static readonly DesignerSerializationVisibilityAttribute Content = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content);

		/// <summary>Specifies that a serializer should not serialize the value of the property. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C14 RID: 3092
		public static readonly DesignerSerializationVisibilityAttribute Hidden = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden);

		/// <summary>Specifies that a serializer should be allowed to serialize the value of the property. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C15 RID: 3093
		public static readonly DesignerSerializationVisibilityAttribute Visible = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible);

		/// <summary>Specifies the default value, which is <see cref="F:System.ComponentModel.DesignerSerializationVisibilityAttribute.Visible" />, that is, a visual designer uses default rules to generate the value of a property. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C16 RID: 3094
		public static readonly DesignerSerializationVisibilityAttribute Default = DesignerSerializationVisibilityAttribute.Visible;
	}
}
