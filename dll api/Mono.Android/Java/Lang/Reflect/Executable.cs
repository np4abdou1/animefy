using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x020003FC RID: 1020
	[Register("java/lang/reflect/Executable", DoNotGenerateAcw = true, ApiSince = 26)]
	public abstract class Executable : AccessibleObject, IGenericDeclaration, IAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IMember
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x0007BB4B File Offset: 0x00079D4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Executable._members;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x0007BB54 File Offset: 0x00079D54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Executable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x0007BB78 File Offset: 0x00079D78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Executable._members.ManagedPeerType;
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x0007BB84 File Offset: 0x00079D84
		protected Executable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x0007BB8E File Offset: 0x00079D8E
		private static Delegate GetGetDeclaringClassHandler()
		{
			if (Executable.cb_getDeclaringClass == null)
			{
				Executable.cb_getDeclaringClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Executable.n_GetDeclaringClass));
			}
			return Executable.cb_getDeclaringClass;
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x0007BBB2 File Offset: 0x00079DB2
		private static IntPtr n_GetDeclaringClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<Executable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeclaringClass);
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002CEA RID: 11498
		public abstract Class DeclaringClass { get; }

		// Token: 0x06002CEB RID: 11499 RVA: 0x0007BBC6 File Offset: 0x00079DC6
		private static Delegate GetIsSyntheticHandler()
		{
			if (Executable.cb_isSynthetic == null)
			{
				Executable.cb_isSynthetic = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Executable.n_IsSynthetic));
			}
			return Executable.cb_isSynthetic;
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0007BBEA File Offset: 0x00079DEA
		private static bool n_IsSynthetic(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Executable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSynthetic;
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x0007BBF9 File Offset: 0x00079DF9
		public virtual bool IsSynthetic
		{
			get
			{
				return Executable._members.InstanceMethods.InvokeVirtualBooleanMethod("isSynthetic.()Z", this, null);
			}
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x0007BC12 File Offset: 0x00079E12
		private static Delegate GetGetModifiersHandler()
		{
			if (Executable.cb_getModifiers == null)
			{
				Executable.cb_getModifiers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Executable.n_GetModifiers));
			}
			return Executable.cb_getModifiers;
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0007BC36 File Offset: 0x00079E36
		private static int n_GetModifiers(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Executable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Modifiers;
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002CF0 RID: 11504
		public abstract int Modifiers { get; }

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0007BC45 File Offset: 0x00079E45
		private static Delegate GetGetNameHandler()
		{
			if (Executable.cb_getName == null)
			{
				Executable.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Executable.n_GetName));
			}
			return Executable.cb_getName;
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x0007BC69 File Offset: 0x00079E69
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<Executable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002CF3 RID: 11507
		public abstract string Name { get; }

		// Token: 0x06002CF4 RID: 11508 RVA: 0x0007BC7D File Offset: 0x00079E7D
		private static Delegate GetGetTypeParametersHandler()
		{
			if (Executable.cb_getTypeParameters == null)
			{
				Executable.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Executable.n_GetTypeParameters));
			}
			return Executable.cb_getTypeParameters;
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0007BCA1 File Offset: 0x00079EA1
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<ITypeVariable>(Object.GetObject<Executable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetTypeParameters());
		}

		// Token: 0x06002CF6 RID: 11510
		public abstract ITypeVariable[] GetTypeParameters();

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0007BCB5 File Offset: 0x00079EB5
		private static Delegate GetIsAnnotationPresent_Ljava_lang_Class_Handler()
		{
			if (Executable.cb_isAnnotationPresent_Ljava_lang_Class_ == null)
			{
				Executable.cb_isAnnotationPresent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Executable.n_IsAnnotationPresent_Ljava_lang_Class_));
			}
			return Executable.cb_isAnnotationPresent_Ljava_lang_Class_;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x0007BCDC File Offset: 0x00079EDC
		private static bool n_IsAnnotationPresent_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_annotationType)
		{
			AccessibleObject @object = Object.GetObject<Executable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Object.GetObject<Class>(native_annotationType, JniHandleOwnership.DoNotTransfer);
			return @object.IsAnnotationPresent(object2);
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x0007BD00 File Offset: 0x00079F00
		public unsafe override bool IsAnnotationPresent(Class annotationType)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationType == null) ? IntPtr.Zero : annotationType.Handle);
				result = Executable._members.InstanceMethods.InvokeVirtualBooleanMethod("isAnnotationPresent.(Ljava/lang/Class;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(annotationType);
			}
			return result;
		}

		// Token: 0x040011BB RID: 4539
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/Executable", typeof(Executable));

		// Token: 0x040011BC RID: 4540
		private static Delegate cb_getDeclaringClass;

		// Token: 0x040011BD RID: 4541
		private static Delegate cb_isSynthetic;

		// Token: 0x040011BE RID: 4542
		private static Delegate cb_getModifiers;

		// Token: 0x040011BF RID: 4543
		private static Delegate cb_getName;

		// Token: 0x040011C0 RID: 4544
		private static Delegate cb_getTypeParameters;

		// Token: 0x040011C1 RID: 4545
		private static Delegate cb_isAnnotationPresent_Ljava_lang_Class_;
	}
}
