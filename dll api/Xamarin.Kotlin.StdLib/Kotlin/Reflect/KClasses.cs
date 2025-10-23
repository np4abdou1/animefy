using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000137 RID: 311
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KClasses", DoNotGenerateAcw = true)]
	public sealed class KClasses : Java.Lang.Object
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x000371DC File Offset: 0x000353DC
		internal static IntPtr class_ref
		{
			get
			{
				return KClasses._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00037200 File Offset: 0x00035400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KClasses._members;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x00037208 File Offset: 0x00035408
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KClasses._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0003722C File Offset: 0x0003542C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KClasses._members.ManagedPeerType;
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00037238 File Offset: 0x00035438
		internal KClasses(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00037244 File Offset: 0x00035444
		[Register("cast", "(Lkotlin/reflect/KClass;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object Cast(IKClass obj, [Nullable(2)] Java.Lang.Object value)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(KClasses._members.StaticMethods.InvokeObjectMethod("cast.(Lkotlin/reflect/KClass;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x000372E4 File Offset: 0x000354E4
		[NullableContext(2)]
		[Register("safeCast", "(Lkotlin/reflect/KClass;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object SafeCast([Nullable(1)] IKClass obj, Java.Lang.Object value)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(KClasses._members.StaticMethods.InvokeObjectMethod("safeCast.(Lkotlin/reflect/KClass;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0400056B RID: 1387
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KClasses", typeof(KClasses));
	}
}
