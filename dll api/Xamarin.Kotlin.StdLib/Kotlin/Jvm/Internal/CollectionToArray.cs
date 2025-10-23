using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000197 RID: 407
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/CollectionToArray", DoNotGenerateAcw = true)]
	public sealed class CollectionToArray : Java.Lang.Object
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00041468 File Offset: 0x0003F668
		internal static IntPtr class_ref
		{
			get
			{
				return CollectionToArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0004148C File Offset: 0x0003F68C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CollectionToArray._members;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x00041494 File Offset: 0x0003F694
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CollectionToArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000414B8 File Offset: 0x0003F6B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CollectionToArray._members.ManagedPeerType;
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000414C4 File Offset: 0x0003F6C4
		internal CollectionToArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000414D0 File Offset: 0x0003F6D0
		[Register("toArray", "(Ljava/util/Collection;)[Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object[] ToArray(ICollection<object> collection)
		{
			IntPtr intPtr = JavaCollection<object>.ToLocalJniHandle(collection);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Java.Lang.Object[])JNIEnv.GetArray(CollectionToArray._members.StaticMethods.InvokeObjectMethod("toArray.(Ljava/util/Collection;)[Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(collection);
			}
			return result;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00041550 File Offset: 0x0003F750
		[Register("toArray", "(Ljava/util/Collection;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object[] ToArray(ICollection<object> collection, [Nullable(new byte[]
		{
			2,
			1
		})] Java.Lang.Object[] a)
		{
			IntPtr intPtr = JavaCollection<object>.ToLocalJniHandle(collection);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(a);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = (Java.Lang.Object[])JNIEnv.GetArray(CollectionToArray._members.StaticMethods.InvokeObjectMethod("toArray.(Ljava/util/Collection;[Ljava/lang/Object;)[Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (a != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, a);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(collection);
				GC.KeepAlive(a);
			}
			return result;
		}

		// Token: 0x04000694 RID: 1684
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/CollectionToArray", typeof(CollectionToArray));
	}
}
