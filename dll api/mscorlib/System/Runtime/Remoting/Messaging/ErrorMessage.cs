using System;
using System.Collections;
using System.Reflection;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000370 RID: 880
	[Serializable]
	internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public int ArgCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0002AC82 File Offset: 0x00028E82
		public object[] Args
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0002AC82 File Offset: 0x00028E82
		public MethodBase MethodBase
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00076ED3 File Offset: 0x000750D3
		public string MethodName
		{
			get
			{
				return "unknown";
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0002AC82 File Offset: 0x00028E82
		public object MethodSignature
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x0002AC82 File Offset: 0x00028E82
		public virtual IDictionary Properties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00076ED3 File Offset: 0x000750D3
		public string TypeName
		{
			get
			{
				return "unknown";
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00076EDA File Offset: 0x000750DA
		public string Uri
		{
			get
			{
				return this._uri;
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0002AC82 File Offset: 0x00028E82
		public object GetArg(int arg_num)
		{
			return null;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0002AC82 File Offset: 0x00028E82
		public LogicalCallContext LogicalCallContext
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000B9E RID: 2974
		private string _uri = "Exception";
	}
}
