using System;

namespace System.ComponentModel
{
	/// <summary>
	///     <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> marks a component's visibility. If <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Yes" /> is present, a visual designer can show this component on a designer.</summary>
	// Token: 0x0200025E RID: 606
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public sealed class DesignTimeVisibleAttribute : Attribute
	{
		/// <summary>Creates a new <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> with the <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" /> property set to the given value in <paramref name="visible" />.</summary>
		/// <param name="visible">The value that the <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" /> property will be set against. </param>
		// Token: 0x06001036 RID: 4150 RVA: 0x0004FA1C File Offset: 0x0004DC1C
		public DesignTimeVisibleAttribute(bool visible)
		{
			this.Visible = visible;
		}

		/// <summary>Gets or sets whether the component should be shown at design time.</summary>
		/// <returns>
		///     <see langword="true" /> if this component should be shown at design time, or <see langword="false" /> if it shouldn't.</returns>
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0004FA2B File Offset: 0x0004DC2B
		public bool Visible { get; }

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An Object to compare with this instance or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001038 RID: 4152 RVA: 0x0004FA34 File Offset: 0x0004DC34
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignTimeVisibleAttribute designTimeVisibleAttribute = obj as DesignTimeVisibleAttribute;
			return designTimeVisibleAttribute != null && designTimeVisibleAttribute.Visible == this.Visible;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06001039 RID: 4153 RVA: 0x0004FA61 File Offset: 0x0004DC61
		public override int GetHashCode()
		{
			return typeof(DesignTimeVisibleAttribute).GetHashCode() ^ (this.Visible ? -1 : 0);
		}

		/// <summary>Gets a value indicating if this instance is equal to the <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" /> value.</summary>
		/// <returns>
		///     <see langword="true" />, if this instance is equal to the <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" /> value; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600103A RID: 4154 RVA: 0x0004FA7F File Offset: 0x0004DC7F
		public override bool IsDefaultAttribute()
		{
			return this.Visible == DesignTimeVisibleAttribute.Default.Visible;
		}

		/// <summary>Marks a component as visible in a visual designer.</summary>
		// Token: 0x04000C47 RID: 3143
		public static readonly DesignTimeVisibleAttribute Yes = new DesignTimeVisibleAttribute(true);

		/// <summary>Marks a component as not visible in a visual designer.</summary>
		// Token: 0x04000C48 RID: 3144
		public static readonly DesignTimeVisibleAttribute No = new DesignTimeVisibleAttribute(false);

		/// <summary>The default visibility which is <see langword="Yes" />.</summary>
		// Token: 0x04000C49 RID: 3145
		public static readonly DesignTimeVisibleAttribute Default = DesignTimeVisibleAttribute.Yes;
	}
}
