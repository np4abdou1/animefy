using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x020003FE RID: 1022
	[Register("java/lang/reflect/Field", DoNotGenerateAcw = true)]
	public sealed class Field : AccessibleObject, IMember, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x0007BE7C File Offset: 0x0007A07C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Field._members;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x0007BE84 File Offset: 0x0007A084
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Field._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x0007BEA8 File Offset: 0x0007A0A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Field._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x0007BB84 File Offset: 0x00079D84
		internal Field(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x0007BEB4 File Offset: 0x0007A0B4
		public Class DeclaringClass
		{
			get
			{
				return Object.GetObject<Class>(Field._members.InstanceMethods.InvokeAbstractObjectMethod("getDeclaringClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x0007BEE6 File Offset: 0x0007A0E6
		public bool IsSynthetic
		{
			get
			{
				return Field._members.InstanceMethods.InvokeAbstractBooleanMethod("isSynthetic.()Z", this, null);
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x0007BEFF File Offset: 0x0007A0FF
		public int Modifiers
		{
			get
			{
				return Field._members.InstanceMethods.InvokeAbstractInt32Method("getModifiers.()I", this, null);
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x0007BF18 File Offset: 0x0007A118
		public string Name
		{
			get
			{
				return JNIEnv.GetString(Field._members.InstanceMethods.InvokeAbstractObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0007BF4C File Offset: 0x0007A14C
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
				@object = Object.GetObject<Object>(Field._members.InstanceMethods.InvokeAbstractObjectMethod("getAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(annotationType);
			}
			return @object;
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x0007BFC0 File Offset: 0x0007A1C0
		public unsafe override bool IsAnnotationPresent(Class annotationType)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((annotationType == null) ? IntPtr.Zero : annotationType.Handle);
				result = Field._members.InstanceMethods.InvokeAbstractBooleanMethod("isAnnotationPresent.(Ljava/lang/Class;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(annotationType);
			}
			return result;
		}

		// Token: 0x040011C3 RID: 4547
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/Field", typeof(Field));
	}
}
