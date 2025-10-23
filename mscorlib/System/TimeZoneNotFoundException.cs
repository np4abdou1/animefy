using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a time zone cannot be found.</summary>
	// Token: 0x02000107 RID: 263
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[Serializable]
	public class TimeZoneNotFoundException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.TimeZoneNotFoundException" /> class with a system-supplied message.</summary>
		// Token: 0x06000983 RID: 2435 RVA: 0x0001CA1B File Offset: 0x0001AC1B
		public TimeZoneNotFoundException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TimeZoneNotFoundException" /> class from serialized data.</summary>
		/// <param name="info">The object that contains the serialized data.</param>
		/// <param name="context">The stream that contains the serialized data.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.-or-The <paramref name="context" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000984 RID: 2436 RVA: 0x0000E782 File Offset: 0x0000C982
		protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
