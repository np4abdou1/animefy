using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;

namespace Kotlin.Reflect
{
	// Token: 0x0200013D RID: 317
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/TypesJVMKt", DoNotGenerateAcw = true)]
	public sealed class TypesJVMKt : Java.Lang.Object
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00037DD0 File Offset: 0x00035FD0
		internal static IntPtr class_ref
		{
			get
			{
				return TypesJVMKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00037DF4 File Offset: 0x00035FF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypesJVMKt._members;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00037DFC File Offset: 0x00035FFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypesJVMKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00037E20 File Offset: 0x00036020
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypesJVMKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00037E2C File Offset: 0x0003602C
		internal TypesJVMKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00037E38 File Offset: 0x00036038
		[Register("getJavaType", "(Lkotlin/reflect/KType;)Ljava/lang/reflect/Type;", "")]
		public unsafe static IType GetJavaType(IKType obj)
		{
			IType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				@object = Java.Lang.Object.GetObject<IType>(TypesJVMKt._members.StaticMethods.InvokeObjectMethod("getJavaType.(Lkotlin/reflect/KType;)Ljava/lang/reflect/Type;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x04000571 RID: 1393
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/TypesJVMKt", typeof(TypesJVMKt));

		// Token: 0x020002E8 RID: 744
		[Nullable(0)]
		[Register("kotlin/reflect/TypesJVMKt$WhenMappings", DoNotGenerateAcw = true)]
		public sealed class WhenMappings : Java.Lang.Object
		{
			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000B8C78 File Offset: 0x000B6E78
			internal static IntPtr class_ref
			{
				get
				{
					return TypesJVMKt.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x060029B1 RID: 10673 RVA: 0x000B8C9C File Offset: 0x000B6E9C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TypesJVMKt.WhenMappings._members;
				}
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000B8CA4 File Offset: 0x000B6EA4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TypesJVMKt.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x060029B3 RID: 10675 RVA: 0x000B8CC8 File Offset: 0x000B6EC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TypesJVMKt.WhenMappings._members.ManagedPeerType;
				}
			}

			// Token: 0x060029B4 RID: 10676 RVA: 0x000B8CD4 File Offset: 0x000B6ED4
			internal WhenMappings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040009DF RID: 2527
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/TypesJVMKt$WhenMappings", typeof(TypesJVMKt.WhenMappings));
		}
	}
}
