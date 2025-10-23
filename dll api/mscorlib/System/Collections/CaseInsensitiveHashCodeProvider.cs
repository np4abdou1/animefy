using System;
using System.Globalization;

namespace System.Collections
{
	/// <summary>Supplies a hash code for an object, using a hashing algorithm that ignores the case of strings.</summary>
	// Token: 0x020005DE RID: 1502
	[Serializable]
	public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> class using the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</summary>
		// Token: 0x06002CAF RID: 11439 RVA: 0x000B829C File Offset: 0x000B649C
		public CaseInsensitiveHashCodeProvider()
		{
			this._compareInfo = CultureInfo.CurrentCulture.CompareInfo;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> class using the specified <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for the new <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="culture" /> is <see langword="null" />. </exception>
		// Token: 0x06002CB0 RID: 11440 RVA: 0x000B82B4 File Offset: 0x000B64B4
		public CaseInsensitiveHashCodeProvider(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			this._compareInfo = culture.CompareInfo;
		}

		/// <summary>Returns a hash code for the given object, using a hashing algorithm that ignores the case of strings.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned. </param>
		/// <returns>A hash code for the given object, using a hashing algorithm that ignores the case of strings.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="obj" /> is <see langword="null" />. </exception>
		// Token: 0x06002CB1 RID: 11441 RVA: 0x000B82D8 File Offset: 0x000B64D8
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			string text = obj as string;
			if (text == null)
			{
				return obj.GetHashCode();
			}
			return this._compareInfo.GetHashCode(text, CompareOptions.IgnoreCase);
		}

		// Token: 0x0400186B RID: 6251
		private readonly CompareInfo _compareInfo;
	}
}
