using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000107 RID: 263
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KDeclarationContainer", DoNotGenerateAcw = true)]
	internal class IKDeclarationContainerInvoker : Java.Lang.Object, IKDeclarationContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0002A580 File Offset: 0x00028780
		private static IntPtr java_class_ref
		{
			get
			{
				return IKDeclarationContainerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0002A5A4 File Offset: 0x000287A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKDeclarationContainerInvoker._members;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0002A5AB File Offset: 0x000287AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0002A5B3 File Offset: 0x000287B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKDeclarationContainerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0002A5BF File Offset: 0x000287BF
		[NullableContext(2)]
		public static IKDeclarationContainer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKDeclarationContainer>(handle, transfer);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0002A5C8 File Offset: 0x000287C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKDeclarationContainerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KDeclarationContainer'.");
			}
			return handle;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0002A5F3 File Offset: 0x000287F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0002A624 File Offset: 0x00028824
		public IKDeclarationContainerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKDeclarationContainerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0002A65C File Offset: 0x0002885C
		private static Delegate GetGetMembersHandler()
		{
			if (IKDeclarationContainerInvoker.cb_getMembers == null)
			{
				IKDeclarationContainerInvoker.cb_getMembers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKDeclarationContainerInvoker.n_GetMembers));
			}
			return IKDeclarationContainerInvoker.cb_getMembers;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0002A680 File Offset: 0x00028880
		private static IntPtr n_GetMembers(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection<IKCallable>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKDeclarationContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Members);
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x0002A694 File Offset: 0x00028894
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

		// Token: 0x040002BA RID: 698
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KDeclarationContainer", typeof(IKDeclarationContainerInvoker));

		// Token: 0x040002BB RID: 699
		private IntPtr class_ref;

		// Token: 0x040002BC RID: 700
		[Nullable(2)]
		private static Delegate cb_getMembers;

		// Token: 0x040002BD RID: 701
		private IntPtr id_getMembers;
	}
}
