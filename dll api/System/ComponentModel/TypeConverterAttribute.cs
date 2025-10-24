using System;

namespace System.ComponentModel
{
	/// <summary>Specifies what type to use as a converter for the object this attribute is bound to.</summary>
	// Token: 0x02000287 RID: 647
	[AttributeUsage(AttributeTargets.All)]
	public sealed class TypeConverterAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class with the default type converter, which is an empty string ("").</summary>
		// Token: 0x0600114E RID: 4430 RVA: 0x00051D6B File Offset: 0x0004FF6B
		public TypeConverterAttribute()
		{
			this.ConverterTypeName = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class, using the specified type as the data converter for the object this attribute is bound to.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of the converter class to use for data conversion for the object this attribute is bound to. </param>
		// Token: 0x0600114F RID: 4431 RVA: 0x00051D7E File Offset: 0x0004FF7E
		public TypeConverterAttribute(Type type)
		{
			this.ConverterTypeName = type.AssemblyQualifiedName;
		}

		/// <summary>Gets the fully qualified type name of the <see cref="T:System.Type" /> to use as a converter for the object this attribute is bound to.</summary>
		/// <returns>The fully qualified type name of the <see cref="T:System.Type" /> to use as a converter for the object this attribute is bound to, or an empty string ("") if none exists. The default value is an empty string ("").</returns>
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00051D92 File Offset: 0x0004FF92
		public string ConverterTypeName { get; }

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001151 RID: 4433 RVA: 0x00051D9C File Offset: 0x0004FF9C
		public override bool Equals(object obj)
		{
			TypeConverterAttribute typeConverterAttribute = obj as TypeConverterAttribute;
			return typeConverterAttribute != null && typeConverterAttribute.ConverterTypeName == this.ConverterTypeName;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</returns>
		// Token: 0x06001152 RID: 4434 RVA: 0x00051DC6 File Offset: 0x0004FFC6
		public override int GetHashCode()
		{
			return this.ConverterTypeName.GetHashCode();
		}

		/// <summary>Specifies the type to use as a converter for the object this attribute is bound to. </summary>
		// Token: 0x04000C95 RID: 3221
		public static readonly TypeConverterAttribute Default = new TypeConverterAttribute();
	}
}
