using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.Reflect
{
	// Token: 0x0200013A RID: 314
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KVariance", DoNotGenerateAcw = true)]
	public sealed class KVariance : Java.Lang.Enum
	{
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x00037934 File Offset: 0x00035B34
		[Nullable(2)]
		[Register("IN")]
		public static KVariance In
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<KVariance>(KVariance._members.StaticFields.GetObjectValue("IN.Lkotlin/reflect/KVariance;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x00037964 File Offset: 0x00035B64
		[Nullable(2)]
		[Register("INVARIANT")]
		public static KVariance Invariant
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<KVariance>(KVariance._members.StaticFields.GetObjectValue("INVARIANT.Lkotlin/reflect/KVariance;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00037994 File Offset: 0x00035B94
		[Nullable(2)]
		[Register("OUT")]
		public static KVariance Out
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<KVariance>(KVariance._members.StaticFields.GetObjectValue("OUT.Lkotlin/reflect/KVariance;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x000379C4 File Offset: 0x00035BC4
		internal static IntPtr class_ref
		{
			get
			{
				return KVariance._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x000379E8 File Offset: 0x00035BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KVariance._members;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x000379F0 File Offset: 0x00035BF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KVariance._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00037A14 File Offset: 0x00035C14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KVariance._members.ManagedPeerType;
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00037A20 File Offset: 0x00035C20
		internal KVariance(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00037A2C File Offset: 0x00035C2C
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(KVariance._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00037A60 File Offset: 0x00035C60
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/reflect/KVariance;", "")]
		public unsafe static KVariance ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			KVariance @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<KVariance>(KVariance._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/reflect/KVariance;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00037ACC File Offset: 0x00035CCC
		[Register("values", "()[Lkotlin/reflect/KVariance;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static KVariance[] Values()
		{
			return (KVariance[])JNIEnv.GetArray(KVariance._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/reflect/KVariance;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(KVariance));
		}

		// Token: 0x0400056E RID: 1390
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KVariance", typeof(KVariance));
	}
}
