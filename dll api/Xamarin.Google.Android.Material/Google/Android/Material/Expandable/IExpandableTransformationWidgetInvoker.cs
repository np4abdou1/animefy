using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Expandable
{
	// Token: 0x02000048 RID: 72
	[Register("com/google/android/material/expandable/ExpandableTransformationWidget", DoNotGenerateAcw = true)]
	internal class IExpandableTransformationWidgetInvoker : Java.Lang.Object, IExpandableTransformationWidget, IExpandableWidget, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00008140 File Offset: 0x00006340
		private static IntPtr java_class_ref
		{
			get
			{
				return IExpandableTransformationWidgetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00008164 File Offset: 0x00006364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExpandableTransformationWidgetInvoker._members;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000816B File Offset: 0x0000636B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00008173 File Offset: 0x00006373
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExpandableTransformationWidgetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000817F File Offset: 0x0000637F
		public static IExpandableTransformationWidget GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExpandableTransformationWidget>(handle, transfer);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00008188 File Offset: 0x00006388
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExpandableTransformationWidgetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.expandable.ExpandableTransformationWidget'.");
			}
			return handle;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000081B3 File Offset: 0x000063B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000081E4 File Offset: 0x000063E4
		public IExpandableTransformationWidgetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExpandableTransformationWidgetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000821C File Offset: 0x0000641C
		private static Delegate GetGetExpandedComponentIdHintHandler()
		{
			if (IExpandableTransformationWidgetInvoker.cb_getExpandedComponentIdHint == null)
			{
				IExpandableTransformationWidgetInvoker.cb_getExpandedComponentIdHint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExpandableTransformationWidgetInvoker.n_GetExpandedComponentIdHint));
			}
			return IExpandableTransformationWidgetInvoker.cb_getExpandedComponentIdHint;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00008240 File Offset: 0x00006440
		private static int n_GetExpandedComponentIdHint(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExpandableTransformationWidget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedComponentIdHint;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000824F File Offset: 0x0000644F
		private static Delegate GetSetExpandedComponentIdHint_IHandler()
		{
			if (IExpandableTransformationWidgetInvoker.cb_setExpandedComponentIdHint_I == null)
			{
				IExpandableTransformationWidgetInvoker.cb_setExpandedComponentIdHint_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IExpandableTransformationWidgetInvoker.n_SetExpandedComponentIdHint_I));
			}
			return IExpandableTransformationWidgetInvoker.cb_setExpandedComponentIdHint_I;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00008273 File Offset: 0x00006473
		private static void n_SetExpandedComponentIdHint_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IExpandableTransformationWidget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedComponentIdHint = p0;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00008283 File Offset: 0x00006483
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000082C4 File Offset: 0x000064C4
		public unsafe int ExpandedComponentIdHint
		{
			get
			{
				if (this.id_getExpandedComponentIdHint == IntPtr.Zero)
				{
					this.id_getExpandedComponentIdHint = JNIEnv.GetMethodID(this.class_ref, "getExpandedComponentIdHint", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getExpandedComponentIdHint);
			}
			set
			{
				if (this.id_setExpandedComponentIdHint_I == IntPtr.Zero)
				{
					this.id_setExpandedComponentIdHint_I = JNIEnv.GetMethodID(this.class_ref, "setExpandedComponentIdHint", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setExpandedComponentIdHint_I, ptr);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00008328 File Offset: 0x00006528
		private static Delegate GetIsExpandedHandler()
		{
			if (IExpandableTransformationWidgetInvoker.cb_isExpanded == null)
			{
				IExpandableTransformationWidgetInvoker.cb_isExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExpandableTransformationWidgetInvoker.n_IsExpanded));
			}
			return IExpandableTransformationWidgetInvoker.cb_isExpanded;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000834C File Offset: 0x0000654C
		private static bool n_IsExpanded(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExpandableTransformationWidget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExpanded;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000835B File Offset: 0x0000655B
		public bool IsExpanded
		{
			get
			{
				if (this.id_isExpanded == IntPtr.Zero)
				{
					this.id_isExpanded = JNIEnv.GetMethodID(this.class_ref, "isExpanded", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isExpanded);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000839B File Offset: 0x0000659B
		private static Delegate GetSetExpanded_ZHandler()
		{
			if (IExpandableTransformationWidgetInvoker.cb_setExpanded_Z == null)
			{
				IExpandableTransformationWidgetInvoker.cb_setExpanded_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(IExpandableTransformationWidgetInvoker.n_SetExpanded_Z));
			}
			return IExpandableTransformationWidgetInvoker.cb_setExpanded_Z;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000083BF File Offset: 0x000065BF
		private static bool n_SetExpanded_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			return Java.Lang.Object.GetObject<IExpandableTransformationWidget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetExpanded(p0);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000083D0 File Offset: 0x000065D0
		public unsafe bool SetExpanded(bool p0)
		{
			if (this.id_setExpanded_Z == IntPtr.Zero)
			{
				this.id_setExpanded_Z = JNIEnv.GetMethodID(this.class_ref, "setExpanded", "(Z)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_setExpanded_Z, ptr);
		}

		// Token: 0x04000085 RID: 133
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/expandable/ExpandableTransformationWidget", typeof(IExpandableTransformationWidgetInvoker));

		// Token: 0x04000086 RID: 134
		private IntPtr class_ref;

		// Token: 0x04000087 RID: 135
		private static Delegate cb_getExpandedComponentIdHint;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_setExpandedComponentIdHint_I;

		// Token: 0x04000089 RID: 137
		private IntPtr id_getExpandedComponentIdHint;

		// Token: 0x0400008A RID: 138
		private IntPtr id_setExpandedComponentIdHint_I;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_isExpanded;

		// Token: 0x0400008C RID: 140
		private IntPtr id_isExpanded;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_setExpanded_Z;

		// Token: 0x0400008E RID: 142
		private IntPtr id_setExpanded_Z;
	}
}
