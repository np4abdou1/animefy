using System;
using System.Globalization;

namespace System
{
	/// <summary>Represents a composite format string, along with the arguments to be formatted. </summary>
	// Token: 0x0200009F RID: 159
	public abstract class FormattableString : IFormattable
	{
		/// <summary>Returns the composite format string. </summary>
		/// <returns>The composite format string. </returns>
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600054A RID: 1354
		public abstract string Format { get; }

		/// <summary>Returns an object array that contains one or more objects to format. </summary>
		/// <returns>An object array that contains one or more objects to format. </returns>
		// Token: 0x0600054B RID: 1355
		public abstract object[] GetArguments();

		/// <summary>Gets the number of arguments to be formatted. </summary>
		/// <returns>The number of arguments to be formatted. </returns>
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600054C RID: 1356
		public abstract int ArgumentCount { get; }

		/// <summary>Returns the argument at the specified index position. </summary>
		/// <param name="index">The index of the argument. Its value can range from zero to one less than the value of <see cref="P:System.FormattableString.ArgumentCount" />. </param>
		/// <returns>The argument. </returns>
		// Token: 0x0600054D RID: 1357
		public abstract object GetArgument(int index);

		/// <summary>Returns the string that results from formatting the composite format string along with its arguments by using the formatting conventions of a specified culture. </summary>
		/// <param name="formatProvider">An object that provides culture-specific formatting information. </param>
		/// <returns>A result string formatted by using the conventions of <paramref name="formatProvider" />. </returns>
		// Token: 0x0600054E RID: 1358
		public abstract string ToString(IFormatProvider formatProvider);

		/// <summary>Returns the string that results from formatting the format string along with its arguments by using the formatting conventions of a specified culture. </summary>
		/// <param name="ignored">A string. This argument is ignored. </param>
		/// <param name="formatProvider">An object that provides culture-specific formatting information. </param>
		/// <returns>A string formatted using the conventions of the <paramref name="formatProvider" /> parameter. </returns>
		// Token: 0x0600054F RID: 1359 RVA: 0x00013B68 File Offset: 0x00011D68
		string IFormattable.ToString(string ignored, IFormatProvider formatProvider)
		{
			return this.ToString(formatProvider);
		}

		/// <summary>Returns the string that results from formatting the composite format string along with its arguments by using the formatting conventions of the current culture. </summary>
		/// <returns>A result string formatted by using the conventions of the current culture. </returns>
		// Token: 0x06000550 RID: 1360 RVA: 0x00013B71 File Offset: 0x00011D71
		public override string ToString()
		{
			return this.ToString(CultureInfo.CurrentCulture);
		}
	}
}
