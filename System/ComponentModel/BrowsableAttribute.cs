using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether a property or event should be displayed in a Properties window.</summary>
	// Token: 0x02000235 RID: 565
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BrowsableAttribute" /> class.</summary>
		/// <param name="browsable">
		///       <see langword="true" /> if a property or event can be modified at design time; otherwise, <see langword="false" />. The default is <see langword="true" />. </param>
		// Token: 0x06000F74 RID: 3956 RVA: 0x0004D150 File Offset: 0x0004B350
		public BrowsableAttribute(bool browsable)
		{
			this.Browsable = browsable;
		}

		/// <summary>Gets a value indicating whether an object is browsable.</summary>
		/// <returns>
		///     <see langword="true" /> if the object is browsable; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x0004D15F File Offset: 0x0004B35F
		public bool Browsable { get; }

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <param name="obj">Another object to compare to. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F76 RID: 3958 RVA: 0x0004D168 File Offset: 0x0004B368
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			BrowsableAttribute browsableAttribute = obj as BrowsableAttribute;
			bool? flag = (browsableAttribute != null) ? new bool?(browsableAttribute.Browsable) : null;
			bool browsable = this.Browsable;
			return flag.GetValueOrDefault() == browsable & flag != null;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F77 RID: 3959 RVA: 0x0004D1B4 File Offset: 0x0004B3B4
		public override int GetHashCode()
		{
			return this.Browsable.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F78 RID: 3960 RVA: 0x0004D1CF File Offset: 0x0004B3CF
		public override bool IsDefaultAttribute()
		{
			return this.Equals(BrowsableAttribute.Default);
		}

		/// <summary>Specifies that a property or event can be modified at design time. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C00 RID: 3072
		public static readonly BrowsableAttribute Yes = new BrowsableAttribute(true);

		/// <summary>Specifies that a property or event cannot be modified at design time. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C01 RID: 3073
		public static readonly BrowsableAttribute No = new BrowsableAttribute(false);

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.BrowsableAttribute" />, which is <see cref="F:System.ComponentModel.BrowsableAttribute.Yes" />. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C02 RID: 3074
		public static readonly BrowsableAttribute Default = BrowsableAttribute.Yes;
	}
}
