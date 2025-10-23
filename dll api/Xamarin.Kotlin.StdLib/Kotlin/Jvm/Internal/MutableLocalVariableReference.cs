using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001B4 RID: 436
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/MutableLocalVariableReference", DoNotGenerateAcw = true)]
	public class MutableLocalVariableReference : MutablePropertyReference0
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x000456B0 File Offset: 0x000438B0
		internal new static IntPtr class_ref
		{
			get
			{
				return MutableLocalVariableReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x000456D4 File Offset: 0x000438D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MutableLocalVariableReference._members;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x000456DC File Offset: 0x000438DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MutableLocalVariableReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00045700 File Offset: 0x00043900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MutableLocalVariableReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0004570C File Offset: 0x0004390C
		protected MutableLocalVariableReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00045718 File Offset: 0x00043918
		[Register(".ctor", "()V", "")]
		public MutableLocalVariableReference() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MutableLocalVariableReference._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MutableLocalVariableReference._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00045786 File Offset: 0x00043986
		private static Delegate GetGetHandler()
		{
			if (MutableLocalVariableReference.cb_get == null)
			{
				MutableLocalVariableReference.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutableLocalVariableReference.n_Get));
			}
			return MutableLocalVariableReference.cb_get;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000457AA File Offset: 0x000439AA
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutableLocalVariableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000457C0 File Offset: 0x000439C0
		[NullableContext(2)]
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public override Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(MutableLocalVariableReference._members.InstanceMethods.InvokeVirtualObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x000457F2 File Offset: 0x000439F2
		private static Delegate GetSet_Ljava_lang_Object_Handler()
		{
			if (MutableLocalVariableReference.cb_set_Ljava_lang_Object_ == null)
			{
				MutableLocalVariableReference.cb_set_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MutableLocalVariableReference.n_Set_Ljava_lang_Object_));
			}
			return MutableLocalVariableReference.cb_set_Ljava_lang_Object_;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00045818 File Offset: 0x00043A18
		private static void n_Set_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			MutablePropertyReference0 @object = Java.Lang.Object.GetObject<MutableLocalVariableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0004583C File Offset: 0x00043A3C
		[NullableContext(2)]
		[Register("set", "(Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Handler")]
		public unsafe override void Set(Java.Lang.Object value)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				MutableLocalVariableReference._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
		}

		// Token: 0x040006E7 RID: 1767
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutableLocalVariableReference", typeof(MutableLocalVariableReference));

		// Token: 0x040006E8 RID: 1768
		[Nullable(2)]
		private static Delegate cb_get;

		// Token: 0x040006E9 RID: 1769
		[Nullable(2)]
		private static Delegate cb_set_Ljava_lang_Object_;
	}
}
