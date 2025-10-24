using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001D2 RID: 466
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/TypeReference", DoNotGenerateAcw = true)]
	public sealed class TypeReference : Java.Lang.Object, IKType, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x0004CCAC File Offset: 0x0004AEAC
		internal static IntPtr class_ref
		{
			get
			{
				return TypeReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0004CCD0 File Offset: 0x0004AED0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypeReference._members;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0004CCD8 File Offset: 0x0004AED8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0004CCFC File Offset: 0x0004AEFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypeReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0004CD08 File Offset: 0x0004AF08
		internal TypeReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0004CD14 File Offset: 0x0004AF14
		[Register(".ctor", "(Lkotlin/reflect/KClassifier;Ljava/util/List;Z)V", "")]
		public unsafe TypeReference(IKClassifier classifier, IList<KTypeProjection> arguments, bool isMarkedNullable) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<KTypeProjection>.ToLocalJniHandle(arguments);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((classifier == null) ? IntPtr.Zero : ((Java.Lang.Object)classifier).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(isMarkedNullable);
				base.SetHandle(TypeReference._members.InstanceMethods.StartCreateInstance("(Lkotlin/reflect/KClassifier;Ljava/util/List;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TypeReference._members.InstanceMethods.FinishCreateInstance("(Lkotlin/reflect/KClassifier;Ljava/util/List;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(classifier);
				GC.KeepAlive(arguments);
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0004CE04 File Offset: 0x0004B004
		[Register(".ctor", "(Lkotlin/reflect/KClassifier;Ljava/util/List;Lkotlin/reflect/KType;I)V", "")]
		public unsafe TypeReference(IKClassifier classifier, IList<KTypeProjection> arguments, [Nullable(2)] IKType platformTypeUpperBound, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<KTypeProjection>.ToLocalJniHandle(arguments);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((classifier == null) ? IntPtr.Zero : ((Java.Lang.Object)classifier).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((platformTypeUpperBound == null) ? IntPtr.Zero : ((Java.Lang.Object)platformTypeUpperBound).Handle);
				ptr[3] = new JniArgumentValue(flags);
				base.SetHandle(TypeReference._members.InstanceMethods.StartCreateInstance("(Lkotlin/reflect/KClassifier;Ljava/util/List;Lkotlin/reflect/KType;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TypeReference._members.InstanceMethods.FinishCreateInstance("(Lkotlin/reflect/KClassifier;Ljava/util/List;Lkotlin/reflect/KType;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(classifier);
				GC.KeepAlive(arguments);
				GC.KeepAlive(platformTypeUpperBound);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0004CF24 File Offset: 0x0004B124
		public IList<IAnnotation> Annotations
		{
			[Register("getAnnotations", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IAnnotation>.FromJniHandle(TypeReference._members.InstanceMethods.InvokeAbstractObjectMethod("getAnnotations.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0004CF58 File Offset: 0x0004B158
		public IList<KTypeProjection> Arguments
		{
			[Register("getArguments", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<KTypeProjection>.FromJniHandle(TypeReference._members.InstanceMethods.InvokeAbstractObjectMethod("getArguments.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0004CF8C File Offset: 0x0004B18C
		public IKClassifier Classifier
		{
			[Register("getClassifier", "()Lkotlin/reflect/KClassifier;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IKClassifier>(TypeReference._members.InstanceMethods.InvokeAbstractObjectMethod("getClassifier.()Lkotlin/reflect/KClassifier;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x0004CFBE File Offset: 0x0004B1BE
		public bool IsMarkedNullable
		{
			[Register("isMarkedNullable", "()Z", "")]
			get
			{
				return TypeReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isMarkedNullable.()Z", this, null);
			}
		}

		// Token: 0x04000747 RID: 1863
		[Register("IS_MUTABLE_COLLECTION_TYPE")]
		public const int IsMutableCollectionType = 2;

		// Token: 0x04000748 RID: 1864
		[Register("IS_NOTHING_TYPE")]
		public const int IsNothingType = 4;

		// Token: 0x04000749 RID: 1865
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/TypeReference", typeof(TypeReference));

		// Token: 0x020002F6 RID: 758
		[Nullable(0)]
		[Register("kotlin/jvm/internal/TypeReference$WhenMappings", DoNotGenerateAcw = true)]
		public sealed class WhenMappings : Java.Lang.Object
		{
			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000B9DB8 File Offset: 0x000B7FB8
			internal static IntPtr class_ref
			{
				get
				{
					return TypeReference.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000B9DDC File Offset: 0x000B7FDC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TypeReference.WhenMappings._members;
				}
			}

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000B9DE4 File Offset: 0x000B7FE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TypeReference.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000B9E08 File Offset: 0x000B8008
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TypeReference.WhenMappings._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A2B RID: 10795 RVA: 0x000B9E14 File Offset: 0x000B8014
			internal WhenMappings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040009ED RID: 2541
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/TypeReference$WhenMappings", typeof(TypeReference.WhenMappings));
		}
	}
}
