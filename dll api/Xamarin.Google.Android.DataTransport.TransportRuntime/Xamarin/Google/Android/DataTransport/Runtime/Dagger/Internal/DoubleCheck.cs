using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000DD RID: 221
	[Register("com/google/android/datatransport/runtime/dagger/internal/DoubleCheck", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class DoubleCheck : Java.Lang.Object, ILazy, IJavaObject, IDisposable, IJavaPeerable, IProvider
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00015F34 File Offset: 0x00014134
		internal static IntPtr class_ref
		{
			get
			{
				return DoubleCheck._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00015F58 File Offset: 0x00014158
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DoubleCheck._members;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00015F60 File Offset: 0x00014160
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DoubleCheck._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00015F84 File Offset: 0x00014184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DoubleCheck._members.ManagedPeerType;
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000026C4 File Offset: 0x000008C4
		internal DoubleCheck(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00015F90 File Offset: 0x00014190
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(DoubleCheck._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00015FC4 File Offset: 0x000141C4
		[Register("lazy", "(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/dagger/Lazy;", "")]
		[JavaTypeParameters(new string[]
		{
			"P extends javax.inject.Provider<T>",
			"T"
		})]
		public unsafe static ILazy Lazy(Java.Lang.Object provider)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(provider);
			ILazy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ILazy>(DoubleCheck._members.StaticMethods.InvokeObjectMethod("lazy.(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/dagger/Lazy;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(provider);
			}
			return @object;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00016034 File Offset: 0x00014234
		[Register("provider", "(Ljavax/inject/Provider;)Ljavax/inject/Provider;", "")]
		[JavaTypeParameters(new string[]
		{
			"P extends javax.inject.Provider<T>",
			"T"
		})]
		public unsafe static IProvider Provider(Java.Lang.Object @delegate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(@delegate);
			IProvider @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IProvider>(DoubleCheck._members.StaticMethods.InvokeObjectMethod("provider.(Ljavax/inject/Provider;)Ljavax/inject/Provider;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@delegate);
			}
			return @object;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000160A4 File Offset: 0x000142A4
		[Register("reentrantCheck", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object ReentrantCheck(Java.Lang.Object currentInstance, Java.Lang.Object newInstance)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((currentInstance == null) ? IntPtr.Zero : currentInstance.Handle);
				ptr[1] = new JniArgumentValue((newInstance == null) ? IntPtr.Zero : newInstance.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DoubleCheck._members.StaticMethods.InvokeObjectMethod("reentrantCheck.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(currentInstance);
				GC.KeepAlive(newInstance);
			}
			return @object;
		}

		// Token: 0x0400022D RID: 557
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/DoubleCheck", typeof(DoubleCheck));
	}
}
