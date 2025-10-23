using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000DB RID: 219
	[Register("android/widget/ListView", DoNotGenerateAcw = true)]
	public class ListView : AbsListView
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00009B6D File Offset: 0x00007D6D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ListView._members;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00009B74 File Offset: 0x00007D74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ListView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00009B98 File Offset: 0x00007D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ListView._members.ManagedPeerType;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000393D File Offset: 0x00001B3D
		protected ListView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00009BA4 File Offset: 0x00007DA4
		public unsafe ListView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ListView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ListView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00009C80 File Offset: 0x00007E80
		public unsafe ListView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ListView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ListView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00009D70 File Offset: 0x00007F70
		private static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Handler()
		{
			if (ListView.cb_setAdapter_Landroid_widget_ListAdapter_ == null)
			{
				ListView.cb_setAdapter_Landroid_widget_ListAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ListView.n_SetAdapter_Landroid_widget_ListAdapter_));
			}
			return ListView.cb_setAdapter_Landroid_widget_ListAdapter_;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00009D94 File Offset: 0x00007F94
		private static void n_SetAdapter_Landroid_widget_ListAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			AdapterView<IListAdapter> @object = Java.Lang.Object.GetObject<ListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IListAdapter object2 = Java.Lang.Object.GetObject<IListAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.Adapter = object2;
		}

		// Token: 0x170000C5 RID: 197
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00009DB8 File Offset: 0x00007FB8
		public unsafe override IListAdapter Adapter
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					ListView._members.InstanceMethods.InvokeVirtualVoidMethod("setAdapter.(Landroid/widget/ListAdapter;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00009E20 File Offset: 0x00008020
		private static Delegate GetSetSelection_IHandler()
		{
			if (ListView.cb_setSelection_I == null)
			{
				ListView.cb_setSelection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ListView.n_SetSelection_I));
			}
			return ListView.cb_setSelection_I;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00009E44 File Offset: 0x00008044
		private static void n_SetSelection_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<ListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelection(position);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00009E54 File Offset: 0x00008054
		public unsafe override void SetSelection(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ListView._members.InstanceMethods.InvokeVirtualVoidMethod("setSelection.(I)V", this, ptr);
		}

		// Token: 0x04000108 RID: 264
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ListView", typeof(ListView));

		// Token: 0x04000109 RID: 265
		private static Delegate cb_setAdapter_Landroid_widget_ListAdapter_;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_setSelection_I;
	}
}
