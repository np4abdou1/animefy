using System;
using System.Reflection;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000362 RID: 866
	internal class ArgInfo
	{
		// Token: 0x06001B4C RID: 6988 RVA: 0x00075B58 File Offset: 0x00073D58
		public ArgInfo(MethodBase method, ArgInfoType type)
		{
			this._method = method;
			ParameterInfo[] parameters = this._method.GetParameters();
			this._paramMap = new int[parameters.Length];
			this._inoutArgCount = 0;
			if (type == ArgInfoType.In)
			{
				for (int i = 0; i < parameters.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						int[] paramMap = this._paramMap;
						int inoutArgCount = this._inoutArgCount;
						this._inoutArgCount = inoutArgCount + 1;
						paramMap[inoutArgCount] = i;
					}
				}
				return;
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef || parameters[j].IsOut)
				{
					int[] paramMap2 = this._paramMap;
					int inoutArgCount = this._inoutArgCount;
					this._inoutArgCount = inoutArgCount + 1;
					paramMap2[inoutArgCount] = j;
				}
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00075C10 File Offset: 0x00073E10
		public object[] GetInOutArgs(object[] args)
		{
			object[] array = new object[this._inoutArgCount];
			for (int i = 0; i < this._inoutArgCount; i++)
			{
				array[i] = args[this._paramMap[i]];
			}
			return array;
		}

		// Token: 0x04000B6D RID: 2925
		private int[] _paramMap;

		// Token: 0x04000B6E RID: 2926
		private int _inoutArgCount;

		// Token: 0x04000B6F RID: 2927
		private MethodBase _method;
	}
}
