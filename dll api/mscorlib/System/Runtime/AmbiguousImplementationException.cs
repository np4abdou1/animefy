using System;
using System.Runtime.Serialization;

namespace System.Runtime
{
	// Token: 0x020002FC RID: 764
	[Serializable]
	public sealed class AmbiguousImplementationException : Exception
	{
		// Token: 0x06001948 RID: 6472 RVA: 0x0006E897 File Offset: 0x0006CA97
		public AmbiguousImplementationException() : base("Ambiguous implementation found.")
		{
			base.HResult = -2146234262;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0006E8AF File Offset: 0x0006CAAF
		public AmbiguousImplementationException(string message) : base(message)
		{
			base.HResult = -2146234262;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0000E782 File Offset: 0x0000C982
		private AmbiguousImplementationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
