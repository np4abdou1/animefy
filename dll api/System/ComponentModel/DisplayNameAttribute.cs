using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the display name for a property, event, or public void method which takes no arguments. </summary>
	// Token: 0x0200023C RID: 572
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class DisplayNameAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DisplayNameAttribute" /> class.</summary>
		// Token: 0x06000F98 RID: 3992 RVA: 0x0004D53A File Offset: 0x0004B73A
		public DisplayNameAttribute() : this(string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DisplayNameAttribute" /> class using the display name.</summary>
		/// <param name="displayName">The display name.</param>
		// Token: 0x06000F99 RID: 3993 RVA: 0x0004D547 File Offset: 0x0004B747
		public DisplayNameAttribute(string displayName)
		{
			this.DisplayNameValue = displayName;
		}

		/// <summary>Gets the display name for a property, event, or public void method that takes no arguments stored in this attribute.</summary>
		/// <returns>The display name.</returns>
		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0004D556 File Offset: 0x0004B756
		public virtual string DisplayName
		{
			get
			{
				return this.DisplayNameValue;
			}
		}

		/// <summary>Gets or sets the display name.</summary>
		/// <returns>The display name.</returns>
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x0004D55E File Offset: 0x0004B75E
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x0004D566 File Offset: 0x0004B766
		protected string DisplayNameValue { get; set; }

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.DisplayNameAttribute" /> instances are equal.</summary>
		/// <param name="obj">The <see cref="T:System.ComponentModel.DisplayNameAttribute" /> to test the value equality of.</param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F9D RID: 3997 RVA: 0x0004D570 File Offset: 0x0004B770
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DisplayNameAttribute displayNameAttribute = obj as DisplayNameAttribute;
			return displayNameAttribute != null && displayNameAttribute.DisplayName == this.DisplayName;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.DisplayNameAttribute" />.</returns>
		// Token: 0x06000F9E RID: 3998 RVA: 0x0004D5A0 File Offset: 0x0004B7A0
		public override int GetHashCode()
		{
			return this.DisplayName.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F9F RID: 3999 RVA: 0x0004D5AD File Offset: 0x0004B7AD
		public override bool IsDefaultAttribute()
		{
			return this.Equals(DisplayNameAttribute.Default);
		}

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DisplayNameAttribute" />. This field is read-only.</summary>
		// Token: 0x04000C18 RID: 3096
		public static readonly DisplayNameAttribute Default = new DisplayNameAttribute();
	}
}
