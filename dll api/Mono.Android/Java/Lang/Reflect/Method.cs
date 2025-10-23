using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x0200040B RID: 1035
	[Register("java/lang/reflect/Method", DoNotGenerateAcw = true)]
	public sealed class Method : Executable, IGenericDeclaration, IAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IMember
	{
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x0007D2CF File Offset: 0x0007B4CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Method._members;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x0007D2D8 File Offset: 0x0007B4D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Method._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x0007D2FC File Offset: 0x0007B4FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Method._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0007BD83 File Offset: 0x00079F83
		internal Method(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x0007D308 File Offset: 0x0007B508
		public override Class DeclaringClass
		{
			get
			{
				return Object.GetObject<Class>(Method._members.InstanceMethods.InvokeAbstractObjectMethod("getDeclaringClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x0007D33A File Offset: 0x0007B53A
		public override bool IsSynthetic
		{
			get
			{
				return Method._members.InstanceMethods.InvokeAbstractBooleanMethod("isSynthetic.()Z", this, null);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x0007D353 File Offset: 0x0007B553
		public override int Modifiers
		{
			get
			{
				return Method._members.InstanceMethods.InvokeAbstractInt32Method("getModifiers.()I", this, null);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x0007D36C File Offset: 0x0007B56C
		public override string Name
		{
			get
			{
				return JNIEnv.GetString(Method._members.InstanceMethods.InvokeAbstractObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x0007D3A0 File Offset: 0x0007B5A0
		[JavaTypeParameters(new string[]
		{
			"A extends java.lang.annotation.Annotation"
		})]
		public unsafe override Object GetAnnotation(Class annotationType)
		{
			Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationType == null) ? IntPtr.Zero : annotationType.Handle);
				@object = Object.GetObject<Object>(Method._members.InstanceMethods.InvokeAbstractObjectMethod("getAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(annotationType);
			}
			return @object;
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x0007D414 File Offset: 0x0007B614
		public override ITypeVariable[] GetTypeParameters()
		{
			return (ITypeVariable[])JNIEnv.GetArray(Method._members.InstanceMethods.InvokeAbstractObjectMethod("getTypeParameters.()[Ljava/lang/reflect/TypeVariable;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ITypeVariable));
		}

		// Token: 0x040011F4 RID: 4596
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/Method", typeof(Method));
	}
}
