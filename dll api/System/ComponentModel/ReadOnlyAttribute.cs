using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether the property this attribute is bound to is read-only or read/write. This class cannot be inherited</summary>
	// Token: 0x02000245 RID: 581
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ReadOnlyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ReadOnlyAttribute" /> class.</summary>
		/// <param name="isReadOnly">
		///       <see langword="true" /> to show that the property this attribute is bound to is read-only; <see langword="false" /> to show that the property is read/write. </param>
		// Token: 0x06000FB8 RID: 4024 RVA: 0x0004D77B File Offset: 0x0004B97B
		public ReadOnlyAttribute(bool isReadOnly)
		{
			this.IsReadOnly = isReadOnly;
		}

		/// <summary>Gets a value indicating whether the property this attribute is bound to is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the property this attribute is bound to is read-only; <see langword="false" /> if the property is read/write.</returns>
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0004D78A File Offset: 0x0004B98A
		public bool IsReadOnly { get; }

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <param name="value">Another object to compare to. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FBA RID: 4026 RVA: 0x0004D794 File Offset: 0x0004B994
		public override bool Equals(object value)
		{
			if (this == value)
			{
				return true;
			}
			ReadOnlyAttribute readOnlyAttribute = value as ReadOnlyAttribute;
			bool? flag = (readOnlyAttribute != null) ? new bool?(readOnlyAttribute.IsReadOnly) : null;
			bool isReadOnly = this.IsReadOnly;
			return flag.GetValueOrDefault() == isReadOnly & flag != null;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ReadOnlyAttribute" />.</returns>
		// Token: 0x06000FBB RID: 4027 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FBC RID: 4028 RVA: 0x0004D7E0 File Offset: 0x0004B9E0
		public override bool IsDefaultAttribute()
		{
			return this.IsReadOnly == ReadOnlyAttribute.Default.IsReadOnly;
		}

		/// <summary>Specifies that the property this attribute is bound to is read-only and cannot be modified in the server explorer. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C23 RID: 3107
		public static readonly ReadOnlyAttribute Yes = new ReadOnlyAttribute(true);

		/// <summary>Specifies that the property this attribute is bound to is read/write and can be modified. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C24 RID: 3108
		public static readonly ReadOnlyAttribute No = new ReadOnlyAttribute(false);

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.ReadOnlyAttribute" />, which is <see cref="F:System.ComponentModel.ReadOnlyAttribute.No" /> (that is, the property this attribute is bound to is read/write). This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C25 RID: 3109
		public static readonly ReadOnlyAttribute Default = ReadOnlyAttribute.No;
	}
}
