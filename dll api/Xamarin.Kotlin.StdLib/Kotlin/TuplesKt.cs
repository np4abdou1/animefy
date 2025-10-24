using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A3 RID: 163
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/TuplesKt", DoNotGenerateAcw = true)]
	public sealed class TuplesKt : Java.Lang.Object
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		internal static IntPtr class_ref
		{
			get
			{
				return TuplesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TuplesKt._members;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000A8DC File Offset: 0x00008ADC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TuplesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0000A900 File Offset: 0x00008B00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TuplesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000A90C File Offset: 0x00008B0C
		internal TuplesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000A918 File Offset: 0x00008B18
		[NullableContext(2)]
		[Register("to", "(Ljava/lang/Object;Ljava/lang/Object;)Lkotlin/Pair;", "")]
		[JavaTypeParameters(new string[]
		{
			"A",
			"B"
		})]
		[return: Nullable(1)]
		public unsafe static Pair To(Java.Lang.Object obj, Java.Lang.Object that)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(obj);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(that);
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Pair>(TuplesKt._members.StaticMethods.InvokeObjectMethod("to.(Ljava/lang/Object;Ljava/lang/Object;)Lkotlin/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(obj);
				GC.KeepAlive(that);
			}
			return @object;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Register("toList", "(Lkotlin/Pair;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IList ToList(Pair obj)
		{
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaList.FromJniHandle(TuplesKt._members.StaticMethods.InvokeObjectMethod("toList.(Lkotlin/Pair;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000AA24 File Offset: 0x00008C24
		[Register("toList", "(Lkotlin/Triple;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IList ToList(Triple obj)
		{
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaList.FromJniHandle(TuplesKt._members.StaticMethods.InvokeObjectMethod("toList.(Lkotlin/Triple;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x04000158 RID: 344
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/TuplesKt", typeof(TuplesKt));
	}
}
