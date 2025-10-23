using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio.FileNio;

namespace Kotlin.IO.Path
{
	// Token: 0x0200022C RID: 556
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/CopyActionContext", DoNotGenerateAcw = true)]
	internal class ICopyActionContextInvoker : Java.Lang.Object, ICopyActionContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x0005652C File Offset: 0x0005472C
		private static IntPtr java_class_ref
		{
			get
			{
				return ICopyActionContextInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00056550 File Offset: 0x00054750
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICopyActionContextInvoker._members;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00056557 File Offset: 0x00054757
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0005655F File Offset: 0x0005475F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICopyActionContextInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0005656B File Offset: 0x0005476B
		[NullableContext(2)]
		public static ICopyActionContext GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICopyActionContext>(handle, transfer);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00056574 File Offset: 0x00054774
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICopyActionContextInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.io.path.CopyActionContext'.");
			}
			return handle;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0005659F File Offset: 0x0005479F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000565D0 File Offset: 0x000547D0
		public ICopyActionContextInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICopyActionContextInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00056608 File Offset: 0x00054808
		private static Delegate GetCopyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_ZHandler()
		{
			if (ICopyActionContextInvoker.cb_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z == null)
			{
				ICopyActionContextInvoker.cb_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_L(ICopyActionContextInvoker.n_CopyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z));
			}
			return ICopyActionContextInvoker.cb_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z;
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0005662C File Offset: 0x0005482C
		private static IntPtr n_CopyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_target, bool followLinks)
		{
			ICopyActionContext @object = Java.Lang.Object.GetObject<ICopyActionContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPath object2 = Java.Lang.Object.GetObject<IPath>(native_p0, JniHandleOwnership.DoNotTransfer);
			IPath object3 = Java.Lang.Object.GetObject<IPath>(native_target, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CopyToIgnoringExistingDirectory(object2, object3, followLinks));
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00056660 File Offset: 0x00054860
		public unsafe CopyActionResult CopyToIgnoringExistingDirectory(IPath p0, IPath target, bool followLinks)
		{
			if (this.id_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z == IntPtr.Zero)
			{
				this.id_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z = JNIEnv.GetMethodID(this.class_ref, "copyToIgnoringExistingDirectory", "(Ljava/nio/file/Path;Ljava/nio/file/Path;Z)Lkotlin/io/path/CopyActionResult;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
			ptr[2] = new JValue(followLinks);
			return Java.Lang.Object.GetObject<CopyActionResult>(JNIEnv.CallObjectMethod(base.Handle, this.id_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040007DB RID: 2011
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/CopyActionContext", typeof(ICopyActionContextInvoker));

		// Token: 0x040007DC RID: 2012
		private IntPtr class_ref;

		// Token: 0x040007DD RID: 2013
		[Nullable(2)]
		private static Delegate cb_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z;

		// Token: 0x040007DE RID: 2014
		private IntPtr id_copyToIgnoringExistingDirectory_Ljava_nio_file_Path_Ljava_nio_file_Path_Z;
	}
}
