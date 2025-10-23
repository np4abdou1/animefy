using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when time zone information is invalid.</summary>
	// Token: 0x020000CA RID: 202
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[Serializable]
	public class InvalidTimeZoneException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidTimeZoneException" /> class with a system-supplied message.</summary>
		// Token: 0x060006A9 RID: 1705 RVA: 0x0001CA1B File Offset: 0x0001AC1B
		public InvalidTimeZoneException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidTimeZoneException" /> class with the specified message string.</summary>
		/// <param name="message">A string that describes the exception.</param>
		// Token: 0x060006AA RID: 1706 RVA: 0x0001CA23 File Offset: 0x0001AC23
		public InvalidTimeZoneException(string message) : base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidTimeZoneException" /> class from serialized data.</summary>
		/// <param name="info">The object that contains the serialized data. </param>
		/// <param name="context">The stream that contains the serialized data.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.-or-The <paramref name="context" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060006AB RID: 1707 RVA: 0x0000E782 File Offset: 0x0000C982
		protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
