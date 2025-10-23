using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Lang.Annotation;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000193 RID: 403
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/CallableReference", DoNotGenerateAcw = true)]
	public abstract class CallableReference : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IKCallable, IKAnnotatedElement
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x000401C0 File Offset: 0x0003E3C0
		[Register("NO_RECEIVER")]
		public static Java.Lang.Object NoReceiver
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(CallableReference._members.StaticFields.GetObjectValue("NO_RECEIVER.Ljava/lang/Object;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x000401F0 File Offset: 0x0003E3F0
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x00040220 File Offset: 0x0003E420
		[Register("receiver")]
		protected Java.Lang.Object Receiver
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(CallableReference._members.InstanceFields.GetObjectValue("receiver.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					CallableReference._members.InstanceFields.SetValue("receiver.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0004026C File Offset: 0x0003E46C
		internal static IntPtr class_ref
		{
			get
			{
				return CallableReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00040290 File Offset: 0x0003E490
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return CallableReference._members;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00040298 File Offset: 0x0003E498
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CallableReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x000402BC File Offset: 0x0003E4BC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return CallableReference._members.ManagedPeerType;
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000402C8 File Offset: 0x0003E4C8
		protected CallableReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000402D4 File Offset: 0x0003E4D4
		[Register(".ctor", "()V", "")]
		public CallableReference() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CallableReference._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CallableReference._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00040344 File Offset: 0x0003E544
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		protected unsafe CallableReference(Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(CallableReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CallableReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000403F4 File Offset: 0x0003E5F4
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		protected unsafe CallableReference(Java.Lang.Object receiver, Class owner, string name, string signature, bool isTopLevel) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(signature);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : owner.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				ptr[4] = new JniArgumentValue(isTopLevel);
				base.SetHandle(CallableReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CallableReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00040528 File Offset: 0x0003E728
		[NullableContext(1)]
		private static Delegate GetGetAnnotationsHandler()
		{
			if (CallableReference.cb_getAnnotations == null)
			{
				CallableReference.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetAnnotations));
			}
			return CallableReference.cb_getAnnotations;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0004054C File Offset: 0x0003E74C
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00040560 File Offset: 0x0003E760
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual IList<IAnnotation> Annotations
		{
			[Register("getAnnotations", "()Ljava/util/List;", "GetGetAnnotationsHandler")]
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return JavaList<IAnnotation>.FromJniHandle(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getAnnotations.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00040592 File Offset: 0x0003E792
		[NullableContext(1)]
		private static Delegate GetGetBoundReceiverHandler()
		{
			if (CallableReference.cb_getBoundReceiver == null)
			{
				CallableReference.cb_getBoundReceiver = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetBoundReceiver));
			}
			return CallableReference.cb_getBoundReceiver;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x000405B6 File Offset: 0x0003E7B6
		private static IntPtr n_GetBoundReceiver(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoundReceiver);
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x000405CC File Offset: 0x0003E7CC
		public virtual Java.Lang.Object BoundReceiver
		{
			[Register("getBoundReceiver", "()Ljava/lang/Object;", "GetGetBoundReceiverHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getBoundReceiver.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000405FE File Offset: 0x0003E7FE
		[NullableContext(1)]
		private static Delegate GetIsAbstractHandler()
		{
			if (CallableReference.cb_isAbstract == null)
			{
				CallableReference.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CallableReference.n_IsAbstract));
			}
			return CallableReference.cb_isAbstract;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00040622 File Offset: 0x0003E822
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00040631 File Offset: 0x0003E831
		public virtual bool IsAbstract
		{
			[Register("isAbstract", "()Z", "GetIsAbstractHandler")]
			get
			{
				return CallableReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isAbstract.()Z", this, null);
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0004064A File Offset: 0x0003E84A
		[NullableContext(1)]
		private static Delegate GetIsFinalHandler()
		{
			if (CallableReference.cb_isFinal == null)
			{
				CallableReference.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CallableReference.n_IsFinal));
			}
			return CallableReference.cb_isFinal;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0004066E File Offset: 0x0003E86E
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0004067D File Offset: 0x0003E87D
		public virtual bool IsFinal
		{
			[Register("isFinal", "()Z", "GetIsFinalHandler")]
			get
			{
				return CallableReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isFinal.()Z", this, null);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00040696 File Offset: 0x0003E896
		[NullableContext(1)]
		private static Delegate GetIsOpenHandler()
		{
			if (CallableReference.cb_isOpen == null)
			{
				CallableReference.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CallableReference.n_IsOpen));
			}
			return CallableReference.cb_isOpen;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000406BA File Offset: 0x0003E8BA
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x000406C9 File Offset: 0x0003E8C9
		public virtual bool IsOpen
		{
			[Register("isOpen", "()Z", "GetIsOpenHandler")]
			get
			{
				return CallableReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isOpen.()Z", this, null);
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000406E2 File Offset: 0x0003E8E2
		[NullableContext(1)]
		private static Delegate GetIsSuspendHandler()
		{
			if (CallableReference.cb_isSuspend == null)
			{
				CallableReference.cb_isSuspend = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CallableReference.n_IsSuspend));
			}
			return CallableReference.cb_isSuspend;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00040706 File Offset: 0x0003E906
		private static bool n_IsSuspend(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuspend;
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00040715 File Offset: 0x0003E915
		public virtual bool IsSuspend
		{
			[Register("isSuspend", "()Z", "GetIsSuspendHandler")]
			get
			{
				return CallableReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isSuspend.()Z", this, null);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0004072E File Offset: 0x0003E92E
		[NullableContext(1)]
		private static Delegate GetGetNameHandler()
		{
			if (CallableReference.cb_getName == null)
			{
				CallableReference.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetName));
			}
			return CallableReference.cb_getName;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00040752 File Offset: 0x0003E952
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00040768 File Offset: 0x0003E968
		public virtual string Name
		{
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get
			{
				return JNIEnv.GetString(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0004079A File Offset: 0x0003E99A
		[NullableContext(1)]
		private static Delegate GetGetOwnerHandler()
		{
			if (CallableReference.cb_getOwner == null)
			{
				CallableReference.cb_getOwner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetOwner));
			}
			return CallableReference.cb_getOwner;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x000407BE File Offset: 0x0003E9BE
		private static IntPtr n_GetOwner(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Owner);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000407D4 File Offset: 0x0003E9D4
		public virtual IKDeclarationContainer Owner
		{
			[Register("getOwner", "()Lkotlin/reflect/KDeclarationContainer;", "GetGetOwnerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKDeclarationContainer>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getOwner.()Lkotlin/reflect/KDeclarationContainer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00040806 File Offset: 0x0003EA06
		[NullableContext(1)]
		private static Delegate GetGetParametersHandler()
		{
			if (CallableReference.cb_getParameters == null)
			{
				CallableReference.cb_getParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetParameters));
			}
			return CallableReference.cb_getParameters;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0004082A File Offset: 0x0003EA2A
		private static IntPtr n_GetParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parameters);
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00040840 File Offset: 0x0003EA40
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual IList<IKParameter> Parameters
		{
			[Register("getParameters", "()Ljava/util/List;", "GetGetParametersHandler")]
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return JavaList<IKParameter>.FromJniHandle(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getParameters.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00040872 File Offset: 0x0003EA72
		[NullableContext(1)]
		private static Delegate GetGetReflectedHandler()
		{
			if (CallableReference.cb_getReflected == null)
			{
				CallableReference.cb_getReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetReflected));
			}
			return CallableReference.cb_getReflected;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00040896 File Offset: 0x0003EA96
		private static IntPtr n_GetReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reflected);
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x000408AC File Offset: 0x0003EAAC
		protected virtual IKCallable Reflected
		{
			[Register("getReflected", "()Lkotlin/reflect/KCallable;", "GetGetReflectedHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKCallable>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000408DE File Offset: 0x0003EADE
		[NullableContext(1)]
		private static Delegate GetGetReturnTypeHandler()
		{
			if (CallableReference.cb_getReturnType == null)
			{
				CallableReference.cb_getReturnType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetReturnType));
			}
			return CallableReference.cb_getReturnType;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00040902 File Offset: 0x0003EB02
		private static IntPtr n_GetReturnType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnType);
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00040918 File Offset: 0x0003EB18
		public virtual IKType ReturnType
		{
			[Register("getReturnType", "()Lkotlin/reflect/KType;", "GetGetReturnTypeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKType>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getReturnType.()Lkotlin/reflect/KType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0004094A File Offset: 0x0003EB4A
		[NullableContext(1)]
		private static Delegate GetGetSignatureHandler()
		{
			if (CallableReference.cb_getSignature == null)
			{
				CallableReference.cb_getSignature = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetSignature));
			}
			return CallableReference.cb_getSignature;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0004096E File Offset: 0x0003EB6E
		private static IntPtr n_GetSignature(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Signature);
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x00040984 File Offset: 0x0003EB84
		public virtual string Signature
		{
			[Register("getSignature", "()Ljava/lang/String;", "GetGetSignatureHandler")]
			get
			{
				return JNIEnv.GetString(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getSignature.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000409B6 File Offset: 0x0003EBB6
		[NullableContext(1)]
		private static Delegate GetGetTypeParametersHandler()
		{
			if (CallableReference.cb_getTypeParameters == null)
			{
				CallableReference.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetTypeParameters));
			}
			return CallableReference.cb_getTypeParameters;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000409DA File Offset: 0x0003EBDA
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x000409F0 File Offset: 0x0003EBF0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual IList<IKTypeParameter> TypeParameters
		{
			[Register("getTypeParameters", "()Ljava/util/List;", "GetGetTypeParametersHandler")]
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return JavaList<IKTypeParameter>.FromJniHandle(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getTypeParameters.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00040A22 File Offset: 0x0003EC22
		[NullableContext(1)]
		private static Delegate GetGetVisibilityHandler()
		{
			if (CallableReference.cb_getVisibility == null)
			{
				CallableReference.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_GetVisibility));
			}
			return CallableReference.cb_getVisibility;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00040A46 File Offset: 0x0003EC46
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00040A5C File Offset: 0x0003EC5C
		public virtual KVisibility Visibility
		{
			[Register("getVisibility", "()Lkotlin/reflect/KVisibility;", "GetGetVisibilityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<KVisibility>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("getVisibility.()Lkotlin/reflect/KVisibility;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00040A8E File Offset: 0x0003EC8E
		[NullableContext(1)]
		private static Delegate GetCall_arrayLjava_lang_Object_Handler()
		{
			if (CallableReference.cb_call_arrayLjava_lang_Object_ == null)
			{
				CallableReference.cb_call_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CallableReference.n_Call_arrayLjava_lang_Object_));
			}
			return CallableReference.cb_call_arrayLjava_lang_Object_;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00040AB4 File Offset: 0x0003ECB4
		private static IntPtr n_Call_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			CallableReference @object = Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Call(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00040AF8 File Offset: 0x0003ECF8
		[Register("call", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetCall_arrayLjava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Call([Nullable(new byte[]
		{
			2,
			1
		})] params Java.Lang.Object[] args)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(args);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("call.([Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (args != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, args);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00040B74 File Offset: 0x0003ED74
		[NullableContext(1)]
		private static Delegate GetCallBy_Ljava_util_Map_Handler()
		{
			if (CallableReference.cb_callBy_Ljava_util_Map_ == null)
			{
				CallableReference.cb_callBy_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CallableReference.n_CallBy_Ljava_util_Map_));
			}
			return CallableReference.cb_callBy_Ljava_util_Map_;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00040B98 File Offset: 0x0003ED98
		private static IntPtr n_CallBy_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			CallableReference @object = Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary args = JavaDictionary.FromJniHandle(native_args, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallBy(args));
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00040BC0 File Offset: 0x0003EDC0
		[Register("callBy", "(Ljava/util/Map;)Ljava/lang/Object;", "GetCallBy_Ljava_util_Map_Handler")]
		public unsafe virtual Java.Lang.Object CallBy(IDictionary args)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(args);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("callBy.(Ljava/util/Map;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00040C34 File Offset: 0x0003EE34
		[NullableContext(1)]
		private static Delegate GetComputeHandler()
		{
			if (CallableReference.cb_compute == null)
			{
				CallableReference.cb_compute = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_Compute));
			}
			return CallableReference.cb_compute;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00040C58 File Offset: 0x0003EE58
		private static IntPtr n_Compute(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Compute());
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00040C6C File Offset: 0x0003EE6C
		[Register("compute", "()Lkotlin/reflect/KCallable;", "GetComputeHandler")]
		public virtual IKCallable Compute()
		{
			return Java.Lang.Object.GetObject<IKCallable>(CallableReference._members.InstanceMethods.InvokeVirtualObjectMethod("compute.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00040C9E File Offset: 0x0003EE9E
		[NullableContext(1)]
		private static Delegate GetComputeReflectedHandler()
		{
			if (CallableReference.cb_computeReflected == null)
			{
				CallableReference.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CallableReference.n_ComputeReflected));
			}
			return CallableReference.cb_computeReflected;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00040CC2 File Offset: 0x0003EEC2
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CallableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x060013F2 RID: 5106
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected abstract IKCallable ComputeReflected();

		// Token: 0x0400067E RID: 1662
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/CallableReference", typeof(CallableReference));

		// Token: 0x0400067F RID: 1663
		private static Delegate cb_getAnnotations;

		// Token: 0x04000680 RID: 1664
		private static Delegate cb_getBoundReceiver;

		// Token: 0x04000681 RID: 1665
		private static Delegate cb_isAbstract;

		// Token: 0x04000682 RID: 1666
		private static Delegate cb_isFinal;

		// Token: 0x04000683 RID: 1667
		private static Delegate cb_isOpen;

		// Token: 0x04000684 RID: 1668
		private static Delegate cb_isSuspend;

		// Token: 0x04000685 RID: 1669
		private static Delegate cb_getName;

		// Token: 0x04000686 RID: 1670
		private static Delegate cb_getOwner;

		// Token: 0x04000687 RID: 1671
		private static Delegate cb_getParameters;

		// Token: 0x04000688 RID: 1672
		private static Delegate cb_getReflected;

		// Token: 0x04000689 RID: 1673
		private static Delegate cb_getReturnType;

		// Token: 0x0400068A RID: 1674
		private static Delegate cb_getSignature;

		// Token: 0x0400068B RID: 1675
		private static Delegate cb_getTypeParameters;

		// Token: 0x0400068C RID: 1676
		private static Delegate cb_getVisibility;

		// Token: 0x0400068D RID: 1677
		private static Delegate cb_call_arrayLjava_lang_Object_;

		// Token: 0x0400068E RID: 1678
		private static Delegate cb_callBy_Ljava_util_Map_;

		// Token: 0x0400068F RID: 1679
		private static Delegate cb_compute;

		// Token: 0x04000690 RID: 1680
		private static Delegate cb_computeReflected;
	}
}
