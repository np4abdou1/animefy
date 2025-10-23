using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Expandable
{
	// Token: 0x0200004A RID: 74
	[Register("com/google/android/material/expandable/ExpandableWidget", DoNotGenerateAcw = true)]
	internal class IExpandableWidgetInvoker : Java.Lang.Object, IExpandableWidget, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00008450 File Offset: 0x00006650
		private static IntPtr java_class_ref
		{
			get
			{
				return IExpandableWidgetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00008474 File Offset: 0x00006674
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExpandableWidgetInvoker._members;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000847B File Offset: 0x0000667B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00008483 File Offset: 0x00006683
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExpandableWidgetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000848F File Offset: 0x0000668F
		public static IExpandableWidget GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExpandableWidget>(handle, transfer);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00008498 File Offset: 0x00006698
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExpandableWidgetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.expandable.ExpandableWidget'.");
			}
			return handle;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000084C3 File Offset: 0x000066C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000084F4 File Offset: 0x000066F4
		public IExpandableWidgetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExpandableWidgetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000852C File Offset: 0x0000672C
		private static Delegate GetIsExpandedHandler()
		{
			if (IExpandableWidgetInvoker.cb_isExpanded == null)
			{
				IExpandableWidgetInvoker.cb_isExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExpandableWidgetInvoker.n_IsExpanded));
			}
			return IExpandableWidgetInvoker.cb_isExpanded;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00008550 File Offset: 0x00006750
		private static bool n_IsExpanded(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExpandableWidget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExpanded;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000855F File Offset: 0x0000675F
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

		// Token: 0x060002E7 RID: 743 RVA: 0x0000859F File Offset: 0x0000679F
		private static Delegate GetSetExpanded_ZHandler()
		{
			if (IExpandableWidgetInvoker.cb_setExpanded_Z == null)
			{
				IExpandableWidgetInvoker.cb_setExpanded_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(IExpandableWidgetInvoker.n_SetExpanded_Z));
			}
			return IExpandableWidgetInvoker.cb_setExpanded_Z;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000085C3 File Offset: 0x000067C3
		private static bool n_SetExpanded_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			return Java.Lang.Object.GetObject<IExpandableWidget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetExpanded(p0);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000085D4 File Offset: 0x000067D4
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

		// Token: 0x0400008F RID: 143
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/expandable/ExpandableWidget", typeof(IExpandableWidgetInvoker));

		// Token: 0x04000090 RID: 144
		private IntPtr class_ref;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_isExpanded;

		// Token: 0x04000092 RID: 146
		private IntPtr id_isExpanded;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_setExpanded_Z;

		// Token: 0x04000094 RID: 148
		private IntPtr id_setExpanded_Z;
	}
}
