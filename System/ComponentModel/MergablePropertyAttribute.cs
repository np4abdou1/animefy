using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that this property can be combined with properties belonging to other objects in a Properties window.</summary>
	// Token: 0x02000244 RID: 580
	[AttributeUsage(AttributeTargets.All)]
	public sealed class MergablePropertyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MergablePropertyAttribute" /> class.</summary>
		/// <param name="allowMerge">
		///       <see langword="true" /> if this property can be combined with properties belonging to other objects in a Properties window; otherwise, <see langword="false" />. </param>
		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004D6E7 File Offset: 0x0004B8E7
		public MergablePropertyAttribute(bool allowMerge)
		{
			this.AllowMerge = allowMerge;
		}

		/// <summary>Gets a value indicating whether this property can be combined with properties belonging to other objects in a Properties window.</summary>
		/// <returns>
		///     <see langword="true" /> if this property can be combined with properties belonging to other objects in a Properties window; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0004D6F6 File Offset: 0x0004B8F6
		public bool AllowMerge { get; }

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <param name="obj">Another object to compare to. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FB4 RID: 4020 RVA: 0x0004D700 File Offset: 0x0004B900
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			MergablePropertyAttribute mergablePropertyAttribute = obj as MergablePropertyAttribute;
			bool? flag = (mergablePropertyAttribute != null) ? new bool?(mergablePropertyAttribute.AllowMerge) : null;
			bool allowMerge = this.AllowMerge;
			return flag.GetValueOrDefault() == allowMerge & flag != null;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.MergablePropertyAttribute" />.</returns>
		// Token: 0x06000FB5 RID: 4021 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FB6 RID: 4022 RVA: 0x0004D74C File Offset: 0x0004B94C
		public override bool IsDefaultAttribute()
		{
			return this.Equals(MergablePropertyAttribute.Default);
		}

		/// <summary>Specifies that a property can be combined with properties belonging to other objects in a Properties window. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C1F RID: 3103
		public static readonly MergablePropertyAttribute Yes = new MergablePropertyAttribute(true);

		/// <summary>Specifies that a property cannot be combined with properties belonging to other objects in a Properties window. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C20 RID: 3104
		public static readonly MergablePropertyAttribute No = new MergablePropertyAttribute(false);

		/// <summary>Specifies the default value, which is <see cref="F:System.ComponentModel.MergablePropertyAttribute.Yes" />, that is a property can be combined with properties belonging to other objects in a Properties window. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C21 RID: 3105
		public static readonly MergablePropertyAttribute Default = MergablePropertyAttribute.Yes;
	}
}
