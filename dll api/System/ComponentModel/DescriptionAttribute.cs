using System;

namespace System.ComponentModel
{
	/// <summary>Specifies a description for a property or event.</summary>
	// Token: 0x02000237 RID: 567
	[AttributeUsage(AttributeTargets.All)]
	public class DescriptionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DescriptionAttribute" /> class with no parameters.</summary>
		// Token: 0x06000F7B RID: 3963 RVA: 0x0004D288 File Offset: 0x0004B488
		public DescriptionAttribute() : this(string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DescriptionAttribute" /> class with a description.</summary>
		/// <param name="description">The description text. </param>
		// Token: 0x06000F7C RID: 3964 RVA: 0x0004D295 File Offset: 0x0004B495
		public DescriptionAttribute(string description)
		{
			this.DescriptionValue = description;
		}

		/// <summary>Gets the description stored in this attribute.</summary>
		/// <returns>The description stored in this attribute.</returns>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x0004D2A4 File Offset: 0x0004B4A4
		public virtual string Description
		{
			get
			{
				return this.DescriptionValue;
			}
		}

		/// <summary>Gets or sets the string stored as the description.</summary>
		/// <returns>The string stored as the description. The default value is an empty string ("").</returns>
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x0004D2B4 File Offset: 0x0004B4B4
		protected string DescriptionValue { get; set; }

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DescriptionAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F80 RID: 3968 RVA: 0x0004D2C0 File Offset: 0x0004B4C0
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DescriptionAttribute descriptionAttribute = obj as DescriptionAttribute;
			return descriptionAttribute != null && descriptionAttribute.Description == this.Description;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F81 RID: 3969 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
		public override int GetHashCode()
		{
			return this.Description.GetHashCode();
		}

		/// <summary>Returns a value indicating whether this is the default <see cref="T:System.ComponentModel.DescriptionAttribute" /> instance.</summary>
		/// <returns>
		///     <see langword="true" />, if this is the default <see cref="T:System.ComponentModel.DescriptionAttribute" /> instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F82 RID: 3970 RVA: 0x0004D2FD File Offset: 0x0004B4FD
		public override bool IsDefaultAttribute()
		{
			return this.Equals(DescriptionAttribute.Default);
		}

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DescriptionAttribute" />, which is an empty string (""). This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C04 RID: 3076
		public static readonly DescriptionAttribute Default = new DescriptionAttribute();
	}
}
