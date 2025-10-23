using System;

namespace System.Runtime.Remoting
{
	// Token: 0x0200031A RID: 794
	[Serializable]
	internal class TypeInfo : IRemotingTypeInfo
	{
		// Token: 0x06001A1D RID: 6685 RVA: 0x00071F90 File Offset: 0x00070190
		public TypeInfo(Type type)
		{
			if (type.IsInterface)
			{
				this.serverType = typeof(MarshalByRefObject).AssemblyQualifiedName;
				this.serverHierarchy = new string[0];
				Type[] interfaces = type.GetInterfaces();
				this.interfacesImplemented = new string[interfaces.Length + 1];
				for (int i = 0; i < interfaces.Length; i++)
				{
					this.interfacesImplemented[i] = interfaces[i].AssemblyQualifiedName;
				}
				this.interfacesImplemented[interfaces.Length] = type.AssemblyQualifiedName;
				return;
			}
			this.serverType = type.AssemblyQualifiedName;
			int num = 0;
			Type baseType = type.BaseType;
			while (baseType != typeof(MarshalByRefObject) && baseType != null)
			{
				baseType = baseType.BaseType;
				num++;
			}
			this.serverHierarchy = new string[num];
			baseType = type.BaseType;
			for (int j = 0; j < num; j++)
			{
				this.serverHierarchy[j] = baseType.AssemblyQualifiedName;
				baseType = baseType.BaseType;
			}
			Type[] interfaces2 = type.GetInterfaces();
			this.interfacesImplemented = new string[interfaces2.Length];
			for (int k = 0; k < interfaces2.Length; k++)
			{
				this.interfacesImplemented[k] = interfaces2[k].AssemblyQualifiedName;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x000720C5 File Offset: 0x000702C5
		public string TypeName
		{
			get
			{
				return this.serverType;
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000720D0 File Offset: 0x000702D0
		public bool CanCastTo(Type fromType, object o)
		{
			if (fromType == typeof(object))
			{
				return true;
			}
			if (fromType == typeof(MarshalByRefObject))
			{
				return true;
			}
			string text = fromType.AssemblyQualifiedName;
			int num = text.IndexOf(',');
			if (num != -1)
			{
				num = text.IndexOf(',', num + 1);
			}
			if (num != -1)
			{
				text = text.Substring(0, num + 1);
			}
			else
			{
				text += ",";
			}
			if ((this.serverType + ",").StartsWith(text))
			{
				return true;
			}
			if (this.serverHierarchy != null)
			{
				string[] array = this.serverHierarchy;
				for (int i = 0; i < array.Length; i++)
				{
					if ((array[i] + ",").StartsWith(text))
					{
						return true;
					}
				}
			}
			if (this.interfacesImplemented != null)
			{
				string[] array = this.interfacesImplemented;
				for (int i = 0; i < array.Length; i++)
				{
					if ((array[i] + ",").StartsWith(text))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04000AE1 RID: 2785
		private string serverType;

		// Token: 0x04000AE2 RID: 2786
		private string[] serverHierarchy;

		// Token: 0x04000AE3 RID: 2787
		private string[] interfacesImplemented;
	}
}
