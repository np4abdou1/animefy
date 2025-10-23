using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x0200018E RID: 398
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/AdaptedFunctionReference", DoNotGenerateAcw = true)]
	public class AdaptedFunctionReference : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IFunctionBase, IFunction
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0003F460 File Offset: 0x0003D660
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x0003F490 File Offset: 0x0003D690
		[Register("receiver")]
		protected Java.Lang.Object Receiver
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(AdaptedFunctionReference._members.InstanceFields.GetObjectValue("receiver.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					AdaptedFunctionReference._members.InstanceFields.SetValue("receiver.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0003F4DC File Offset: 0x0003D6DC
		internal static IntPtr class_ref
		{
			get
			{
				return AdaptedFunctionReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0003F500 File Offset: 0x0003D700
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AdaptedFunctionReference._members;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0003F508 File Offset: 0x0003D708
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdaptedFunctionReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0003F52C File Offset: 0x0003D72C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AdaptedFunctionReference._members.ManagedPeerType;
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0003F538 File Offset: 0x0003D738
		protected AdaptedFunctionReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0003F544 File Offset: 0x0003D744
		[Register(".ctor", "(ILjava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe AdaptedFunctionReference(int arity, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				*ptr = new JniArgumentValue(arity);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : owner.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				ptr[4] = new JniArgumentValue(flags);
				base.SetHandle(AdaptedFunctionReference._members.InstanceMethods.StartCreateInstance("(ILjava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdaptedFunctionReference._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0003F664 File Offset: 0x0003D864
		[Register(".ctor", "(ILjava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe AdaptedFunctionReference(int arity, Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(signature);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arity);
				ptr[1] = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				ptr[2] = new JniArgumentValue((owner == null) ? IntPtr.Zero : owner.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue(intPtr2);
				ptr[5] = new JniArgumentValue(flags);
				base.SetHandle(AdaptedFunctionReference._members.InstanceMethods.StartCreateInstance("(ILjava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdaptedFunctionReference._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0003F7B0 File Offset: 0x0003D9B0
		[NullableContext(1)]
		private static Delegate GetGetArityHandler()
		{
			if (AdaptedFunctionReference.cb_getArity == null)
			{
				AdaptedFunctionReference.cb_getArity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdaptedFunctionReference.n_GetArity));
			}
			return AdaptedFunctionReference.cb_getArity;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0003F7D4 File Offset: 0x0003D9D4
		private static int n_GetArity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdaptedFunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Arity;
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0003F7E3 File Offset: 0x0003D9E3
		public virtual int Arity
		{
			[Register("getArity", "()I", "GetGetArityHandler")]
			get
			{
				return AdaptedFunctionReference._members.InstanceMethods.InvokeVirtualInt32Method("getArity.()I", this, null);
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0003F7FC File Offset: 0x0003D9FC
		[NullableContext(1)]
		private static Delegate GetGetOwnerHandler()
		{
			if (AdaptedFunctionReference.cb_getOwner == null)
			{
				AdaptedFunctionReference.cb_getOwner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdaptedFunctionReference.n_GetOwner));
			}
			return AdaptedFunctionReference.cb_getOwner;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0003F820 File Offset: 0x0003DA20
		private static IntPtr n_GetOwner(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdaptedFunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Owner);
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0003F834 File Offset: 0x0003DA34
		public virtual IKDeclarationContainer Owner
		{
			[Register("getOwner", "()Lkotlin/reflect/KDeclarationContainer;", "GetGetOwnerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKDeclarationContainer>(AdaptedFunctionReference._members.InstanceMethods.InvokeVirtualObjectMethod("getOwner.()Lkotlin/reflect/KDeclarationContainer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000677 RID: 1655
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/AdaptedFunctionReference", typeof(AdaptedFunctionReference));

		// Token: 0x04000678 RID: 1656
		private static Delegate cb_getArity;

		// Token: 0x04000679 RID: 1657
		private static Delegate cb_getOwner;
	}
}
