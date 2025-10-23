using System;
using System.Collections;
using System.IO;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000369 RID: 873
	internal class CADMethodReturnMessage : CADMessageBase
	{
		// Token: 0x06001B74 RID: 7028 RVA: 0x0007681C File Offset: 0x00074A1C
		internal static CADMethodReturnMessage Create(IMessage callMsg)
		{
			IMethodReturnMessage methodReturnMessage = callMsg as IMethodReturnMessage;
			if (methodReturnMessage == null)
			{
				return null;
			}
			return new CADMethodReturnMessage(methodReturnMessage);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0007683C File Offset: 0x00074A3C
		internal CADMethodReturnMessage(IMethodReturnMessage retMsg) : base(retMsg)
		{
			ArrayList arrayList = null;
			this._propertyCount = CADMessageBase.MarshalProperties(retMsg.Properties, ref arrayList);
			this._returnValue = base.MarshalArgument(retMsg.ReturnValue, ref arrayList);
			this._args = base.MarshalArguments(retMsg.Args, ref arrayList);
			this._sig = CADMessageBase.GetSignature(base.GetMethod(), true);
			if (retMsg.Exception != null)
			{
				if (arrayList == null)
				{
					arrayList = new ArrayList();
				}
				this._exception = new CADArgHolder(arrayList.Count);
				arrayList.Add(retMsg.Exception);
			}
			base.SaveLogicalCallContext(retMsg, ref arrayList);
			if (arrayList != null)
			{
				MemoryStream memoryStream = CADSerializer.SerializeObject(arrayList.ToArray());
				this._serializedArgs = memoryStream.GetBuffer();
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000768F4 File Offset: 0x00074AF4
		internal ArrayList GetArguments()
		{
			ArrayList result = null;
			if (this._serializedArgs != null)
			{
				byte[] array = new byte[this._serializedArgs.Length];
				Array.Copy(this._serializedArgs, array, this._serializedArgs.Length);
				result = new ArrayList((object[])CADSerializer.DeserializeObject(new MemoryStream(array)));
				this._serializedArgs = null;
			}
			return result;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00076803 File Offset: 0x00074A03
		internal object[] GetArgs(ArrayList args)
		{
			return base.UnmarshalArguments(this._args, args);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0007694B File Offset: 0x00074B4B
		internal object GetReturnValue(ArrayList args)
		{
			return base.UnmarshalArgument(this._returnValue, args);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0007695A File Offset: 0x00074B5A
		internal Exception GetException(ArrayList args)
		{
			if (this._exception == null)
			{
				return null;
			}
			return (Exception)args[this._exception.index];
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00076812 File Offset: 0x00074A12
		internal int PropertiesCount
		{
			get
			{
				return this._propertyCount;
			}
		}

		// Token: 0x04000B8F RID: 2959
		private object _returnValue;

		// Token: 0x04000B90 RID: 2960
		private CADArgHolder _exception;

		// Token: 0x04000B91 RID: 2961
		private Type[] _sig;
	}
}
