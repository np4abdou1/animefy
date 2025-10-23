using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Reflect
{
	// Token: 0x02000139 RID: 313
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KTypeProjection", DoNotGenerateAcw = true)]
	public sealed class KTypeProjection : Java.Lang.Object
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0003749C File Offset: 0x0003569C
		[Register("Companion")]
		public static KTypeProjection.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<KTypeProjection.CompanionStatic>(KTypeProjection._members.StaticFields.GetObjectValue("Companion.Lkotlin/reflect/KTypeProjection$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x000374CC File Offset: 0x000356CC
		[Register("star")]
		public static KTypeProjection Star
		{
			get
			{
				return Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection._members.StaticFields.GetObjectValue("star.Lkotlin/reflect/KTypeProjection;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x000374FC File Offset: 0x000356FC
		internal static IntPtr class_ref
		{
			get
			{
				return KTypeProjection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00037520 File Offset: 0x00035720
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KTypeProjection._members;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x00037528 File Offset: 0x00035728
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KTypeProjection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0003754C File Offset: 0x0003574C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KTypeProjection._members.ManagedPeerType;
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00037558 File Offset: 0x00035758
		internal KTypeProjection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00037564 File Offset: 0x00035764
		[NullableContext(2)]
		[Register(".ctor", "(Lkotlin/reflect/KVariance;Lkotlin/reflect/KType;)V", "")]
		public unsafe KTypeProjection(KVariance variance, IKType type) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((variance == null) ? IntPtr.Zero : variance.Handle);
				ptr[1] = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				base.SetHandle(KTypeProjection._members.InstanceMethods.StartCreateInstance("(Lkotlin/reflect/KVariance;Lkotlin/reflect/KType;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				KTypeProjection._members.InstanceMethods.FinishCreateInstance("(Lkotlin/reflect/KVariance;Lkotlin/reflect/KType;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(variance);
				GC.KeepAlive(type);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00037640 File Offset: 0x00035840
		[Nullable(2)]
		public IKType Type
		{
			[NullableContext(2)]
			[Register("getType", "()Lkotlin/reflect/KType;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IKType>(KTypeProjection._members.InstanceMethods.InvokeNonvirtualObjectMethod("getType.()Lkotlin/reflect/KType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00037674 File Offset: 0x00035874
		[Nullable(2)]
		public KVariance Variance
		{
			[NullableContext(2)]
			[Register("getVariance", "()Lkotlin/reflect/KVariance;", "")]
			get
			{
				return Java.Lang.Object.GetObject<KVariance>(KTypeProjection._members.InstanceMethods.InvokeNonvirtualObjectMethod("getVariance.()Lkotlin/reflect/KVariance;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000376A8 File Offset: 0x000358A8
		[NullableContext(2)]
		[Register("component1", "()Lkotlin/reflect/KVariance;", "")]
		public KVariance Component1()
		{
			return Java.Lang.Object.GetObject<KVariance>(KTypeProjection._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Lkotlin/reflect/KVariance;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000376DC File Offset: 0x000358DC
		[NullableContext(2)]
		[Register("component2", "()Lkotlin/reflect/KType;", "")]
		public IKType Component2()
		{
			return Java.Lang.Object.GetObject<IKType>(KTypeProjection._members.InstanceMethods.InvokeNonvirtualObjectMethod("component2.()Lkotlin/reflect/KType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00037710 File Offset: 0x00035910
		[Register("contravariant", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", "")]
		public unsafe static KTypeProjection Contravariant(IKType type)
		{
			KTypeProjection @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection._members.StaticMethods.InvokeObjectMethod("contravariant.(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00037788 File Offset: 0x00035988
		[NullableContext(2)]
		[Register("copy", "(Lkotlin/reflect/KVariance;Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", "")]
		[return: Nullable(1)]
		public unsafe KTypeProjection Copy(KVariance variance, IKType type)
		{
			KTypeProjection @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((variance == null) ? IntPtr.Zero : variance.Handle);
				ptr[1] = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy.(Lkotlin/reflect/KVariance;Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(variance);
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00037828 File Offset: 0x00035A28
		[Register("covariant", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", "")]
		public unsafe static KTypeProjection Covariant(IKType type)
		{
			KTypeProjection @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection._members.StaticMethods.InvokeObjectMethod("covariant.(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x000378A0 File Offset: 0x00035AA0
		[Register("invariant", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", "")]
		public unsafe static KTypeProjection Invariant(IKType type)
		{
			KTypeProjection @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
				@object = Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection._members.StaticMethods.InvokeObjectMethod("invariant.(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x0400056D RID: 1389
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KTypeProjection", typeof(KTypeProjection));

		// Token: 0x020002E6 RID: 742
		[Nullable(0)]
		[Register("kotlin/reflect/KTypeProjection$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000B8958 File Offset: 0x000B6B58
			internal static IntPtr class_ref
			{
				get
				{
					return KTypeProjection.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x060029A1 RID: 10657 RVA: 0x000B897C File Offset: 0x000B6B7C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return KTypeProjection.CompanionStatic._members;
				}
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x060029A2 RID: 10658 RVA: 0x000B8984 File Offset: 0x000B6B84
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return KTypeProjection.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000B89A8 File Offset: 0x000B6BA8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return KTypeProjection.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x060029A4 RID: 10660 RVA: 0x000B89B4 File Offset: 0x000B6BB4
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029A5 RID: 10661 RVA: 0x000B89C0 File Offset: 0x000B6BC0
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe CompanionStatic(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(KTypeProjection.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					KTypeProjection.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x060029A6 RID: 10662 RVA: 0x000B8A70 File Offset: 0x000B6C70
			[Register("contravariant", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", "")]
			public unsafe KTypeProjection Contravariant(IKType type)
			{
				KTypeProjection @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
					@object = Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("contravariant.(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(type);
				}
				return @object;
			}

			// Token: 0x060029A7 RID: 10663 RVA: 0x000B8AE8 File Offset: 0x000B6CE8
			[Register("covariant", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", "")]
			public unsafe KTypeProjection Covariant(IKType type)
			{
				KTypeProjection @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
					@object = Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("covariant.(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(type);
				}
				return @object;
			}

			// Token: 0x060029A8 RID: 10664 RVA: 0x000B8B60 File Offset: 0x000B6D60
			[Register("invariant", "(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", "")]
			public unsafe KTypeProjection Invariant(IKType type)
			{
				KTypeProjection @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : ((Java.Lang.Object)type).Handle);
					@object = Java.Lang.Object.GetObject<KTypeProjection>(KTypeProjection.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("invariant.(Lkotlin/reflect/KType;)Lkotlin/reflect/KTypeProjection;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(type);
				}
				return @object;
			}

			// Token: 0x040009DD RID: 2525
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KTypeProjection$Companion", typeof(KTypeProjection.CompanionStatic));
		}

		// Token: 0x020002E7 RID: 743
		[Nullable(0)]
		[Register("kotlin/reflect/KTypeProjection$WhenMappings", DoNotGenerateAcw = true)]
		public sealed class WhenMappings : Java.Lang.Object
		{
			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x060029AA RID: 10666 RVA: 0x000B8BF4 File Offset: 0x000B6DF4
			internal static IntPtr class_ref
			{
				get
				{
					return KTypeProjection.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x060029AB RID: 10667 RVA: 0x000B8C18 File Offset: 0x000B6E18
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return KTypeProjection.WhenMappings._members;
				}
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x060029AC RID: 10668 RVA: 0x000B8C20 File Offset: 0x000B6E20
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return KTypeProjection.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x060029AD RID: 10669 RVA: 0x000B8C44 File Offset: 0x000B6E44
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return KTypeProjection.WhenMappings._members.ManagedPeerType;
				}
			}

			// Token: 0x060029AE RID: 10670 RVA: 0x000B8C50 File Offset: 0x000B6E50
			internal WhenMappings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040009DE RID: 2526
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KTypeProjection$WhenMappings", typeof(KTypeProjection.WhenMappings));
		}
	}
}
