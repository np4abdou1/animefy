using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000341 RID: 833
	internal class CrossAppDomainSink : IMessageSink
	{
		// Token: 0x06001ADA RID: 6874 RVA: 0x00074AFF File Offset: 0x00072CFF
		internal CrossAppDomainSink(int domainID)
		{
			this._domainID = domainID;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00074B10 File Offset: 0x00072D10
		internal static CrossAppDomainSink GetSink(int domainID)
		{
			object syncRoot = CrossAppDomainSink.s_sinks.SyncRoot;
			CrossAppDomainSink result;
			lock (syncRoot)
			{
				if (CrossAppDomainSink.s_sinks.ContainsKey(domainID))
				{
					result = (CrossAppDomainSink)CrossAppDomainSink.s_sinks[domainID];
				}
				else
				{
					CrossAppDomainSink crossAppDomainSink = new CrossAppDomainSink(domainID);
					CrossAppDomainSink.s_sinks[domainID] = crossAppDomainSink;
					result = crossAppDomainSink;
				}
			}
			return result;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x00074B94 File Offset: 0x00072D94
		internal int TargetDomainId
		{
			get
			{
				return this._domainID;
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00074B9C File Offset: 0x00072D9C
		private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg)
		{
			CrossAppDomainSink.ProcessMessageRes result = default(CrossAppDomainSink.ProcessMessageRes);
			try
			{
				AppDomain.CurrentDomain.ProcessMessageInDomain(arrRequest, cadMsg, out result.arrResponse, out result.cadMrm);
			}
			catch (Exception e)
			{
				IMessage msg = new MethodResponse(e, new ErrorMessage());
				result.arrResponse = CADSerializer.SerializeMessage(msg).GetBuffer();
			}
			return result;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00074C00 File Offset: 0x00072E00
		public virtual IMessage SyncProcessMessage(IMessage msgRequest)
		{
			IMessage result = null;
			try
			{
				byte[] array = null;
				byte[] array2 = null;
				CADMethodReturnMessage retmsg = null;
				CADMethodCallMessage cadmethodCallMessage = CADMethodCallMessage.Create(msgRequest);
				if (cadmethodCallMessage == null)
				{
					array2 = CADSerializer.SerializeMessage(msgRequest).GetBuffer();
				}
				Context currentContext = Thread.CurrentContext;
				try
				{
					CrossAppDomainSink.ProcessMessageRes processMessageRes = (CrossAppDomainSink.ProcessMessageRes)AppDomain.InvokeInDomainByID(this._domainID, CrossAppDomainSink.processMessageMethod, null, new object[]
					{
						array2,
						cadmethodCallMessage
					});
					array = processMessageRes.arrResponse;
					retmsg = processMessageRes.cadMrm;
				}
				finally
				{
					AppDomain.InternalSetContext(currentContext);
				}
				if (array != null)
				{
					result = CADSerializer.DeserializeMessage(new MemoryStream(array), msgRequest as IMethodCallMessage);
				}
				else
				{
					result = new MethodResponse(msgRequest as IMethodCallMessage, retmsg);
				}
			}
			catch (Exception e)
			{
				try
				{
					result = new ReturnMessage(e, msgRequest as IMethodCallMessage);
				}
				catch (Exception)
				{
				}
			}
			return result;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00074CD8 File Offset: 0x00072ED8
		public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
		{
			AsyncRequest state = new AsyncRequest(reqMsg, replySink);
			ThreadPool.QueueUserWorkItem(delegate(object data)
			{
				try
				{
					this.SendAsyncMessage(data);
				}
				catch
				{
				}
			}, state);
			return null;
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00074D04 File Offset: 0x00072F04
		public void SendAsyncMessage(object data)
		{
			AsyncRequest asyncRequest = (AsyncRequest)data;
			IMessage msg = this.SyncProcessMessage(asyncRequest.MsgRequest);
			asyncRequest.ReplySink.SyncProcessMessage(msg);
		}

		// Token: 0x04000B3E RID: 2878
		private static Hashtable s_sinks = new Hashtable();

		// Token: 0x04000B3F RID: 2879
		private static MethodInfo processMessageMethod = typeof(CrossAppDomainSink).GetMethod("ProcessMessageInDomain", BindingFlags.Static | BindingFlags.NonPublic);

		// Token: 0x04000B40 RID: 2880
		private int _domainID;

		// Token: 0x02000342 RID: 834
		private struct ProcessMessageRes
		{
			// Token: 0x04000B41 RID: 2881
			public byte[] arrResponse;

			// Token: 0x04000B42 RID: 2882
			public CADMethodReturnMessage cadMrm;
		}
	}
}
