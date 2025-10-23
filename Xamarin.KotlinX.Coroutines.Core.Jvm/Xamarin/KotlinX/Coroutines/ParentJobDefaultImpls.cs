using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ParentJob$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ParentJobDefaultImpls : Java.Lang.Object
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000F728 File Offset: 0x0000D928
		internal static IntPtr class_ref
		{
			get
			{
				return ParentJobDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000F74C File Offset: 0x0000D94C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ParentJobDefaultImpls._members;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000F754 File Offset: 0x0000D954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ParentJobDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000F778 File Offset: 0x0000D978
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ParentJobDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000F784 File Offset: 0x0000D984
		internal ParentJobDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000F790 File Offset: 0x0000D990
		[Register("fold", "(Lkotlinx/coroutines/ParentJob;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IParentJob _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ParentJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/ParentJob;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000F860 File Offset: 0x0000DA60
		[Register("get", "(Lkotlinx/coroutines/ParentJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(IParentJob _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ParentJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlinx/coroutines/ParentJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000F904 File Offset: 0x0000DB04
		[Register("minusKey", "(Lkotlinx/coroutines/ParentJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext MinusKey(IParentJob _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ParentJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlinx/coroutines/ParentJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Register("plus", "(Lkotlinx/coroutines/ParentJob;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext Plus(IParentJob _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ParentJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/ParentJob;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/ParentJob;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "")]
		public unsafe static IJob Plus(IParentJob _this, IJob other)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(ParentJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/ParentJob;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x040001B2 RID: 434
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ParentJob$DefaultImpls", typeof(ParentJobDefaultImpls));
	}
}
