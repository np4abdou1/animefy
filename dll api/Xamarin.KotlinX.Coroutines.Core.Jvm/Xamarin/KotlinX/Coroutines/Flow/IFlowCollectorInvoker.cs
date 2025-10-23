using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000AC RID: 172
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/FlowCollector", DoNotGenerateAcw = true)]
	internal class IFlowCollectorInvoker : Java.Lang.Object, IFlowCollector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001D544 File Offset: 0x0001B744
		private static IntPtr java_class_ref
		{
			get
			{
				return IFlowCollectorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0001D568 File Offset: 0x0001B768
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFlowCollectorInvoker._members;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0001D56F File Offset: 0x0001B76F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0001D577 File Offset: 0x0001B777
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFlowCollectorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0001D583 File Offset: 0x0001B783
		[NullableContext(2)]
		public static IFlowCollector GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFlowCollector>(handle, transfer);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0001D58C File Offset: 0x0001B78C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFlowCollectorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.flow.FlowCollector'.");
			}
			return handle;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001D5B7 File Offset: 0x0001B7B7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0001D5E8 File Offset: 0x0001B7E8
		public IFlowCollectorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFlowCollectorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0001D620 File Offset: 0x0001B820
		private static Delegate GetEmit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IFlowCollectorInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				IFlowCollectorInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IFlowCollectorInvoker.n_Emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return IFlowCollectorInvoker.cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0001D644 File Offset: 0x0001B844
		private static IntPtr n_Emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_p1)
		{
			IFlowCollector @object = Java.Lang.Object.GetObject<IFlowCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Emit(object2, object3));
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0001D678 File Offset: 0x0001B878
		[NullableContext(2)]
		public unsafe Java.Lang.Object Emit(Java.Lang.Object value, [Nullable(1)] IContinuation p1)
		{
			if (this.id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "emit", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0400027D RID: 637
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/FlowCollector", typeof(IFlowCollectorInvoker));

		// Token: 0x0400027E RID: 638
		private IntPtr class_ref;

		// Token: 0x0400027F RID: 639
		[Nullable(2)]
		private static Delegate cb_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000280 RID: 640
		private IntPtr id_emit_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
	}
}
