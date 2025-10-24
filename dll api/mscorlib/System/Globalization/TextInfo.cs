using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
	/// <summary>Defines text properties and behaviors, such as casing, that are specific to a writing system. </summary>
	// Token: 0x020005A4 RID: 1444
	[ComVisible(true)]
	[Serializable]
	public class TextInfo : ICloneable, IDeserializationCallback
	{
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x000AF634 File Offset: 0x000AD834
		internal static TextInfo Invariant
		{
			get
			{
				if (TextInfo.s_Invariant == null)
				{
					TextInfo.s_Invariant = new TextInfo(CultureData.Invariant);
				}
				return TextInfo.s_Invariant;
			}
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000AF657 File Offset: 0x000AD857
		internal TextInfo(CultureData cultureData)
		{
			this.m_cultureData = cultureData;
			this.m_cultureName = this.m_cultureData.CultureName;
			this.m_textInfoName = this.m_cultureData.STEXTINFO;
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x000AF688 File Offset: 0x000AD888
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.m_cultureData = null;
			this.m_cultureName = null;
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000AF698 File Offset: 0x000AD898
		private void OnDeserialized()
		{
			if (this.m_cultureData == null)
			{
				if (this.m_cultureName == null)
				{
					if (this.customCultureName != null)
					{
						this.m_cultureName = this.customCultureName;
					}
					else if (this.m_win32LangID == 0)
					{
						this.m_cultureName = "ar-SA";
					}
					else
					{
						this.m_cultureName = CultureInfo.GetCultureInfo(this.m_win32LangID).m_cultureData.CultureName;
					}
				}
				this.m_cultureData = CultureInfo.GetCultureInfo(this.m_cultureName).m_cultureData;
				this.m_textInfoName = this.m_cultureData.STEXTINFO;
			}
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000AF722 File Offset: 0x000AD922
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000AF72A File Offset: 0x000AD92A
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.m_useUserOverride = false;
			this.customCultureName = this.m_cultureName;
			this.m_win32LangID = CultureInfo.GetCultureInfo(this.m_cultureName).LCID;
		}

		/// <summary>Gets the American National Standards Institute (ANSI) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>The ANSI code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000AF755 File Offset: 0x000AD955
		public virtual int ANSICodePage
		{
			get
			{
				return this.m_cultureData.IDEFAULTANSICODEPAGE;
			}
		}

		/// <summary>Gets the name of the culture associated with the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
		/// <returns>The name of a culture. </returns>
		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x000AF762 File Offset: 0x000AD962
		[ComVisible(false)]
		public string CultureName
		{
			get
			{
				return this.m_textInfoName;
			}
		}

		/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
		/// <returns>A new instance of <see cref="T:System.Object" /> that is the memberwise clone of the current <see cref="T:System.Globalization.TextInfo" /> object.</returns>
		// Token: 0x06002B75 RID: 11125 RVA: 0x000AF76A File Offset: 0x000AD96A
		[ComVisible(false)]
		public virtual object Clone()
		{
			object obj = base.MemberwiseClone();
			((TextInfo)obj).SetReadOnlyState(false);
			return obj;
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000AF77E File Offset: 0x000AD97E
		internal void SetReadOnlyState(bool readOnly)
		{
			this.m_isReadOnly = readOnly;
		}

		/// <summary>Converts the specified character to lowercase.</summary>
		/// <param name="c">The character to convert to lowercase. </param>
		/// <returns>The specified character converted to lowercase.</returns>
		// Token: 0x06002B77 RID: 11127 RVA: 0x000AF787 File Offset: 0x000AD987
		[SecuritySafeCritical]
		public virtual char ToLower(char c)
		{
			if (TextInfo.IsAscii(c) && this.IsAsciiCasingSameAsInvariant)
			{
				return TextInfo.ToLowerAsciiInvariant(c);
			}
			return this.ToLowerInternal(c);
		}

		/// <summary>Converts the specified string to lowercase.</summary>
		/// <param name="str">The string to convert to lowercase. </param>
		/// <returns>The specified string converted to lowercase.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="str" /> is null. </exception>
		// Token: 0x06002B78 RID: 11128 RVA: 0x000AF7A7 File Offset: 0x000AD9A7
		[SecuritySafeCritical]
		public virtual string ToLower(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return this.ToLowerInternal(str);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000AF7BE File Offset: 0x000AD9BE
		private static char ToLowerAsciiInvariant(char c)
		{
			if ('A' <= c && c <= 'Z')
			{
				c |= ' ';
			}
			return c;
		}

		/// <summary>Converts the specified character to uppercase.</summary>
		/// <param name="c">The character to convert to uppercase. </param>
		/// <returns>The specified character converted to uppercase.</returns>
		// Token: 0x06002B7A RID: 11130 RVA: 0x000AF7D2 File Offset: 0x000AD9D2
		[SecuritySafeCritical]
		public virtual char ToUpper(char c)
		{
			if (TextInfo.IsAscii(c) && this.IsAsciiCasingSameAsInvariant)
			{
				return TextInfo.ToUpperAsciiInvariant(c);
			}
			return this.ToUpperInternal(c);
		}

		/// <summary>Converts the specified string to uppercase.</summary>
		/// <param name="str">The string to convert to uppercase. </param>
		/// <returns>The specified string converted to uppercase.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="str" /> is null. </exception>
		// Token: 0x06002B7B RID: 11131 RVA: 0x000AF7F2 File Offset: 0x000AD9F2
		[SecuritySafeCritical]
		public virtual string ToUpper(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return this.ToUpperInternal(str);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000AF809 File Offset: 0x000ADA09
		internal static char ToUpperAsciiInvariant(char c)
		{
			if ('a' <= c && c <= 'z')
			{
				c = (char)((int)c & -33);
			}
			return c;
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000AF81D File Offset: 0x000ADA1D
		private static bool IsAscii(char c)
		{
			return c < '\u0080';
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000AF828 File Offset: 0x000ADA28
		private bool IsAsciiCasingSameAsInvariant
		{
			get
			{
				if (this.m_IsAsciiCasingSameAsInvariant == null)
				{
					this.m_IsAsciiCasingSameAsInvariant = new bool?(!(this.m_cultureData.SISO639LANGNAME == "az") && !(this.m_cultureData.SISO639LANGNAME == "tr"));
				}
				return this.m_IsAsciiCasingSameAsInvariant.Value;
			}
		}

		/// <summary>Determines whether the specified object represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
		/// <param name="obj">The object to compare with the current <see cref="T:System.Globalization.TextInfo" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002B7F RID: 11135 RVA: 0x000AF88C File Offset: 0x000ADA8C
		public override bool Equals(object obj)
		{
			TextInfo textInfo = obj as TextInfo;
			return textInfo != null && this.CultureName.Equals(textInfo.CultureName);
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.TextInfo" />, suitable for hashing algorithms and data structures, such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x06002B80 RID: 11136 RVA: 0x000AF8B6 File Offset: 0x000ADAB6
		public override int GetHashCode()
		{
			return this.CultureName.GetHashCode();
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Globalization.TextInfo" />.</returns>
		// Token: 0x06002B81 RID: 11137 RVA: 0x000AF8C3 File Offset: 0x000ADAC3
		public override string ToString()
		{
			return "TextInfo - " + this.m_cultureData.CultureName;
		}

		/// <summary>Raises the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event. </param>
		// Token: 0x06002B82 RID: 11138 RVA: 0x000AF722 File Offset: 0x000AD922
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialized();
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000AF8DC File Offset: 0x000ADADC
		private unsafe string ToUpperInternal(string str)
		{
			if (str.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(str.Length);
			fixed (string text2 = str)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				fixed (string text3 = text)
				{
					char* ptr2 = text3;
					if (ptr2 != null)
					{
						ptr2 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr3 = ptr2;
					char* ptr4 = ptr;
					for (int i = 0; i < str.Length; i++)
					{
						*ptr3 = this.ToUpper(*ptr4);
						ptr4++;
						ptr3++;
					}
					text2 = null;
				}
				return text;
			}
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000AF960 File Offset: 0x000ADB60
		private unsafe string ToLowerInternal(string str)
		{
			if (str.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(str.Length);
			fixed (string text2 = str)
			{
				char* ptr = text2;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				fixed (string text3 = text)
				{
					char* ptr2 = text3;
					if (ptr2 != null)
					{
						ptr2 += RuntimeHelpers.OffsetToStringData / 2;
					}
					char* ptr3 = ptr2;
					char* ptr4 = ptr;
					for (int i = 0; i < str.Length; i++)
					{
						*ptr3 = this.ToLower(*ptr4);
						ptr4++;
						ptr3++;
					}
					text2 = null;
				}
				return text;
			}
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x000AF9E4 File Offset: 0x000ADBE4
		private char ToUpperInternal(char c)
		{
			if (!this.m_cultureData.IsInvariantCulture)
			{
				if (c <= 'ǲ')
				{
					if (c > 'ſ')
					{
						if (c <= 'ǈ')
						{
							if (c != 'ǅ' && c != 'ǈ')
							{
								goto IL_15A;
							}
						}
						else if (c != 'ǋ' && c != 'ǲ')
						{
							goto IL_15A;
						}
						return c - '\u0001';
					}
					if (c == 'µ')
					{
						return 'Μ';
					}
					if (c == 'ı')
					{
						return 'I';
					}
					if (c == 'ſ')
					{
						return 'S';
					}
				}
				else if (c <= 'ϰ')
				{
					if (c <= 'ς')
					{
						if (c == 'ͅ')
						{
							return 'Ι';
						}
						if (c == 'ς')
						{
							return 'Σ';
						}
					}
					else
					{
						switch (c)
						{
						case 'ϐ':
							return 'Β';
						case 'ϑ':
							return 'Θ';
						case 'ϒ':
						case 'ϓ':
						case 'ϔ':
							break;
						case 'ϕ':
							return 'Φ';
						case 'ϖ':
							return 'Π';
						default:
							if (c == 'ϰ')
							{
								return 'Κ';
							}
							break;
						}
					}
				}
				else if (c <= 'ϵ')
				{
					if (c == 'ϱ')
					{
						return 'Ρ';
					}
					if (c == 'ϵ')
					{
						return 'Ε';
					}
				}
				else
				{
					if (c == 'ẛ')
					{
						return 'Ṡ';
					}
					if (c == 'ι')
					{
						return 'Ι';
					}
				}
				IL_15A:
				if (!this.IsAsciiCasingSameAsInvariant)
				{
					if (c == 'i')
					{
						return 'İ';
					}
					if (TextInfo.IsAscii(c))
					{
						return TextInfo.ToUpperAsciiInvariant(c);
					}
				}
			}
			if (c >= 'à' && c <= 'ֆ')
			{
				return TextInfoToUpperData.range_00e0_0586[(int)(c - 'à')];
			}
			if (c >= 'ḁ' && c <= 'ῳ')
			{
				return TextInfoToUpperData.range_1e01_1ff3[(int)(c - 'ḁ')];
			}
			if (c >= 'ⅰ' && c <= 'ↄ')
			{
				return TextInfoToUpperData.range_2170_2184[(int)(c - 'ⅰ')];
			}
			if (c >= 'ⓐ' && c <= 'ⓩ')
			{
				return TextInfoToUpperData.range_24d0_24e9[(int)(c - 'ⓐ')];
			}
			if (c >= 'ⰰ' && c <= 'ⳣ')
			{
				return TextInfoToUpperData.range_2c30_2ce3[(int)(c - 'ⰰ')];
			}
			if (c >= 'ⴀ' && c <= 'ⴥ')
			{
				return TextInfoToUpperData.range_2d00_2d25[(int)(c - 'ⴀ')];
			}
			if (c >= 'ꙁ' && c <= 'ꚗ')
			{
				return TextInfoToUpperData.range_a641_a697[(int)(c - 'ꙁ')];
			}
			if (c >= 'ꜣ' && c <= 'ꞌ')
			{
				return TextInfoToUpperData.range_a723_a78c[(int)(c - 'ꜣ')];
			}
			if ('ａ' <= c && c <= 'ｚ')
			{
				return c - ' ';
			}
			if (c == 'ᵹ')
			{
				return 'Ᵹ';
			}
			if (c == 'ᵽ')
			{
				return 'Ᵽ';
			}
			if (c != 'ⅎ')
			{
				return c;
			}
			return 'Ⅎ';
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x000AFCA0 File Offset: 0x000ADEA0
		private char ToLowerInternal(char c)
		{
			if (!this.m_cultureData.IsInvariantCulture)
			{
				if (c <= 'ǲ')
				{
					if (c <= 'ǅ')
					{
						if (c == 'İ')
						{
							return 'i';
						}
						if (c != 'ǅ')
						{
							goto IL_D3;
						}
					}
					else if (c != 'ǈ' && c != 'ǋ' && c != 'ǲ')
					{
						goto IL_D3;
					}
					return c + '\u0001';
				}
				if (c <= 'ẞ')
				{
					switch (c)
					{
					case 'ϒ':
						return 'υ';
					case 'ϓ':
						return 'ύ';
					case 'ϔ':
						return 'ϋ';
					default:
						if (c == 'ϴ')
						{
							return 'θ';
						}
						if (c == 'ẞ')
						{
							return 'ß';
						}
						break;
					}
				}
				else
				{
					if (c == 'Ω')
					{
						return 'ω';
					}
					if (c == 'K')
					{
						return 'k';
					}
					if (c == 'Å')
					{
						return 'å';
					}
				}
				IL_D3:
				if (!this.IsAsciiCasingSameAsInvariant)
				{
					if (c == 'I')
					{
						return 'ı';
					}
					if (TextInfo.IsAscii(c))
					{
						return TextInfo.ToLowerAsciiInvariant(c);
					}
				}
			}
			if (c >= 'À' && c <= 'Ֆ')
			{
				return TextInfoToLowerData.range_00c0_0556[(int)(c - 'À')];
			}
			if (c >= 'Ⴀ' && c <= 'Ⴥ')
			{
				return TextInfoToLowerData.range_10a0_10c5[(int)(c - 'Ⴀ')];
			}
			if (c >= 'Ḁ' && c <= 'ῼ')
			{
				return TextInfoToLowerData.range_1e00_1ffc[(int)(c - 'Ḁ')];
			}
			if (c >= 'Ⅰ' && c <= 'Ⅿ')
			{
				return TextInfoToLowerData.range_2160_216f[(int)(c - 'Ⅰ')];
			}
			if (c >= 'Ⓐ' && c <= 'Ⓩ')
			{
				return TextInfoToLowerData.range_24b6_24cf[(int)(c - 'Ⓐ')];
			}
			if (c >= 'Ⰰ' && c <= 'Ⱞ')
			{
				return TextInfoToLowerData.range_2c00_2c2e[(int)(c - 'Ⰰ')];
			}
			if (c >= 'Ⱡ' && c <= 'Ⳣ')
			{
				return TextInfoToLowerData.range_2c60_2ce2[(int)(c - 'Ⱡ')];
			}
			if (c >= 'Ꙁ' && c <= 'Ꚗ')
			{
				return TextInfoToLowerData.range_a640_a696[(int)(c - 'Ꙁ')];
			}
			if (c >= 'Ꜣ' && c <= 'Ꞌ')
			{
				return TextInfoToLowerData.range_a722_a78b[(int)(c - 'Ꜣ')];
			}
			if ('Ａ' <= c && c <= 'Ｚ')
			{
				return c + ' ';
			}
			if (c == 'Ⅎ')
			{
				return 'ⅎ';
			}
			if (c != 'Ↄ')
			{
				return c;
			}
			return 'ↄ';
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x000AFEE8 File Offset: 0x000AE0E8
		internal unsafe void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination)
		{
			for (int i = 0; i < source.Length; i++)
			{
				*destination[i] = TextInfo.ToUpperAsciiInvariant((char)(*source[i]));
			}
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x000AFF20 File Offset: 0x000AE120
		internal unsafe void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper)
		{
			if (source.IsEmpty)
			{
				return;
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(destination))
				{
					char* ptr2 = reference2;
					int i = 0;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					if (toUpper)
					{
						while (i < source.Length)
						{
							*(ptr4++) = this.ToUpper(*(ptr3++));
							i++;
						}
					}
					else
					{
						while (i < source.Length)
						{
							*(ptr4++) = this.ToLower(*(ptr3++));
							i++;
						}
					}
				}
			}
		}

		// Token: 0x04001779 RID: 6009
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x0400177A RID: 6010
		[OptionalField(VersionAdded = 3)]
		private string m_cultureName;

		// Token: 0x0400177B RID: 6011
		[NonSerialized]
		private CultureData m_cultureData;

		// Token: 0x0400177C RID: 6012
		[NonSerialized]
		private string m_textInfoName;

		// Token: 0x0400177D RID: 6013
		[NonSerialized]
		private bool? m_IsAsciiCasingSameAsInvariant;

		// Token: 0x0400177E RID: 6014
		internal static volatile TextInfo s_Invariant;

		// Token: 0x0400177F RID: 6015
		[OptionalField(VersionAdded = 2)]
		private string customCultureName;

		// Token: 0x04001780 RID: 6016
		[OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x04001781 RID: 6017
		[OptionalField(VersionAdded = 1)]
		internal int m_win32LangID;
	}
}
