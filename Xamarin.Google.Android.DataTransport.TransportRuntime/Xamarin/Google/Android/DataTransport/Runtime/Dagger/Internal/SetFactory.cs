using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000D7 RID: 215
	[Register("com/google/android/datatransport/runtime/dagger/internal/SetFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class SetFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060007AD RID: 1965 RVA: 0x000158C8 File Offset: 0x00013AC8
		[Register("get", "()Ljava/util/Set;", "")]
		public Java.Lang.Object Get()
		{
			return (Java.Lang.Object)JavaSet.FromJniHandle(SetFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00015900 File Offset: 0x00013B00
		internal static IntPtr class_ref
		{
			get
			{
				return SetFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00015924 File Offset: 0x00013B24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SetFactory._members;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0001592C File Offset: 0x00013B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SetFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00015950 File Offset: 0x00013B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SetFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000026C4 File Offset: 0x000008C4
		internal SetFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0001595C File Offset: 0x00013B5C
		[Register("builder", "(II)Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static SetFactory.Builder InvokeBuilder(int individualProviderSize, int collectionProviderSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(individualProviderSize);
			ptr[1] = new JniArgumentValue(collectionProviderSize);
			return Java.Lang.Object.GetObject<SetFactory.Builder>(SetFactory._members.StaticMethods.InvokeObjectMethod("builder.(II)Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000159B8 File Offset: 0x00013BB8
		[Register("empty", "()Lcom/google/android/datatransport/runtime/dagger/internal/Factory;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static IFactory Empty()
		{
			return Java.Lang.Object.GetObject<IFactory>(SetFactory._members.StaticMethods.InvokeObjectMethod("empty.()Lcom/google/android/datatransport/runtime/dagger/internal/Factory;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000228 RID: 552
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/SetFactory", typeof(SetFactory));

		// Token: 0x020000D8 RID: 216
		[Register("com/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x1700024D RID: 589
			// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00015A04 File Offset: 0x00013C04
			internal static IntPtr class_ref
			{
				get
				{
					return SetFactory.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00015A28 File Offset: 0x00013C28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SetFactory.Builder._members;
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00015A30 File Offset: 0x00013C30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return SetFactory.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00015A54 File Offset: 0x00013C54
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SetFactory.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060007BA RID: 1978 RVA: 0x000026C4 File Offset: 0x000008C4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060007BB RID: 1979 RVA: 0x00015A60 File Offset: 0x00013C60
			[Register("addCollectionProvider", "(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder;", "")]
			public unsafe SetFactory.Builder AddCollectionProvider(IProvider collectionProvider)
			{
				SetFactory.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((collectionProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)collectionProvider).Handle);
					@object = Java.Lang.Object.GetObject<SetFactory.Builder>(SetFactory.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("addCollectionProvider.(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(collectionProvider);
				}
				return @object;
			}

			// Token: 0x060007BC RID: 1980 RVA: 0x00015AD8 File Offset: 0x00013CD8
			[Register("addProvider", "(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder;", "")]
			public unsafe SetFactory.Builder AddProvider(IProvider individualProvider)
			{
				SetFactory.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((individualProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)individualProvider).Handle);
					@object = Java.Lang.Object.GetObject<SetFactory.Builder>(SetFactory.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("addProvider.(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(individualProvider);
				}
				return @object;
			}

			// Token: 0x060007BD RID: 1981 RVA: 0x00015B50 File Offset: 0x00013D50
			[Register("build", "()Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory;", "")]
			public SetFactory Build()
			{
				return Java.Lang.Object.GetObject<SetFactory>(SetFactory.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/dagger/internal/SetFactory;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000229 RID: 553
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder", typeof(SetFactory.Builder));
		}
	}
}
