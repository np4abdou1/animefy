using System;
using System.Reflection;
using System.Runtime.Remoting.Proxies;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200038A RID: 906
	internal class StackBuilderSink : IMessageSink
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x00078EF4 File Offset: 0x000770F4
		public StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute)
		{
			this._target = obj;
			if (!forceInternalExecute && RemotingServices.IsTransparentProxy(obj))
			{
				this._rp = RemotingServices.GetRealProxy(obj);
			}
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00078F1A File Offset: 0x0007711A
		public IMessage SyncProcessMessage(IMessage msg)
		{
			this.CheckParameters(msg);
			if (this._rp != null)
			{
				return this._rp.Invoke(msg);
			}
			return RemotingServices.InternalExecuteMessage(this._target, (IMethodCallMessage)msg);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00078F4C File Offset: 0x0007714C
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			object[] state = new object[]
			{
				msg,
				replySink
			};
			ThreadPool.QueueUserWorkItem(delegate(object data)
			{
				try
				{
					this.ExecuteAsyncMessage(data);
				}
				catch
				{
				}
			}, state);
			return null;
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00078F7C File Offset: 0x0007717C
		private void ExecuteAsyncMessage(object ob)
		{
			object[] array = (object[])ob;
			IMethodCallMessage methodCallMessage = (IMethodCallMessage)array[0];
			IMessageSink messageSink = (IMessageSink)array[1];
			this.CheckParameters(methodCallMessage);
			IMessage msg;
			if (this._rp != null)
			{
				msg = this._rp.Invoke(methodCallMessage);
			}
			else
			{
				msg = RemotingServices.InternalExecuteMessage(this._target, methodCallMessage);
			}
			messageSink.SyncProcessMessage(msg);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00078FD4 File Offset: 0x000771D4
		private void CheckParameters(IMessage msg)
		{
			IMethodCallMessage methodCallMessage = (IMethodCallMessage)msg;
			ParameterInfo[] parameters = methodCallMessage.MethodBase.GetParameters();
			int num = 0;
			foreach (ParameterInfo parameterInfo in parameters)
			{
				object arg = methodCallMessage.GetArg(num++);
				Type type = parameterInfo.ParameterType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
				}
				if (arg != null && !type.IsInstanceOfType(arg))
				{
					throw new RemotingException(string.Concat(new string[]
					{
						"Cannot cast argument ",
						parameterInfo.Position.ToString(),
						" of type '",
						arg.GetType().AssemblyQualifiedName,
						"' to type '",
						type.AssemblyQualifiedName,
						"'"
					}));
				}
			}
		}

		// Token: 0x04000BE9 RID: 3049
		private MarshalByRefObject _target;

		// Token: 0x04000BEA RID: 3050
		private RealProxy _rp;
	}
}
