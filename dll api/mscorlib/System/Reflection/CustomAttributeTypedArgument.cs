using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Represents an argument of a custom attribute in the reflection-only context, or an element of an array argument.</summary>
	// Token: 0x020004C8 RID: 1224
	public struct CustomAttributeTypedArgument
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> class with the specified type and value.</summary>
		/// <param name="argumentType">The type of the custom attribute argument.</param>
		/// <param name="value">The value of the custom attribute argument.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="argumentType" /> is <see langword="null" />.</exception>
		// Token: 0x06002298 RID: 8856 RVA: 0x0008B5A8 File Offset: 0x000897A8
		public CustomAttributeTypedArgument(Type argumentType, object value)
		{
			if (argumentType == null)
			{
				throw new ArgumentNullException("argumentType");
			}
			this.Value = ((value == null) ? null : CustomAttributeTypedArgument.CanonicalizeValue(value));
			this.ArgumentType = argumentType;
			Array array = value as Array;
			if (array != null)
			{
				Type elementType = array.GetType().GetElementType();
				CustomAttributeTypedArgument[] array2 = new CustomAttributeTypedArgument[array.GetLength(0)];
				for (int i = 0; i < array2.Length; i++)
				{
					object value2 = array.GetValue(i);
					Type argumentType2 = (elementType == typeof(object) && value2 != null) ? value2.GetType() : elementType;
					array2[i] = new CustomAttributeTypedArgument(argumentType2, value2);
				}
				this.Value = new ReadOnlyCollection<CustomAttributeTypedArgument>(array2);
			}
		}

		/// <summary>Gets the type of the argument or of the array argument element.</summary>
		/// <returns>A <see cref="T:System.Type" /> object representing the type of the argument or of the array element.</returns>
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x0008B65A File Offset: 0x0008985A
		public readonly Type ArgumentType { get; }

		/// <summary>Gets the value of the argument for a simple argument or for an element of an array argument; gets a collection of values for an array argument.</summary>
		/// <returns>An object that represents the value of the argument or element, or a generic <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> objects that represent the values of an array-type argument.</returns>
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0008B662 File Offset: 0x00089862
		public readonly object Value { get; }

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <param name="obj">Another object to compare to. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600229B RID: 8859 RVA: 0x0008B66A File Offset: 0x0008986A
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
		// Token: 0x0600229C RID: 8860 RVA: 0x0008B67A File Offset: 0x0008987A
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Returns a string consisting of the argument name, the equal sign, and a string representation of the argument value.</summary>
		/// <returns>A string consisting of the argument name, the equal sign, and a string representation of the argument value.</returns>
		// Token: 0x0600229D RID: 8861 RVA: 0x0008B68C File Offset: 0x0008988C
		public override string ToString()
		{
			return this.ToString(false);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0008B698 File Offset: 0x00089898
		internal string ToString(bool typed)
		{
			if (this.ArgumentType == null)
			{
				return base.ToString();
			}
			string result;
			try
			{
				if (this.ArgumentType.IsEnum)
				{
					result = string.Format(CultureInfo.CurrentCulture, typed ? "{0}" : "({1}){0}", this.Value, this.ArgumentType.FullNameOrDefault);
				}
				else if (this.Value == null)
				{
					result = string.Format(CultureInfo.CurrentCulture, typed ? "null" : "({0})null", this.ArgumentType.NameOrDefault);
				}
				else if (this.ArgumentType == typeof(string))
				{
					result = string.Format(CultureInfo.CurrentCulture, "\"{0}\"", this.Value);
				}
				else if (this.ArgumentType == typeof(char))
				{
					result = string.Format(CultureInfo.CurrentCulture, "'{0}'", this.Value);
				}
				else if (this.ArgumentType == typeof(Type))
				{
					result = string.Format(CultureInfo.CurrentCulture, "typeof({0})", ((Type)this.Value).FullNameOrDefault);
				}
				else if (this.ArgumentType.IsArray)
				{
					IList<CustomAttributeTypedArgument> list = this.Value as IList<CustomAttributeTypedArgument>;
					Type elementType = this.ArgumentType.GetElementType();
					string str = string.Format(CultureInfo.CurrentCulture, "new {0}[{1}] {{ ", elementType.IsEnum ? elementType.FullNameOrDefault : elementType.NameOrDefault, list.Count);
					for (int i = 0; i < list.Count; i++)
					{
						str += string.Format(CultureInfo.CurrentCulture, (i == 0) ? "{0}" : ", {0}", list[i].ToString(elementType != typeof(object)));
					}
					result = str + " }";
				}
				else
				{
					result = string.Format(CultureInfo.CurrentCulture, typed ? "{0}" : "({1}){0}", this.Value, this.ArgumentType.NameOrDefault);
				}
			}
			catch (MissingMetadataException)
			{
				result = base.ToString();
			}
			return result;
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0008B8F4 File Offset: 0x00089AF4
		private static object CanonicalizeValue(object value)
		{
			if (value.GetType().IsEnum)
			{
				return ((Enum)value).GetValue();
			}
			return value;
		}
	}
}
