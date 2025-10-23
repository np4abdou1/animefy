using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Auth.Api.SignIn
{
	// Token: 0x02000019 RID: 25
	[Register("com/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension", DoNotGenerateAcw = true)]
	internal class IGoogleSignInOptionsExtensionInvoker : Java.Lang.Object, IGoogleSignInOptionsExtension, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003850 File Offset: 0x00001A50
		private static IntPtr java_class_ref
		{
			get
			{
				return IGoogleSignInOptionsExtensionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003874 File Offset: 0x00001A74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGoogleSignInOptionsExtensionInvoker._members;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000387B File Offset: 0x00001A7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003883 File Offset: 0x00001A83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGoogleSignInOptionsExtensionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000388F File Offset: 0x00001A8F
		public static IGoogleSignInOptionsExtension GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGoogleSignInOptionsExtension>(handle, transfer);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003898 File Offset: 0x00001A98
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGoogleSignInOptionsExtensionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension'.");
			}
			return handle;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000038C3 File Offset: 0x00001AC3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000038F4 File Offset: 0x00001AF4
		public IGoogleSignInOptionsExtensionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGoogleSignInOptionsExtensionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000392C File Offset: 0x00001B2C
		private static Delegate GetGetExtensionTypeHandler()
		{
			if (IGoogleSignInOptionsExtensionInvoker.cb_getExtensionType == null)
			{
				IGoogleSignInOptionsExtensionInvoker.cb_getExtensionType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGoogleSignInOptionsExtensionInvoker.n_GetExtensionType));
			}
			return IGoogleSignInOptionsExtensionInvoker.cb_getExtensionType;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003950 File Offset: 0x00001B50
		private static int n_GetExtensionType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGoogleSignInOptionsExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExtensionType;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000395F File Offset: 0x00001B5F
		public int ExtensionType
		{
			get
			{
				if (this.id_getExtensionType == IntPtr.Zero)
				{
					this.id_getExtensionType = JNIEnv.GetMethodID(this.class_ref, "getExtensionType", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getExtensionType);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000399F File Offset: 0x00001B9F
		private static Delegate GetGetImpliedScopesHandler()
		{
			if (IGoogleSignInOptionsExtensionInvoker.cb_getImpliedScopes == null)
			{
				IGoogleSignInOptionsExtensionInvoker.cb_getImpliedScopes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGoogleSignInOptionsExtensionInvoker.n_GetImpliedScopes));
			}
			return IGoogleSignInOptionsExtensionInvoker.cb_getImpliedScopes;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000039C3 File Offset: 0x00001BC3
		private static IntPtr n_GetImpliedScopes(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<Scope>.ToLocalJniHandle(Java.Lang.Object.GetObject<IGoogleSignInOptionsExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ImpliedScopes);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000039D8 File Offset: 0x00001BD8
		public IList<Scope> ImpliedScopes
		{
			get
			{
				if (this.id_getImpliedScopes == IntPtr.Zero)
				{
					this.id_getImpliedScopes = JNIEnv.GetMethodID(this.class_ref, "getImpliedScopes", "()Ljava/util/List;");
				}
				return JavaList<Scope>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getImpliedScopes), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003A29 File Offset: 0x00001C29
		private static Delegate GetToBundleHandler()
		{
			if (IGoogleSignInOptionsExtensionInvoker.cb_toBundle == null)
			{
				IGoogleSignInOptionsExtensionInvoker.cb_toBundle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGoogleSignInOptionsExtensionInvoker.n_ToBundle));
			}
			return IGoogleSignInOptionsExtensionInvoker.cb_toBundle;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003A4D File Offset: 0x00001C4D
		private static IntPtr n_ToBundle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGoogleSignInOptionsExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBundle());
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003A64 File Offset: 0x00001C64
		public Bundle ToBundle()
		{
			if (this.id_toBundle == IntPtr.Zero)
			{
				this.id_toBundle = JNIEnv.GetMethodID(this.class_ref, "toBundle", "()Landroid/os/Bundle;");
			}
			return Java.Lang.Object.GetObject<Bundle>(JNIEnv.CallObjectMethod(base.Handle, this.id_toBundle), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400001E RID: 30
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension", typeof(IGoogleSignInOptionsExtensionInvoker));

		// Token: 0x0400001F RID: 31
		private IntPtr class_ref;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_getExtensionType;

		// Token: 0x04000021 RID: 33
		private IntPtr id_getExtensionType;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_getImpliedScopes;

		// Token: 0x04000023 RID: 35
		private IntPtr id_getImpliedScopes;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_toBundle;

		// Token: 0x04000025 RID: 37
		private IntPtr id_toBundle;
	}
}
