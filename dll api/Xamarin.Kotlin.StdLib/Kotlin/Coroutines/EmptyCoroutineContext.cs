using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Coroutines
{
	// Token: 0x02000250 RID: 592
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/EmptyCoroutineContext", DoNotGenerateAcw = true)]
	public sealed class EmptyCoroutineContext : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, ICoroutineContext
	{
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x0005B8E8 File Offset: 0x00059AE8
		[Register("INSTANCE")]
		public static EmptyCoroutineContext Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<EmptyCoroutineContext>(EmptyCoroutineContext._members.StaticFields.GetObjectValue("INSTANCE.Lkotlin/coroutines/EmptyCoroutineContext;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0005B918 File Offset: 0x00059B18
		internal static IntPtr class_ref
		{
			get
			{
				return EmptyCoroutineContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0005B93C File Offset: 0x00059B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EmptyCoroutineContext._members;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0005B944 File Offset: 0x00059B44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EmptyCoroutineContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0005B968 File Offset: 0x00059B68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EmptyCoroutineContext._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0005B974 File Offset: 0x00059B74
		internal EmptyCoroutineContext(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0005B980 File Offset: 0x00059B80
		[NullableContext(2)]
		[Register("fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(EmptyCoroutineContext._members.InstanceMethods.InvokeAbstractObjectMethod("fold.(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0005BA20 File Offset: 0x00059C20
		[Register("get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Get(ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(EmptyCoroutineContext._members.InstanceMethods.InvokeAbstractObjectMethod("get.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0005BA98 File Offset: 0x00059C98
		[Register("minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe ICoroutineContext MinusKey(ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(EmptyCoroutineContext._members.InstanceMethods.InvokeAbstractObjectMethod("minusKey.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0005BB10 File Offset: 0x00059D10
		[Register("plus", "(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe ICoroutineContext Plus(ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(EmptyCoroutineContext._members.InstanceMethods.InvokeAbstractObjectMethod("plus.(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x04000869 RID: 2153
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/EmptyCoroutineContext", typeof(EmptyCoroutineContext));
	}
}
