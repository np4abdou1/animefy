using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the default value for a property.</summary>
	// Token: 0x02000230 RID: 560
	[AttributeUsage(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 32-bit signed integer.</summary>
		/// <param name="value">A 32-bit signed integer that is the default value. </param>
		// Token: 0x06000F5D RID: 3933 RVA: 0x0004CF2C File Offset: 0x0004B12C
		public DefaultValueAttribute(int value)
		{
			this._value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 64-bit signed integer.</summary>
		/// <param name="value">A 64-bit signed integer that is the default value. </param>
		// Token: 0x06000F5E RID: 3934 RVA: 0x0004CF40 File Offset: 0x0004B140
		public DefaultValueAttribute(long value)
		{
			this._value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.Boolean" /> value.</summary>
		/// <param name="value">A <see cref="T:System.Boolean" /> that is the default value. </param>
		// Token: 0x06000F5F RID: 3935 RVA: 0x0004CF54 File Offset: 0x0004B154
		public DefaultValueAttribute(bool value)
		{
			this._value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.String" />.</summary>
		/// <param name="value">A <see cref="T:System.String" /> that is the default value. </param>
		// Token: 0x06000F60 RID: 3936 RVA: 0x0004CF68 File Offset: 0x0004B168
		public DefaultValueAttribute(string value)
		{
			this._value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that represents the default value. </param>
		// Token: 0x06000F61 RID: 3937 RVA: 0x0004CF68 File Offset: 0x0004B168
		public DefaultValueAttribute(object value)
		{
			this._value = value;
		}

		/// <summary>Gets the default value of the property this attribute is bound to.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the default value of the property this attribute is bound to.</returns>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004CF77 File Offset: 0x0004B177
		public virtual object Value
		{
			get
			{
				return this._value;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultValueAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F63 RID: 3939 RVA: 0x0004CF80 File Offset: 0x0004B180
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DefaultValueAttribute defaultValueAttribute = obj as DefaultValueAttribute;
			if (defaultValueAttribute == null)
			{
				return false;
			}
			if (this.Value != null)
			{
				return this.Value.Equals(defaultValueAttribute.Value);
			}
			return defaultValueAttribute.Value == null;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F64 RID: 3940 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000BF7 RID: 3063
		private object _value;
	}
}
