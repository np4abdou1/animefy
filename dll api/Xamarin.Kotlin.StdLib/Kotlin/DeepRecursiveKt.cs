using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000047 RID: 71
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/DeepRecursiveKt", DoNotGenerateAcw = true)]
	public sealed class DeepRecursiveKt : Java.Lang.Object
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000028A8 File Offset: 0x00000AA8
		internal static IntPtr class_ref
		{
			get
			{
				return DeepRecursiveKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000028CC File Offset: 0x00000ACC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeepRecursiveKt._members;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000028D4 File Offset: 0x00000AD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeepRecursiveKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000028F8 File Offset: 0x00000AF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeepRecursiveKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002904 File Offset: 0x00000B04
		internal DeepRecursiveKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002910 File Offset: 0x00000B10
		[NullableContext(2)]
		[Register("invoke", "(Lkotlin/DeepRecursiveFunction;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static Java.Lang.Object Invoke([Nullable(1)] DeepRecursiveFunction obj, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DeepRecursiveKt._members.StaticMethods.InvokeObjectMethod("invoke.(Lkotlin/DeepRecursiveFunction;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x04000014 RID: 20
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/DeepRecursiveKt", typeof(DeepRecursiveKt));
	}
}
