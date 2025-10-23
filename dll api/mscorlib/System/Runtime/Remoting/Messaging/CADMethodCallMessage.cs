using System;
using System.Collections;
using System.IO;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000368 RID: 872
	internal class CADMethodCallMessage : CADMessageBase
	{
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x00076713 File Offset: 0x00074913
		internal string Uri
		{
			get
			{
				return this._uri;
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0007671C File Offset: 0x0007491C
		internal static CADMethodCallMessage Create(IMessage callMsg)
		{
			IMethodCallMessage methodCallMessage = callMsg as IMethodCallMessage;
			if (methodCallMessage == null)
			{
				return null;
			}
			return new CADMethodCallMessage(methodCallMessage);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0007673C File Offset: 0x0007493C
		internal CADMethodCallMessage(IMethodCallMessage callMsg) : base(callMsg)
		{
			this._uri = callMsg.Uri;
			ArrayList arrayList = null;
			this._propertyCount = CADMessageBase.MarshalProperties(callMsg.Properties, ref arrayList);
			this._args = base.MarshalArguments(callMsg.Args, ref arrayList);
			base.SaveLogicalCallContext(callMsg, ref arrayList);
			if (arrayList != null)
			{
				MemoryStream memoryStream = CADSerializer.SerializeObject(arrayList.ToArray());
				this._serializedArgs = memoryStream.GetBuffer();
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000767AC File Offset: 0x000749AC
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

		// Token: 0x06001B72 RID: 7026 RVA: 0x00076803 File Offset: 0x00074A03
		internal object[] GetArgs(ArrayList args)
		{
			return base.UnmarshalArguments(this._args, args);
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00076812 File Offset: 0x00074A12
		internal int PropertiesCount
		{
			get
			{
				return this._propertyCount;
			}
		}

		// Token: 0x04000B8E RID: 2958
		private string _uri;
	}
}
