using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000A8 RID: 168
	[Register("android/widget/AdapterView", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends android.widget.Adapter"
	})]
	public abstract class AdapterView : ViewGroup
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00004270 File Offset: 0x00002470
		internal static IntPtr class_ref
		{
			get
			{
				return AdapterView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00004294 File Offset: 0x00002494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdapterView._members;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000429C File Offset: 0x0000249C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdapterView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x000042C0 File Offset: 0x000024C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdapterView._members.ManagedPeerType;
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003AAC File Offset: 0x00001CAC
		protected AdapterView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000042CC File Offset: 0x000024CC
		public unsafe AdapterView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(AdapterView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdapterView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000043A8 File Offset: 0x000025A8
		public unsafe AdapterView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(AdapterView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdapterView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x1700003C RID: 60
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00004498 File Offset: 0x00002698
		public unsafe AdapterView.IOnItemSelectedListener OnItemSelectedListener
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					AdapterView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnItemSelectedListener.(Landroid/widget/AdapterView$OnItemSelectedListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00004500 File Offset: 0x00002700
		private static Delegate GetSetAdapter_Landroid_widget_Adapter_Handler()
		{
			if (AdapterView.cb_setAdapter_Landroid_widget_Adapter_ == null)
			{
				AdapterView.cb_setAdapter_Landroid_widget_Adapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdapterView.n_SetAdapter_Landroid_widget_Adapter_));
			}
			return AdapterView.cb_setAdapter_Landroid_widget_Adapter_;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00004524 File Offset: 0x00002724
		private static void n_SetAdapter_Landroid_widget_Adapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			AdapterView @object = Java.Lang.Object.GetObject<AdapterView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.RawAdapter = object2;
		}

		// Token: 0x1700003D RID: 61
		// (set) Token: 0x060002EA RID: 746
		protected abstract Java.Lang.Object RawAdapter { set; }

		// Token: 0x060002EB RID: 747 RVA: 0x00004547 File Offset: 0x00002747
		private static Delegate GetGetSelectedItemPositionHandler()
		{
			if (AdapterView.cb_getSelectedItemPosition == null)
			{
				AdapterView.cb_getSelectedItemPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdapterView.n_GetSelectedItemPosition));
			}
			return AdapterView.cb_getSelectedItemPosition;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000456B File Offset: 0x0000276B
		private static int n_GetSelectedItemPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdapterView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SelectedItemPosition;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000457A File Offset: 0x0000277A
		public virtual int SelectedItemPosition
		{
			get
			{
				return AdapterView._members.InstanceMethods.InvokeVirtualInt32Method("getSelectedItemPosition.()I", this, null);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00004593 File Offset: 0x00002793
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (AdapterView.cb_onLayout_ZIIII == null)
			{
				AdapterView.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(AdapterView.n_OnLayout_ZIIII));
			}
			return AdapterView.cb_onLayout_ZIIII;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000045B7 File Offset: 0x000027B7
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int left, int top, int right, int bottom)
		{
			Java.Lang.Object.GetObject<AdapterView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, left, top, right, bottom);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000045D0 File Offset: 0x000027D0
		protected unsafe override void OnLayout(bool changed, int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(left);
			ptr[2] = new JniArgumentValue(top);
			ptr[3] = new JniArgumentValue(right);
			ptr[4] = new JniArgumentValue(bottom);
			AdapterView._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00004662 File Offset: 0x00002862
		private static Delegate GetSetSelection_IHandler()
		{
			if (AdapterView.cb_setSelection_I == null)
			{
				AdapterView.cb_setSelection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AdapterView.n_SetSelection_I));
			}
			return AdapterView.cb_setSelection_I;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00004686 File Offset: 0x00002886
		private static void n_SetSelection_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<AdapterView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelection(position);
		}

		// Token: 0x060002F3 RID: 755
		public abstract void SetSelection(int position);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060002F4 RID: 756 RVA: 0x00004698 File Offset: 0x00002898
		// (remove) Token: 0x060002F5 RID: 757 RVA: 0x000046E8 File Offset: 0x000028E8
		public event EventHandler<AdapterView.ItemSelectedEventArgs> ItemSelected
		{
			add
			{
				EventHelper.AddEventHandler<AdapterView.IOnItemSelectedListener, AdapterView.IOnItemSelectedListenerImplementor>(ref this.weak_implementor___SetOnItemSelectedListener, new Func<AdapterView.IOnItemSelectedListenerImplementor>(this.__CreateIOnItemSelectedListenerImplementor), delegate(AdapterView.IOnItemSelectedListener __v)
				{
					this.OnItemSelectedListener = __v;
				}, delegate(AdapterView.IOnItemSelectedListenerImplementor __h)
				{
					__h.OnItemSelectedHandler = (EventHandler<AdapterView.ItemSelectedEventArgs>)Delegate.Combine(__h.OnItemSelectedHandler, value);
				});
			}
			remove
			{
				Func<AdapterView.IOnItemSelectedListenerImplementor, bool> empty;
				if ((empty = AdapterView.<>O.<2>____IsEmpty) == null)
				{
					empty = (AdapterView.<>O.<2>____IsEmpty = new Func<AdapterView.IOnItemSelectedListenerImplementor, bool>(AdapterView.IOnItemSelectedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<AdapterView.IOnItemSelectedListener, AdapterView.IOnItemSelectedListenerImplementor>(ref this.weak_implementor___SetOnItemSelectedListener, empty, delegate(AdapterView.IOnItemSelectedListener __v)
				{
					this.OnItemSelectedListener = null;
				}, delegate(AdapterView.IOnItemSelectedListenerImplementor __h)
				{
					__h.OnItemSelectedHandler = (EventHandler<AdapterView.ItemSelectedEventArgs>)Delegate.Remove(__h.OnItemSelectedHandler, value);
				});
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00004747 File Offset: 0x00002947
		private AdapterView.IOnItemSelectedListenerImplementor __CreateIOnItemSelectedListenerImplementor()
		{
			return new AdapterView.IOnItemSelectedListenerImplementor(this);
		}

		// Token: 0x04000056 RID: 86
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AdapterView", typeof(AdapterView));

		// Token: 0x04000057 RID: 87
		private static Delegate cb_setAdapter_Landroid_widget_Adapter_;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_getSelectedItemPosition;

		// Token: 0x04000059 RID: 89
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_setSelection_I;

		// Token: 0x0400005B RID: 91
		private WeakReference weak_implementor___SetOnItemSelectedListener;

		// Token: 0x020000A9 RID: 169
		[Register("android/widget/AdapterView$OnItemSelectedListener", "", "Android.Widget.AdapterView/IOnItemSelectedListenerInvoker")]
		public interface IOnItemSelectedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060002F8 RID: 760
			[Register("onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnItemSelected(AdapterView parent, View view, int position, long id);

			// Token: 0x060002F9 RID: 761
			[Register("onNothingSelected", "(Landroid/widget/AdapterView;)V", "GetOnNothingSelected_Landroid_widget_AdapterView_Handler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnNothingSelected(AdapterView parent);
		}

		// Token: 0x020000AA RID: 170
		[Register("android/widget/AdapterView$OnItemSelectedListener", DoNotGenerateAcw = true)]
		internal class IOnItemSelectedListenerInvoker : Java.Lang.Object, AdapterView.IOnItemSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060002FA RID: 762 RVA: 0x0000476C File Offset: 0x0000296C
			private static IntPtr java_class_ref
			{
				get
				{
					return AdapterView.IOnItemSelectedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060002FB RID: 763 RVA: 0x00004790 File Offset: 0x00002990
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AdapterView.IOnItemSelectedListenerInvoker._members;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060002FC RID: 764 RVA: 0x00004797 File Offset: 0x00002997
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060002FD RID: 765 RVA: 0x0000479F File Offset: 0x0000299F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AdapterView.IOnItemSelectedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060002FE RID: 766 RVA: 0x000047AB File Offset: 0x000029AB
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, AdapterView.IOnItemSelectedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.AdapterView.OnItemSelectedListener'.");
				}
				return handle;
			}

			// Token: 0x060002FF RID: 767 RVA: 0x000047D6 File Offset: 0x000029D6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00004808 File Offset: 0x00002A08
			public IOnItemSelectedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(AdapterView.IOnItemSelectedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000301 RID: 769 RVA: 0x00004840 File Offset: 0x00002A40
			private static Delegate GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler()
			{
				if (AdapterView.IOnItemSelectedListenerInvoker.cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
				{
					AdapterView.IOnItemSelectedListenerInvoker.cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIJ_V(AdapterView.IOnItemSelectedListenerInvoker.n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ));
				}
				return AdapterView.IOnItemSelectedListenerInvoker.cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;
			}

			// Token: 0x06000302 RID: 770 RVA: 0x00004864 File Offset: 0x00002A64
			private static void n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_view, int position, long id)
			{
				AdapterView.IOnItemSelectedListener @object = Java.Lang.Object.GetObject<AdapterView.IOnItemSelectedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AdapterView object2 = Java.Lang.Object.GetObject<AdapterView>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnItemSelected(object2, object3, position, id);
			}

			// Token: 0x06000303 RID: 771 RVA: 0x00004894 File Offset: 0x00002A94
			public unsafe void OnItemSelected(AdapterView parent, View view, int position, long id)
			{
				if (this.id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ == IntPtr.Zero)
				{
					this.id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNIEnv.GetMethodID(this.class_ref, "onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[2] = new JValue(position);
				ptr[3] = new JValue(id);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ, ptr);
			}

			// Token: 0x06000304 RID: 772 RVA: 0x00004956 File Offset: 0x00002B56
			private static Delegate GetOnNothingSelected_Landroid_widget_AdapterView_Handler()
			{
				if (AdapterView.IOnItemSelectedListenerInvoker.cb_onNothingSelected_Landroid_widget_AdapterView_ == null)
				{
					AdapterView.IOnItemSelectedListenerInvoker.cb_onNothingSelected_Landroid_widget_AdapterView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdapterView.IOnItemSelectedListenerInvoker.n_OnNothingSelected_Landroid_widget_AdapterView_));
				}
				return AdapterView.IOnItemSelectedListenerInvoker.cb_onNothingSelected_Landroid_widget_AdapterView_;
			}

			// Token: 0x06000305 RID: 773 RVA: 0x0000497C File Offset: 0x00002B7C
			private static void n_OnNothingSelected_Landroid_widget_AdapterView_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
			{
				AdapterView.IOnItemSelectedListener @object = Java.Lang.Object.GetObject<AdapterView.IOnItemSelectedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AdapterView object2 = Java.Lang.Object.GetObject<AdapterView>(native_parent, JniHandleOwnership.DoNotTransfer);
				@object.OnNothingSelected(object2);
			}

			// Token: 0x06000306 RID: 774 RVA: 0x000049A0 File Offset: 0x00002BA0
			public unsafe void OnNothingSelected(AdapterView parent)
			{
				if (this.id_onNothingSelected_Landroid_widget_AdapterView_ == IntPtr.Zero)
				{
					this.id_onNothingSelected_Landroid_widget_AdapterView_ = JNIEnv.GetMethodID(this.class_ref, "onNothingSelected", "(Landroid/widget/AdapterView;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onNothingSelected_Landroid_widget_AdapterView_, ptr);
			}

			// Token: 0x0400005C RID: 92
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AdapterView$OnItemSelectedListener", typeof(AdapterView.IOnItemSelectedListenerInvoker));

			// Token: 0x0400005D RID: 93
			private IntPtr class_ref;

			// Token: 0x0400005E RID: 94
			private static Delegate cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;

			// Token: 0x0400005F RID: 95
			private IntPtr id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;

			// Token: 0x04000060 RID: 96
			private static Delegate cb_onNothingSelected_Landroid_widget_AdapterView_;

			// Token: 0x04000061 RID: 97
			private IntPtr id_onNothingSelected_Landroid_widget_AdapterView_;
		}

		// Token: 0x020000AB RID: 171
		public class ItemSelectedEventArgs : EventArgs
		{
			// Token: 0x06000308 RID: 776 RVA: 0x00004A2E File Offset: 0x00002C2E
			public ItemSelectedEventArgs(AdapterView parent, View view, int position, long id)
			{
				this.parent = parent;
				this.view = view;
				this.position = position;
				this.id = id;
			}

			// Token: 0x04000062 RID: 98
			private AdapterView parent;

			// Token: 0x04000063 RID: 99
			private View view;

			// Token: 0x04000064 RID: 100
			private int position;

			// Token: 0x04000065 RID: 101
			private long id;
		}

		// Token: 0x020000AC RID: 172
		public class NothingSelectedEventArgs : EventArgs
		{
			// Token: 0x06000309 RID: 777 RVA: 0x00004A53 File Offset: 0x00002C53
			public NothingSelectedEventArgs(AdapterView parent)
			{
				this.parent = parent;
			}

			// Token: 0x04000066 RID: 102
			private AdapterView parent;
		}

		// Token: 0x020000AD RID: 173
		[Register("mono/android/widget/AdapterView_OnItemSelectedListenerImplementor")]
		internal sealed class IOnItemSelectedListenerImplementor : Java.Lang.Object, AdapterView.IOnItemSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600030A RID: 778 RVA: 0x00004A62 File Offset: 0x00002C62
			public IOnItemSelectedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/android/widget/AdapterView_OnItemSelectedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00004A9C File Offset: 0x00002C9C
			public void OnItemSelected(AdapterView parent, View view, int position, long id)
			{
				EventHandler<AdapterView.ItemSelectedEventArgs> onItemSelectedHandler = this.OnItemSelectedHandler;
				if (onItemSelectedHandler != null)
				{
					onItemSelectedHandler(this.sender, new AdapterView.ItemSelectedEventArgs(parent, view, position, id));
				}
			}

			// Token: 0x0600030C RID: 780 RVA: 0x00004ACC File Offset: 0x00002CCC
			public void OnNothingSelected(AdapterView parent)
			{
				EventHandler<AdapterView.NothingSelectedEventArgs> onNothingSelectedHandler = this.OnNothingSelectedHandler;
				if (onNothingSelectedHandler != null)
				{
					onNothingSelectedHandler(this.sender, new AdapterView.NothingSelectedEventArgs(parent));
				}
			}

			// Token: 0x0600030D RID: 781 RVA: 0x00004AF5 File Offset: 0x00002CF5
			internal static bool __IsEmpty(AdapterView.IOnItemSelectedListenerImplementor value)
			{
				return value.OnItemSelectedHandler == null && value.OnNothingSelectedHandler == null;
			}

			// Token: 0x04000067 RID: 103
			private object sender;

			// Token: 0x04000068 RID: 104
			public EventHandler<AdapterView.ItemSelectedEventArgs> OnItemSelectedHandler;

			// Token: 0x04000069 RID: 105
			public EventHandler<AdapterView.NothingSelectedEventArgs> OnNothingSelectedHandler;
		}

		// Token: 0x020000AE RID: 174
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400006A RID: 106
			public static Func<AdapterView.IOnItemSelectedListenerImplementor, bool> <2>____IsEmpty;
		}
	}
}
