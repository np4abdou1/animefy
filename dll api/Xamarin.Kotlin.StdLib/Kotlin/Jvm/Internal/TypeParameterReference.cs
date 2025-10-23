using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001D1 RID: 465
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/TypeParameterReference", DoNotGenerateAcw = true)]
	public sealed class TypeParameterReference : Java.Lang.Object, IKTypeParameter, IKClassifier, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x0004C9CC File Offset: 0x0004ABCC
		[Register("Companion")]
		public static TypeParameterReference.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<TypeParameterReference.CompanionStatic>(TypeParameterReference._members.StaticFields.GetObjectValue("Companion.Lkotlin/jvm/internal/TypeParameterReference$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x0004C9FC File Offset: 0x0004ABFC
		internal static IntPtr class_ref
		{
			get
			{
				return TypeParameterReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x0004CA20 File Offset: 0x0004AC20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypeParameterReference._members;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x0004CA28 File Offset: 0x0004AC28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeParameterReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x0004CA4C File Offset: 0x0004AC4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypeParameterReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0004CA58 File Offset: 0x0004AC58
		internal TypeParameterReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0004CA64 File Offset: 0x0004AC64
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/String;Lkotlin/reflect/KVariance;Z)V", "")]
		public unsafe TypeParameterReference([Nullable(2)] Java.Lang.Object container, string name, KVariance variance, bool isReified) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((variance == null) ? IntPtr.Zero : variance.Handle);
				ptr[3] = new JniArgumentValue(isReified);
				base.SetHandle(TypeParameterReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/String;Lkotlin/reflect/KVariance;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TypeParameterReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/String;Lkotlin/reflect/KVariance;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(container);
				GC.KeepAlive(variance);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x0004CB74 File Offset: 0x0004AD74
		public bool IsReified
		{
			[Register("isReified", "()Z", "")]
			get
			{
				return TypeParameterReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isReified.()Z", this, null);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0004CB90 File Offset: 0x0004AD90
		public string Name
		{
			[Register("getName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(TypeParameterReference._members.InstanceMethods.InvokeAbstractObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x0004CBC4 File Offset: 0x0004ADC4
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		public unsafe IList<IKType> UpperBounds
		{
			[Register("getUpperBounds", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IKType>.FromJniHandle(TypeParameterReference._members.InstanceMethods.InvokeAbstractObjectMethod("getUpperBounds.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setUpperBounds", "(Ljava/util/List;)V", "")]
			set
			{
				IntPtr intPtr = JavaList<IKType>.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TypeParameterReference._members.InstanceMethods.InvokeNonvirtualVoidMethod("setUpperBounds.(Ljava/util/List;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x0004CC5C File Offset: 0x0004AE5C
		public KVariance Variance
		{
			[Register("getVariance", "()Lkotlin/reflect/KVariance;", "")]
			get
			{
				return Java.Lang.Object.GetObject<KVariance>(TypeParameterReference._members.InstanceMethods.InvokeAbstractObjectMethod("getVariance.()Lkotlin/reflect/KVariance;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000746 RID: 1862
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/TypeParameterReference", typeof(TypeParameterReference));

		// Token: 0x020002F5 RID: 757
		[Nullable(0)]
		[Register("kotlin/jvm/internal/TypeParameterReference$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000B9C0C File Offset: 0x000B7E0C
			internal static IntPtr class_ref
			{
				get
				{
					return TypeParameterReference.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000B9C30 File Offset: 0x000B7E30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TypeParameterReference.CompanionStatic._members;
				}
			}

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x06002A21 RID: 10785 RVA: 0x000B9C38 File Offset: 0x000B7E38
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TypeParameterReference.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000B9C5C File Offset: 0x000B7E5C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TypeParameterReference.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A23 RID: 10787 RVA: 0x000B9C68 File Offset: 0x000B7E68
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A24 RID: 10788 RVA: 0x000B9C74 File Offset: 0x000B7E74
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
					base.SetHandle(TypeParameterReference.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					TypeParameterReference.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06002A25 RID: 10789 RVA: 0x000B9D24 File Offset: 0x000B7F24
			[Register("toString", "(Lkotlin/reflect/KTypeParameter;)Ljava/lang/String;", "")]
			public unsafe string ToString(IKTypeParameter typeParameter)
			{
				string @string;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((typeParameter == null) ? IntPtr.Zero : ((Java.Lang.Object)typeParameter).Handle);
					@string = JNIEnv.GetString(TypeParameterReference.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("toString.(Lkotlin/reflect/KTypeParameter;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(typeParameter);
				}
				return @string;
			}

			// Token: 0x040009EC RID: 2540
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/TypeParameterReference$Companion", typeof(TypeParameterReference.CompanionStatic));

			// Token: 0x02000305 RID: 773
			[Nullable(0)]
			[Register("kotlin/jvm/internal/TypeParameterReference$Companion$WhenMappings", DoNotGenerateAcw = true)]
			public sealed class WhenMappings : Java.Lang.Object
			{
				// Token: 0x17000AC5 RID: 2757
				// (get) Token: 0x06002AAA RID: 10922 RVA: 0x000BB518 File Offset: 0x000B9718
				internal static IntPtr class_ref
				{
					get
					{
						return TypeParameterReference.CompanionStatic.WhenMappings._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000AC6 RID: 2758
				// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000BB53C File Offset: 0x000B973C
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return TypeParameterReference.CompanionStatic.WhenMappings._members;
					}
				}

				// Token: 0x17000AC7 RID: 2759
				// (get) Token: 0x06002AAC RID: 10924 RVA: 0x000BB544 File Offset: 0x000B9744
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return TypeParameterReference.CompanionStatic.WhenMappings._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000AC8 RID: 2760
				// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000BB568 File Offset: 0x000B9768
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return TypeParameterReference.CompanionStatic.WhenMappings._members.ManagedPeerType;
					}
				}

				// Token: 0x06002AAE RID: 10926 RVA: 0x000BB574 File Offset: 0x000B9774
				internal WhenMappings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x040009FC RID: 2556
				private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/TypeParameterReference$Companion$WhenMappings", typeof(TypeParameterReference.CompanionStatic.WhenMappings));
			}
		}
	}
}
