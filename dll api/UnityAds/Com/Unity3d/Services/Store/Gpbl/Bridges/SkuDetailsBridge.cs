using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000058 RID: 88
	[Register("com/unity3d/services/store/gpbl/bridges/SkuDetailsBridge", DoNotGenerateAcw = true)]
	public class SkuDetailsBridge : CommonJsonResponseBridge
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000063B0 File Offset: 0x000045B0
		internal new static IntPtr class_ref
		{
			get
			{
				return SkuDetailsBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000063D4 File Offset: 0x000045D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SkuDetailsBridge._members;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000063DC File Offset: 0x000045DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SkuDetailsBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00006400 File Offset: 0x00004600
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SkuDetailsBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00005CD5 File Offset: 0x00003ED5
		protected SkuDetailsBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000640C File Offset: 0x0000460C
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe SkuDetailsBridge(Java.Lang.Object skuDetails) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((skuDetails == null) ? IntPtr.Zero : skuDetails.Handle);
				base.SetHandle(SkuDetailsBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SkuDetailsBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(skuDetails);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000064BC File Offset: 0x000046BC
		private static Delegate GetGetClassNameHandler()
		{
			if (SkuDetailsBridge.cb_getClassName == null)
			{
				SkuDetailsBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SkuDetailsBridge.n_GetClassName));
			}
			return SkuDetailsBridge.cb_getClassName;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000064E0 File Offset: 0x000046E0
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<SkuDetailsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000064F4 File Offset: 0x000046F4
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(SkuDetailsBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/SkuDetailsBridge", typeof(SkuDetailsBridge));

		// Token: 0x0400005A RID: 90
		private static Delegate cb_getClassName;
	}
}
