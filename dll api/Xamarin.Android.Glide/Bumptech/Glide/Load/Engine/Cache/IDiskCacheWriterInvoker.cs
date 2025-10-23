using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000165 RID: 357
	[Register("com/bumptech/glide/load/engine/cache/DiskCache$Writer", DoNotGenerateAcw = true)]
	internal class IDiskCacheWriterInvoker : Java.Lang.Object, IDiskCacheWriter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0003992C File Offset: 0x00037B2C
		private static IntPtr java_class_ref
		{
			get
			{
				return IDiskCacheWriterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00039950 File Offset: 0x00037B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDiskCacheWriterInvoker._members;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00039957 File Offset: 0x00037B57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x0003995F File Offset: 0x00037B5F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDiskCacheWriterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0003996B File Offset: 0x00037B6B
		public static IDiskCacheWriter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDiskCacheWriter>(handle, transfer);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00039974 File Offset: 0x00037B74
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDiskCacheWriterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.cache.DiskCache.Writer'.");
			}
			return handle;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0003999F File Offset: 0x00037B9F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000399D0 File Offset: 0x00037BD0
		public IDiskCacheWriterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDiskCacheWriterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00039A08 File Offset: 0x00037C08
		private static Delegate GetWrite_Ljava_io_File_Handler()
		{
			if (IDiskCacheWriterInvoker.cb_write_Ljava_io_File_ == null)
			{
				IDiskCacheWriterInvoker.cb_write_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IDiskCacheWriterInvoker.n_Write_Ljava_io_File_));
			}
			return IDiskCacheWriterInvoker.cb_write_Ljava_io_File_;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00039A2C File Offset: 0x00037C2C
		private static bool n_Write_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDiskCacheWriter @object = Java.Lang.Object.GetObject<IDiskCacheWriter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.Write(object2);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00039A50 File Offset: 0x00037C50
		public unsafe bool Write(File p0)
		{
			if (this.id_write_Ljava_io_File_ == IntPtr.Zero)
			{
				this.id_write_Ljava_io_File_ = JNIEnv.GetMethodID(this.class_ref, "write", "(Ljava/io/File;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_write_Ljava_io_File_, ptr);
		}

		// Token: 0x04000416 RID: 1046
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskCache$Writer", typeof(IDiskCacheWriterInvoker));

		// Token: 0x04000417 RID: 1047
		private IntPtr class_ref;

		// Token: 0x04000418 RID: 1048
		private static Delegate cb_write_Ljava_io_File_;

		// Token: 0x04000419 RID: 1049
		private IntPtr id_write_Ljava_io_File_;
	}
}
