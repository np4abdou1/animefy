using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.Enum" /> objects to and from various other representations.</summary>
	// Token: 0x0200029C RID: 668
	public class EnumConverter : TypeConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EnumConverter" /> class for the given type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of enumeration to associate with this enumeration converter. </param>
		// Token: 0x06001199 RID: 4505 RVA: 0x000525DC File Offset: 0x000507DC
		public EnumConverter(Type type)
		{
			this.type = type;
		}

		/// <summary>Gets a value indicating whether this converter can convert an object in the given source type to an enumeration object using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you wish to convert from. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600119A RID: 4506 RVA: 0x000525EB File Offset: 0x000507EB
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || sourceType == typeof(Enum[]) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Gets a value indicating whether this converter can convert an object to the given destination type using the context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you wish to convert to. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600119B RID: 4507 RVA: 0x0005261B File Offset: 0x0005081B
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || destinationType == typeof(Enum[]) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Gets an <see cref="T:System.Collections.IComparer" /> that can be used to sort the values of the enumeration.</summary>
		/// <returns>An <see cref="T:System.Collections.IComparer" /> for sorting the enumeration values.</returns>
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0005264B File Offset: 0x0005084B
		protected virtual IComparer Comparer
		{
			get
			{
				return InvariantComparer.Default;
			}
		}

		/// <summary>Converts the specified value object to an enumeration object.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current culture is assumed. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="value" /> is not a valid value for the target type. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x0600119D RID: 4509 RVA: 0x00052654 File Offset: 0x00050854
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				try
				{
					string text = (string)value;
					if (text.IndexOf(',') != -1)
					{
						long num = 0L;
						foreach (string value2 in text.Split(new char[]
						{
							','
						}))
						{
							num |= Convert.ToInt64((Enum)Enum.Parse(this.type, value2, true), culture);
						}
						return Enum.ToObject(this.type, num);
					}
					return Enum.Parse(this.type, text, true);
				}
				catch (Exception innerException)
				{
					throw new FormatException(SR.GetString("{0} is not a valid value for {1}.", new object[]
					{
						(string)value,
						this.type.Name
					}), innerException);
				}
			}
			if (value is Enum[])
			{
				long num2 = 0L;
				foreach (Enum value3 in (Enum[])value)
				{
					num2 |= Convert.ToInt64(value3, culture);
				}
				return Enum.ToObject(this.type, num2);
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Converts the given value object to the specified destination type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current culture is assumed. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destinationType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a valid value for the enumeration. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x0600119E RID: 4510 RVA: 0x00052778 File Offset: 0x00050978
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value != null)
			{
				Type underlyingType = Enum.GetUnderlyingType(this.type);
				if (value is IConvertible && value.GetType() != underlyingType)
				{
					value = ((IConvertible)value).ToType(underlyingType, culture);
				}
				if (!this.type.IsDefined(typeof(FlagsAttribute), false) && !Enum.IsDefined(this.type, value))
				{
					throw new ArgumentException(SR.GetString("The value '{0}' is not a valid value for the enum '{1}'.", new object[]
					{
						value.ToString(),
						this.type.Name
					}));
				}
				return Enum.Format(this.type, value, "G");
			}
			else
			{
				if (destinationType == typeof(InstanceDescriptor) && value != null)
				{
					string text = base.ConvertToInvariantString(context, value);
					if (this.type.IsDefined(typeof(FlagsAttribute), false) && text.IndexOf(',') != -1)
					{
						Type underlyingType2 = Enum.GetUnderlyingType(this.type);
						if (value is IConvertible)
						{
							object obj = ((IConvertible)value).ToType(underlyingType2, culture);
							MethodInfo method = typeof(Enum).GetMethod("ToObject", new Type[]
							{
								typeof(Type),
								underlyingType2
							});
							if (method != null)
							{
								return new InstanceDescriptor(method, new object[]
								{
									this.type,
									obj
								});
							}
						}
					}
					else
					{
						FieldInfo field = this.type.GetField(text);
						if (field != null)
						{
							return new InstanceDescriptor(field, null);
						}
					}
				}
				if (!(destinationType == typeof(Enum[])) || value == null)
				{
					return base.ConvertTo(context, culture, value, destinationType);
				}
				if (this.type.IsDefined(typeof(FlagsAttribute), false))
				{
					List<Enum> list = new List<Enum>();
					Array array = Enum.GetValues(this.type);
					long[] array2 = new long[array.Length];
					for (int i = 0; i < array.Length; i++)
					{
						array2[i] = Convert.ToInt64((Enum)array.GetValue(i), culture);
					}
					long num = Convert.ToInt64((Enum)value, culture);
					bool flag = true;
					while (flag)
					{
						flag = false;
						foreach (long num2 in array2)
						{
							if ((num2 != 0L && (num2 & num) == num2) || num2 == num)
							{
								list.Add((Enum)Enum.ToObject(this.type, num2));
								flag = true;
								num &= ~num2;
								break;
							}
						}
						if (num == 0L)
						{
							break;
						}
					}
					if (!flag && num != 0L)
					{
						list.Add((Enum)Enum.ToObject(this.type, num));
					}
					return list.ToArray();
				}
				return new Enum[]
				{
					(Enum)Enum.ToObject(this.type, value)
				};
			}
		}

		/// <summary>Gets a collection of standard values for the data type this validator is designed for.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values, or <see langword="null" /> if the data type does not support a standard set of values.</returns>
		// Token: 0x0600119F RID: 4511 RVA: 0x00052A7C File Offset: 0x00050C7C
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (this.values == null)
			{
				Type reflectionType = TypeDescriptor.GetReflectionType(this.type);
				if (reflectionType == null)
				{
					reflectionType = this.type;
				}
				FieldInfo[] fields = reflectionType.GetFields(BindingFlags.Static | BindingFlags.Public);
				ArrayList arrayList = null;
				if (fields != null && fields.Length != 0)
				{
					arrayList = new ArrayList(fields.Length);
				}
				if (arrayList != null)
				{
					foreach (FieldInfo fieldInfo in fields)
					{
						BrowsableAttribute browsableAttribute = null;
						object[] customAttributes = fieldInfo.GetCustomAttributes(typeof(BrowsableAttribute), false);
						for (int j = 0; j < customAttributes.Length; j++)
						{
							browsableAttribute = (((Attribute)customAttributes[j]) as BrowsableAttribute);
						}
						if (browsableAttribute == null || browsableAttribute.Browsable)
						{
							object obj = null;
							try
							{
								if (fieldInfo.Name != null)
								{
									obj = Enum.Parse(this.type, fieldInfo.Name);
								}
							}
							catch (ArgumentException)
							{
							}
							if (obj != null)
							{
								arrayList.Add(obj);
							}
						}
					}
					IComparer comparer = this.Comparer;
					if (comparer != null)
					{
						arrayList.Sort(comparer);
					}
				}
				Array array2 = (arrayList != null) ? arrayList.ToArray() : null;
				this.values = new TypeConverter.StandardValuesCollection(array2);
			}
			return this.values;
		}

		/// <summary>Gets a value indicating whether this object supports a standard set of values that can be picked from a list using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <returns>
		///     <see langword="true" /> because <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> should be called to find a common set of values the object supports. This method never returns <see langword="false" />.</returns>
		// Token: 0x060011A0 RID: 4512 RVA: 0x00009518 File Offset: 0x00007718
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x04000CA2 RID: 3234
		private TypeConverter.StandardValuesCollection values;

		// Token: 0x04000CA3 RID: 3235
		private Type type;
	}
}
