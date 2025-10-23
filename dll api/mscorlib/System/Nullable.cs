using System;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Represents a value type that can be assigned <see langword="null" />.</summary>
	/// <typeparam name="T">The underlying value type of the <see cref="T:System.Nullable`1" /> generic type.</typeparam>
	// Token: 0x020000DE RID: 222
	[NonVersionable]
	[Serializable]
	public struct Nullable<T> where T : struct
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Nullable`1" /> structure to the specified value. </summary>
		/// <param name="value">A value type.</param>
		// Token: 0x0600073B RID: 1851 RVA: 0x0001E0EF File Offset: 0x0001C2EF
		[NonVersionable]
		public Nullable(T value)
		{
			this.value = value;
			this.hasValue = true;
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Nullable`1" /> object has a valid value of its underlying type. </summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Nullable`1" /> object has a value; <see langword="false" /> if the current <see cref="T:System.Nullable`1" /> object has no value.</returns>
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001E0FF File Offset: 0x0001C2FF
		public bool HasValue
		{
			[NonVersionable]
			get
			{
				return this.hasValue;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.Nullable`1" /> object if it has been assigned a valid underlying value.</summary>
		/// <returns>The value of the current <see cref="T:System.Nullable`1" /> object if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />. An exception is thrown if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</exception>
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0001E107 File Offset: 0x0001C307
		public T Value
		{
			get
			{
				if (!this.hasValue)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue();
				}
				return this.value;
			}
		}

		/// <summary>Retrieves the value of the current <see cref="T:System.Nullable`1" /> object, or the object's default value.</summary>
		/// <returns>The value of the <see cref="P:System.Nullable`1.Value" /> property if the  <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />; otherwise, the default value of the current <see cref="T:System.Nullable`1" /> object. The type of the default value is the type argument of the current <see cref="T:System.Nullable`1" /> object, and the value of the default value consists solely of binary zeroes.</returns>
		// Token: 0x0600073E RID: 1854 RVA: 0x0001E11C File Offset: 0x0001C31C
		[NonVersionable]
		public T GetValueOrDefault()
		{
			return this.value;
		}

		/// <summary>Retrieves the value of the current <see cref="T:System.Nullable`1" /> object, or the specified default value.</summary>
		/// <param name="defaultValue">A value to return if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</param>
		/// <returns>The value of the <see cref="P:System.Nullable`1.Value" /> property if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />; otherwise, the <paramref name="defaultValue" /> parameter.</returns>
		// Token: 0x0600073F RID: 1855 RVA: 0x0001E124 File Offset: 0x0001C324
		[NonVersionable]
		public T GetValueOrDefault(T defaultValue)
		{
			if (!this.hasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		/// <summary>Indicates whether the current <see cref="T:System.Nullable`1" /> object is equal to a specified object.</summary>
		/// <param name="other">An object.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="other" /> parameter is equal to the current <see cref="T:System.Nullable`1" /> object; otherwise, <see langword="false" />. This table describes how equality is defined for the compared values: Return ValueDescription
		///             <see langword="true" />
		///           The <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />, and the <paramref name="other" /> parameter is <see langword="null" />. That is, two null values are equal by definition.-or-The <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />, and the value returned by the <see cref="P:System.Nullable`1.Value" /> property is equal to the <paramref name="other" /> parameter.
		///             <see langword="false" />
		///           The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is <see langword="true" />, and the <paramref name="other" /> parameter is <see langword="null" />.-or-The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is <see langword="false" />, and the <paramref name="other" /> parameter is not <see langword="null" />.-or-The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is <see langword="true" />, and the value returned by the <see cref="P:System.Nullable`1.Value" /> property is not equal to the <paramref name="other" /> parameter.</returns>
		// Token: 0x06000740 RID: 1856 RVA: 0x0001E136 File Offset: 0x0001C336
		public override bool Equals(object other)
		{
			if (!this.hasValue)
			{
				return other == null;
			}
			return other != null && this.value.Equals(other);
		}

		/// <summary>Retrieves the hash code of the object returned by the <see cref="P:System.Nullable`1.Value" /> property.</summary>
		/// <returns>The hash code of the object returned by the <see cref="P:System.Nullable`1.Value" /> property if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />, or zero if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />. </returns>
		// Token: 0x06000741 RID: 1857 RVA: 0x0001E15C File Offset: 0x0001C35C
		public override int GetHashCode()
		{
			if (!this.hasValue)
			{
				return 0;
			}
			return this.value.GetHashCode();
		}

		/// <summary>Returns the text representation of the value of the current <see cref="T:System.Nullable`1" /> object.</summary>
		/// <returns>The text representation of the value of the current <see cref="T:System.Nullable`1" /> object if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />, or an empty string ("") if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</returns>
		// Token: 0x06000742 RID: 1858 RVA: 0x0001E179 File Offset: 0x0001C379
		public override string ToString()
		{
			if (!this.hasValue)
			{
				return "";
			}
			return this.value.ToString();
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0001E19A File Offset: 0x0001C39A
		private static object Box(T? o)
		{
			if (!o.hasValue)
			{
				return null;
			}
			return o.value;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
		private static T? Unbox(object o)
		{
			if (o == null)
			{
				return null;
			}
			return new T?((T)((object)o));
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0001E1DC File Offset: 0x0001C3DC
		private static T? UnboxExact(object o)
		{
			if (o == null)
			{
				return null;
			}
			if (o.GetType() != typeof(T))
			{
				throw new InvalidCastException();
			}
			return new T?((T)((object)o));
		}

		// Token: 0x04000334 RID: 820
		private readonly bool hasValue;

		// Token: 0x04000335 RID: 821
		internal T value;
	}
}
