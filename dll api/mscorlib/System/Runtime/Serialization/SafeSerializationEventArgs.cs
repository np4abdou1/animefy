using System;
using System.Collections.Generic;

namespace System.Runtime.Serialization
{
	/// <summary>Provides data for the <see cref="E:System.Exception.SerializeObjectState" /> event.</summary>
	// Token: 0x020003AD RID: 941
	public sealed class SafeSerializationEventArgs : EventArgs
	{
		// Token: 0x06001D31 RID: 7473 RVA: 0x0007BBC6 File Offset: 0x00079DC6
		internal SafeSerializationEventArgs(StreamingContext streamingContext)
		{
			this.m_streamingContext = streamingContext;
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0007BBE0 File Offset: 0x00079DE0
		internal IList<object> SerializedStates
		{
			get
			{
				return this.m_serializedStates;
			}
		}

		// Token: 0x04000C39 RID: 3129
		private StreamingContext m_streamingContext;

		// Token: 0x04000C3A RID: 3130
		private List<object> m_serializedStates = new List<object>();
	}
}
