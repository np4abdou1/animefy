using System;

namespace System.ComponentModel
{
	/// <summary>Indicates that the property grid should refresh when the associated property value changes. This class cannot be inherited.</summary>
	// Token: 0x020002B2 RID: 690
	[AttributeUsage(AttributeTargets.All)]
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshPropertiesAttribute" /> class.</summary>
		/// <param name="refresh">A <see cref="T:System.ComponentModel.RefreshProperties" /> value indicating the nature of the refresh.</param>
		// Token: 0x06001287 RID: 4743 RVA: 0x0005926E File Offset: 0x0005746E
		public RefreshPropertiesAttribute(RefreshProperties refresh)
		{
			this.refresh = refresh;
		}

		/// <summary>Gets the refresh properties for the member.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.RefreshProperties" /> that indicates the current refresh properties for the member.</returns>
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0005927D File Offset: 0x0005747D
		public RefreshProperties RefreshProperties
		{
			get
			{
				return this.refresh;
			}
		}

		/// <summary>Overrides the object's <see cref="Overload:System.Object.Equals" /> method.</summary>
		/// <param name="value">The object to test for equality. </param>
		/// <returns>
		///     <see langword="true" /> if the specified object is the same; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001289 RID: 4745 RVA: 0x00059285 File Offset: 0x00057485
		public override bool Equals(object value)
		{
			return value is RefreshPropertiesAttribute && ((RefreshPropertiesAttribute)value).RefreshProperties == this.refresh;
		}

		/// <summary>Returns the hash code for this object.</summary>
		/// <returns>The hash code for the object that the attribute belongs to.</returns>
		// Token: 0x0600128A RID: 4746 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if the current value of the attribute is the default; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600128B RID: 4747 RVA: 0x000592A4 File Offset: 0x000574A4
		public override bool IsDefaultAttribute()
		{
			return this.Equals(RefreshPropertiesAttribute.Default);
		}

		/// <summary>Indicates that all properties are queried again and refreshed if the property value is changed. This field is read-only.</summary>
		// Token: 0x04000D06 RID: 3334
		public static readonly RefreshPropertiesAttribute All = new RefreshPropertiesAttribute(RefreshProperties.All);

		/// <summary>Indicates that all properties are repainted if the property value is changed. This field is read-only.</summary>
		// Token: 0x04000D07 RID: 3335
		public static readonly RefreshPropertiesAttribute Repaint = new RefreshPropertiesAttribute(RefreshProperties.Repaint);

		/// <summary>Indicates that no other properties are refreshed if the property value is changed. This field is read-only.</summary>
		// Token: 0x04000D08 RID: 3336
		public static readonly RefreshPropertiesAttribute Default = new RefreshPropertiesAttribute(RefreshProperties.None);

		// Token: 0x04000D09 RID: 3337
		private RefreshProperties refresh;
	}
}
