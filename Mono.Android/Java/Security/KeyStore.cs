using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Security.Cert;

namespace Java.Security
{
	// Token: 0x02000361 RID: 865
	[Register("java/security/KeyStore", DoNotGenerateAcw = true)]
	public class KeyStore : Java.Lang.Object
	{
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x0006E417 File Offset: 0x0006C617
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KeyStore._members;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x0006E420 File Offset: 0x0006C620
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KeyStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x0006E444 File Offset: 0x0006C644
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KeyStore._members.ManagedPeerType;
			}
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000021E0 File Offset: 0x000003E0
		protected KeyStore(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x0006E450 File Offset: 0x0006C650
		public unsafe Certificate GetCertificate(string alias)
		{
			IntPtr intPtr = JNIEnv.NewString(alias);
			Certificate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Certificate>(KeyStore._members.InstanceMethods.InvokeNonvirtualObjectMethod("getCertificate.(Ljava/lang/String;)Ljava/security/cert/Certificate;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		public unsafe static KeyStore GetInstance(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			KeyStore @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<KeyStore>(KeyStore._members.StaticMethods.InvokeObjectMethod("getInstance.(Ljava/lang/String;)Ljava/security/KeyStore;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0006E528 File Offset: 0x0006C728
		public unsafe void Load(KeyStore.ILoadStoreParameter param)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((param == null) ? IntPtr.Zero : ((Java.Lang.Object)param).Handle);
				KeyStore._members.InstanceMethods.InvokeNonvirtualVoidMethod("load.(Ljava/security/KeyStore$LoadStoreParameter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(param);
			}
		}

		// Token: 0x04000FE9 RID: 4073
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/KeyStore", typeof(KeyStore));

		// Token: 0x02000362 RID: 866
		[Register("java/security/KeyStore$LoadStoreParameter", "", "Java.Security.KeyStore/ILoadStoreParameterInvoker")]
		public interface ILoadStoreParameter : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x0600267E RID: 9854
			KeyStore.IProtectionParameter ProtectionParameter { [Register("getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;", "GetGetProtectionParameterHandler:Java.Security.KeyStore/ILoadStoreParameterInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")] get; }
		}

		// Token: 0x02000363 RID: 867
		[Register("java/security/KeyStore$LoadStoreParameter", DoNotGenerateAcw = true)]
		internal class ILoadStoreParameterInvoker : Java.Lang.Object, KeyStore.ILoadStoreParameter, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x0600267F RID: 9855 RVA: 0x0006E5AC File Offset: 0x0006C7AC
			private static IntPtr java_class_ref
			{
				get
				{
					return KeyStore.ILoadStoreParameterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06002680 RID: 9856 RVA: 0x0006E5D0 File Offset: 0x0006C7D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return KeyStore.ILoadStoreParameterInvoker._members;
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x06002681 RID: 9857 RVA: 0x0006E5D7 File Offset: 0x0006C7D7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06002682 RID: 9858 RVA: 0x0006E5DF File Offset: 0x0006C7DF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return KeyStore.ILoadStoreParameterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06002683 RID: 9859 RVA: 0x0006E5EB File Offset: 0x0006C7EB
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, KeyStore.ILoadStoreParameterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.security.KeyStore.LoadStoreParameter'.");
				}
				return handle;
			}

			// Token: 0x06002684 RID: 9860 RVA: 0x0006E616 File Offset: 0x0006C816
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06002685 RID: 9861 RVA: 0x0006E648 File Offset: 0x0006C848
			public ILoadStoreParameterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(KeyStore.ILoadStoreParameterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06002686 RID: 9862 RVA: 0x0006E680 File Offset: 0x0006C880
			private static Delegate GetGetProtectionParameterHandler()
			{
				if (KeyStore.ILoadStoreParameterInvoker.cb_getProtectionParameter == null)
				{
					KeyStore.ILoadStoreParameterInvoker.cb_getProtectionParameter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(KeyStore.ILoadStoreParameterInvoker.n_GetProtectionParameter));
				}
				return KeyStore.ILoadStoreParameterInvoker.cb_getProtectionParameter;
			}

			// Token: 0x06002687 RID: 9863 RVA: 0x0006E6A4 File Offset: 0x0006C8A4
			private static IntPtr n_GetProtectionParameter(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<KeyStore.ILoadStoreParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProtectionParameter);
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06002688 RID: 9864 RVA: 0x0006E6B8 File Offset: 0x0006C8B8
			public KeyStore.IProtectionParameter ProtectionParameter
			{
				get
				{
					if (this.id_getProtectionParameter == IntPtr.Zero)
					{
						this.id_getProtectionParameter = JNIEnv.GetMethodID(this.class_ref, "getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;");
					}
					return Java.Lang.Object.GetObject<KeyStore.IProtectionParameter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getProtectionParameter), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000FEA RID: 4074
			private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/KeyStore$LoadStoreParameter", typeof(KeyStore.ILoadStoreParameterInvoker));

			// Token: 0x04000FEB RID: 4075
			private IntPtr class_ref;

			// Token: 0x04000FEC RID: 4076
			private static Delegate cb_getProtectionParameter;

			// Token: 0x04000FED RID: 4077
			private IntPtr id_getProtectionParameter;
		}

		// Token: 0x02000364 RID: 868
		[Register("java/security/KeyStore$ProtectionParameter", "", "Java.Security.KeyStore/IProtectionParameterInvoker")]
		public interface IProtectionParameter : IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000365 RID: 869
		[Register("java/security/KeyStore$ProtectionParameter", DoNotGenerateAcw = true)]
		internal class IProtectionParameterInvoker : Java.Lang.Object, KeyStore.IProtectionParameter, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x0600268A RID: 9866 RVA: 0x0006E724 File Offset: 0x0006C924
			private static IntPtr java_class_ref
			{
				get
				{
					return KeyStore.IProtectionParameterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x0600268B RID: 9867 RVA: 0x0006E748 File Offset: 0x0006C948
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return KeyStore.IProtectionParameterInvoker._members;
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x0600268C RID: 9868 RVA: 0x0006E74F File Offset: 0x0006C94F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x0600268D RID: 9869 RVA: 0x0006E757 File Offset: 0x0006C957
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return KeyStore.IProtectionParameterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600268E RID: 9870 RVA: 0x0006E763 File Offset: 0x0006C963
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, KeyStore.IProtectionParameterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.security.KeyStore.ProtectionParameter'.");
				}
				return handle;
			}

			// Token: 0x0600268F RID: 9871 RVA: 0x0006E78E File Offset: 0x0006C98E
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06002690 RID: 9872 RVA: 0x0006E7C0 File Offset: 0x0006C9C0
			public IProtectionParameterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(KeyStore.IProtectionParameterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x04000FEE RID: 4078
			private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/KeyStore$ProtectionParameter", typeof(KeyStore.IProtectionParameterInvoker));

			// Token: 0x04000FEF RID: 4079
			private IntPtr class_ref;
		}
	}
}
