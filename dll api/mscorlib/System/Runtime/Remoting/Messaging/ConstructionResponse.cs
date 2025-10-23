using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" /> interface to create a message that responds to a call to instantiate a remote object.</summary>
	// Token: 0x0200036E RID: 878
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
	{
		// Token: 0x06001B96 RID: 7062 RVA: 0x00076E67 File Offset: 0x00075067
		internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) : base(resultObject, null, callCtx, msg)
		{
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00076E73 File Offset: 0x00075073
		internal ConstructionResponse(Exception e, IMethodCallMessage msg) : base(e, msg)
		{
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00076E7D File Offset: 0x0007507D
		internal ConstructionResponse(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x00076E87 File Offset: 0x00075087
		public override IDictionary Properties
		{
			get
			{
				return base.Properties;
			}
		}
	}
}
