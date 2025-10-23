using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x0200018F RID: 399
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/ArrayIteratorKt", DoNotGenerateAcw = true)]
	public sealed class ArrayIteratorKt : Java.Lang.Object
	{
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003F884 File Offset: 0x0003DA84
		internal static IntPtr class_ref
		{
			get
			{
				return ArrayIteratorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0003F8A8 File Offset: 0x0003DAA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ArrayIteratorKt._members;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0003F8B0 File Offset: 0x0003DAB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ArrayIteratorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0003F8D4 File Offset: 0x0003DAD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ArrayIteratorKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0003F8E0 File Offset: 0x0003DAE0
		internal ArrayIteratorKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0003F8EC File Offset: 0x0003DAEC
		[Register("iterator", "([Ljava/lang/Object;)Ljava/util/Iterator;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IIterator Iterator(Java.Lang.Object[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(array);
			IIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterator>(ArrayIteratorKt._members.StaticMethods.InvokeObjectMethod("iterator.([Ljava/lang/Object;)Ljava/util/Iterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x0400067A RID: 1658
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ArrayIteratorKt", typeof(ArrayIteratorKt));
	}
}
