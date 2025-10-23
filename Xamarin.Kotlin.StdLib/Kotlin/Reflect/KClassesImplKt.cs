using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000138 RID: 312
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KClassesImplKt", DoNotGenerateAcw = true)]
	public sealed class KClassesImplKt : Java.Lang.Object
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000373A0 File Offset: 0x000355A0
		internal static IntPtr class_ref
		{
			get
			{
				return KClassesImplKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x000373C4 File Offset: 0x000355C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KClassesImplKt._members;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000373CC File Offset: 0x000355CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KClassesImplKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x000373F0 File Offset: 0x000355F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KClassesImplKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000373FC File Offset: 0x000355FC
		internal KClassesImplKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00037408 File Offset: 0x00035608
		[Register("getQualifiedOrSimpleName", "(Lkotlin/reflect/KClass;)Ljava/lang/String;", "")]
		[return: Nullable(2)]
		public unsafe static string GetQualifiedOrSimpleName(IKClass obj)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@string = JNIEnv.GetString(KClassesImplKt._members.StaticMethods.InvokeObjectMethod("getQualifiedOrSimpleName.(Lkotlin/reflect/KClass;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @string;
		}

		// Token: 0x0400056C RID: 1388
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KClassesImplKt", typeof(KClassesImplKt));
	}
}
