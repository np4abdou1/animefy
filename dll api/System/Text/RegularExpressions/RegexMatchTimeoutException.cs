using System;
using System.Runtime.Serialization;

namespace System.Text.RegularExpressions
{
	/// <summary>The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.</summary>
	// Token: 0x020000B1 RID: 177
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException, ISerializable
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> class with information about the regular expression pattern, the input text, and the time-out interval.</summary>
		/// <param name="regexInput">The input text processed by the regular expression engine when the time-out occurred.</param>
		/// <param name="regexPattern">The pattern used by the regular expression engine when the time-out occurred.</param>
		/// <param name="matchTimeout">The time-out interval.</param>
		// Token: 0x06000512 RID: 1298 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
		public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout) : base("The RegEx engine has timed out while trying to match a pattern to an input string. This can occur for many reasons, including very large inputs or excessive backtracking caused by nested quantifiers, back-references and other factors.")
		{
			this.Input = regexInput;
			this.Pattern = regexPattern;
			this.MatchTimeout = matchTimeout;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> class with a system-supplied message.</summary>
		// Token: 0x06000513 RID: 1299 RVA: 0x0001F640 File Offset: 0x0001D840
		public RegexMatchTimeoutException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> class with serialized data.</summary>
		/// <param name="info">The object that contains the serialized data.</param>
		/// <param name="context">The stream that contains the serialized data.</param>
		// Token: 0x06000514 RID: 1300 RVA: 0x0001F66C File Offset: 0x0001D86C
		protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.Input = info.GetString("regexInput");
			this.Pattern = info.GetString("regexPattern");
			this.MatchTimeout = new TimeSpan(info.GetInt64("timeoutTicks"));
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize a <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> object.</summary>
		/// <param name="si">The object to populate with data.</param>
		/// <param name="context">The destination for this serialization.</param>
		// Token: 0x06000515 RID: 1301 RVA: 0x0001F6DC File Offset: 0x0001D8DC
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("regexInput", this.Input);
			info.AddValue("regexPattern", this.Pattern);
			info.AddValue("timeoutTicks", this.MatchTimeout.Ticks);
		}

		/// <summary>Gets the input text that the regular expression engine was processing when the time-out occurred.</summary>
		/// <returns>The regular expression input text.</returns>
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001F72C File Offset: 0x0001D92C
		public string Input { get; } = string.Empty;

		/// <summary>Gets the regular expression pattern that was used in the matching operation when the time-out occurred.</summary>
		/// <returns>The regular expression pattern.</returns>
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001F734 File Offset: 0x0001D934
		public string Pattern { get; } = string.Empty;

		/// <summary>Gets the time-out interval for a regular expression match.</summary>
		/// <returns>The time-out interval.</returns>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0001F73C File Offset: 0x0001D93C
		public TimeSpan MatchTimeout { get; } = TimeSpan.FromTicks(-1L);
	}
}
