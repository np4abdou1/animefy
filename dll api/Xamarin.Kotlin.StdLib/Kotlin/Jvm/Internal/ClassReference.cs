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
	// Token: 0x02000196 RID: 406
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/ClassReference", DoNotGenerateAcw = true)]
	public sealed class ClassReference : Java.Lang.Object, IClassBasedDeclarationContainer, IKDeclarationContainer, IJavaObject, IDisposable, IJavaPeerable, IKClass, IKAnnotatedElement, IKClassifier
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x00040F4C File Offset: 0x0003F14C
		[Register("Companion")]
		public static ClassReference.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<ClassReference.CompanionStatic>(ClassReference._members.StaticFields.GetObjectValue("Companion.Lkotlin/jvm/internal/ClassReference$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00040F7C File Offset: 0x0003F17C
		internal static IntPtr class_ref
		{
			get
			{
				return ClassReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00040FA0 File Offset: 0x0003F1A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClassReference._members;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00040FA8 File Offset: 0x0003F1A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClassReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00040FCC File Offset: 0x0003F1CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClassReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00040FD8 File Offset: 0x0003F1D8
		internal ClassReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00040FE4 File Offset: 0x0003F1E4
		[Register(".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe ClassReference(Class jClass) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((jClass == null) ? IntPtr.Zero : jClass.Handle);
				base.SetHandle(ClassReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ClassReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(jClass);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00041094 File Offset: 0x0003F294
		public IList<IAnnotation> Annotations
		{
			[Register("getAnnotations", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IAnnotation>.FromJniHandle(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getAnnotations.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x000410C8 File Offset: 0x0003F2C8
		public ICollection<IKFunction> Constructors
		{
			[Register("getConstructors", "()Ljava/util/Collection;", "")]
			get
			{
				return JavaCollection<IKFunction>.FromJniHandle(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getConstructors.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x000410FA File Offset: 0x0003F2FA
		public bool IsAbstract
		{
			[Register("isAbstract", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isAbstract.()Z", this, null);
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00041113 File Offset: 0x0003F313
		public bool IsCompanion
		{
			[Register("isCompanion", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isCompanion.()Z", this, null);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0004112C File Offset: 0x0003F32C
		public bool IsData
		{
			[Register("isData", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isData.()Z", this, null);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x00041145 File Offset: 0x0003F345
		public bool IsFinal
		{
			[Register("isFinal", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isFinal.()Z", this, null);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0004115E File Offset: 0x0003F35E
		public bool IsFun
		{
			[Register("isFun", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isFun.()Z", this, null);
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00041177 File Offset: 0x0003F377
		public bool IsInner
		{
			[Register("isInner", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isInner.()Z", this, null);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00041190 File Offset: 0x0003F390
		public bool IsOpen
		{
			[Register("isOpen", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isOpen.()Z", this, null);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x000411A9 File Offset: 0x0003F3A9
		public bool IsSealed
		{
			[Register("isSealed", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isSealed.()Z", this, null);
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x000411C2 File Offset: 0x0003F3C2
		public bool IsValue
		{
			[Register("isValue", "()Z", "")]
			get
			{
				return ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isValue.()Z", this, null);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000411DC File Offset: 0x0003F3DC
		public Class JClass
		{
			[Register("getJClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getJClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00041210 File Offset: 0x0003F410
		public ICollection<IKCallable> Members
		{
			[Register("getMembers", "()Ljava/util/Collection;", "")]
			get
			{
				return JavaCollection<IKCallable>.FromJniHandle(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getMembers.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00041244 File Offset: 0x0003F444
		public ICollection<IKClass> NestedClasses
		{
			[Register("getNestedClasses", "()Ljava/util/Collection;", "")]
			get
			{
				return JavaCollection<IKClass>.FromJniHandle(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getNestedClasses.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00041278 File Offset: 0x0003F478
		[Nullable(2)]
		public Java.Lang.Object ObjectInstance
		{
			[NullableContext(2)]
			[Register("getObjectInstance", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getObjectInstance.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x000412AC File Offset: 0x0003F4AC
		[Nullable(2)]
		public string QualifiedName
		{
			[NullableContext(2)]
			[Register("getQualifiedName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getQualifiedName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000412E0 File Offset: 0x0003F4E0
		public IList<IKClass> SealedSubclasses
		{
			[Register("getSealedSubclasses", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IKClass>.FromJniHandle(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getSealedSubclasses.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00041314 File Offset: 0x0003F514
		[Nullable(2)]
		public string SimpleName
		{
			[NullableContext(2)]
			[Register("getSimpleName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getSimpleName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00041348 File Offset: 0x0003F548
		public IList<IKType> Supertypes
		{
			[Register("getSupertypes", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IKType>.FromJniHandle(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getSupertypes.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0004137C File Offset: 0x0003F57C
		public IList<IKTypeParameter> TypeParameters
		{
			[Register("getTypeParameters", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IKTypeParameter>.FromJniHandle(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getTypeParameters.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000413B0 File Offset: 0x0003F5B0
		[Nullable(2)]
		public KVisibility Visibility
		{
			[NullableContext(2)]
			[Register("getVisibility", "()Lkotlin/reflect/KVisibility;", "")]
			get
			{
				return Java.Lang.Object.GetObject<KVisibility>(ClassReference._members.InstanceMethods.InvokeAbstractObjectMethod("getVisibility.()Lkotlin/reflect/KVisibility;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x000413E4 File Offset: 0x0003F5E4
		[NullableContext(2)]
		[Register("isInstance", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool IsInstance(Java.Lang.Object value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = ClassReference._members.InstanceMethods.InvokeAbstractBooleanMethod("isInstance.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x04000693 RID: 1683
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ClassReference", typeof(ClassReference));

		// Token: 0x020002EA RID: 746
		[Nullable(0)]
		[Register("kotlin/jvm/internal/ClassReference$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x060029BE RID: 10686 RVA: 0x000B8E6C File Offset: 0x000B706C
			internal static IntPtr class_ref
			{
				get
				{
					return ClassReference.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x060029BF RID: 10687 RVA: 0x000B8E90 File Offset: 0x000B7090
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ClassReference.CompanionStatic._members;
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000B8E98 File Offset: 0x000B7098
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ClassReference.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x060029C1 RID: 10689 RVA: 0x000B8EBC File Offset: 0x000B70BC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ClassReference.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x060029C2 RID: 10690 RVA: 0x000B8EC8 File Offset: 0x000B70C8
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029C3 RID: 10691 RVA: 0x000B8ED4 File Offset: 0x000B70D4
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
					base.SetHandle(ClassReference.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ClassReference.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x060029C4 RID: 10692 RVA: 0x000B8F84 File Offset: 0x000B7184
			[Register("getClassQualifiedName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
			[return: Nullable(2)]
			public unsafe string GetClassQualifiedName(Class jClass)
			{
				string @string;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((jClass == null) ? IntPtr.Zero : jClass.Handle);
					@string = JNIEnv.GetString(ClassReference.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getClassQualifiedName.(Ljava/lang/Class;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(jClass);
				}
				return @string;
			}

			// Token: 0x060029C5 RID: 10693 RVA: 0x000B8FF8 File Offset: 0x000B71F8
			[Register("getClassSimpleName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
			[return: Nullable(2)]
			public unsafe string GetClassSimpleName(Class jClass)
			{
				string @string;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((jClass == null) ? IntPtr.Zero : jClass.Handle);
					@string = JNIEnv.GetString(ClassReference.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getClassSimpleName.(Ljava/lang/Class;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(jClass);
				}
				return @string;
			}

			// Token: 0x060029C6 RID: 10694 RVA: 0x000B906C File Offset: 0x000B726C
			[Register("isInstance", "(Ljava/lang/Object;Ljava/lang/Class;)Z", "")]
			public unsafe bool IsInstance([Nullable(2)] Java.Lang.Object value, Class jClass)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ptr[1] = new JniArgumentValue((jClass == null) ? IntPtr.Zero : jClass.Handle);
					result = ClassReference.CompanionStatic._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isInstance.(Ljava/lang/Object;Ljava/lang/Class;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
					GC.KeepAlive(jClass);
				}
				return result;
			}

			// Token: 0x040009E1 RID: 2529
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ClassReference$Companion", typeof(ClassReference.CompanionStatic));
		}
	}
}
