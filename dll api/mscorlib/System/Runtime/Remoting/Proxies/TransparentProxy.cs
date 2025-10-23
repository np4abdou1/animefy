using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Mono;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x02000321 RID: 801
	[StructLayout(0)]
	internal class TransparentProxy
	{
		// Token: 0x06001A33 RID: 6707 RVA: 0x000724F0 File Offset: 0x000706F0
		internal RuntimeType GetProxyType()
		{
			return (RuntimeType)Type.GetTypeFromHandle(this._class.ProxyClass.GetTypeHandle());
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0007251A File Offset: 0x0007071A
		private bool IsContextBoundObject
		{
			get
			{
				return this.GetProxyType().IsContextful;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00072527 File Offset: 0x00070727
		private Context TargetContext
		{
			get
			{
				return this._rp._targetContext;
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00072534 File Offset: 0x00070734
		private bool InCurrentContext()
		{
			return this.IsContextBoundObject && this.TargetContext == Thread.CurrentContext;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00072550 File Offset: 0x00070750
		internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr)
		{
			RuntimeClassHandle runtimeClassHandle = new RuntimeClassHandle(classPtr);
			RuntimeFieldHandle handle = new RuntimeFieldHandle(fieldPtr);
			RuntimeTypeHandle typeHandle = runtimeClassHandle.GetTypeHandle();
			FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(handle);
			if (this.InCurrentContext())
			{
				object server = this._rp._server;
				return fieldFromHandle.GetValue(server);
			}
			string fullName = Type.GetTypeFromHandle(typeHandle).FullName;
			string name = fieldFromHandle.Name;
			object[] in_args = new object[]
			{
				fullName,
				name
			};
			object[] out_args = new object[1];
			MethodInfo method = typeof(object).GetMethod("FieldGetter", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method == null)
			{
				throw new MissingMethodException("System.Object", "FieldGetter");
			}
			MonoMethodMessage msg = new MonoMethodMessage(method, in_args, out_args);
			Exception ex;
			object[] array;
			RealProxy.PrivateInvoke(this._rp, msg, out ex, out array);
			if (ex != null)
			{
				throw ex;
			}
			return array[0];
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0007261C File Offset: 0x0007081C
		internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg)
		{
			RuntimeClassHandle runtimeClassHandle = new RuntimeClassHandle(classPtr);
			RuntimeFieldHandle handle = new RuntimeFieldHandle(fieldPtr);
			RuntimeTypeHandle typeHandle = runtimeClassHandle.GetTypeHandle();
			FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(handle);
			if (this.InCurrentContext())
			{
				object server = this._rp._server;
				fieldFromHandle.SetValue(server, arg);
				return;
			}
			string fullName = Type.GetTypeFromHandle(typeHandle).FullName;
			string name = fieldFromHandle.Name;
			object[] in_args = new object[]
			{
				fullName,
				name,
				arg
			};
			MethodInfo method = typeof(object).GetMethod("FieldSetter", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method == null)
			{
				throw new MissingMethodException("System.Object", "FieldSetter");
			}
			MonoMethodMessage msg = new MonoMethodMessage(method, in_args, null);
			Exception ex;
			object[] array;
			RealProxy.PrivateInvoke(this._rp, msg, out ex, out array);
			if (ex != null)
			{
				throw ex;
			}
		}

		// Token: 0x04000AEE RID: 2798
		public RealProxy _rp;

		// Token: 0x04000AEF RID: 2799
		private RuntimeRemoteClassHandle _class;

		// Token: 0x04000AF0 RID: 2800
		private bool _custom_type_info;
	}
}
