using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Indicates that the implementing message sink will be provided by dynamically registered properties.</summary>
	// Token: 0x02000339 RID: 825
	[ComVisible(true)]
	public interface IDynamicMessageSink
	{
		/// <summary>Indicates that a call is returning.</summary>
		/// <param name="replyMsg">A reply message. </param>
		/// <param name="bCliSide">A value of <see langword="true" /> if the method is invoked on the client side and <see langword="false" /> if it is invoked on the server side. </param>
		/// <param name="bAsync">A value of <see langword="true" /> if this is an asynchronic call and <see langword="false" /> if it is a synchronic call. </param>
		// Token: 0x06001AAB RID: 6827
		void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

		/// <summary>Indicates that a call is starting.</summary>
		/// <param name="reqMsg">A request message. </param>
		/// <param name="bCliSide">A value of <see langword="true" /> if the method is invoked on the client side and <see langword="false" /> if the method is on the server side. </param>
		/// <param name="bAsync">A value of <see langword="true" /> if this is an asynchronic call and <see langword="false" /> if it is a synchronic call. </param>
		// Token: 0x06001AAC RID: 6828
		void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
	}
}
