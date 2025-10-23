using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Mono.Interop;

namespace System
{
	// Token: 0x02000198 RID: 408
	[StructLayout(0)]
	internal class __ComObject : MarshalByRefObject
	{
		// Token: 0x06000F8E RID: 3982
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern __ComObject CreateRCW(Type t);

		// Token: 0x06000F8F RID: 3983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ReleaseInterfaces();

		// Token: 0x06000F90 RID: 3984 RVA: 0x000411D0 File Offset: 0x0003F3D0
		~__ComObject()
		{
			if (this.hash_table != IntPtr.Zero)
			{
				if (this.synchronization_context != null)
				{
					this.synchronization_context.Post(delegate(object state)
					{
						this.ReleaseInterfaces();
					}, this);
				}
				else
				{
					this.ReleaseInterfaces();
				}
			}
			this.proxy = null;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00041238 File Offset: 0x0003F438
		public __ComObject()
		{
			this.Initialize(base.GetType());
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0004124C File Offset: 0x0003F44C
		internal __ComObject(Type t)
		{
			this.Initialize(t);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0004125C File Offset: 0x0003F45C
		internal __ComObject(IntPtr pItf, ComInteropProxy p)
		{
			this.proxy = p;
			this.InitializeApartmentDetails();
			Guid iid_IUnknown = __ComObject.IID_IUnknown;
			Marshal.ThrowExceptionForHR(Marshal.QueryInterface(pItf, ref iid_IUnknown, out this.iunknown));
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00041295 File Offset: 0x0003F495
		internal void Initialize(IntPtr pUnk, ComInteropProxy p)
		{
			this.proxy = p;
			this.InitializeApartmentDetails();
			this.iunknown = pUnk;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000412AB File Offset: 0x0003F4AB
		internal void Initialize(Type t)
		{
			this.InitializeApartmentDetails();
			if (this.iunknown != IntPtr.Zero)
			{
				return;
			}
			this.iunknown = __ComObject.CreateIUnknown(t);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000412D4 File Offset: 0x0003F4D4
		internal static IntPtr CreateIUnknown(Type t)
		{
			RuntimeHelpers.RunClassConstructor(t.TypeHandle);
			ObjectCreationDelegate objectCreationCallback = ExtensibleClassFactory.GetObjectCreationCallback(t);
			IntPtr intPtr;
			if (objectCreationCallback != null)
			{
				intPtr = objectCreationCallback(IntPtr.Zero);
				if (intPtr == IntPtr.Zero)
				{
					throw new COMException(string.Format("ObjectCreationDelegate for type {0} failed to return a valid COM object", t));
				}
			}
			else
			{
				Marshal.ThrowExceptionForHR(__ComObject.CoCreateInstance(__ComObject.GetCLSID(t), IntPtr.Zero, 21U, __ComObject.IID_IUnknown, out intPtr));
			}
			return intPtr;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00041340 File Offset: 0x0003F540
		private void InitializeApartmentDetails()
		{
			if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
			{
				return;
			}
			this.synchronization_context = SynchronizationContext.Current;
			if (this.synchronization_context != null && this.synchronization_context.GetType() == typeof(SynchronizationContext))
			{
				this.synchronization_context = null;
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00041390 File Offset: 0x0003F590
		private static Guid GetCLSID(Type t)
		{
			if (t.IsImport)
			{
				return t.GUID;
			}
			Type baseType = t.BaseType;
			while (baseType != typeof(object))
			{
				if (baseType.IsImport)
				{
					return baseType.GUID;
				}
				baseType = baseType.BaseType;
			}
			throw new COMException("Could not find base COM type for type " + t.ToString());
		}

		// Token: 0x06000F99 RID: 3993
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern IntPtr GetInterfaceInternal(Type t, bool throwException);

		// Token: 0x06000F9A RID: 3994 RVA: 0x000413F2 File Offset: 0x0003F5F2
		internal IntPtr GetInterface(Type t, bool throwException)
		{
			this.CheckIUnknown();
			return this.GetInterfaceInternal(t, throwException);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00041402 File Offset: 0x0003F602
		internal IntPtr GetInterface(Type t)
		{
			return this.GetInterface(t, true);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0004140C File Offset: 0x0003F60C
		private void CheckIUnknown()
		{
			if (this.iunknown == IntPtr.Zero)
			{
				throw new InvalidComObjectException("COM object that has been separated from its underlying RCW cannot be used.");
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0004142B File Offset: 0x0003F62B
		internal IntPtr IUnknown
		{
			get
			{
				if (this.iunknown == IntPtr.Zero)
				{
					throw new InvalidComObjectException("COM object that has been separated from its underlying RCW cannot be used.");
				}
				return this.iunknown;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00041450 File Offset: 0x0003F650
		internal IntPtr IDispatch
		{
			get
			{
				IntPtr @interface = this.GetInterface(typeof(IDispatch));
				if (@interface == IntPtr.Zero)
				{
					throw new InvalidComObjectException("COM object that has been separated from its underlying RCW cannot be used.");
				}
				return @interface;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x0004147A File Offset: 0x0003F67A
		internal static Guid IID_IUnknown
		{
			get
			{
				return new Guid("00000000-0000-0000-C000-000000000046");
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00041486 File Offset: 0x0003F686
		internal static Guid IID_IDispatch
		{
			get
			{
				return new Guid("00020400-0000-0000-C000-000000000046");
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00041494 File Offset: 0x0003F694
		public override bool Equals(object obj)
		{
			this.CheckIUnknown();
			if (obj == null)
			{
				return false;
			}
			__ComObject _ComObject = obj as __ComObject;
			return _ComObject != null && this.iunknown == _ComObject.IUnknown;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000414C9 File Offset: 0x0003F6C9
		public override int GetHashCode()
		{
			this.CheckIUnknown();
			return this.iunknown.ToInt32();
		}

		// Token: 0x06000FA3 RID: 4003
		[DllImport("ole32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
		private static extern int CoCreateInstance([MarshalAs(UnmanagedType.LPStruct)] [In] Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, [MarshalAs(UnmanagedType.LPStruct)] [In] Guid riid, out IntPtr pUnk);

		// Token: 0x040005F5 RID: 1525
		private IntPtr iunknown;

		// Token: 0x040005F6 RID: 1526
		private IntPtr hash_table;

		// Token: 0x040005F7 RID: 1527
		private SynchronizationContext synchronization_context;

		// Token: 0x040005F8 RID: 1528
		private ComInteropProxy proxy;
	}
}
