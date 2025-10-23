using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;

namespace Kotlin.IO
{
	// Token: 0x02000223 RID: 547
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/FileTreeWalk", DoNotGenerateAcw = true)]
	public sealed class FileTreeWalk : Java.Lang.Object, ISequence, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x00055704 File Offset: 0x00053904
		internal static IntPtr class_ref
		{
			get
			{
				return FileTreeWalk._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x00055728 File Offset: 0x00053928
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileTreeWalk._members;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x00055730 File Offset: 0x00053930
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileTreeWalk._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x00055754 File Offset: 0x00053954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileTreeWalk._members.ManagedPeerType;
			}
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00055760 File Offset: 0x00053960
		internal FileTreeWalk(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0005576C File Offset: 0x0005396C
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(FileTreeWalk._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000557A0 File Offset: 0x000539A0
		[Register("maxDepth", "(I)Lkotlin/io/FileTreeWalk;", "")]
		public unsafe FileTreeWalk MaxDepth(int depth)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(depth);
			return Java.Lang.Object.GetObject<FileTreeWalk>(FileTreeWalk._members.InstanceMethods.InvokeNonvirtualObjectMethod("maxDepth.(I)Lkotlin/io/FileTreeWalk;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000557EC File Offset: 0x000539EC
		[Register("onEnter", "(Lkotlin/jvm/functions/Function1;)Lkotlin/io/FileTreeWalk;", "")]
		public unsafe FileTreeWalk OnEnter(IFunction1 function)
		{
			FileTreeWalk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				@object = Java.Lang.Object.GetObject<FileTreeWalk>(FileTreeWalk._members.InstanceMethods.InvokeNonvirtualObjectMethod("onEnter.(Lkotlin/jvm/functions/Function1;)Lkotlin/io/FileTreeWalk;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(function);
			}
			return @object;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00055864 File Offset: 0x00053A64
		[Register("onFail", "(Lkotlin/jvm/functions/Function2;)Lkotlin/io/FileTreeWalk;", "")]
		public unsafe FileTreeWalk OnFail(IFunction2 function)
		{
			FileTreeWalk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				@object = Java.Lang.Object.GetObject<FileTreeWalk>(FileTreeWalk._members.InstanceMethods.InvokeNonvirtualObjectMethod("onFail.(Lkotlin/jvm/functions/Function2;)Lkotlin/io/FileTreeWalk;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(function);
			}
			return @object;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000558DC File Offset: 0x00053ADC
		[Register("onLeave", "(Lkotlin/jvm/functions/Function1;)Lkotlin/io/FileTreeWalk;", "")]
		public unsafe FileTreeWalk OnLeave(IFunction1 function)
		{
			FileTreeWalk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				@object = Java.Lang.Object.GetObject<FileTreeWalk>(FileTreeWalk._members.InstanceMethods.InvokeNonvirtualObjectMethod("onLeave.(Lkotlin/jvm/functions/Function1;)Lkotlin/io/FileTreeWalk;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(function);
			}
			return @object;
		}

		// Token: 0x040007D4 RID: 2004
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/FileTreeWalk", typeof(FileTreeWalk));
	}
}
