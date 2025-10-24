using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	/// <summary>Represents a base implementation of the <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> interface that uses the <see cref="T:System.Convert" /> class and the <see cref="T:System.IConvertible" /> interface.</summary>
	// Token: 0x02000397 RID: 919
	public class FormatterConverter : IFormatterConverter
	{
		/// <summary>Converts a value to the given <see cref="T:System.Type" />.</summary>
		/// <param name="value">The object to convert. </param>
		/// <param name="type">The <see cref="T:System.Type" /> into which <paramref name="value" /> is converted. </param>
		/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001C8A RID: 7306 RVA: 0x000792B2 File Offset: 0x000774B2
		public object Convert(object value, Type type)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
		}

		/// <summary>Converts a value to a <see cref="T:System.Boolean" />.</summary>
		/// <param name="value">The object to convert. </param>
		/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001C8B RID: 7307 RVA: 0x000792C8 File Offset: 0x000774C8
		public bool ToBoolean(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToBoolean(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Converts a value to a 32-bit signed integer.</summary>
		/// <param name="value">The object to convert. </param>
		/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001C8C RID: 7308 RVA: 0x000792DD File Offset: 0x000774DD
		public int ToInt32(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToInt32(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Converts a value to a 64-bit signed integer.</summary>
		/// <param name="value">The object to convert. </param>
		/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001C8D RID: 7309 RVA: 0x000792F2 File Offset: 0x000774F2
		public long ToInt64(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToInt64(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Converts a value to a single-precision floating-point number.</summary>
		/// <param name="value">The object to convert. </param>
		/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001C8E RID: 7310 RVA: 0x00079307 File Offset: 0x00077507
		public float ToSingle(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToSingle(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Converts the specified object to a <see cref="T:System.String" />.</summary>
		/// <param name="value">The object to convert. </param>
		/// <returns>The converted <paramref name="value" /> or <see langword="null" /> if the <paramref name="type" /> parameter is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001C8F RID: 7311 RVA: 0x0007931C File Offset: 0x0007751C
		public string ToString(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToString(value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00079331 File Offset: 0x00077531
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowValueNullException()
		{
			throw new ArgumentNullException("value");
		}
	}
}
