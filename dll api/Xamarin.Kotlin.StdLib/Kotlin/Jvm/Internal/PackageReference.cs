using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001BD RID: 445
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/PackageReference", DoNotGenerateAcw = true)]
	public sealed class PackageReference : Java.Lang.Object, IClassBasedDeclarationContainer, IKDeclarationContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x000471BC File Offset: 0x000453BC
		internal static IntPtr class_ref
		{
			get
			{
				return PackageReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000471E0 File Offset: 0x000453E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PackageReference._members;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000471E8 File Offset: 0x000453E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PackageReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0004720C File Offset: 0x0004540C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PackageReference._members.ManagedPeerType;
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00047218 File Offset: 0x00045418
		internal PackageReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00047224 File Offset: 0x00045424
		[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public unsafe PackageReference(Class jClass, string moduleName) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(moduleName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((jClass == null) ? IntPtr.Zero : jClass.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(PackageReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PackageReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(jClass);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000472F0 File Offset: 0x000454F0
		public Class JClass
		{
			[Register("getJClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(PackageReference._members.InstanceMethods.InvokeAbstractObjectMethod("getJClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00047324 File Offset: 0x00045524
		public ICollection<IKCallable> Members
		{
			[Register("getMembers", "()Ljava/util/Collection;", "")]
			get
			{
				return JavaCollection<IKCallable>.FromJniHandle(PackageReference._members.InstanceMethods.InvokeAbstractObjectMethod("getMembers.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000708 RID: 1800
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PackageReference", typeof(PackageReference));
	}
}
