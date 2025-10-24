using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x0200040A RID: 1034
	[Register("java/lang/reflect/TypeVariable", DoNotGenerateAcw = true)]
	internal class ITypeVariableInvoker : Object, ITypeVariable, IType, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x0007D030 File Offset: 0x0007B230
		private static IntPtr java_class_ref
		{
			get
			{
				return ITypeVariableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x0007D054 File Offset: 0x0007B254
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITypeVariableInvoker._members;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x0007D05B File Offset: 0x0007B25B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x0007D063 File Offset: 0x0007B263
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITypeVariableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x0007D06F File Offset: 0x0007B26F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITypeVariableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.reflect.TypeVariable'.");
			}
			return handle;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x0007D09A File Offset: 0x0007B29A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x0007D0CC File Offset: 0x0007B2CC
		public ITypeVariableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITypeVariableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x0007D104 File Offset: 0x0007B304
		private static Delegate GetGetGenericDeclarationHandler()
		{
			if (ITypeVariableInvoker.cb_getGenericDeclaration == null)
			{
				ITypeVariableInvoker.cb_getGenericDeclaration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITypeVariableInvoker.n_GetGenericDeclaration));
			}
			return ITypeVariableInvoker.cb_getGenericDeclaration;
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x0007D128 File Offset: 0x0007B328
		private static IntPtr n_GetGenericDeclaration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<ITypeVariable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GenericDeclaration);
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x0007D13C File Offset: 0x0007B33C
		public Object GenericDeclaration
		{
			get
			{
				if (this.id_getGenericDeclaration == IntPtr.Zero)
				{
					this.id_getGenericDeclaration = JNIEnv.GetMethodID(this.class_ref, "getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;");
				}
				return Object.GetObject<Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGenericDeclaration), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x0007D18D File Offset: 0x0007B38D
		private static Delegate GetGetNameHandler()
		{
			if (ITypeVariableInvoker.cb_getName == null)
			{
				ITypeVariableInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITypeVariableInvoker.n_GetName));
			}
			return ITypeVariableInvoker.cb_getName;
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x0007D1B1 File Offset: 0x0007B3B1
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<ITypeVariable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x0007D1C8 File Offset: 0x0007B3C8
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

		// Token: 0x06002D80 RID: 11648 RVA: 0x0007D219 File Offset: 0x0007B419
		private static Delegate GetGetBoundsHandler()
		{
			if (ITypeVariableInvoker.cb_getBounds == null)
			{
				ITypeVariableInvoker.cb_getBounds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITypeVariableInvoker.n_GetBounds));
			}
			return ITypeVariableInvoker.cb_getBounds;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x0007D23D File Offset: 0x0007B43D
		private static IntPtr n_GetBounds(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<IType>(Object.GetObject<ITypeVariable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBounds());
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x0007D254 File Offset: 0x0007B454
		public IType[] GetBounds()
		{
			if (this.id_getBounds == IntPtr.Zero)
			{
				this.id_getBounds = JNIEnv.GetMethodID(this.class_ref, "getBounds", "()[Ljava/lang/reflect/Type;");
			}
			return (IType[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getBounds), JniHandleOwnership.TransferLocalRef, typeof(IType));
		}

		// Token: 0x040011EC RID: 4588
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/TypeVariable", typeof(ITypeVariableInvoker));

		// Token: 0x040011ED RID: 4589
		private IntPtr class_ref;

		// Token: 0x040011EE RID: 4590
		private static Delegate cb_getGenericDeclaration;

		// Token: 0x040011EF RID: 4591
		private IntPtr id_getGenericDeclaration;

		// Token: 0x040011F0 RID: 4592
		private static Delegate cb_getName;

		// Token: 0x040011F1 RID: 4593
		private IntPtr id_getName;

		// Token: 0x040011F2 RID: 4594
		private static Delegate cb_getBounds;

		// Token: 0x040011F3 RID: 4595
		private IntPtr id_getBounds;
	}
}
