using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.IO.Path
{
	// Token: 0x02000230 RID: 560
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/FileVisitorBuilder", DoNotGenerateAcw = true)]
	internal class IFileVisitorBuilderInvoker : Java.Lang.Object, IFileVisitorBuilder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00056A74 File Offset: 0x00054C74
		private static IntPtr java_class_ref
		{
			get
			{
				return IFileVisitorBuilderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00056A98 File Offset: 0x00054C98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFileVisitorBuilderInvoker._members;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x00056A9F File Offset: 0x00054C9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00056AA7 File Offset: 0x00054CA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFileVisitorBuilderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00056AB3 File Offset: 0x00054CB3
		[NullableContext(2)]
		public static IFileVisitorBuilder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFileVisitorBuilder>(handle, transfer);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00056ABC File Offset: 0x00054CBC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFileVisitorBuilderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.io.path.FileVisitorBuilder'.");
			}
			return handle;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00056AE7 File Offset: 0x00054CE7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00056B18 File Offset: 0x00054D18
		public IFileVisitorBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFileVisitorBuilderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00056B50 File Offset: 0x00054D50
		private static Delegate GetOnPostVisitDirectory_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IFileVisitorBuilderInvoker.cb_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_ == null)
			{
				IFileVisitorBuilderInvoker.cb_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFileVisitorBuilderInvoker.n_OnPostVisitDirectory_Lkotlin_jvm_functions_Function2_));
			}
			return IFileVisitorBuilderInvoker.cb_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00056B74 File Offset: 0x00054D74
		private static void n_OnPostVisitDirectory_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			IFileVisitorBuilder @object = Java.Lang.Object.GetObject<IFileVisitorBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction2 object2 = Java.Lang.Object.GetObject<IFunction2>(native_function, JniHandleOwnership.DoNotTransfer);
			@object.OnPostVisitDirectory(object2);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00056B98 File Offset: 0x00054D98
		public unsafe void OnPostVisitDirectory(IFunction2 function)
		{
			if (this.id_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "onPostVisitDirectory", "(Lkotlin/jvm/functions/Function2;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_, ptr);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00056C10 File Offset: 0x00054E10
		private static Delegate GetOnPreVisitDirectory_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IFileVisitorBuilderInvoker.cb_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_ == null)
			{
				IFileVisitorBuilderInvoker.cb_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFileVisitorBuilderInvoker.n_OnPreVisitDirectory_Lkotlin_jvm_functions_Function2_));
			}
			return IFileVisitorBuilderInvoker.cb_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00056C34 File Offset: 0x00054E34
		private static void n_OnPreVisitDirectory_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			IFileVisitorBuilder @object = Java.Lang.Object.GetObject<IFileVisitorBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction2 object2 = Java.Lang.Object.GetObject<IFunction2>(native_function, JniHandleOwnership.DoNotTransfer);
			@object.OnPreVisitDirectory(object2);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00056C58 File Offset: 0x00054E58
		public unsafe void OnPreVisitDirectory(IFunction2 function)
		{
			if (this.id_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "onPreVisitDirectory", "(Lkotlin/jvm/functions/Function2;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_, ptr);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00056CD0 File Offset: 0x00054ED0
		private static Delegate GetOnVisitFile_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IFileVisitorBuilderInvoker.cb_onVisitFile_Lkotlin_jvm_functions_Function2_ == null)
			{
				IFileVisitorBuilderInvoker.cb_onVisitFile_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFileVisitorBuilderInvoker.n_OnVisitFile_Lkotlin_jvm_functions_Function2_));
			}
			return IFileVisitorBuilderInvoker.cb_onVisitFile_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00056CF4 File Offset: 0x00054EF4
		private static void n_OnVisitFile_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			IFileVisitorBuilder @object = Java.Lang.Object.GetObject<IFileVisitorBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction2 object2 = Java.Lang.Object.GetObject<IFunction2>(native_function, JniHandleOwnership.DoNotTransfer);
			@object.OnVisitFile(object2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00056D18 File Offset: 0x00054F18
		public unsafe void OnVisitFile(IFunction2 function)
		{
			if (this.id_onVisitFile_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_onVisitFile_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "onVisitFile", "(Lkotlin/jvm/functions/Function2;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onVisitFile_Lkotlin_jvm_functions_Function2_, ptr);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00056D90 File Offset: 0x00054F90
		private static Delegate GetOnVisitFileFailed_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IFileVisitorBuilderInvoker.cb_onVisitFileFailed_Lkotlin_jvm_functions_Function2_ == null)
			{
				IFileVisitorBuilderInvoker.cb_onVisitFileFailed_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFileVisitorBuilderInvoker.n_OnVisitFileFailed_Lkotlin_jvm_functions_Function2_));
			}
			return IFileVisitorBuilderInvoker.cb_onVisitFileFailed_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00056DB4 File Offset: 0x00054FB4
		private static void n_OnVisitFileFailed_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			IFileVisitorBuilder @object = Java.Lang.Object.GetObject<IFileVisitorBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction2 object2 = Java.Lang.Object.GetObject<IFunction2>(native_function, JniHandleOwnership.DoNotTransfer);
			@object.OnVisitFileFailed(object2);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00056DD8 File Offset: 0x00054FD8
		public unsafe void OnVisitFileFailed(IFunction2 function)
		{
			if (this.id_onVisitFileFailed_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_onVisitFileFailed_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "onVisitFileFailed", "(Lkotlin/jvm/functions/Function2;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onVisitFileFailed_Lkotlin_jvm_functions_Function2_, ptr);
		}

		// Token: 0x040007E9 RID: 2025
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/FileVisitorBuilder", typeof(IFileVisitorBuilderInvoker));

		// Token: 0x040007EA RID: 2026
		private IntPtr class_ref;

		// Token: 0x040007EB RID: 2027
		[Nullable(2)]
		private static Delegate cb_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040007EC RID: 2028
		private IntPtr id_onPostVisitDirectory_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040007ED RID: 2029
		[Nullable(2)]
		private static Delegate cb_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040007EE RID: 2030
		private IntPtr id_onPreVisitDirectory_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040007EF RID: 2031
		[Nullable(2)]
		private static Delegate cb_onVisitFile_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040007F0 RID: 2032
		private IntPtr id_onVisitFile_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040007F1 RID: 2033
		[Nullable(2)]
		private static Delegate cb_onVisitFileFailed_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040007F2 RID: 2034
		private IntPtr id_onVisitFileFailed_Lkotlin_jvm_functions_Function2_;
	}
}
