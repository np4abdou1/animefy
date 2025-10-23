using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000331 RID: 817
	internal class CrossContextChannel : IMessageSink
	{
		// Token: 0x06001A9C RID: 6812 RVA: 0x00073BC0 File Offset: 0x00071DC0
		public IMessage SyncProcessMessage(IMessage msg)
		{
			ServerIdentity serverIdentity = (ServerIdentity)RemotingServices.GetMessageTargetIdentity(msg);
			Context context = null;
			if (Thread.CurrentContext != serverIdentity.Context)
			{
				context = Context.SwitchToContext(serverIdentity.Context);
			}
			IMessage result;
			try
			{
				Context.NotifyGlobalDynamicSinks(true, msg, false, false);
				Thread.CurrentContext.NotifyDynamicSinks(true, msg, false, false);
				result = serverIdentity.Context.GetServerContextSinkChain().SyncProcessMessage(msg);
				Context.NotifyGlobalDynamicSinks(false, msg, false, false);
				Thread.CurrentContext.NotifyDynamicSinks(false, msg, false, false);
			}
			catch (Exception e)
			{
				result = new ReturnMessage(e, (IMethodCallMessage)msg);
			}
			finally
			{
				if (context != null)
				{
					Context.SwitchToContext(context);
				}
			}
			return result;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00073C70 File Offset: 0x00071E70
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			ServerIdentity serverIdentity = (ServerIdentity)RemotingServices.GetMessageTargetIdentity(msg);
			Context context = null;
			if (Thread.CurrentContext != serverIdentity.Context)
			{
				context = Context.SwitchToContext(serverIdentity.Context);
			}
			IMessageCtrl result;
			try
			{
				Context.NotifyGlobalDynamicSinks(true, msg, false, true);
				Thread.CurrentContext.NotifyDynamicSinks(true, msg, false, false);
				if (replySink != null)
				{
					replySink = new CrossContextChannel.ContextRestoreSink(replySink, context, msg);
				}
				IMessageCtrl messageCtrl = serverIdentity.AsyncObjectProcessMessage(msg, replySink);
				if (replySink == null)
				{
					Context.NotifyGlobalDynamicSinks(false, msg, false, false);
					Thread.CurrentContext.NotifyDynamicSinks(false, msg, false, false);
				}
				result = messageCtrl;
			}
			catch (Exception e)
			{
				if (replySink != null)
				{
					replySink.SyncProcessMessage(new ReturnMessage(e, (IMethodCallMessage)msg));
				}
				result = null;
			}
			finally
			{
				if (context != null)
				{
					Context.SwitchToContext(context);
				}
			}
			return result;
		}

		// Token: 0x02000332 RID: 818
		private class ContextRestoreSink : IMessageSink
		{
			// Token: 0x06001A9F RID: 6815 RVA: 0x00073D34 File Offset: 0x00071F34
			public ContextRestoreSink(IMessageSink next, Context context, IMessage call)
			{
				this._next = next;
				this._context = context;
				this._call = call;
			}

			// Token: 0x06001AA0 RID: 6816 RVA: 0x00073D54 File Offset: 0x00071F54
			public IMessage SyncProcessMessage(IMessage msg)
			{
				IMessage result;
				try
				{
					Context.NotifyGlobalDynamicSinks(false, msg, false, false);
					Thread.CurrentContext.NotifyDynamicSinks(false, msg, false, false);
					result = this._next.SyncProcessMessage(msg);
				}
				catch (Exception e)
				{
					result = new ReturnMessage(e, (IMethodCallMessage)this._call);
				}
				finally
				{
					if (this._context != null)
					{
						Context.SwitchToContext(this._context);
					}
				}
				return result;
			}

			// Token: 0x06001AA1 RID: 6817 RVA: 0x0002AD12 File Offset: 0x00028F12
			public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
			{
				throw new NotSupportedException();
			}

			// Token: 0x04000B26 RID: 2854
			private IMessageSink _next;

			// Token: 0x04000B27 RID: 2855
			private Context _context;

			// Token: 0x04000B28 RID: 2856
			private IMessage _call;
		}
	}
}
