using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000158 RID: 344
	[Register("com/bumptech/glide/load/engine/LoadPath", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data",
		"ResourceType",
		"Transcode"
	})]
	public class LoadPath : Java.Lang.Object
	{
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00038138 File Offset: 0x00036338
		internal static IntPtr class_ref
		{
			get
			{
				return LoadPath._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0003815C File Offset: 0x0003635C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadPath._members;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00038164 File Offset: 0x00036364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadPath._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00038188 File Offset: 0x00036388
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadPath._members.ManagedPeerType;
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00038194 File Offset: 0x00036394
		protected LoadPath(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x000381A0 File Offset: 0x000363A0
		[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;Landroidx/core/util/Pools$Pool;)V", "")]
		public unsafe LoadPath(Class dataClass, Class resourceClass, Class transcodeClass, IList decodePaths, Pools.IPool listPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList.ToLocalJniHandle(decodePaths);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue((listPool == null) ? IntPtr.Zero : ((Java.Lang.Object)listPool).Handle);
				base.SetHandle(LoadPath._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;Landroidx/core/util/Pools$Pool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadPath._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;Landroidx/core/util/Pools$Pool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(decodePaths);
				GC.KeepAlive(listPool);
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00038300 File Offset: 0x00036500
		private static Delegate GetGetDataClassHandler()
		{
			if (LoadPath.cb_getDataClass == null)
			{
				LoadPath.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LoadPath.n_GetDataClass));
			}
			return LoadPath.cb_getDataClass;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00038324 File Offset: 0x00036524
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LoadPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00038338 File Offset: 0x00036538
		public virtual Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(LoadPath._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040003FE RID: 1022
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/LoadPath", typeof(LoadPath));

		// Token: 0x040003FF RID: 1023
		private static Delegate cb_getDataClass;
	}
}
