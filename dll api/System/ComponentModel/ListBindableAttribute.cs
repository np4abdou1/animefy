using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that a list can be used as a data source. A visual designer should use this attribute to determine whether to display a particular list in a data-binding picker. This class cannot be inherited.</summary>
	// Token: 0x02000273 RID: 627
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ListBindableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListBindableAttribute" /> class using a value to indicate whether the list is bindable.</summary>
		/// <param name="listBindable">
		///       <see langword="true" /> if the list is bindable; otherwise, <see langword="false" />. </param>
		// Token: 0x060010B9 RID: 4281 RVA: 0x0005049D File Offset: 0x0004E69D
		public ListBindableAttribute(bool listBindable)
		{
			this.ListBindable = listBindable;
		}

		/// <summary>Gets whether the list is bindable.</summary>
		/// <returns>
		///     <see langword="true" /> if the list is bindable; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x000504AC File Offset: 0x0004E6AC
		public bool ListBindable { get; }

		/// <summary>Returns whether the object passed is equal to this <see cref="T:System.ComponentModel.ListBindableAttribute" />.</summary>
		/// <param name="obj">The object to test equality with. </param>
		/// <returns>
		///     <see langword="true" /> if the object passed is equal to this <see cref="T:System.ComponentModel.ListBindableAttribute" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010BB RID: 4283 RVA: 0x000504B4 File Offset: 0x0004E6B4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ListBindableAttribute listBindableAttribute = obj as ListBindableAttribute;
			return listBindableAttribute != null && listBindableAttribute.ListBindable == this.ListBindable;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ListBindableAttribute" />.</returns>
		// Token: 0x060010BC RID: 4284 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Returns whether <see cref="P:System.ComponentModel.ListBindableAttribute.ListBindable" /> is set to the default value.</summary>
		/// <returns>
		///     <see langword="true" /> if <see cref="P:System.ComponentModel.ListBindableAttribute.ListBindable" /> is set to the default value; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010BD RID: 4285 RVA: 0x000504E1 File Offset: 0x0004E6E1
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ListBindableAttribute.Default) || this._isDefault;
		}

		/// <summary>Specifies that the list is bindable. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C5C RID: 3164
		public static readonly ListBindableAttribute Yes = new ListBindableAttribute(true);

		/// <summary>Specifies that the list is not bindable. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C5D RID: 3165
		public static readonly ListBindableAttribute No = new ListBindableAttribute(false);

		/// <summary>Represents the default value for <see cref="T:System.ComponentModel.ListBindableAttribute" />.</summary>
		// Token: 0x04000C5E RID: 3166
		public static readonly ListBindableAttribute Default = ListBindableAttribute.Yes;

		// Token: 0x04000C5F RID: 3167
		private bool _isDefault;
	}
}
