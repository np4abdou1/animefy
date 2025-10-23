using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Internal;

namespace Kotlin
{
	// Token: 0x02000048 RID: 72
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/DeepRecursiveScope", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T",
		"R"
	})]
	public abstract class DeepRecursiveScope : Java.Lang.Object
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000029C4 File Offset: 0x00000BC4
		internal static IntPtr class_ref
		{
			get
			{
				return DeepRecursiveScope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000029E8 File Offset: 0x00000BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeepRecursiveScope._members;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000029F0 File Offset: 0x00000BF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeepRecursiveScope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00002A14 File Offset: 0x00000C14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeepRecursiveScope._members.ManagedPeerType;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002A20 File Offset: 0x00000C20
		protected DeepRecursiveScope(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002A2C File Offset: 0x00000C2C
		[NullableContext(2)]
		[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe DeepRecursiveScope(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
				base.SetHandle(DeepRecursiveScope._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeepRecursiveScope._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_constructor_marker);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002ADC File Offset: 0x00000CDC
		private static Delegate GetCallRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (DeepRecursiveScope.cb_callRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				DeepRecursiveScope.cb_callRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(DeepRecursiveScope.n_CallRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return DeepRecursiveScope.cb_callRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002B00 File Offset: 0x00000D00
		private static IntPtr n_CallRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_value, IntPtr native_p2)
		{
			DeepRecursiveScope @object = Java.Lang.Object.GetObject<DeepRecursiveScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DeepRecursiveFunction object2 = Java.Lang.Object.GetObject<DeepRecursiveFunction>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IContinuation object4 = Java.Lang.Object.GetObject<IContinuation>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallRecursive(object2, object3, object4));
		}

		// Token: 0x06000126 RID: 294
		[Register("callRecursive", "(Lkotlin/DeepRecursiveFunction;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCallRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"U",
			"S"
		})]
		[return: Nullable(2)]
		public abstract Java.Lang.Object CallRecursive(DeepRecursiveFunction p0, [Nullable(2)] Java.Lang.Object value, IContinuation p2);

		// Token: 0x06000127 RID: 295 RVA: 0x00002B3B File Offset: 0x00000D3B
		private static Delegate GetCallRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (DeepRecursiveScope.cb_callRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				DeepRecursiveScope.cb_callRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(DeepRecursiveScope.n_CallRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return DeepRecursiveScope.cb_callRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002B60 File Offset: 0x00000D60
		private static IntPtr n_CallRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_p1)
		{
			DeepRecursiveScope @object = Java.Lang.Object.GetObject<DeepRecursiveScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallRecursive(object2, object3));
		}

		// Token: 0x06000129 RID: 297
		[NullableContext(2)]
		[Register("callRecursive", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCallRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler")]
		public abstract Java.Lang.Object CallRecursive(Java.Lang.Object value, [Nullable(1)] IContinuation p1);

		// Token: 0x0600012A RID: 298 RVA: 0x00002B94 File Offset: 0x00000D94
		[Obsolete("deprecated")]
		[Register("invoke", "(Lkotlin/DeepRecursiveFunction;Ljava/lang/Object;)Ljava/lang/Void;", "")]
		public unsafe Java.Lang.Void Invoke(DeepRecursiveFunction _this_invoke, [Nullable(2)] Java.Lang.Object value)
		{
			Java.Lang.Void @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_invoke == null) ? IntPtr.Zero : _this_invoke.Handle);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Void>(DeepRecursiveScope._members.InstanceMethods.InvokeNonvirtualObjectMethod("invoke.(Lkotlin/DeepRecursiveFunction;Ljava/lang/Object;)Ljava/lang/Void;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_invoke);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x04000015 RID: 21
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/DeepRecursiveScope", typeof(DeepRecursiveScope));

		// Token: 0x04000016 RID: 22
		[Nullable(2)]
		private static Delegate cb_callRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000017 RID: 23
		[Nullable(2)]
		private static Delegate cb_callRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
	}
}
