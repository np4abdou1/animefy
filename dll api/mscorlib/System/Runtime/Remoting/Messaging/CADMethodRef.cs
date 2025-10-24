using System;
using System.Reflection;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000366 RID: 870
	[Serializable]
	internal class CADMethodRef
	{
		// Token: 0x06001B5F RID: 7007 RVA: 0x00075DEC File Offset: 0x00073FEC
		private Type[] GetTypes(string[] typeArray)
		{
			Type[] array = new Type[typeArray.Length];
			for (int i = 0; i < typeArray.Length; i++)
			{
				array[i] = Type.GetType(typeArray[i], true);
			}
			return array;
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00075E20 File Offset: 0x00074020
		public MethodBase Resolve()
		{
			Type type = Type.GetType(this.typeName, true);
			Type[] types = this.GetTypes(this.param_names);
			MethodBase methodBase;
			if (this.ctor)
			{
				methodBase = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
			}
			else
			{
				methodBase = type.GetMethod(this.methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
			}
			if (methodBase != null && this.generic_arg_names != null && !methodBase.IsGenericMethodDefinition)
			{
				methodBase = null;
			}
			if (methodBase != null && this.generic_arg_names != null)
			{
				methodBase = ((MethodInfo)methodBase).MakeGenericMethod(this.GetTypes(this.generic_arg_names));
			}
			if (methodBase == null && this.generic_arg_names != null)
			{
				foreach (MethodInfo methodInfo in type.GetMethods())
				{
					if (!(methodInfo.Name != this.methodName) && methodInfo.IsGenericMethodDefinition && methodInfo.GetGenericArguments().Length == this.generic_arg_names.Length)
					{
						methodBase = methodInfo.MakeGenericMethod(this.GetTypes(this.generic_arg_names));
						ParameterInfo[] parameters = methodBase.GetParameters();
						if (this.param_names.Length == parameters.Length)
						{
							for (int j = 0; j < parameters.Length; j++)
							{
								if (parameters[j].ParameterType.AssemblyQualifiedName != this.param_names[j])
								{
									methodBase = null;
									break;
								}
							}
							if (methodBase != null)
							{
								break;
							}
						}
					}
				}
			}
			if (methodBase == null)
			{
				throw new RemotingException(string.Concat(new string[]
				{
					"Method '",
					this.methodName,
					"' not found in type '",
					this.typeName,
					"'"
				}));
			}
			return methodBase;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00075FD4 File Offset: 0x000741D4
		public CADMethodRef(IMethodMessage msg)
		{
			MethodBase methodBase = msg.MethodBase;
			this.typeName = methodBase.DeclaringType.AssemblyQualifiedName;
			this.ctor = methodBase.IsConstructor;
			this.methodName = methodBase.Name;
			ParameterInfo[] parameters = methodBase.GetParameters();
			this.param_names = new string[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				this.param_names[i] = parameters[i].ParameterType.AssemblyQualifiedName;
			}
			if (!this.ctor && methodBase.IsGenericMethod)
			{
				Type[] genericArguments = methodBase.GetGenericArguments();
				this.generic_arg_names = new string[genericArguments.Length];
				for (int j = 0; j < genericArguments.Length; j++)
				{
					this.generic_arg_names[j] = genericArguments[j].AssemblyQualifiedName;
				}
			}
		}

		// Token: 0x04000B84 RID: 2948
		private bool ctor;

		// Token: 0x04000B85 RID: 2949
		private string typeName;

		// Token: 0x04000B86 RID: 2950
		private string methodName;

		// Token: 0x04000B87 RID: 2951
		private string[] param_names;

		// Token: 0x04000B88 RID: 2952
		private string[] generic_arg_names;
	}
}
