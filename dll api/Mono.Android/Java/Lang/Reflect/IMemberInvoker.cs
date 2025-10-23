using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000406 RID: 1030
	[Register("java/lang/reflect/Member", DoNotGenerateAcw = true)]
	internal class IMemberInvoker : Object, IMember, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x0007CBD0 File Offset: 0x0007ADD0
		private static IntPtr java_class_ref
		{
			get
			{
				return IMemberInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x0007CBF4 File Offset: 0x0007ADF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMemberInvoker._members;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x0007CBFB File Offset: 0x0007ADFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x0007CC03 File Offset: 0x0007AE03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMemberInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x0007CC0F File Offset: 0x0007AE0F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMemberInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.reflect.Member'.");
			}
			return handle;
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x0007CC3A File Offset: 0x0007AE3A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x0007CC6C File Offset: 0x0007AE6C
		public IMemberInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMemberInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x0007CCA4 File Offset: 0x0007AEA4
		private static Delegate GetGetDeclaringClassHandler()
		{
			if (IMemberInvoker.cb_getDeclaringClass == null)
			{
				IMemberInvoker.cb_getDeclaringClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMemberInvoker.n_GetDeclaringClass));
			}
			return IMemberInvoker.cb_getDeclaringClass;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x0007CCC8 File Offset: 0x0007AEC8
		private static IntPtr n_GetDeclaringClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<IMember>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeclaringClass);
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x0007CCDC File Offset: 0x0007AEDC
		public Class DeclaringClass
		{
			get
			{
				if (this.id_getDeclaringClass == IntPtr.Zero)
				{
					this.id_getDeclaringClass = JNIEnv.GetMethodID(this.class_ref, "getDeclaringClass", "()Ljava/lang/Class;");
				}
				return Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDeclaringClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x0007CD2D File Offset: 0x0007AF2D
		private static Delegate GetIsSyntheticHandler()
		{
			if (IMemberInvoker.cb_isSynthetic == null)
			{
				IMemberInvoker.cb_isSynthetic = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMemberInvoker.n_IsSynthetic));
			}
			return IMemberInvoker.cb_isSynthetic;
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x0007CD51 File Offset: 0x0007AF51
		private static bool n_IsSynthetic(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<IMember>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSynthetic;
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x0007CD60 File Offset: 0x0007AF60
		public bool IsSynthetic
		{
			get
			{
				if (this.id_isSynthetic == IntPtr.Zero)
				{
					this.id_isSynthetic = JNIEnv.GetMethodID(this.class_ref, "isSynthetic", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isSynthetic);
			}
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0007CDA0 File Offset: 0x0007AFA0
		private static Delegate GetGetModifiersHandler()
		{
			if (IMemberInvoker.cb_getModifiers == null)
			{
				IMemberInvoker.cb_getModifiers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMemberInvoker.n_GetModifiers));
			}
			return IMemberInvoker.cb_getModifiers;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
		private static int n_GetModifiers(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<IMember>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Modifiers;
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x0007CDD3 File Offset: 0x0007AFD3
		public int Modifiers
		{
			get
			{
				if (this.id_getModifiers == IntPtr.Zero)
				{
					this.id_getModifiers = JNIEnv.GetMethodID(this.class_ref, "getModifiers", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getModifiers);
			}
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x0007CE13 File Offset: 0x0007B013
		private static Delegate GetGetNameHandler()
		{
			if (IMemberInvoker.cb_getName == null)
			{
				IMemberInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMemberInvoker.n_GetName));
			}
			return IMemberInvoker.cb_getName;
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x0007CE37 File Offset: 0x0007B037
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<IMember>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x0007CE4C File Offset: 0x0007B04C
		public string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040011DE RID: 4574
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/Member", typeof(IMemberInvoker));

		// Token: 0x040011DF RID: 4575
		private IntPtr class_ref;

		// Token: 0x040011E0 RID: 4576
		private static Delegate cb_getDeclaringClass;

		// Token: 0x040011E1 RID: 4577
		private IntPtr id_getDeclaringClass;

		// Token: 0x040011E2 RID: 4578
		private static Delegate cb_isSynthetic;

		// Token: 0x040011E3 RID: 4579
		private IntPtr id_isSynthetic;

		// Token: 0x040011E4 RID: 4580
		private static Delegate cb_getModifiers;

		// Token: 0x040011E5 RID: 4581
		private IntPtr id_getModifiers;

		// Token: 0x040011E6 RID: 4582
		private static Delegate cb_getName;

		// Token: 0x040011E7 RID: 4583
		private IntPtr id_getName;
	}
}
