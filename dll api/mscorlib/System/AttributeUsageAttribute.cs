using System;

namespace System
{
	/// <summary>Specifies the usage of another attribute class. This class cannot be inherited.</summary>
	// Token: 0x02000083 RID: 131
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	[Serializable]
	public sealed class AttributeUsageAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.AttributeUsageAttribute" /> class with the specified list of <see cref="T:System.AttributeTargets" />, the <see cref="P:System.AttributeUsageAttribute.AllowMultiple" /> value, and the <see cref="P:System.AttributeUsageAttribute.Inherited" /> value.</summary>
		/// <param name="validOn">The set of values combined using a bitwise OR operation to indicate which program elements are valid. </param>
		// Token: 0x060002C2 RID: 706 RVA: 0x0000ED22 File Offset: 0x0000CF22
		public AttributeUsageAttribute(AttributeTargets validOn)
		{
			this._attributeTarget = validOn;
		}

		/// <summary>Gets or sets a Boolean value indicating whether more than one instance of the indicated attribute can be specified for a single program element.</summary>
		/// <returns>
		///     <see langword="true" /> if more than one instance is allowed to be specified; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000ED43 File Offset: 0x0000CF43
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000ED4B File Offset: 0x0000CF4B
		public bool AllowMultiple
		{
			get
			{
				return this._allowMultiple;
			}
			set
			{
				this._allowMultiple = value;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether the indicated attribute is inherited by derived classes and overriding members.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute can be inherited by derived classes and overriding members; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000ED54 File Offset: 0x0000CF54
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		public bool Inherited
		{
			get
			{
				return this._inherited;
			}
			set
			{
				this._inherited = value;
			}
		}

		// Token: 0x040001C5 RID: 453
		private AttributeTargets _attributeTarget = AttributeTargets.All;

		// Token: 0x040001C6 RID: 454
		private bool _allowMultiple;

		// Token: 0x040001C7 RID: 455
		private bool _inherited = true;

		// Token: 0x040001C8 RID: 456
		internal static AttributeUsageAttribute Default = new AttributeUsageAttribute(AttributeTargets.All);
	}
}
