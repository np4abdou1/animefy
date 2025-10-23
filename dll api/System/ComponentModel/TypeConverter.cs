using System;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Provides a unified way of converting types of values to other types, as well as for accessing standard values and subproperties.</summary>
	// Token: 0x020002A3 RID: 675
	[ComVisible(true)]
	public class TypeConverter
	{
		/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter.</summary>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001209 RID: 4617 RVA: 0x000561A2 File Offset: 0x000543A2
		public bool CanConvertFrom(Type sourceType)
		{
			return this.CanConvertFrom(null, sourceType);
		}

		/// <summary>Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600120A RID: 4618 RVA: 0x000561AC File Offset: 0x000543AC
		public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(InstanceDescriptor);
		}

		/// <summary>Returns whether this converter can convert the object to the specified type.</summary>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600120B RID: 4619 RVA: 0x000561C3 File Offset: 0x000543C3
		public bool CanConvertTo(Type destinationType)
		{
			return this.CanConvertTo(null, destinationType);
		}

		/// <summary>Returns whether this converter can convert the object to the specified type, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to. </param>
		/// <returns>
		///     <see langword="true" /> if this converter can perform the conversion; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600120C RID: 4620 RVA: 0x000561CD File Offset: 0x000543CD
		public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		/// <summary>Converts the given object to the type of this converter, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x0600120D RID: 4621 RVA: 0x000561E0 File Offset: 0x000543E0
		public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			InstanceDescriptor instanceDescriptor = value as InstanceDescriptor;
			if (instanceDescriptor != null)
			{
				return instanceDescriptor.Invoke();
			}
			throw this.GetConvertFromException(value);
		}

		/// <summary>Converts the given string to the type of this converter, using the invariant culture.</summary>
		/// <param name="text">The <see cref="T:System.String" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted text.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x0600120E RID: 4622 RVA: 0x00056205 File Offset: 0x00054405
		public object ConvertFromInvariantString(string text)
		{
			return this.ConvertFromString(null, CultureInfo.InvariantCulture, text);
		}

		/// <summary>Converts the given text to an object, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If <see langword="null" /> is passed, the current culture is assumed. </param>
		/// <param name="text">The <see cref="T:System.String" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted text.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x0600120F RID: 4623 RVA: 0x00056214 File Offset: 0x00054414
		public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
		{
			return this.ConvertFrom(context, culture, text);
		}

		/// <summary>Converts the given value object to the specified type, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If <see langword="null" /> is passed, the current culture is assumed. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06001210 RID: 4624 RVA: 0x00056220 File Offset: 0x00054420
		public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (!(destinationType == typeof(string)))
			{
				throw this.GetConvertToException(value, destinationType);
			}
			if (value == null)
			{
				return string.Empty;
			}
			if (culture != null && culture != CultureInfo.CurrentCulture)
			{
				IFormattable formattable = value as IFormattable;
				if (formattable != null)
				{
					return formattable.ToString(null, culture);
				}
			}
			return value.ToString();
		}

		/// <summary>Converts the specified value to a culture-invariant string representation.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>A <see cref="T:System.String" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06001211 RID: 4625 RVA: 0x0005628C File Offset: 0x0005448C
		public string ConvertToInvariantString(object value)
		{
			return this.ConvertToString(null, CultureInfo.InvariantCulture, value);
		}

		/// <summary>Converts the specified value to a culture-invariant string representation, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>A <see cref="T:System.String" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06001212 RID: 4626 RVA: 0x0005629B File Offset: 0x0005449B
		public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
		{
			return this.ConvertToString(context, CultureInfo.InvariantCulture, value);
		}

		/// <summary>Converts the specified value to a string representation.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06001213 RID: 4627 RVA: 0x000562AA File Offset: 0x000544AA
		public string ConvertToString(object value)
		{
			return (string)this.ConvertTo(null, CultureInfo.CurrentCulture, value, typeof(string));
		}

		/// <summary>Converts the given value to a string representation, using the specified context and culture information.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If <see langword="null" /> is passed, the current culture is assumed. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		// Token: 0x06001214 RID: 4628 RVA: 0x000562C8 File Offset: 0x000544C8
		public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return (string)this.ConvertTo(context, culture, value, typeof(string));
		}

		/// <summary>Returns an exception to throw when a conversion cannot be performed.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to convert, or <see langword="null" /> if the object is not available. </param>
		/// <returns>An <see cref="T:System.Exception" /> that represents the exception to throw when a conversion cannot be performed.</returns>
		/// <exception cref="T:System.NotSupportedException">Automatically thrown by this method. </exception>
		// Token: 0x06001215 RID: 4629 RVA: 0x000562E4 File Offset: 0x000544E4
		protected Exception GetConvertFromException(object value)
		{
			string text;
			if (value == null)
			{
				text = SR.GetString("(null)");
			}
			else
			{
				text = value.GetType().FullName;
			}
			throw new NotSupportedException(SR.GetString("{0} cannot convert from {1}.", new object[]
			{
				base.GetType().Name,
				text
			}));
		}

		/// <summary>Returns an exception to throw when a conversion cannot be performed.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to convert, or <see langword="null" /> if the object is not available. </param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type the conversion was trying to convert to. </param>
		/// <returns>An <see cref="T:System.Exception" /> that represents the exception to throw when a conversion cannot be performed.</returns>
		/// <exception cref="T:System.NotSupportedException">Automatically thrown by this method. </exception>
		// Token: 0x06001216 RID: 4630 RVA: 0x00056334 File Offset: 0x00054534
		protected Exception GetConvertToException(object value, Type destinationType)
		{
			string text;
			if (value == null)
			{
				text = SR.GetString("(null)");
			}
			else
			{
				text = value.GetType().FullName;
			}
			throw new NotSupportedException(SR.GetString("'{0}' is unable to convert '{1}' to '{2}'.", new object[]
			{
				base.GetType().Name,
				text,
				destinationType.FullName
			}));
		}

		/// <summary>Returns a collection of standard values for the data type this type converter is designed for when provided with a format context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context that can be used to extract additional information about the environment from which this converter is invoked. This parameter or properties of this parameter can be <see langword="null" />. </param>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values, or <see langword="null" /> if the data type does not support a standard set of values.</returns>
		// Token: 0x06001217 RID: 4631 RVA: 0x000022FE File Offset: 0x000004FE
		public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		/// <summary>Returns whether this object supports a standard set of values that can be picked from a list, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <returns>
		///     <see langword="true" /> if <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> should be called to find a common set of values the object supports; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001218 RID: 4632 RVA: 0x000023F6 File Offset: 0x000005F6
		public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Represents a collection of values.</summary>
		// Token: 0x020002A4 RID: 676
		[DefaultMember("Item")]
		public class StandardValuesCollection : ICollection, IEnumerable
		{
			/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> class.</summary>
			/// <param name="values">An <see cref="T:System.Collections.ICollection" /> that represents the objects to put into the collection. </param>
			// Token: 0x0600121A RID: 4634 RVA: 0x00056390 File Offset: 0x00054590
			public StandardValuesCollection(ICollection values)
			{
				if (values == null)
				{
					values = new object[0];
				}
				Array array = values as Array;
				if (array != null)
				{
					this.valueArray = array;
				}
				this.values = values;
			}

			/// <summary>Gets the number of objects in the collection.</summary>
			/// <returns>The number of objects in the collection.</returns>
			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x0600121B RID: 4635 RVA: 0x000563C6 File Offset: 0x000545C6
			public int Count
			{
				get
				{
					if (this.valueArray != null)
					{
						return this.valueArray.Length;
					}
					return this.values.Count;
				}
			}

			/// <summary>Copies the contents of this collection to an array.</summary>
			/// <param name="array">An <see cref="T:System.Array" /> that represents the array to copy to. </param>
			/// <param name="index">The index to start from. </param>
			// Token: 0x0600121C RID: 4636 RVA: 0x000563E7 File Offset: 0x000545E7
			public void CopyTo(Array array, int index)
			{
				this.values.CopyTo(array, index);
			}

			/// <summary>Returns an enumerator for this collection.</summary>
			/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
			// Token: 0x0600121D RID: 4637 RVA: 0x000563F6 File Offset: 0x000545F6
			public IEnumerator GetEnumerator()
			{
				return this.values.GetEnumerator();
			}

			/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.Count" />.</summary>
			/// <returns>The number of elements contained in the <see cref="T:System.Collections.ICollection" />.</returns>
			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x0600121E RID: 4638 RVA: 0x00056403 File Offset: 0x00054603
			int ICollection.Count
			{
				get
				{
					return this.Count;
				}
			}

			/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
			/// <returns>
			///     <see langword="false" /> in all cases.</returns>
			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x0600121F RID: 4639 RVA: 0x000023F6 File Offset: 0x000005F6
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
			/// <returns>
			///     <see langword="null" /> in all cases.</returns>
			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06001220 RID: 4640 RVA: 0x000022FE File Offset: 0x000004FE
			object ICollection.SyncRoot
			{
				get
				{
					return null;
				}
			}

			/// <summary>Copies the contents of this collection to an array.</summary>
			/// <param name="array">The array to copy to. </param>
			/// <param name="index">The index in the array where copying should begin. </param>
			// Token: 0x06001221 RID: 4641 RVA: 0x0005640B File Offset: 0x0005460B
			void ICollection.CopyTo(Array array, int index)
			{
				this.CopyTo(array, index);
			}

			/// <summary>For a description of this member, see <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
			/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
			// Token: 0x06001222 RID: 4642 RVA: 0x00056415 File Offset: 0x00054615
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000CE4 RID: 3300
			private ICollection values;

			// Token: 0x04000CE5 RID: 3301
			private Array valueArray;
		}
	}
}
