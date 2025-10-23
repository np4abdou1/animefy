using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt is made to access an unloaded application domain. </summary>
	// Token: 0x02000126 RID: 294
	[Serializable]
	public class AppDomainUnloadedException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.AppDomainUnloadedException" /> class.</summary>
		// Token: 0x06000B77 RID: 2935 RVA: 0x0002FC27 File Offset: 0x0002DE27
		public AppDomainUnloadedException() : base("Attempted to access an unloaded AppDomain.")
		{
			base.HResult = -2146234348;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.AppDomainUnloadedException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000B78 RID: 2936 RVA: 0x0000E339 File Offset: 0x0000C539
		protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
