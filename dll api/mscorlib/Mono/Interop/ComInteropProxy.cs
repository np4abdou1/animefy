using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Threading;

namespace Mono.Interop
{
	// Token: 0x0200002F RID: 47
	[StructLayout(0)]
	internal class ComInteropProxy : RealProxy, IRemotingTypeInfo
	{
		// Token: 0x06000096 RID: 150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void AddProxy(IntPtr pItf, ref ComInteropProxy proxy);

		// Token: 0x06000097 RID: 151
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FindProxy(IntPtr pItf, ref ComInteropProxy proxy);

		// Token: 0x06000098 RID: 152 RVA: 0x000036EC File Offset: 0x000018EC
		private ComInteropProxy(Type t) : base(t)
		{
			this.com_object = __ComObject.CreateRCW(t);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003708 File Offset: 0x00001908
		private void CacheProxy()
		{
			ComInteropProxy comInteropProxy = null;
			ComInteropProxy.FindProxy(this.com_object.IUnknown, ref comInteropProxy);
			if (comInteropProxy == null)
			{
				ComInteropProxy comInteropProxy2 = this;
				ComInteropProxy.AddProxy(this.com_object.IUnknown, ref comInteropProxy2);
				return;
			}
			Interlocked.Increment(ref this.ref_count);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000374D File Offset: 0x0000194D
		private ComInteropProxy(IntPtr pUnk) : this(pUnk, typeof(__ComObject))
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003760 File Offset: 0x00001960
		internal ComInteropProxy(IntPtr pUnk, Type t) : base(t)
		{
			this.com_object = new __ComObject(pUnk, this);
			this.CacheProxy();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003784 File Offset: 0x00001984
		internal static ComInteropProxy GetProxy(IntPtr pItf, Type t)
		{
			Guid iid_IUnknown = __ComObject.IID_IUnknown;
			IntPtr intPtr;
			Marshal.ThrowExceptionForHR(Marshal.QueryInterface(pItf, ref iid_IUnknown, out intPtr));
			ComInteropProxy comInteropProxy = null;
			ComInteropProxy.FindProxy(intPtr, ref comInteropProxy);
			if (comInteropProxy == null)
			{
				Marshal.Release(intPtr);
				return new ComInteropProxy(intPtr);
			}
			Marshal.Release(intPtr);
			Interlocked.Increment(ref comInteropProxy.ref_count);
			return comInteropProxy;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000037D8 File Offset: 0x000019D8
		internal static ComInteropProxy CreateProxy(Type t)
		{
			IntPtr intPtr = __ComObject.CreateIUnknown(t);
			ComInteropProxy comInteropProxy = null;
			ComInteropProxy.FindProxy(intPtr, ref comInteropProxy);
			ComInteropProxy comInteropProxy2;
			if (comInteropProxy != null)
			{
				Type type = comInteropProxy.com_object.GetType();
				if (type != t)
				{
					throw new InvalidCastException(string.Format("Unable to cast object of type '{0}' to type '{1}'.", type, t));
				}
				comInteropProxy2 = comInteropProxy;
				Marshal.Release(intPtr);
			}
			else
			{
				comInteropProxy2 = new ComInteropProxy(t);
				comInteropProxy2.com_object.Initialize(intPtr, comInteropProxy2);
			}
			return comInteropProxy2;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003840 File Offset: 0x00001A40
		public override IMessage Invoke(IMessage msg)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000384C File Offset: 0x00001A4C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00003854 File Offset: 0x00001A54
		public string TypeName
		{
			get
			{
				return this.type_name;
			}
			set
			{
				this.type_name = value;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003860 File Offset: 0x00001A60
		public bool CanCastTo(Type fromType, object o)
		{
			__ComObject _ComObject = o as __ComObject;
			if (_ComObject == null)
			{
				throw new NotSupportedException("Only RCWs are currently supported");
			}
			return (fromType.Attributes & TypeAttributes.Import) != TypeAttributes.NotPublic && !(_ComObject.GetInterface(fromType, false) == IntPtr.Zero);
		}

		// Token: 0x040000CE RID: 206
		private __ComObject com_object;

		// Token: 0x040000CF RID: 207
		private int ref_count = 1;

		// Token: 0x040000D0 RID: 208
		private string type_name;
	}
}
