using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Defines the different language versions of the Gregorian calendar.</summary>
	// Token: 0x020005A0 RID: 1440
	[ComVisible(true)]
	[Serializable]
	public enum GregorianCalendarTypes
	{
		/// <summary>Refers to the localized version of the Gregorian calendar, based on the language of the <see cref="T:System.Globalization.CultureInfo" /> that uses the <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		// Token: 0x04001747 RID: 5959
		Localized = 1,
		/// <summary>Refers to the U.S. English version of the Gregorian calendar.</summary>
		// Token: 0x04001748 RID: 5960
		USEnglish,
		/// <summary>Refers to the Middle East French version of the Gregorian calendar.</summary>
		// Token: 0x04001749 RID: 5961
		MiddleEastFrench = 9,
		/// <summary>Refers to the Arabic version of the Gregorian calendar.</summary>
		// Token: 0x0400174A RID: 5962
		Arabic,
		/// <summary>Refers to the transliterated English version of the Gregorian calendar.</summary>
		// Token: 0x0400174B RID: 5963
		TransliteratedEnglish,
		/// <summary>Refers to the transliterated French version of the Gregorian calendar.</summary>
		// Token: 0x0400174C RID: 5964
		TransliteratedFrench
	}
}
