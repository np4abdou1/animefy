﻿using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Provides enumerated values to use to set regular expression options.</summary>
	// Token: 0x020000B3 RID: 179
	[Flags]
	public enum RegexOptions
	{
		/// <summary>Specifies that no options are set. For more information about the default behavior of the regular expression engine, see the "Default Options" section in the Regular Expression Options topic. </summary>
		// Token: 0x04000359 RID: 857
		None = 0,
		/// <summary>Specifies case-insensitive matching. For more information, see the "Case-Insensitive Matching " section in the Regular Expression Options topic. </summary>
		// Token: 0x0400035A RID: 858
		IgnoreCase = 1,
		/// <summary>Multiline mode. Changes the meaning of ^ and $ so they match at the beginning and end, respectively, of any line, and not just the beginning and end of the entire string. For more information, see the "Multiline Mode" section in the Regular Expression Options topic. </summary>
		// Token: 0x0400035B RID: 859
		Multiline = 2,
		/// <summary>Specifies that the only valid captures are explicitly named or numbered groups of the form (?&lt;name&gt;…). This allows unnamed parentheses to act as noncapturing groups without the syntactic clumsiness of the expression (?:…). For more information, see the "Explicit Captures Only" section in the Regular Expression Options topic. </summary>
		// Token: 0x0400035C RID: 860
		ExplicitCapture = 4,
		/// <summary>Specifies that the regular expression is compiled to an assembly. This yields faster execution but increases startup time. This value should not be assigned to the <see cref="P:System.Text.RegularExpressions.RegexCompilationInfo.Options" /> property when calling the <see cref="M:System.Text.RegularExpressions.Regex.CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[],System.Reflection.AssemblyName)" /> method. For more information, see the "Compiled Regular Expressions" section in the Regular Expression Options topic. </summary>
		// Token: 0x0400035D RID: 861
		Compiled = 8,
		/// <summary>Specifies single-line mode. Changes the meaning of the dot (.) so it matches every character (instead of every character except \n). For more information, see the "Single-line Mode" section in the Regular Expression Options topic. </summary>
		// Token: 0x0400035E RID: 862
		Singleline = 16,
		/// <summary>Eliminates unescaped white space from the pattern and enables comments marked with #. However, this value does not affect or eliminate white space in , numeric , or tokens that mark the beginning of individual . For more information, see the "Ignore White Space" section of the Regular Expression Options topic. </summary>
		// Token: 0x0400035F RID: 863
		IgnorePatternWhitespace = 32,
		/// <summary>Specifies that the search will be from right to left instead of from left to right. For more information, see the "Right-to-Left Mode" section in the Regular Expression Options topic. </summary>
		// Token: 0x04000360 RID: 864
		RightToLeft = 64,
		/// <summary>Enables ECMAScript-compliant behavior for the expression. This value can be used only in conjunction with the <see cref="F:System.Text.RegularExpressions.RegexOptions.IgnoreCase" />, <see cref="F:System.Text.RegularExpressions.RegexOptions.Multiline" />, and <see cref="F:System.Text.RegularExpressions.RegexOptions.Compiled" /> values. The use of this value with any other values results in an exception.For more information on the <see cref="F:System.Text.RegularExpressions.RegexOptions.ECMAScript" /> option, see the "ECMAScript Matching Behavior" section in the Regular Expression Options topic. </summary>
		// Token: 0x04000361 RID: 865
		ECMAScript = 256,
		/// <summary>Specifies that cultural differences in language is ignored. For more information, see the "Comparison Using the Invariant Culture" section in the Regular Expression Options topic.</summary>
		// Token: 0x04000362 RID: 866
		CultureInvariant = 512
	}
}
