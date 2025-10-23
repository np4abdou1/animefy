using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that the designer for a class belongs to a certain category.</summary>
	// Token: 0x02000239 RID: 569
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class DesignerCategoryAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerCategoryAttribute" /> class with an empty string ("").</summary>
		// Token: 0x06000F8A RID: 3978 RVA: 0x0004D3CD File Offset: 0x0004B5CD
		public DesignerCategoryAttribute()
		{
			this.Category = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerCategoryAttribute" /> class with the given category name.</summary>
		/// <param name="category">The name of the category. </param>
		// Token: 0x06000F8B RID: 3979 RVA: 0x0004D3E0 File Offset: 0x0004B5E0
		public DesignerCategoryAttribute(string category)
		{
			this.Category = category;
		}

		/// <summary>Gets the name of the category.</summary>
		/// <returns>The name of the category.</returns>
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0004D3EF File Offset: 0x0004B5EF
		public string Category { get; }

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F8D RID: 3981 RVA: 0x0004D3F8 File Offset: 0x0004B5F8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignerCategoryAttribute designerCategoryAttribute = obj as DesignerCategoryAttribute;
			return designerCategoryAttribute != null && designerCategoryAttribute.Category == this.Category;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F8E RID: 3982 RVA: 0x0004D428 File Offset: 0x0004B628
		public override int GetHashCode()
		{
			return this.Category.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F8F RID: 3983 RVA: 0x0004D435 File Offset: 0x0004B635
		public override bool IsDefaultAttribute()
		{
			return this.Category.Equals(DesignerCategoryAttribute.Default.Category);
		}

		/// <summary>Gets a unique identifier for this attribute.</summary>
		/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0004D44C File Offset: 0x0004B64C
		public override object TypeId
		{
			get
			{
				return base.GetType().FullName + this.Category;
			}
		}

		/// <summary>Specifies that a component marked with this category use a component designer. This field is read-only.</summary>
		// Token: 0x04000C0A RID: 3082
		public static readonly DesignerCategoryAttribute Component = new DesignerCategoryAttribute("Component");

		/// <summary>Specifies that a component marked with this category cannot use a visual designer. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C0B RID: 3083
		public static readonly DesignerCategoryAttribute Default = new DesignerCategoryAttribute();

		/// <summary>Specifies that a component marked with this category use a form designer. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C0C RID: 3084
		public static readonly DesignerCategoryAttribute Form = new DesignerCategoryAttribute("Form");

		/// <summary>Specifies that a component marked with this category use a generic designer. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C0D RID: 3085
		public static readonly DesignerCategoryAttribute Generic = new DesignerCategoryAttribute("Designer");
	}
}
