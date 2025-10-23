using System;
using System.Runtime.Serialization;

namespace System.Resources
{
	/// <summary>The exception that is thrown if the main assembly does not contain the resources for the neutral culture, and an appropriate satellite assembly is missing.</summary>
	// Token: 0x0200047B RID: 1147
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingManifestResourceException" /> class with default properties.</summary>
		// Token: 0x060020BC RID: 8380 RVA: 0x000899A7 File Offset: 0x00087BA7
		public MissingManifestResourceException() : base("Unable to find manifest resource.")
		{
			base.HResult = -2146233038;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingManifestResourceException" /> class from serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination of the exception. </param>
		// Token: 0x060020BD RID: 8381 RVA: 0x0000E339 File Offset: 0x0000C539
		protected MissingManifestResourceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
