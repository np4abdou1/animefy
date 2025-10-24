using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000EA RID: 234
	[Register("com/google/android/datatransport/runtime/dagger/internal/InstanceFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class InstanceFactory : Java.Lang.Object, ILazy, IJavaObject, IDisposable, IJavaPeerable, IFactory, IProvider
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x000170F8 File Offset: 0x000152F8
		internal static IntPtr class_ref
		{
			get
			{
				return InstanceFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0001711C File Offset: 0x0001531C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InstanceFactory._members;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00017124 File Offset: 0x00015324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InstanceFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00017148 File Offset: 0x00015348
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InstanceFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000026C4 File Offset: 0x000008C4
		internal InstanceFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00017154 File Offset: 0x00015354
		[Register("create", "(Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/Factory;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFactory Create(Java.Lang.Object instance)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(instance);
			IFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFactory>(InstanceFactory._members.StaticMethods.InvokeObjectMethod("create.(Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(instance);
			}
			return @object;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000171C4 File Offset: 0x000153C4
		[Register("createNullable", "(Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/Factory;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFactory CreateNullable(Java.Lang.Object instance)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(instance);
			IFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFactory>(InstanceFactory._members.StaticMethods.InvokeObjectMethod("createNullable.(Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(instance);
			}
			return @object;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00017234 File Offset: 0x00015434
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(InstanceFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400025F RID: 607
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/InstanceFactory", typeof(InstanceFactory));
	}
}
