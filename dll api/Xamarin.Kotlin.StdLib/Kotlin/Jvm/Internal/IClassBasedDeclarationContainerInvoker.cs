using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x0200019E RID: 414
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/ClassBasedDeclarationContainer", DoNotGenerateAcw = true)]
	internal class IClassBasedDeclarationContainerInvoker : Java.Lang.Object, IClassBasedDeclarationContainer, IKDeclarationContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x000420AC File Offset: 0x000402AC
		private static IntPtr java_class_ref
		{
			get
			{
				return IClassBasedDeclarationContainerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x000420D0 File Offset: 0x000402D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IClassBasedDeclarationContainerInvoker._members;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x000420D7 File Offset: 0x000402D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x000420DF File Offset: 0x000402DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IClassBasedDeclarationContainerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x000420EB File Offset: 0x000402EB
		[NullableContext(2)]
		public static IClassBasedDeclarationContainer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IClassBasedDeclarationContainer>(handle, transfer);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000420F4 File Offset: 0x000402F4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IClassBasedDeclarationContainerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.ClassBasedDeclarationContainer'.");
			}
			return handle;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0004211F File Offset: 0x0004031F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00042150 File Offset: 0x00040350
		public IClassBasedDeclarationContainerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IClassBasedDeclarationContainerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00042188 File Offset: 0x00040388
		private static Delegate GetGetJClassHandler()
		{
			if (IClassBasedDeclarationContainerInvoker.cb_getJClass == null)
			{
				IClassBasedDeclarationContainerInvoker.cb_getJClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClassBasedDeclarationContainerInvoker.n_GetJClass));
			}
			return IClassBasedDeclarationContainerInvoker.cb_getJClass;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000421AC File Offset: 0x000403AC
		private static IntPtr n_GetJClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClassBasedDeclarationContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).JClass);
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x000421C0 File Offset: 0x000403C0
		public Class JClass
		{
			get
			{
				if (this.id_getJClass == IntPtr.Zero)
				{
					this.id_getJClass = JNIEnv.GetMethodID(this.class_ref, "getJClass", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_getJClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00042211 File Offset: 0x00040411
		private static Delegate GetGetMembersHandler()
		{
			if (IClassBasedDeclarationContainerInvoker.cb_getMembers == null)
			{
				IClassBasedDeclarationContainerInvoker.cb_getMembers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClassBasedDeclarationContainerInvoker.n_GetMembers));
			}
			return IClassBasedDeclarationContainerInvoker.cb_getMembers;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00042235 File Offset: 0x00040435
		private static IntPtr n_GetMembers(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection<IKCallable>.ToLocalJniHandle(Java.Lang.Object.GetObject<IClassBasedDeclarationContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Members);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0004224C File Offset: 0x0004044C
		public ICollection<IKCallable> Members
		{
			get
			{
				if (this.id_getMembers == IntPtr.Zero)
				{
					this.id_getMembers = JNIEnv.GetMethodID(this.class_ref, "getMembers", "()Ljava/util/Collection;");
				}
				return JavaCollection<IKCallable>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getMembers), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040006A0 RID: 1696
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ClassBasedDeclarationContainer", typeof(IClassBasedDeclarationContainerInvoker));

		// Token: 0x040006A1 RID: 1697
		private IntPtr class_ref;

		// Token: 0x040006A2 RID: 1698
		[Nullable(2)]
		private static Delegate cb_getJClass;

		// Token: 0x040006A3 RID: 1699
		private IntPtr id_getJClass;

		// Token: 0x040006A4 RID: 1700
		[Nullable(2)]
		private static Delegate cb_getMembers;

		// Token: 0x040006A5 RID: 1701
		private IntPtr id_getMembers;
	}
}
