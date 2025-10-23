using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000012 RID: 18
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Debug", DoNotGenerateAcw = true)]
	public sealed class Debug : Java.Lang.Object
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002200 File Offset: 0x00000400
		internal static IntPtr class_ref
		{
			get
			{
				return Debug._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002224 File Offset: 0x00000424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Debug._members;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000222C File Offset: 0x0000042C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Debug._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002250 File Offset: 0x00000450
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Debug._members.ManagedPeerType;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000225C File Offset: 0x0000045C
		internal Debug(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Debug", typeof(Debug));

		// Token: 0x02000074 RID: 116
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/Debug$Renderer", "", "JetBrains.Annotations.Debug/IRendererInvoker")]
		public interface IRenderer : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003EA RID: 1002
			[NullableContext(2)]
			[Register("childrenArray", "()Ljava/lang/String;", "GetChildrenArrayHandler:JetBrains.Annotations.Debug/IRendererInvoker, Xamarin.Jetbrains.Annotations")]
			string ChildrenArray();

			// Token: 0x060003EB RID: 1003
			[NullableContext(2)]
			[Register("hasChildren", "()Ljava/lang/String;", "GetHasChildrenHandler:JetBrains.Annotations.Debug/IRendererInvoker, Xamarin.Jetbrains.Annotations")]
			string HasChildren();

			// Token: 0x060003EC RID: 1004
			[NullableContext(2)]
			[Register("text", "()Ljava/lang/String;", "GetTextHandler:JetBrains.Annotations.Debug/IRendererInvoker, Xamarin.Jetbrains.Annotations")]
			string Text();
		}

		// Token: 0x02000075 RID: 117
		[NullableContext(2)]
		[Nullable(0)]
		[Register("org/jetbrains/annotations/Debug$Renderer", DoNotGenerateAcw = true)]
		internal class IRendererInvoker : Java.Lang.Object, Debug.IRenderer, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060003ED RID: 1005 RVA: 0x0000A948 File Offset: 0x00008B48
			private static IntPtr java_class_ref
			{
				get
				{
					return Debug.IRendererInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000A96C File Offset: 0x00008B6C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Debug.IRendererInvoker._members;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000A973 File Offset: 0x00008B73
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000A97B File Offset: 0x00008B7B
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Debug.IRendererInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x0000A987 File Offset: 0x00008B87
			public static Debug.IRenderer GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Debug.IRenderer>(handle, transfer);
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x0000A990 File Offset: 0x00008B90
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Debug.IRendererInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Debug.Renderer'.");
				}
				return handle;
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x0000A9BB File Offset: 0x00008BBB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x0000A9EC File Offset: 0x00008BEC
			public IRendererInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Debug.IRendererInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x0000AA24 File Offset: 0x00008C24
			[NullableContext(1)]
			private static Delegate GetChildrenArrayHandler()
			{
				if (Debug.IRendererInvoker.cb_childrenArray == null)
				{
					Debug.IRendererInvoker.cb_childrenArray = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Debug.IRendererInvoker.n_ChildrenArray));
				}
				return Debug.IRendererInvoker.cb_childrenArray;
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x0000AA48 File Offset: 0x00008C48
			private static IntPtr n_ChildrenArray(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Debug.IRenderer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChildrenArray());
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x0000AA5C File Offset: 0x00008C5C
			public string ChildrenArray()
			{
				if (this.id_childrenArray == IntPtr.Zero)
				{
					this.id_childrenArray = JNIEnv.GetMethodID(this.class_ref, "childrenArray", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_childrenArray), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x0000AAAD File Offset: 0x00008CAD
			[NullableContext(1)]
			private static Delegate GetHasChildrenHandler()
			{
				if (Debug.IRendererInvoker.cb_hasChildren == null)
				{
					Debug.IRendererInvoker.cb_hasChildren = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Debug.IRendererInvoker.n_HasChildren));
				}
				return Debug.IRendererInvoker.cb_hasChildren;
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x0000AAD1 File Offset: 0x00008CD1
			private static IntPtr n_HasChildren(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Debug.IRenderer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasChildren());
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x0000AAE8 File Offset: 0x00008CE8
			public string HasChildren()
			{
				if (this.id_hasChildren == IntPtr.Zero)
				{
					this.id_hasChildren = JNIEnv.GetMethodID(this.class_ref, "hasChildren", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_hasChildren), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x0000AB39 File Offset: 0x00008D39
			[NullableContext(1)]
			private static Delegate GetTextHandler()
			{
				if (Debug.IRendererInvoker.cb_text == null)
				{
					Debug.IRendererInvoker.cb_text = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Debug.IRendererInvoker.n_Text));
				}
				return Debug.IRendererInvoker.cb_text;
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x0000AB5D File Offset: 0x00008D5D
			private static IntPtr n_Text(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Debug.IRenderer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Text());
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x0000AB74 File Offset: 0x00008D74
			public string Text()
			{
				if (this.id_text == IntPtr.Zero)
				{
					this.id_text = JNIEnv.GetMethodID(this.class_ref, "text", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_text), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x0000ABC5 File Offset: 0x00008DC5
			[NullableContext(1)]
			private static Delegate GetAnnotationTypeHandler()
			{
				if (Debug.IRendererInvoker.cb_annotationType == null)
				{
					Debug.IRendererInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Debug.IRendererInvoker.n_AnnotationType));
				}
				return Debug.IRendererInvoker.cb_annotationType;
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x0000ABE9 File Offset: 0x00008DE9
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Debug.IRenderer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x0000AC00 File Offset: 0x00008E00
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x0000AC51 File Offset: 0x00008E51
			[NullableContext(1)]
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (Debug.IRendererInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					Debug.IRendererInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Debug.IRendererInvoker.n_Equals_Ljava_lang_Object_));
				}
				return Debug.IRendererInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0000AC78 File Offset: 0x00008E78
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<Debug.IRenderer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x0000AC9C File Offset: 0x00008E9C
			public new unsafe bool Equals(Java.Lang.Object obj)
			{
				if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((obj == null) ? IntPtr.Zero : obj.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x0000AD0F File Offset: 0x00008F0F
			[NullableContext(1)]
			private static Delegate GetGetHashCodeHandler()
			{
				if (Debug.IRendererInvoker.cb_hashCode == null)
				{
					Debug.IRendererInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Debug.IRendererInvoker.n_GetHashCode));
				}
				return Debug.IRendererInvoker.cb_hashCode;
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0000AD33 File Offset: 0x00008F33
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Debug.IRenderer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x0000AD42 File Offset: 0x00008F42
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x0000AD82 File Offset: 0x00008F82
			[NullableContext(1)]
			private static Delegate GetToStringHandler()
			{
				if (Debug.IRendererInvoker.cb_toString == null)
				{
					Debug.IRendererInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Debug.IRendererInvoker.n_ToString));
				}
				return Debug.IRendererInvoker.cb_toString;
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x0000ADA6 File Offset: 0x00008FA6
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Debug.IRenderer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x0000ADBC File Offset: 0x00008FBC
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001C4 RID: 452
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Debug$Renderer", typeof(Debug.IRendererInvoker));

			// Token: 0x040001C5 RID: 453
			private IntPtr class_ref;

			// Token: 0x040001C6 RID: 454
			private static Delegate cb_childrenArray;

			// Token: 0x040001C7 RID: 455
			private IntPtr id_childrenArray;

			// Token: 0x040001C8 RID: 456
			private static Delegate cb_hasChildren;

			// Token: 0x040001C9 RID: 457
			private IntPtr id_hasChildren;

			// Token: 0x040001CA RID: 458
			private static Delegate cb_text;

			// Token: 0x040001CB RID: 459
			private IntPtr id_text;

			// Token: 0x040001CC RID: 460
			private static Delegate cb_annotationType;

			// Token: 0x040001CD RID: 461
			private IntPtr id_annotationType;

			// Token: 0x040001CE RID: 462
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001CF RID: 463
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001D0 RID: 464
			private static Delegate cb_hashCode;

			// Token: 0x040001D1 RID: 465
			private IntPtr id_hashCode;

			// Token: 0x040001D2 RID: 466
			private static Delegate cb_toString;

			// Token: 0x040001D3 RID: 467
			private IntPtr id_toString;
		}
	}
}
