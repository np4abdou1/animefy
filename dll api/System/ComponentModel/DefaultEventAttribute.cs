using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the default event for a component.</summary>
	// Token: 0x0200025A RID: 602
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultEventAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultEventAttribute" /> class.</summary>
		/// <param name="name">The name of the default event for the component this attribute is bound to. </param>
		// Token: 0x0600101D RID: 4125 RVA: 0x0004F849 File Offset: 0x0004DA49
		public DefaultEventAttribute(string name)
		{
			this.Name = name;
		}

		/// <summary>Gets the name of the default event for the component this attribute is bound to.</summary>
		/// <returns>The name of the default event for the component this attribute is bound to. The default value is <see langword="null" />.</returns>
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0004F858 File Offset: 0x0004DA58
		public string Name { get; }

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultEventAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600101F RID: 4127 RVA: 0x0004F860 File Offset: 0x0004DA60
		public override bool Equals(object obj)
		{
			DefaultEventAttribute defaultEventAttribute = obj as DefaultEventAttribute;
			return defaultEventAttribute != null && defaultEventAttribute.Name == this.Name;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06001020 RID: 4128 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DefaultEventAttribute" />, which is <see langword="null" />. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C3F RID: 3135
		public static readonly DefaultEventAttribute Default = new DefaultEventAttribute(null);
	}
}
