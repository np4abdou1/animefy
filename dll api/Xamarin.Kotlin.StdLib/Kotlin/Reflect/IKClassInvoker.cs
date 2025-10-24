using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Reflect
{
	// Token: 0x02000103 RID: 259
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KClass", DoNotGenerateAcw = true)]
	internal class IKClassInvoker : Java.Lang.Object, IKClass, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKClassifier, IKDeclarationContainer
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0002979C File Offset: 0x0002799C
		private static IntPtr java_class_ref
		{
			get
			{
				return IKClassInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x000297C0 File Offset: 0x000279C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKClassInvoker._members;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x000297C7 File Offset: 0x000279C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x000297CF File Offset: 0x000279CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKClassInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000297DB File Offset: 0x000279DB
		[NullableContext(2)]
		public static IKClass GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKClass>(handle, transfer);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000297E4 File Offset: 0x000279E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKClassInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KClass'.");
			}
			return handle;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002980F File Offset: 0x00027A0F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00029840 File Offset: 0x00027A40
		public IKClassInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKClassInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00029878 File Offset: 0x00027A78
		private static Delegate GetGetConstructorsHandler()
		{
			if (IKClassInvoker.cb_getConstructors == null)
			{
				IKClassInvoker.cb_getConstructors = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetConstructors));
			}
			return IKClassInvoker.cb_getConstructors;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002989C File Offset: 0x00027A9C
		private static IntPtr n_GetConstructors(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection<IKFunction>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Constructors);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000298B0 File Offset: 0x00027AB0
		public ICollection<IKFunction> Constructors
		{
			get
			{
				if (this.id_getConstructors == IntPtr.Zero)
				{
					this.id_getConstructors = JNIEnv.GetMethodID(this.class_ref, "getConstructors", "()Ljava/util/Collection;");
				}
				return JavaCollection<IKFunction>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getConstructors), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00029901 File Offset: 0x00027B01
		private static Delegate GetIsAbstractHandler()
		{
			if (IKClassInvoker.cb_isAbstract == null)
			{
				IKClassInvoker.cb_isAbstract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsAbstract));
			}
			return IKClassInvoker.cb_isAbstract;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00029925 File Offset: 0x00027B25
		private static bool n_IsAbstract(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbstract;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00029934 File Offset: 0x00027B34
		public bool IsAbstract
		{
			get
			{
				if (this.id_isAbstract == IntPtr.Zero)
				{
					this.id_isAbstract = JNIEnv.GetMethodID(this.class_ref, "isAbstract", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isAbstract);
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00029974 File Offset: 0x00027B74
		private static Delegate GetIsCompanionHandler()
		{
			if (IKClassInvoker.cb_isCompanion == null)
			{
				IKClassInvoker.cb_isCompanion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsCompanion));
			}
			return IKClassInvoker.cb_isCompanion;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00029998 File Offset: 0x00027B98
		private static bool n_IsCompanion(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompanion;
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000299A7 File Offset: 0x00027BA7
		public bool IsCompanion
		{
			get
			{
				if (this.id_isCompanion == IntPtr.Zero)
				{
					this.id_isCompanion = JNIEnv.GetMethodID(this.class_ref, "isCompanion", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCompanion);
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000299E7 File Offset: 0x00027BE7
		private static Delegate GetIsDataHandler()
		{
			if (IKClassInvoker.cb_isData == null)
			{
				IKClassInvoker.cb_isData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsData));
			}
			return IKClassInvoker.cb_isData;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00029A0B File Offset: 0x00027C0B
		private static bool n_IsData(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsData;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00029A1A File Offset: 0x00027C1A
		public bool IsData
		{
			get
			{
				if (this.id_isData == IntPtr.Zero)
				{
					this.id_isData = JNIEnv.GetMethodID(this.class_ref, "isData", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isData);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00029A5A File Offset: 0x00027C5A
		private static Delegate GetIsFinalHandler()
		{
			if (IKClassInvoker.cb_isFinal == null)
			{
				IKClassInvoker.cb_isFinal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsFinal));
			}
			return IKClassInvoker.cb_isFinal;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00029A7E File Offset: 0x00027C7E
		private static bool n_IsFinal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFinal;
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00029A8D File Offset: 0x00027C8D
		public bool IsFinal
		{
			get
			{
				if (this.id_isFinal == IntPtr.Zero)
				{
					this.id_isFinal = JNIEnv.GetMethodID(this.class_ref, "isFinal", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isFinal);
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00029ACD File Offset: 0x00027CCD
		private static Delegate GetIsFunHandler()
		{
			if (IKClassInvoker.cb_isFun == null)
			{
				IKClassInvoker.cb_isFun = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsFun));
			}
			return IKClassInvoker.cb_isFun;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00029AF1 File Offset: 0x00027CF1
		private static bool n_IsFun(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFun;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00029B00 File Offset: 0x00027D00
		public bool IsFun
		{
			get
			{
				if (this.id_isFun == IntPtr.Zero)
				{
					this.id_isFun = JNIEnv.GetMethodID(this.class_ref, "isFun", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isFun);
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00029B40 File Offset: 0x00027D40
		private static Delegate GetIsInnerHandler()
		{
			if (IKClassInvoker.cb_isInner == null)
			{
				IKClassInvoker.cb_isInner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsInner));
			}
			return IKClassInvoker.cb_isInner;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00029B64 File Offset: 0x00027D64
		private static bool n_IsInner(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInner;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00029B73 File Offset: 0x00027D73
		public bool IsInner
		{
			get
			{
				if (this.id_isInner == IntPtr.Zero)
				{
					this.id_isInner = JNIEnv.GetMethodID(this.class_ref, "isInner", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isInner);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00029BB3 File Offset: 0x00027DB3
		private static Delegate GetIsOpenHandler()
		{
			if (IKClassInvoker.cb_isOpen == null)
			{
				IKClassInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsOpen));
			}
			return IKClassInvoker.cb_isOpen;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00029BD7 File Offset: 0x00027DD7
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00029BE6 File Offset: 0x00027DE6
		public bool IsOpen
		{
			get
			{
				if (this.id_isOpen == IntPtr.Zero)
				{
					this.id_isOpen = JNIEnv.GetMethodID(this.class_ref, "isOpen", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOpen);
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00029C26 File Offset: 0x00027E26
		private static Delegate GetIsSealedHandler()
		{
			if (IKClassInvoker.cb_isSealed == null)
			{
				IKClassInvoker.cb_isSealed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsSealed));
			}
			return IKClassInvoker.cb_isSealed;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00029C4A File Offset: 0x00027E4A
		private static bool n_IsSealed(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSealed;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00029C59 File Offset: 0x00027E59
		public bool IsSealed
		{
			get
			{
				if (this.id_isSealed == IntPtr.Zero)
				{
					this.id_isSealed = JNIEnv.GetMethodID(this.class_ref, "isSealed", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isSealed);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00029C99 File Offset: 0x00027E99
		private static Delegate GetIsValueHandler()
		{
			if (IKClassInvoker.cb_isValue == null)
			{
				IKClassInvoker.cb_isValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKClassInvoker.n_IsValue));
			}
			return IKClassInvoker.cb_isValue;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00029CBD File Offset: 0x00027EBD
		private static bool n_IsValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsValue;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00029CCC File Offset: 0x00027ECC
		public bool IsValue
		{
			get
			{
				if (this.id_isValue == IntPtr.Zero)
				{
					this.id_isValue = JNIEnv.GetMethodID(this.class_ref, "isValue", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isValue);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00029D0C File Offset: 0x00027F0C
		private static Delegate GetGetMembersHandler()
		{
			if (IKClassInvoker.cb_getMembers == null)
			{
				IKClassInvoker.cb_getMembers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetMembers));
			}
			return IKClassInvoker.cb_getMembers;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00029D30 File Offset: 0x00027F30
		private static IntPtr n_GetMembers(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection<IKCallable>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Members);
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00029D44 File Offset: 0x00027F44
		public ICollection<IKCallable> Members
		{
			get
			{
				if (this.id_getMembers == IntPtr.Zero)
				{
					this.id_getMembers = JNIEnv.GetMethodID(this.class_ref, "getMembers", "()Ljava/util/Collection;");
				}
				return JavaCollection<IKCallable>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getMembers), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00029D95 File Offset: 0x00027F95
		private static Delegate GetGetNestedClassesHandler()
		{
			if (IKClassInvoker.cb_getNestedClasses == null)
			{
				IKClassInvoker.cb_getNestedClasses = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetNestedClasses));
			}
			return IKClassInvoker.cb_getNestedClasses;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00029DB9 File Offset: 0x00027FB9
		private static IntPtr n_GetNestedClasses(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection<IKClass>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedClasses);
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00029DD0 File Offset: 0x00027FD0
		public ICollection<IKClass> NestedClasses
		{
			get
			{
				if (this.id_getNestedClasses == IntPtr.Zero)
				{
					this.id_getNestedClasses = JNIEnv.GetMethodID(this.class_ref, "getNestedClasses", "()Ljava/util/Collection;");
				}
				return JavaCollection<IKClass>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getNestedClasses), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00029E21 File Offset: 0x00028021
		private static Delegate GetGetObjectInstanceHandler()
		{
			if (IKClassInvoker.cb_getObjectInstance == null)
			{
				IKClassInvoker.cb_getObjectInstance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetObjectInstance));
			}
			return IKClassInvoker.cb_getObjectInstance;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00029E45 File Offset: 0x00028045
		private static IntPtr n_GetObjectInstance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ObjectInstance);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00029E5C File Offset: 0x0002805C
		[Nullable(2)]
		public Java.Lang.Object ObjectInstance
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getObjectInstance == IntPtr.Zero)
				{
					this.id_getObjectInstance = JNIEnv.GetMethodID(this.class_ref, "getObjectInstance", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getObjectInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00029EAD File Offset: 0x000280AD
		private static Delegate GetGetQualifiedNameHandler()
		{
			if (IKClassInvoker.cb_getQualifiedName == null)
			{
				IKClassInvoker.cb_getQualifiedName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetQualifiedName));
			}
			return IKClassInvoker.cb_getQualifiedName;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00029ED1 File Offset: 0x000280D1
		private static IntPtr n_GetQualifiedName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QualifiedName);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00029EE8 File Offset: 0x000280E8
		[Nullable(2)]
		public string QualifiedName
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getQualifiedName == IntPtr.Zero)
				{
					this.id_getQualifiedName = JNIEnv.GetMethodID(this.class_ref, "getQualifiedName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getQualifiedName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00029F39 File Offset: 0x00028139
		private static Delegate GetGetSealedSubclassesHandler()
		{
			if (IKClassInvoker.cb_getSealedSubclasses == null)
			{
				IKClassInvoker.cb_getSealedSubclasses = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetSealedSubclasses));
			}
			return IKClassInvoker.cb_getSealedSubclasses;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00029F5D File Offset: 0x0002815D
		private static IntPtr n_GetSealedSubclasses(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKClass>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SealedSubclasses);
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00029F74 File Offset: 0x00028174
		public IList<IKClass> SealedSubclasses
		{
			get
			{
				if (this.id_getSealedSubclasses == IntPtr.Zero)
				{
					this.id_getSealedSubclasses = JNIEnv.GetMethodID(this.class_ref, "getSealedSubclasses", "()Ljava/util/List;");
				}
				return JavaList<IKClass>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getSealedSubclasses), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00029FC5 File Offset: 0x000281C5
		private static Delegate GetGetSimpleNameHandler()
		{
			if (IKClassInvoker.cb_getSimpleName == null)
			{
				IKClassInvoker.cb_getSimpleName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetSimpleName));
			}
			return IKClassInvoker.cb_getSimpleName;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00029FE9 File Offset: 0x000281E9
		private static IntPtr n_GetSimpleName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SimpleName);
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0002A000 File Offset: 0x00028200
		[Nullable(2)]
		public string SimpleName
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getSimpleName == IntPtr.Zero)
				{
					this.id_getSimpleName = JNIEnv.GetMethodID(this.class_ref, "getSimpleName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getSimpleName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0002A051 File Offset: 0x00028251
		private static Delegate GetGetSupertypesHandler()
		{
			if (IKClassInvoker.cb_getSupertypes == null)
			{
				IKClassInvoker.cb_getSupertypes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetSupertypes));
			}
			return IKClassInvoker.cb_getSupertypes;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0002A075 File Offset: 0x00028275
		private static IntPtr n_GetSupertypes(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKType>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Supertypes);
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0002A08C File Offset: 0x0002828C
		public IList<IKType> Supertypes
		{
			get
			{
				if (this.id_getSupertypes == IntPtr.Zero)
				{
					this.id_getSupertypes = JNIEnv.GetMethodID(this.class_ref, "getSupertypes", "()Ljava/util/List;");
				}
				return JavaList<IKType>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupertypes), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0002A0DD File Offset: 0x000282DD
		private static Delegate GetGetTypeParametersHandler()
		{
			if (IKClassInvoker.cb_getTypeParameters == null)
			{
				IKClassInvoker.cb_getTypeParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetTypeParameters));
			}
			return IKClassInvoker.cb_getTypeParameters;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0002A101 File Offset: 0x00028301
		private static IntPtr n_GetTypeParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKTypeParameter>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeParameters);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0002A118 File Offset: 0x00028318
		public IList<IKTypeParameter> TypeParameters
		{
			get
			{
				if (this.id_getTypeParameters == IntPtr.Zero)
				{
					this.id_getTypeParameters = JNIEnv.GetMethodID(this.class_ref, "getTypeParameters", "()Ljava/util/List;");
				}
				return JavaList<IKTypeParameter>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getTypeParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0002A169 File Offset: 0x00028369
		private static Delegate GetGetVisibilityHandler()
		{
			if (IKClassInvoker.cb_getVisibility == null)
			{
				IKClassInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetVisibility));
			}
			return IKClassInvoker.cb_getVisibility;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0002A18D File Offset: 0x0002838D
		private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002A1A4 File Offset: 0x000283A4
		[Nullable(2)]
		public KVisibility Visibility
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getVisibility == IntPtr.Zero)
				{
					this.id_getVisibility = JNIEnv.GetMethodID(this.class_ref, "getVisibility", "()Lkotlin/reflect/KVisibility;");
				}
				return Java.Lang.Object.GetObject<KVisibility>(JNIEnv.CallObjectMethod(base.Handle, this.id_getVisibility), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0002A1F5 File Offset: 0x000283F5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IKClassInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IKClassInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IKClassInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IKClassInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0002A21C File Offset: 0x0002841C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IKClass @object = Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0002A240 File Offset: 0x00028440
		[NullableContext(2)]
		public new unsafe bool Equals(Java.Lang.Object other)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : other.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0002A2B3 File Offset: 0x000284B3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IKClassInvoker.cb_hashCode == null)
			{
				IKClassInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IKClassInvoker.n_GetHashCode));
			}
			return IKClassInvoker.cb_hashCode;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0002A2D7 File Offset: 0x000284D7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0002A2E6 File Offset: 0x000284E6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0002A326 File Offset: 0x00028526
		private static Delegate GetIsInstance_Ljava_lang_Object_Handler()
		{
			if (IKClassInvoker.cb_isInstance_Ljava_lang_Object_ == null)
			{
				IKClassInvoker.cb_isInstance_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IKClassInvoker.n_IsInstance_Ljava_lang_Object_));
			}
			return IKClassInvoker.cb_isInstance_Ljava_lang_Object_;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0002A34C File Offset: 0x0002854C
		private static bool n_IsInstance_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IKClass @object = Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.IsInstance(object2);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0002A370 File Offset: 0x00028570
		[NullableContext(2)]
		public unsafe bool IsInstance(Java.Lang.Object value)
		{
			if (this.id_isInstance_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_isInstance_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "isInstance", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_isInstance_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0002A3E3 File Offset: 0x000285E3
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKClassInvoker.cb_getAnnotations == null)
			{
				IKClassInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKClassInvoker.n_GetAnnotations));
			}
			return IKClassInvoker.cb_getAnnotations;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0002A407 File Offset: 0x00028607
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKClass>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0002A41C File Offset: 0x0002861C
		public IList<IAnnotation> Annotations
		{
			get
			{
				if (this.id_getAnnotations == IntPtr.Zero)
				{
					this.id_getAnnotations = JNIEnv.GetMethodID(this.class_ref, "getAnnotations", "()Ljava/util/List;");
				}
				return JavaList<IAnnotation>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getAnnotations), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KClass", typeof(IKClassInvoker));

		// Token: 0x04000289 RID: 649
		private IntPtr class_ref;

		// Token: 0x0400028A RID: 650
		[Nullable(2)]
		private static Delegate cb_getConstructors;

		// Token: 0x0400028B RID: 651
		private IntPtr id_getConstructors;

		// Token: 0x0400028C RID: 652
		[Nullable(2)]
		private static Delegate cb_isAbstract;

		// Token: 0x0400028D RID: 653
		private IntPtr id_isAbstract;

		// Token: 0x0400028E RID: 654
		[Nullable(2)]
		private static Delegate cb_isCompanion;

		// Token: 0x0400028F RID: 655
		private IntPtr id_isCompanion;

		// Token: 0x04000290 RID: 656
		[Nullable(2)]
		private static Delegate cb_isData;

		// Token: 0x04000291 RID: 657
		private IntPtr id_isData;

		// Token: 0x04000292 RID: 658
		[Nullable(2)]
		private static Delegate cb_isFinal;

		// Token: 0x04000293 RID: 659
		private IntPtr id_isFinal;

		// Token: 0x04000294 RID: 660
		[Nullable(2)]
		private static Delegate cb_isFun;

		// Token: 0x04000295 RID: 661
		private IntPtr id_isFun;

		// Token: 0x04000296 RID: 662
		[Nullable(2)]
		private static Delegate cb_isInner;

		// Token: 0x04000297 RID: 663
		private IntPtr id_isInner;

		// Token: 0x04000298 RID: 664
		[Nullable(2)]
		private static Delegate cb_isOpen;

		// Token: 0x04000299 RID: 665
		private IntPtr id_isOpen;

		// Token: 0x0400029A RID: 666
		[Nullable(2)]
		private static Delegate cb_isSealed;

		// Token: 0x0400029B RID: 667
		private IntPtr id_isSealed;

		// Token: 0x0400029C RID: 668
		[Nullable(2)]
		private static Delegate cb_isValue;

		// Token: 0x0400029D RID: 669
		private IntPtr id_isValue;

		// Token: 0x0400029E RID: 670
		[Nullable(2)]
		private static Delegate cb_getMembers;

		// Token: 0x0400029F RID: 671
		private IntPtr id_getMembers;

		// Token: 0x040002A0 RID: 672
		[Nullable(2)]
		private static Delegate cb_getNestedClasses;

		// Token: 0x040002A1 RID: 673
		private IntPtr id_getNestedClasses;

		// Token: 0x040002A2 RID: 674
		[Nullable(2)]
		private static Delegate cb_getObjectInstance;

		// Token: 0x040002A3 RID: 675
		private IntPtr id_getObjectInstance;

		// Token: 0x040002A4 RID: 676
		[Nullable(2)]
		private static Delegate cb_getQualifiedName;

		// Token: 0x040002A5 RID: 677
		private IntPtr id_getQualifiedName;

		// Token: 0x040002A6 RID: 678
		[Nullable(2)]
		private static Delegate cb_getSealedSubclasses;

		// Token: 0x040002A7 RID: 679
		private IntPtr id_getSealedSubclasses;

		// Token: 0x040002A8 RID: 680
		[Nullable(2)]
		private static Delegate cb_getSimpleName;

		// Token: 0x040002A9 RID: 681
		private IntPtr id_getSimpleName;

		// Token: 0x040002AA RID: 682
		[Nullable(2)]
		private static Delegate cb_getSupertypes;

		// Token: 0x040002AB RID: 683
		private IntPtr id_getSupertypes;

		// Token: 0x040002AC RID: 684
		[Nullable(2)]
		private static Delegate cb_getTypeParameters;

		// Token: 0x040002AD RID: 685
		private IntPtr id_getTypeParameters;

		// Token: 0x040002AE RID: 686
		[Nullable(2)]
		private static Delegate cb_getVisibility;

		// Token: 0x040002AF RID: 687
		private IntPtr id_getVisibility;

		// Token: 0x040002B0 RID: 688
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040002B1 RID: 689
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040002B2 RID: 690
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040002B3 RID: 691
		private IntPtr id_hashCode;

		// Token: 0x040002B4 RID: 692
		[Nullable(2)]
		private static Delegate cb_isInstance_Ljava_lang_Object_;

		// Token: 0x040002B5 RID: 693
		private IntPtr id_isInstance_Ljava_lang_Object_;

		// Token: 0x040002B6 RID: 694
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x040002B7 RID: 695
		private IntPtr id_getAnnotations;
	}
}
