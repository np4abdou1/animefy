using System;
using System.Globalization;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Provides static methods to convert input text into names for code entities.</summary>
	// Token: 0x020001C6 RID: 454
	public class CodeIdentifier
	{
		/// <summary>Produces a Pascal-case string from an input string. </summary>
		/// <param name="identifier">The name of a code entity, such as a method parameter, typically taken from an XML element or attribute name.</param>
		/// <returns>A Pascal-case version of the parameter string.</returns>
		// Token: 0x06000F73 RID: 3955 RVA: 0x00062918 File Offset: 0x00060B18
		public static string MakePascal(string identifier)
		{
			identifier = CodeIdentifier.MakeValid(identifier);
			if (identifier.Length <= 2)
			{
				return identifier.ToUpper(CultureInfo.InvariantCulture);
			}
			if (char.IsLower(identifier[0]))
			{
				return char.ToUpper(identifier[0], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture) + identifier.Substring(1);
			}
			return identifier;
		}

		/// <summary>Produces a valid code entity name from an input string. </summary>
		/// <param name="identifier">The name of a code entity, such as a method parameter, typically taken from an XML element or attribute name.</param>
		/// <returns>A string that can be used as a code identifier, such as the name of a method parameter.</returns>
		// Token: 0x06000F74 RID: 3956 RVA: 0x0006297C File Offset: 0x00060B7C
		public static string MakeValid(string identifier)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			while (num < identifier.Length && stringBuilder.Length < 511)
			{
				char c = identifier[num];
				if (CodeIdentifier.IsValid(c))
				{
					if (stringBuilder.Length == 0 && !CodeIdentifier.IsValidStart(c))
					{
						stringBuilder.Append("Item");
					}
					stringBuilder.Append(c);
				}
				num++;
			}
			if (stringBuilder.Length == 0)
			{
				return "Item";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000629F5 File Offset: 0x00060BF5
		private static bool IsValidStart(char c)
		{
			return char.GetUnicodeCategory(c) != UnicodeCategory.DecimalDigitNumber;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00062A04 File Offset: 0x00060C04
		private static bool IsValid(char c)
		{
			switch (char.GetUnicodeCategory(c))
			{
			case UnicodeCategory.UppercaseLetter:
			case UnicodeCategory.LowercaseLetter:
			case UnicodeCategory.TitlecaseLetter:
			case UnicodeCategory.ModifierLetter:
			case UnicodeCategory.OtherLetter:
			case UnicodeCategory.NonSpacingMark:
			case UnicodeCategory.SpacingCombiningMark:
			case UnicodeCategory.DecimalDigitNumber:
			case UnicodeCategory.ConnectorPunctuation:
				return true;
			case UnicodeCategory.EnclosingMark:
			case UnicodeCategory.LetterNumber:
			case UnicodeCategory.OtherNumber:
			case UnicodeCategory.SpaceSeparator:
			case UnicodeCategory.LineSeparator:
			case UnicodeCategory.ParagraphSeparator:
			case UnicodeCategory.Control:
			case UnicodeCategory.Format:
			case UnicodeCategory.Surrogate:
			case UnicodeCategory.PrivateUse:
			case UnicodeCategory.DashPunctuation:
			case UnicodeCategory.OpenPunctuation:
			case UnicodeCategory.ClosePunctuation:
			case UnicodeCategory.InitialQuotePunctuation:
			case UnicodeCategory.FinalQuotePunctuation:
			case UnicodeCategory.OtherPunctuation:
			case UnicodeCategory.MathSymbol:
			case UnicodeCategory.CurrencySymbol:
			case UnicodeCategory.ModifierSymbol:
			case UnicodeCategory.OtherSymbol:
			case UnicodeCategory.OtherNotAssigned:
				return false;
			default:
				return false;
			}
		}
	}
}
