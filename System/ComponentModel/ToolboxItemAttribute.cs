using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Represents an attribute of a toolbox item.</summary>
	// Token: 0x0200025D RID: 605
	[AttributeUsage(AttributeTargets.All)]
	public class ToolboxItemAttribute : Attribute
	{
		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if the current value of the attribute is the default; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600102F RID: 4143 RVA: 0x0004F95D File Offset: 0x0004DB5D
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ToolboxItemAttribute.Default);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and specifies whether to use default initialization values.</summary>
		/// <param name="defaultType">
		///       <see langword="true" /> to create a toolbox item attribute for a default type; <see langword="false" /> to associate no default toolbox item support for this attribute. </param>
		// Token: 0x06001030 RID: 4144 RVA: 0x0004F96A File Offset: 0x0004DB6A
		public ToolboxItemAttribute(bool defaultType)
		{
			if (defaultType)
			{
				this._toolboxItemTypeName = "System.Drawing.Design.ToolboxItem, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class using the specified name of the type.</summary>
		/// <param name="toolboxItemTypeName">The names of the type of the toolbox item and of the assembly that contains the type. </param>
		// Token: 0x06001031 RID: 4145 RVA: 0x0004F980 File Offset: 0x0004DB80
		public ToolboxItemAttribute(string toolboxItemTypeName)
		{
			toolboxItemTypeName.ToUpper(CultureInfo.InvariantCulture);
			this._toolboxItemTypeName = toolboxItemTypeName;
		}

		/// <summary>Gets or sets the name of the type of the current <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>The fully qualified type name of the current toolbox item.</returns>
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0004F99B File Offset: 0x0004DB9B
		public string ToolboxItemTypeName
		{
			get
			{
				if (this._toolboxItemTypeName == null)
				{
					return string.Empty;
				}
				return this._toolboxItemTypeName;
			}
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001033 RID: 4147 RVA: 0x0004F9B4 File Offset: 0x0004DBB4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ToolboxItemAttribute toolboxItemAttribute = obj as ToolboxItemAttribute;
			return toolboxItemAttribute != null && toolboxItemAttribute.ToolboxItemTypeName == this.ToolboxItemTypeName;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06001034 RID: 4148 RVA: 0x0004F9E4 File Offset: 0x0004DBE4
		public override int GetHashCode()
		{
			if (this._toolboxItemTypeName != null)
			{
				return this._toolboxItemTypeName.GetHashCode();
			}
			return base.GetHashCode();
		}

		// Token: 0x04000C43 RID: 3139
		private string _toolboxItemTypeName;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and sets the type to the default, <see cref="T:System.Drawing.Design.ToolboxItem" />. This field is read-only.</summary>
		// Token: 0x04000C44 RID: 3140
		public static readonly ToolboxItemAttribute Default = new ToolboxItemAttribute("System.Drawing.Design.ToolboxItem, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and sets the type to <see langword="null" />. This field is read-only.</summary>
		// Token: 0x04000C45 RID: 3141
		public static readonly ToolboxItemAttribute None = new ToolboxItemAttribute(false);
	}
}
