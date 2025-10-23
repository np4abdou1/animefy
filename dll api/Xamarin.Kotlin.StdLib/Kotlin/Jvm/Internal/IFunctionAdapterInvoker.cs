using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A0 RID: 416
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/FunctionAdapter", DoNotGenerateAcw = true)]
	internal class IFunctionAdapterInvoker : Java.Lang.Object, IFunctionAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x000422B8 File Offset: 0x000404B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunctionAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x000422DC File Offset: 0x000404DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFunctionAdapterInvoker._members;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x000422E3 File Offset: 0x000404E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x000422EB File Offset: 0x000404EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFunctionAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000422F7 File Offset: 0x000404F7
		[NullableContext(2)]
		public static IFunctionAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunctionAdapter>(handle, transfer);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00042300 File Offset: 0x00040500
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunctionAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.FunctionAdapter'.");
			}
			return handle;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0004232B File Offset: 0x0004052B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0004235C File Offset: 0x0004055C
		public IFunctionAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunctionAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00042394 File Offset: 0x00040594
		private static Delegate GetGetFunctionDelegateHandler()
		{
			if (IFunctionAdapterInvoker.cb_getFunctionDelegate == null)
			{
				IFunctionAdapterInvoker.cb_getFunctionDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFunctionAdapterInvoker.n_GetFunctionDelegate));
			}
			return IFunctionAdapterInvoker.cb_getFunctionDelegate;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000423B8 File Offset: 0x000405B8
		private static IntPtr n_GetFunctionDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFunctionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FunctionDelegate);
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x000423CC File Offset: 0x000405CC
		[Nullable(2)]
		public IFunction FunctionDelegate
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getFunctionDelegate == IntPtr.Zero)
				{
					this.id_getFunctionDelegate = JNIEnv.GetMethodID(this.class_ref, "getFunctionDelegate", "()Lkotlin/Function;");
				}
				return Java.Lang.Object.GetObject<IFunction>(JNIEnv.CallObjectMethod(base.Handle, this.id_getFunctionDelegate), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040006A6 RID: 1702
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/FunctionAdapter", typeof(IFunctionAdapterInvoker));

		// Token: 0x040006A7 RID: 1703
		private IntPtr class_ref;

		// Token: 0x040006A8 RID: 1704
		[Nullable(2)]
		private static Delegate cb_getFunctionDelegate;

		// Token: 0x040006A9 RID: 1705
		private IntPtr id_getFunctionDelegate;
	}
}
