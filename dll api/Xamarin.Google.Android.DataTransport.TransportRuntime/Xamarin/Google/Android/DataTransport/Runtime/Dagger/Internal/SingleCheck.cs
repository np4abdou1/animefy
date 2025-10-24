using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000F2 RID: 242
	[Register("com/google/android/datatransport/runtime/dagger/internal/SingleCheck", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class SingleCheck : Java.Lang.Object, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00017C10 File Offset: 0x00015E10
		internal static IntPtr class_ref
		{
			get
			{
				return SingleCheck._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00017C34 File Offset: 0x00015E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SingleCheck._members;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00017C3C File Offset: 0x00015E3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SingleCheck._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00017C60 File Offset: 0x00015E60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SingleCheck._members.ManagedPeerType;
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000026C4 File Offset: 0x000008C4
		internal SingleCheck(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00017C6C File Offset: 0x00015E6C
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SingleCheck._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00017CA0 File Offset: 0x00015EA0
		[Register("provider", "(Ljavax/inject/Provider;)Ljavax/inject/Provider;", "")]
		[JavaTypeParameters(new string[]
		{
			"P extends javax.inject.Provider<T>",
			"T"
		})]
		public unsafe static IProvider Provider(Java.Lang.Object provider)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(provider);
			IProvider @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IProvider>(SingleCheck._members.StaticMethods.InvokeObjectMethod("provider.(Ljavax/inject/Provider;)Ljavax/inject/Provider;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(provider);
			}
			return @object;
		}

		// Token: 0x04000267 RID: 615
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/SingleCheck", typeof(SingleCheck));
	}
}
