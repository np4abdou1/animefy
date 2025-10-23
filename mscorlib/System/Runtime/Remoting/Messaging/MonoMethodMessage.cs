using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000380 RID: 896
	[Serializable]
	[StructLayout(0)]
	internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
	{
		// Token: 0x06001C1C RID: 7196 RVA: 0x000786E8 File Offset: 0x000768E8
		internal void InitMessage(RuntimeMethodInfo method, object[] out_args)
		{
			this.method = method;
			ParameterInfo[] parametersInternal = method.GetParametersInternal();
			int num = parametersInternal.Length;
			this.args = new object[num];
			this.arg_types = new byte[num];
			this.asyncResult = null;
			this.call_type = CallType.Sync;
			this.names = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.names[i] = parametersInternal[i].Name;
			}
			bool flag = out_args != null;
			int num2 = 0;
			for (int j = 0; j < num; j++)
			{
				bool isOut = parametersInternal[j].IsOut;
				byte b;
				if (parametersInternal[j].ParameterType.IsByRef)
				{
					if (flag)
					{
						this.args[j] = out_args[num2++];
					}
					b = 2;
					if (!isOut)
					{
						b |= 1;
					}
				}
				else
				{
					b = 1;
					if (isOut)
					{
						b |= 4;
					}
				}
				this.arg_types[j] = b;
			}
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000787C9 File Offset: 0x000769C9
		public MonoMethodMessage(MethodBase method, object[] out_args)
		{
			if (method != null)
			{
				this.InitMessage((RuntimeMethodInfo)method, out_args);
				return;
			}
			this.args = null;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000787F0 File Offset: 0x000769F0
		internal MonoMethodMessage(MethodInfo minfo, object[] in_args, object[] out_args)
		{
			this.InitMessage((RuntimeMethodInfo)minfo, out_args);
			int num = in_args.Length;
			for (int i = 0; i < num; i++)
			{
				this.args[i] = in_args[i];
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0007882B File Offset: 0x00076A2B
		private static MethodInfo GetMethodInfo(Type type, string methodName)
		{
			MethodInfo methodInfo = type.GetMethod(methodName);
			if (methodInfo == null)
			{
				throw new ArgumentException(string.Format("Could not find '{0}' in {1}", methodName, type), "methodName");
			}
			return methodInfo;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00078854 File Offset: 0x00076A54
		public MonoMethodMessage(Type type, string methodName, object[] in_args) : this(MonoMethodMessage.GetMethodInfo(type, methodName), in_args, null)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00078865 File Offset: 0x00076A65
		public IDictionary Properties
		{
			get
			{
				if (this.properties == null)
				{
					this.properties = new MCMDictionary(this);
				}
				return this.properties;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00078881 File Offset: 0x00076A81
		public int ArgCount
		{
			get
			{
				if (this.CallType == CallType.EndInvoke)
				{
					return -1;
				}
				if (this.args == null)
				{
					return 0;
				}
				return this.args.Length;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000788A0 File Offset: 0x00076AA0
		public object[] Args
		{
			get
			{
				return this.args;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000788A8 File Offset: 0x00076AA8
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x000788B0 File Offset: 0x00076AB0
		public LogicalCallContext LogicalCallContext
		{
			get
			{
				return this.ctx;
			}
			set
			{
				this.ctx = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000788B9 File Offset: 0x00076AB9
		public MethodBase MethodBase
		{
			get
			{
				return this.method;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x000788C1 File Offset: 0x00076AC1
		public string MethodName
		{
			get
			{
				if (null == this.method)
				{
					return string.Empty;
				}
				return this.method.Name;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000788E4 File Offset: 0x00076AE4
		public object MethodSignature
		{
			get
			{
				if (this.methodSignature == null)
				{
					ParameterInfo[] parameters = this.method.GetParameters();
					this.methodSignature = new Type[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						this.methodSignature[i] = parameters[i].ParameterType;
					}
				}
				return this.methodSignature;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x00078937 File Offset: 0x00076B37
		public string TypeName
		{
			get
			{
				if (null == this.method)
				{
					return string.Empty;
				}
				return this.method.DeclaringType.AssemblyQualifiedName;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0007895D File Offset: 0x00076B5D
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00078965 File Offset: 0x00076B65
		public string Uri
		{
			get
			{
				return this.uri;
			}
			set
			{
				this.uri = value;
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0007896E File Offset: 0x00076B6E
		public object GetArg(int arg_num)
		{
			if (this.args == null)
			{
				return null;
			}
			return this.args[arg_num];
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00078982 File Offset: 0x00076B82
		public Exception Exception
		{
			get
			{
				return this.exc;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x0007898C File Offset: 0x00076B8C
		public int OutArgCount
		{
			get
			{
				if (this.args == null)
				{
					return 0;
				}
				int num = 0;
				byte[] array = this.arg_types;
				for (int i = 0; i < array.Length; i++)
				{
					if ((array[i] & 2) != 0)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x000789C8 File Offset: 0x00076BC8
		public object[] OutArgs
		{
			get
			{
				if (this.args == null)
				{
					return null;
				}
				object[] array = new object[this.OutArgCount];
				int num2;
				int num = num2 = 0;
				byte[] array2 = this.arg_types;
				for (int i = 0; i < array2.Length; i++)
				{
					if ((array2[i] & 2) != 0)
					{
						array[num++] = this.args[num2];
					}
					num2++;
				}
				return array;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00078A24 File Offset: 0x00076C24
		public object ReturnValue
		{
			get
			{
				return this.rval;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00078A2C File Offset: 0x00076C2C
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x00078A34 File Offset: 0x00076C34
		Identity IInternalMessage.TargetIdentity
		{
			get
			{
				return this.identity;
			}
			set
			{
				this.identity = value;
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00078A3D File Offset: 0x00076C3D
		bool IInternalMessage.HasProperties()
		{
			return this.properties != null;
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00078A48 File Offset: 0x00076C48
		public AsyncResult AsyncResult
		{
			get
			{
				return this.asyncResult;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x00078A50 File Offset: 0x00076C50
		internal CallType CallType
		{
			get
			{
				if (this.call_type == CallType.Sync && RemotingServices.IsOneWay(this.method))
				{
					this.call_type = CallType.OneWay;
				}
				return this.call_type;
			}
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00078A74 File Offset: 0x00076C74
		public bool NeedsOutProcessing(out int outCount)
		{
			bool flag = false;
			outCount = 0;
			foreach (byte b in this.arg_types)
			{
				if ((b & 2) != 0)
				{
					outCount++;
				}
				else if ((b & 4) != 0)
				{
					flag = true;
				}
			}
			return outCount > 0 || flag;
		}

		// Token: 0x04000BC3 RID: 3011
		private RuntimeMethodInfo method;

		// Token: 0x04000BC4 RID: 3012
		private object[] args;

		// Token: 0x04000BC5 RID: 3013
		private string[] names;

		// Token: 0x04000BC6 RID: 3014
		private byte[] arg_types;

		// Token: 0x04000BC7 RID: 3015
		public LogicalCallContext ctx;

		// Token: 0x04000BC8 RID: 3016
		public object rval;

		// Token: 0x04000BC9 RID: 3017
		public Exception exc;

		// Token: 0x04000BCA RID: 3018
		private AsyncResult asyncResult;

		// Token: 0x04000BCB RID: 3019
		private CallType call_type;

		// Token: 0x04000BCC RID: 3020
		private string uri;

		// Token: 0x04000BCD RID: 3021
		private MCMDictionary properties;

		// Token: 0x04000BCE RID: 3022
		private Identity identity;

		// Token: 0x04000BCF RID: 3023
		private Type[] methodSignature;
	}
}
