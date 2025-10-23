using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Google.Android.Material.Internal;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Navigation
{
	// Token: 0x0200005E RID: 94
	[Register("com/google/android/material/navigation/NavigationView", DoNotGenerateAcw = true)]
	public class NavigationView : ScrimInsetsFrameLayout
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0000D840 File Offset: 0x0000BA40
		internal new static IntPtr class_ref
		{
			get
			{
				return NavigationView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0000D864 File Offset: 0x0000BA64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NavigationView._members;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0000D86C File Offset: 0x0000BA6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NavigationView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0000D890 File Offset: 0x0000BA90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NavigationView._members.ManagedPeerType;
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000D89C File Offset: 0x0000BA9C
		protected NavigationView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe NavigationView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(NavigationView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NavigationView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000D958 File Offset: 0x0000BB58
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe NavigationView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NavigationView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NavigationView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000DA34 File Offset: 0x0000BC34
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe NavigationView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NavigationView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NavigationView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000DB24 File Offset: 0x0000BD24
		private static Delegate GetIsBottomInsetScrimEnabledHandler()
		{
			if (NavigationView.cb_isBottomInsetScrimEnabled == null)
			{
				NavigationView.cb_isBottomInsetScrimEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NavigationView.n_IsBottomInsetScrimEnabled));
			}
			return NavigationView.cb_isBottomInsetScrimEnabled;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000DB48 File Offset: 0x0000BD48
		private static bool n_IsBottomInsetScrimEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BottomInsetScrimEnabled;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000DB57 File Offset: 0x0000BD57
		private static Delegate GetSetBottomInsetScrimEnabled_ZHandler()
		{
			if (NavigationView.cb_setBottomInsetScrimEnabled_Z == null)
			{
				NavigationView.cb_setBottomInsetScrimEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(NavigationView.n_SetBottomInsetScrimEnabled_Z));
			}
			return NavigationView.cb_setBottomInsetScrimEnabled_Z;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000DB7B File Offset: 0x0000BD7B
		private static void n_SetBottomInsetScrimEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BottomInsetScrimEnabled = enabled;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0000DB8B File Offset: 0x0000BD8B
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
		public unsafe virtual bool BottomInsetScrimEnabled
		{
			[Register("isBottomInsetScrimEnabled", "()Z", "GetIsBottomInsetScrimEnabledHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualBooleanMethod("isBottomInsetScrimEnabled.()Z", this, null);
			}
			[Register("setBottomInsetScrimEnabled", "(Z)V", "GetSetBottomInsetScrimEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setBottomInsetScrimEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000DBDF File Offset: 0x0000BDDF
		private static Delegate GetGetCheckedItemHandler()
		{
			if (NavigationView.cb_getCheckedItem == null)
			{
				NavigationView.cb_getCheckedItem = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NavigationView.n_GetCheckedItem));
			}
			return NavigationView.cb_getCheckedItem;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000DC03 File Offset: 0x0000BE03
		private static IntPtr n_GetCheckedItem(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CheckedItem);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000DC17 File Offset: 0x0000BE17
		private static Delegate GetSetCheckedItem_Landroid_view_MenuItem_Handler()
		{
			if (NavigationView.cb_setCheckedItem_Landroid_view_MenuItem_ == null)
			{
				NavigationView.cb_setCheckedItem_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NavigationView.n_SetCheckedItem_Landroid_view_MenuItem_));
			}
			return NavigationView.cb_setCheckedItem_Landroid_view_MenuItem_;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		private static void n_SetCheckedItem_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_checkedItem)
		{
			NavigationView @object = Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_checkedItem, JniHandleOwnership.DoNotTransfer);
			@object.CheckedItem = object2;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0000DC60 File Offset: 0x0000BE60
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x0000DC94 File Offset: 0x0000BE94
		public unsafe virtual IMenuItem CheckedItem
		{
			[Register("getCheckedItem", "()Landroid/view/MenuItem;", "GetGetCheckedItemHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMenuItem>(NavigationView._members.InstanceMethods.InvokeVirtualObjectMethod("getCheckedItem.()Landroid/view/MenuItem;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCheckedItem", "(Landroid/view/MenuItem;)V", "GetSetCheckedItem_Landroid_view_MenuItem_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setCheckedItem.(Landroid/view/MenuItem;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		private static Delegate GetGetDividerInsetEndHandler()
		{
			if (NavigationView.cb_getDividerInsetEnd == null)
			{
				NavigationView.cb_getDividerInsetEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetDividerInsetEnd));
			}
			return NavigationView.cb_getDividerInsetEnd;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0000DD20 File Offset: 0x0000BF20
		private static int n_GetDividerInsetEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerInsetEnd;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000DD2F File Offset: 0x0000BF2F
		private static Delegate GetSetDividerInsetEnd_IHandler()
		{
			if (NavigationView.cb_setDividerInsetEnd_I == null)
			{
				NavigationView.cb_setDividerInsetEnd_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetDividerInsetEnd_I));
			}
			return NavigationView.cb_setDividerInsetEnd_I;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000DD53 File Offset: 0x0000BF53
		private static void n_SetDividerInsetEnd_I(IntPtr jnienv, IntPtr native__this, int dividerInsetEnd)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerInsetEnd = dividerInsetEnd;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0000DD63 File Offset: 0x0000BF63
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		public unsafe virtual int DividerInsetEnd
		{
			[Register("getDividerInsetEnd", "()I", "GetGetDividerInsetEndHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getDividerInsetEnd.()I", this, null);
			}
			[Register("setDividerInsetEnd", "(I)V", "GetSetDividerInsetEnd_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setDividerInsetEnd.(I)V", this, ptr);
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000DDB7 File Offset: 0x0000BFB7
		private static Delegate GetGetDividerInsetStartHandler()
		{
			if (NavigationView.cb_getDividerInsetStart == null)
			{
				NavigationView.cb_getDividerInsetStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetDividerInsetStart));
			}
			return NavigationView.cb_getDividerInsetStart;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000DDDB File Offset: 0x0000BFDB
		private static int n_GetDividerInsetStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerInsetStart;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000DDEA File Offset: 0x0000BFEA
		private static Delegate GetSetDividerInsetStart_IHandler()
		{
			if (NavigationView.cb_setDividerInsetStart_I == null)
			{
				NavigationView.cb_setDividerInsetStart_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetDividerInsetStart_I));
			}
			return NavigationView.cb_setDividerInsetStart_I;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000DE0E File Offset: 0x0000C00E
		private static void n_SetDividerInsetStart_I(IntPtr jnienv, IntPtr native__this, int dividerInsetStart)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerInsetStart = dividerInsetStart;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0000DE1E File Offset: 0x0000C01E
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x0000DE38 File Offset: 0x0000C038
		public unsafe virtual int DividerInsetStart
		{
			[Register("getDividerInsetStart", "()I", "GetGetDividerInsetStartHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getDividerInsetStart.()I", this, null);
			}
			[Register("setDividerInsetStart", "(I)V", "GetSetDividerInsetStart_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setDividerInsetStart.(I)V", this, ptr);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000DE73 File Offset: 0x0000C073
		private static Delegate GetGetHeaderCountHandler()
		{
			if (NavigationView.cb_getHeaderCount == null)
			{
				NavigationView.cb_getHeaderCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetHeaderCount));
			}
			return NavigationView.cb_getHeaderCount;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000DE97 File Offset: 0x0000C097
		private static int n_GetHeaderCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HeaderCount;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0000DEA6 File Offset: 0x0000C0A6
		public virtual int HeaderCount
		{
			[Register("getHeaderCount", "()I", "GetGetHeaderCountHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getHeaderCount.()I", this, null);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000DEBF File Offset: 0x0000C0BF
		private static Delegate GetGetItemBackgroundHandler()
		{
			if (NavigationView.cb_getItemBackground == null)
			{
				NavigationView.cb_getItemBackground = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NavigationView.n_GetItemBackground));
			}
			return NavigationView.cb_getItemBackground;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000DEE3 File Offset: 0x0000C0E3
		private static IntPtr n_GetItemBackground(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemBackground);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000DEF7 File Offset: 0x0000C0F7
		private static Delegate GetSetItemBackground_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (NavigationView.cb_setItemBackground_Landroid_graphics_drawable_Drawable_ == null)
			{
				NavigationView.cb_setItemBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NavigationView.n_SetItemBackground_Landroid_graphics_drawable_Drawable_));
			}
			return NavigationView.cb_setItemBackground_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000DF1C File Offset: 0x0000C11C
		private static void n_SetItemBackground_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_itemBackground)
		{
			NavigationView @object = Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_itemBackground, JniHandleOwnership.DoNotTransfer);
			@object.ItemBackground = object2;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000DF40 File Offset: 0x0000C140
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0000DF74 File Offset: 0x0000C174
		public unsafe virtual Drawable ItemBackground
		{
			[Register("getItemBackground", "()Landroid/graphics/drawable/Drawable;", "GetGetItemBackgroundHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(NavigationView._members.InstanceMethods.InvokeVirtualObjectMethod("getItemBackground.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setItemBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetItemBackground_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemBackground.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000DFD8 File Offset: 0x0000C1D8
		private static Delegate GetGetItemHorizontalPaddingHandler()
		{
			if (NavigationView.cb_getItemHorizontalPadding == null)
			{
				NavigationView.cb_getItemHorizontalPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetItemHorizontalPadding));
			}
			return NavigationView.cb_getItemHorizontalPadding;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000DFFC File Offset: 0x0000C1FC
		private static int n_GetItemHorizontalPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemHorizontalPadding;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000E00B File Offset: 0x0000C20B
		private static Delegate GetSetItemHorizontalPadding_IHandler()
		{
			if (NavigationView.cb_setItemHorizontalPadding_I == null)
			{
				NavigationView.cb_setItemHorizontalPadding_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemHorizontalPadding_I));
			}
			return NavigationView.cb_setItemHorizontalPadding_I;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000E02F File Offset: 0x0000C22F
		private static void n_SetItemHorizontalPadding_I(IntPtr jnienv, IntPtr native__this, int padding)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemHorizontalPadding = padding;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0000E03F File Offset: 0x0000C23F
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x0000E058 File Offset: 0x0000C258
		public unsafe virtual int ItemHorizontalPadding
		{
			[Register("getItemHorizontalPadding", "()I", "GetGetItemHorizontalPaddingHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getItemHorizontalPadding.()I", this, null);
			}
			[Register("setItemHorizontalPadding", "(I)V", "GetSetItemHorizontalPadding_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemHorizontalPadding.(I)V", this, ptr);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000E093 File Offset: 0x0000C293
		private static Delegate GetGetItemIconPaddingHandler()
		{
			if (NavigationView.cb_getItemIconPadding == null)
			{
				NavigationView.cb_getItemIconPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetItemIconPadding));
			}
			return NavigationView.cb_getItemIconPadding;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000E0B7 File Offset: 0x0000C2B7
		private static int n_GetItemIconPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemIconPadding;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
		private static Delegate GetSetItemIconPadding_IHandler()
		{
			if (NavigationView.cb_setItemIconPadding_I == null)
			{
				NavigationView.cb_setItemIconPadding_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemIconPadding_I));
			}
			return NavigationView.cb_setItemIconPadding_I;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000E0EA File Offset: 0x0000C2EA
		private static void n_SetItemIconPadding_I(IntPtr jnienv, IntPtr native__this, int padding)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemIconPadding = padding;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0000E0FA File Offset: 0x0000C2FA
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x0000E114 File Offset: 0x0000C314
		public unsafe virtual int ItemIconPadding
		{
			[Register("getItemIconPadding", "()I", "GetGetItemIconPaddingHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getItemIconPadding.()I", this, null);
			}
			[Register("setItemIconPadding", "(I)V", "GetSetItemIconPadding_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemIconPadding.(I)V", this, ptr);
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000E14F File Offset: 0x0000C34F
		private static Delegate GetGetItemIconTintListHandler()
		{
			if (NavigationView.cb_getItemIconTintList == null)
			{
				NavigationView.cb_getItemIconTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NavigationView.n_GetItemIconTintList));
			}
			return NavigationView.cb_getItemIconTintList;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000E173 File Offset: 0x0000C373
		private static IntPtr n_GetItemIconTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemIconTintList);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000E187 File Offset: 0x0000C387
		private static Delegate GetSetItemIconTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (NavigationView.cb_setItemIconTintList_Landroid_content_res_ColorStateList_ == null)
			{
				NavigationView.cb_setItemIconTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NavigationView.n_SetItemIconTintList_Landroid_content_res_ColorStateList_));
			}
			return NavigationView.cb_setItemIconTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		private static void n_SetItemIconTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			NavigationView @object = Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.ItemIconTintList = object2;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0000E204 File Offset: 0x0000C404
		public unsafe virtual ColorStateList ItemIconTintList
		{
			[Register("getItemIconTintList", "()Landroid/content/res/ColorStateList;", "GetGetItemIconTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(NavigationView._members.InstanceMethods.InvokeVirtualObjectMethod("getItemIconTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setItemIconTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetItemIconTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemIconTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000E268 File Offset: 0x0000C468
		private static Delegate GetGetItemMaxLinesHandler()
		{
			if (NavigationView.cb_getItemMaxLines == null)
			{
				NavigationView.cb_getItemMaxLines = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetItemMaxLines));
			}
			return NavigationView.cb_getItemMaxLines;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000E28C File Offset: 0x0000C48C
		private static int n_GetItemMaxLines(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemMaxLines;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000E29B File Offset: 0x0000C49B
		private static Delegate GetSetItemMaxLines_IHandler()
		{
			if (NavigationView.cb_setItemMaxLines_I == null)
			{
				NavigationView.cb_setItemMaxLines_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemMaxLines_I));
			}
			return NavigationView.cb_setItemMaxLines_I;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000E2BF File Offset: 0x0000C4BF
		private static void n_SetItemMaxLines_I(IntPtr jnienv, IntPtr native__this, int itemMaxLines)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemMaxLines = itemMaxLines;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0000E2CF File Offset: 0x0000C4CF
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
		public unsafe virtual int ItemMaxLines
		{
			[Register("getItemMaxLines", "()I", "GetGetItemMaxLinesHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getItemMaxLines.()I", this, null);
			}
			[Register("setItemMaxLines", "(I)V", "GetSetItemMaxLines_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemMaxLines.(I)V", this, ptr);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000E323 File Offset: 0x0000C523
		private static Delegate GetGetItemTextColorHandler()
		{
			if (NavigationView.cb_getItemTextColor == null)
			{
				NavigationView.cb_getItemTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NavigationView.n_GetItemTextColor));
			}
			return NavigationView.cb_getItemTextColor;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000E347 File Offset: 0x0000C547
		private static IntPtr n_GetItemTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemTextColor);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000E35B File Offset: 0x0000C55B
		private static Delegate GetSetItemTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (NavigationView.cb_setItemTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				NavigationView.cb_setItemTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NavigationView.n_SetItemTextColor_Landroid_content_res_ColorStateList_));
			}
			return NavigationView.cb_setItemTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000E380 File Offset: 0x0000C580
		private static void n_SetItemTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_textColor)
		{
			NavigationView @object = Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_textColor, JniHandleOwnership.DoNotTransfer);
			@object.ItemTextColor = object2;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x0000E3D8 File Offset: 0x0000C5D8
		public unsafe virtual ColorStateList ItemTextColor
		{
			[Register("getItemTextColor", "()Landroid/content/res/ColorStateList;", "GetGetItemTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(NavigationView._members.InstanceMethods.InvokeVirtualObjectMethod("getItemTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setItemTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetItemTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000E43C File Offset: 0x0000C63C
		private static Delegate GetGetItemVerticalPaddingHandler()
		{
			if (NavigationView.cb_getItemVerticalPadding == null)
			{
				NavigationView.cb_getItemVerticalPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetItemVerticalPadding));
			}
			return NavigationView.cb_getItemVerticalPadding;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000E460 File Offset: 0x0000C660
		private static int n_GetItemVerticalPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemVerticalPadding;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000E46F File Offset: 0x0000C66F
		private static Delegate GetSetItemVerticalPadding_IHandler()
		{
			if (NavigationView.cb_setItemVerticalPadding_I == null)
			{
				NavigationView.cb_setItemVerticalPadding_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemVerticalPadding_I));
			}
			return NavigationView.cb_setItemVerticalPadding_I;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000E493 File Offset: 0x0000C693
		private static void n_SetItemVerticalPadding_I(IntPtr jnienv, IntPtr native__this, int padding)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemVerticalPadding = padding;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0000E4A3 File Offset: 0x0000C6A3
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		public unsafe virtual int ItemVerticalPadding
		{
			[Register("getItemVerticalPadding", "()I", "GetGetItemVerticalPaddingHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getItemVerticalPadding.()I", this, null);
			}
			[Register("setItemVerticalPadding", "(I)V", "GetSetItemVerticalPadding_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemVerticalPadding.(I)V", this, ptr);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000E4F7 File Offset: 0x0000C6F7
		private static Delegate GetGetMenuHandler()
		{
			if (NavigationView.cb_getMenu == null)
			{
				NavigationView.cb_getMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NavigationView.n_GetMenu));
			}
			return NavigationView.cb_getMenu;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000E51B File Offset: 0x0000C71B
		private static IntPtr n_GetMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Menu);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000E530 File Offset: 0x0000C730
		public virtual IMenu Menu
		{
			[Register("getMenu", "()Landroid/view/Menu;", "GetGetMenuHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMenu>(NavigationView._members.InstanceMethods.InvokeVirtualObjectMethod("getMenu.()Landroid/view/Menu;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0000E562 File Offset: 0x0000C762
		private static Delegate GetGetSubheaderInsetEndHandler()
		{
			if (NavigationView.cb_getSubheaderInsetEnd == null)
			{
				NavigationView.cb_getSubheaderInsetEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetSubheaderInsetEnd));
			}
			return NavigationView.cb_getSubheaderInsetEnd;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0000E586 File Offset: 0x0000C786
		private static int n_GetSubheaderInsetEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubheaderInsetEnd;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000E595 File Offset: 0x0000C795
		private static Delegate GetSetSubheaderInsetEnd_IHandler()
		{
			if (NavigationView.cb_setSubheaderInsetEnd_I == null)
			{
				NavigationView.cb_setSubheaderInsetEnd_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetSubheaderInsetEnd_I));
			}
			return NavigationView.cb_setSubheaderInsetEnd_I;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000E5B9 File Offset: 0x0000C7B9
		private static void n_SetSubheaderInsetEnd_I(IntPtr jnienv, IntPtr native__this, int subheaderInsetEnd)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubheaderInsetEnd = subheaderInsetEnd;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000E5C9 File Offset: 0x0000C7C9
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		public unsafe virtual int SubheaderInsetEnd
		{
			[Register("getSubheaderInsetEnd", "()I", "GetGetSubheaderInsetEndHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getSubheaderInsetEnd.()I", this, null);
			}
			[Register("setSubheaderInsetEnd", "(I)V", "GetSetSubheaderInsetEnd_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setSubheaderInsetEnd.(I)V", this, ptr);
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000E61F File Offset: 0x0000C81F
		private static Delegate GetGetSubheaderInsetStartHandler()
		{
			if (NavigationView.cb_getSubheaderInsetStart == null)
			{
				NavigationView.cb_getSubheaderInsetStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NavigationView.n_GetSubheaderInsetStart));
			}
			return NavigationView.cb_getSubheaderInsetStart;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000E643 File Offset: 0x0000C843
		private static int n_GetSubheaderInsetStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubheaderInsetStart;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000E652 File Offset: 0x0000C852
		private static Delegate GetSetSubheaderInsetStart_IHandler()
		{
			if (NavigationView.cb_setSubheaderInsetStart_I == null)
			{
				NavigationView.cb_setSubheaderInsetStart_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetSubheaderInsetStart_I));
			}
			return NavigationView.cb_setSubheaderInsetStart_I;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000E676 File Offset: 0x0000C876
		private static void n_SetSubheaderInsetStart_I(IntPtr jnienv, IntPtr native__this, int subheaderInsetStart)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubheaderInsetStart = subheaderInsetStart;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000E686 File Offset: 0x0000C886
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public unsafe virtual int SubheaderInsetStart
		{
			[Register("getSubheaderInsetStart", "()I", "GetGetSubheaderInsetStartHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualInt32Method("getSubheaderInsetStart.()I", this, null);
			}
			[Register("setSubheaderInsetStart", "(I)V", "GetSetSubheaderInsetStart_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setSubheaderInsetStart.(I)V", this, ptr);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000E6DB File Offset: 0x0000C8DB
		private static Delegate GetIsTopInsetScrimEnabledHandler()
		{
			if (NavigationView.cb_isTopInsetScrimEnabled == null)
			{
				NavigationView.cb_isTopInsetScrimEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NavigationView.n_IsTopInsetScrimEnabled));
			}
			return NavigationView.cb_isTopInsetScrimEnabled;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000E6FF File Offset: 0x0000C8FF
		private static bool n_IsTopInsetScrimEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopInsetScrimEnabled;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000E70E File Offset: 0x0000C90E
		private static Delegate GetSetTopInsetScrimEnabled_ZHandler()
		{
			if (NavigationView.cb_setTopInsetScrimEnabled_Z == null)
			{
				NavigationView.cb_setTopInsetScrimEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(NavigationView.n_SetTopInsetScrimEnabled_Z));
			}
			return NavigationView.cb_setTopInsetScrimEnabled_Z;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000E732 File Offset: 0x0000C932
		private static void n_SetTopInsetScrimEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopInsetScrimEnabled = enabled;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0000E742 File Offset: 0x0000C942
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0000E75C File Offset: 0x0000C95C
		public unsafe virtual bool TopInsetScrimEnabled
		{
			[Register("isTopInsetScrimEnabled", "()Z", "GetIsTopInsetScrimEnabledHandler")]
			get
			{
				return NavigationView._members.InstanceMethods.InvokeVirtualBooleanMethod("isTopInsetScrimEnabled.()Z", this, null);
			}
			[Register("setTopInsetScrimEnabled", "(Z)V", "GetSetTopInsetScrimEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setTopInsetScrimEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0000E797 File Offset: 0x0000C997
		private static Delegate GetAddHeaderView_Landroid_view_View_Handler()
		{
			if (NavigationView.cb_addHeaderView_Landroid_view_View_ == null)
			{
				NavigationView.cb_addHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NavigationView.n_AddHeaderView_Landroid_view_View_));
			}
			return NavigationView.cb_addHeaderView_Landroid_view_View_;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		private static void n_AddHeaderView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			NavigationView @object = Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.AddHeaderView(object2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		[Register("addHeaderView", "(Landroid/view/View;)V", "GetAddHeaderView_Landroid_view_View_Handler")]
		public unsafe virtual void AddHeaderView(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("addHeaderView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000E844 File Offset: 0x0000CA44
		private static Delegate GetGetHeaderView_IHandler()
		{
			if (NavigationView.cb_getHeaderView_I == null)
			{
				NavigationView.cb_getHeaderView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NavigationView.n_GetHeaderView_I));
			}
			return NavigationView.cb_getHeaderView_I;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000E868 File Offset: 0x0000CA68
		private static IntPtr n_GetHeaderView_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHeaderView(index));
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Register("getHeaderView", "(I)Landroid/view/View;", "GetGetHeaderView_IHandler")]
		public unsafe virtual View GetHeaderView(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<View>(NavigationView._members.InstanceMethods.InvokeVirtualObjectMethod("getHeaderView.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000E8C9 File Offset: 0x0000CAC9
		private static Delegate GetInflateHeaderView_IHandler()
		{
			if (NavigationView.cb_inflateHeaderView_I == null)
			{
				NavigationView.cb_inflateHeaderView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NavigationView.n_InflateHeaderView_I));
			}
			return NavigationView.cb_inflateHeaderView_I;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000E8ED File Offset: 0x0000CAED
		private static IntPtr n_InflateHeaderView_I(IntPtr jnienv, IntPtr native__this, int res)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InflateHeaderView(res));
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000E904 File Offset: 0x0000CB04
		[Register("inflateHeaderView", "(I)Landroid/view/View;", "GetInflateHeaderView_IHandler")]
		public unsafe virtual View InflateHeaderView(int res)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(res);
			return Java.Lang.Object.GetObject<View>(NavigationView._members.InstanceMethods.InvokeVirtualObjectMethod("inflateHeaderView.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000E94D File Offset: 0x0000CB4D
		private static Delegate GetInflateMenu_IHandler()
		{
			if (NavigationView.cb_inflateMenu_I == null)
			{
				NavigationView.cb_inflateMenu_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_InflateMenu_I));
			}
			return NavigationView.cb_inflateMenu_I;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000E971 File Offset: 0x0000CB71
		private static void n_InflateMenu_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InflateMenu(resId);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000E984 File Offset: 0x0000CB84
		[Register("inflateMenu", "(I)V", "GetInflateMenu_IHandler")]
		public unsafe virtual void InflateMenu(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("inflateMenu.(I)V", this, ptr);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000E9BF File Offset: 0x0000CBBF
		private static Delegate GetRemoveHeaderView_Landroid_view_View_Handler()
		{
			if (NavigationView.cb_removeHeaderView_Landroid_view_View_ == null)
			{
				NavigationView.cb_removeHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NavigationView.n_RemoveHeaderView_Landroid_view_View_));
			}
			return NavigationView.cb_removeHeaderView_Landroid_view_View_;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
		private static void n_RemoveHeaderView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			NavigationView @object = Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.RemoveHeaderView(object2);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000EA08 File Offset: 0x0000CC08
		[Register("removeHeaderView", "(Landroid/view/View;)V", "GetRemoveHeaderView_Landroid_view_View_Handler")]
		public unsafe virtual void RemoveHeaderView(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("removeHeaderView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		private static Delegate GetSetCheckedItem_IHandler()
		{
			if (NavigationView.cb_setCheckedItem_I == null)
			{
				NavigationView.cb_setCheckedItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetCheckedItem_I));
			}
			return NavigationView.cb_setCheckedItem_I;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000EA90 File Offset: 0x0000CC90
		private static void n_SetCheckedItem_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCheckedItem(id);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		[Register("setCheckedItem", "(I)V", "GetSetCheckedItem_IHandler")]
		public unsafe virtual void SetCheckedItem(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setCheckedItem.(I)V", this, ptr);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000EADB File Offset: 0x0000CCDB
		private static Delegate GetSetItemBackgroundResource_IHandler()
		{
			if (NavigationView.cb_setItemBackgroundResource_I == null)
			{
				NavigationView.cb_setItemBackgroundResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemBackgroundResource_I));
			}
			return NavigationView.cb_setItemBackgroundResource_I;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000EAFF File Offset: 0x0000CCFF
		private static void n_SetItemBackgroundResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetItemBackgroundResource(resId);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000EB10 File Offset: 0x0000CD10
		[Register("setItemBackgroundResource", "(I)V", "GetSetItemBackgroundResource_IHandler")]
		public unsafe virtual void SetItemBackgroundResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemBackgroundResource.(I)V", this, ptr);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000EB4B File Offset: 0x0000CD4B
		private static Delegate GetSetItemHorizontalPaddingResource_IHandler()
		{
			if (NavigationView.cb_setItemHorizontalPaddingResource_I == null)
			{
				NavigationView.cb_setItemHorizontalPaddingResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemHorizontalPaddingResource_I));
			}
			return NavigationView.cb_setItemHorizontalPaddingResource_I;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000EB6F File Offset: 0x0000CD6F
		private static void n_SetItemHorizontalPaddingResource_I(IntPtr jnienv, IntPtr native__this, int paddingResource)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetItemHorizontalPaddingResource(paddingResource);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Register("setItemHorizontalPaddingResource", "(I)V", "GetSetItemHorizontalPaddingResource_IHandler")]
		public unsafe virtual void SetItemHorizontalPaddingResource(int paddingResource)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(paddingResource);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemHorizontalPaddingResource.(I)V", this, ptr);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000EBBB File Offset: 0x0000CDBB
		private static Delegate GetSetItemIconPaddingResource_IHandler()
		{
			if (NavigationView.cb_setItemIconPaddingResource_I == null)
			{
				NavigationView.cb_setItemIconPaddingResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemIconPaddingResource_I));
			}
			return NavigationView.cb_setItemIconPaddingResource_I;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000EBDF File Offset: 0x0000CDDF
		private static void n_SetItemIconPaddingResource_I(IntPtr jnienv, IntPtr native__this, int paddingResource)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetItemIconPaddingResource(paddingResource);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		[Register("setItemIconPaddingResource", "(I)V", "GetSetItemIconPaddingResource_IHandler")]
		public unsafe virtual void SetItemIconPaddingResource(int paddingResource)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(paddingResource);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemIconPaddingResource.(I)V", this, ptr);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000EC2B File Offset: 0x0000CE2B
		private static Delegate GetSetItemIconSize_IHandler()
		{
			if (NavigationView.cb_setItemIconSize_I == null)
			{
				NavigationView.cb_setItemIconSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemIconSize_I));
			}
			return NavigationView.cb_setItemIconSize_I;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000EC4F File Offset: 0x0000CE4F
		private static void n_SetItemIconSize_I(IntPtr jnienv, IntPtr native__this, int iconSize)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetItemIconSize(iconSize);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000EC60 File Offset: 0x0000CE60
		[Register("setItemIconSize", "(I)V", "GetSetItemIconSize_IHandler")]
		public unsafe virtual void SetItemIconSize(int iconSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(iconSize);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemIconSize.(I)V", this, ptr);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0000EC9B File Offset: 0x0000CE9B
		private static Delegate GetSetItemTextAppearance_IHandler()
		{
			if (NavigationView.cb_setItemTextAppearance_I == null)
			{
				NavigationView.cb_setItemTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemTextAppearance_I));
			}
			return NavigationView.cb_setItemTextAppearance_I;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000ECBF File Offset: 0x0000CEBF
		private static void n_SetItemTextAppearance_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetItemTextAppearance(resId);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[Register("setItemTextAppearance", "(I)V", "GetSetItemTextAppearance_IHandler")]
		public unsafe virtual void SetItemTextAppearance(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		private static Delegate GetSetItemVerticalPaddingResource_IHandler()
		{
			if (NavigationView.cb_setItemVerticalPaddingResource_I == null)
			{
				NavigationView.cb_setItemVerticalPaddingResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(NavigationView.n_SetItemVerticalPaddingResource_I));
			}
			return NavigationView.cb_setItemVerticalPaddingResource_I;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000ED2F File Offset: 0x0000CF2F
		private static void n_SetItemVerticalPaddingResource_I(IntPtr jnienv, IntPtr native__this, int paddingResource)
		{
			Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetItemVerticalPaddingResource(paddingResource);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000ED40 File Offset: 0x0000CF40
		[Register("setItemVerticalPaddingResource", "(I)V", "GetSetItemVerticalPaddingResource_IHandler")]
		public unsafe virtual void SetItemVerticalPaddingResource(int paddingResource)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(paddingResource);
			NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemVerticalPaddingResource.(I)V", this, ptr);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000ED7B File Offset: 0x0000CF7B
		private static Delegate GetSetNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_Handler()
		{
			if (NavigationView.cb_setNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_ == null)
			{
				NavigationView.cb_setNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NavigationView.n_SetNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_));
			}
			return NavigationView.cb_setNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		private static void n_SetNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			NavigationView @object = Java.Lang.Object.GetObject<NavigationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			NavigationView.IOnNavigationItemSelectedListener object2 = Java.Lang.Object.GetObject<NavigationView.IOnNavigationItemSelectedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetNavigationItemSelectedListener(object2);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
		[Register("setNavigationItemSelectedListener", "(Lcom/google/android/material/navigation/NavigationView$OnNavigationItemSelectedListener;)V", "GetSetNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_Handler")]
		public unsafe virtual void SetNavigationItemSelectedListener(NavigationView.IOnNavigationItemSelectedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				NavigationView._members.InstanceMethods.InvokeVirtualVoidMethod("setNavigationItemSelectedListener.(Lcom/google/android/material/navigation/NavigationView$OnNavigationItemSelectedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000557 RID: 1367 RVA: 0x0000EE2C File Offset: 0x0000D02C
		// (remove) Token: 0x06000558 RID: 1368 RVA: 0x0000EE78 File Offset: 0x0000D078
		public event EventHandler<NavigationView.NavigationItemSelectedEventArgs> NavigationItemSelected
		{
			add
			{
				EventHelper.AddEventHandler<NavigationView.IOnNavigationItemSelectedListener, NavigationView.IOnNavigationItemSelectedListenerImplementor>(ref this.weak_implementor_SetNavigationItemSelectedListener, new Func<NavigationView.IOnNavigationItemSelectedListenerImplementor>(this.__CreateIOnNavigationItemSelectedListenerImplementor), new Action<NavigationView.IOnNavigationItemSelectedListener>(this.SetNavigationItemSelectedListener), delegate(NavigationView.IOnNavigationItemSelectedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<NavigationView.NavigationItemSelectedEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<NavigationView.IOnNavigationItemSelectedListenerImplementor, bool> empty;
				if ((empty = NavigationView.<>O.<0>____IsEmpty) == null)
				{
					empty = (NavigationView.<>O.<0>____IsEmpty = new Func<NavigationView.IOnNavigationItemSelectedListenerImplementor, bool>(NavigationView.IOnNavigationItemSelectedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<NavigationView.IOnNavigationItemSelectedListener, NavigationView.IOnNavigationItemSelectedListenerImplementor>(ref this.weak_implementor_SetNavigationItemSelectedListener, empty, delegate(NavigationView.IOnNavigationItemSelectedListener __v)
				{
					this.SetNavigationItemSelectedListener(null);
				}, delegate(NavigationView.IOnNavigationItemSelectedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<NavigationView.NavigationItemSelectedEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000EED7 File Offset: 0x0000D0D7
		private NavigationView.IOnNavigationItemSelectedListenerImplementor __CreateIOnNavigationItemSelectedListenerImplementor()
		{
			return new NavigationView.IOnNavigationItemSelectedListenerImplementor(this);
		}

		// Token: 0x04000132 RID: 306
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/navigation/NavigationView", typeof(NavigationView));

		// Token: 0x04000133 RID: 307
		private static Delegate cb_isBottomInsetScrimEnabled;

		// Token: 0x04000134 RID: 308
		private static Delegate cb_setBottomInsetScrimEnabled_Z;

		// Token: 0x04000135 RID: 309
		private static Delegate cb_getCheckedItem;

		// Token: 0x04000136 RID: 310
		private static Delegate cb_setCheckedItem_Landroid_view_MenuItem_;

		// Token: 0x04000137 RID: 311
		private static Delegate cb_getDividerInsetEnd;

		// Token: 0x04000138 RID: 312
		private static Delegate cb_setDividerInsetEnd_I;

		// Token: 0x04000139 RID: 313
		private static Delegate cb_getDividerInsetStart;

		// Token: 0x0400013A RID: 314
		private static Delegate cb_setDividerInsetStart_I;

		// Token: 0x0400013B RID: 315
		private static Delegate cb_getHeaderCount;

		// Token: 0x0400013C RID: 316
		private static Delegate cb_getItemBackground;

		// Token: 0x0400013D RID: 317
		private static Delegate cb_setItemBackground_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400013E RID: 318
		private static Delegate cb_getItemHorizontalPadding;

		// Token: 0x0400013F RID: 319
		private static Delegate cb_setItemHorizontalPadding_I;

		// Token: 0x04000140 RID: 320
		private static Delegate cb_getItemIconPadding;

		// Token: 0x04000141 RID: 321
		private static Delegate cb_setItemIconPadding_I;

		// Token: 0x04000142 RID: 322
		private static Delegate cb_getItemIconTintList;

		// Token: 0x04000143 RID: 323
		private static Delegate cb_setItemIconTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000144 RID: 324
		private static Delegate cb_getItemMaxLines;

		// Token: 0x04000145 RID: 325
		private static Delegate cb_setItemMaxLines_I;

		// Token: 0x04000146 RID: 326
		private static Delegate cb_getItemTextColor;

		// Token: 0x04000147 RID: 327
		private static Delegate cb_setItemTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000148 RID: 328
		private static Delegate cb_getItemVerticalPadding;

		// Token: 0x04000149 RID: 329
		private static Delegate cb_setItemVerticalPadding_I;

		// Token: 0x0400014A RID: 330
		private static Delegate cb_getMenu;

		// Token: 0x0400014B RID: 331
		private static Delegate cb_getSubheaderInsetEnd;

		// Token: 0x0400014C RID: 332
		private static Delegate cb_setSubheaderInsetEnd_I;

		// Token: 0x0400014D RID: 333
		private static Delegate cb_getSubheaderInsetStart;

		// Token: 0x0400014E RID: 334
		private static Delegate cb_setSubheaderInsetStart_I;

		// Token: 0x0400014F RID: 335
		private static Delegate cb_isTopInsetScrimEnabled;

		// Token: 0x04000150 RID: 336
		private static Delegate cb_setTopInsetScrimEnabled_Z;

		// Token: 0x04000151 RID: 337
		private static Delegate cb_addHeaderView_Landroid_view_View_;

		// Token: 0x04000152 RID: 338
		private static Delegate cb_getHeaderView_I;

		// Token: 0x04000153 RID: 339
		private static Delegate cb_inflateHeaderView_I;

		// Token: 0x04000154 RID: 340
		private static Delegate cb_inflateMenu_I;

		// Token: 0x04000155 RID: 341
		private static Delegate cb_removeHeaderView_Landroid_view_View_;

		// Token: 0x04000156 RID: 342
		private static Delegate cb_setCheckedItem_I;

		// Token: 0x04000157 RID: 343
		private static Delegate cb_setItemBackgroundResource_I;

		// Token: 0x04000158 RID: 344
		private static Delegate cb_setItemHorizontalPaddingResource_I;

		// Token: 0x04000159 RID: 345
		private static Delegate cb_setItemIconPaddingResource_I;

		// Token: 0x0400015A RID: 346
		private static Delegate cb_setItemIconSize_I;

		// Token: 0x0400015B RID: 347
		private static Delegate cb_setItemTextAppearance_I;

		// Token: 0x0400015C RID: 348
		private static Delegate cb_setItemVerticalPaddingResource_I;

		// Token: 0x0400015D RID: 349
		private static Delegate cb_setNavigationItemSelectedListener_Lcom_google_android_material_navigation_NavigationView_OnNavigationItemSelectedListener_;

		// Token: 0x0400015E RID: 350
		private WeakReference weak_implementor_SetNavigationItemSelectedListener;

		// Token: 0x0200005F RID: 95
		[Register("com/google/android/material/navigation/NavigationView$OnNavigationItemSelectedListener", "", "Google.Android.Material.Navigation.NavigationView/IOnNavigationItemSelectedListenerInvoker")]
		public interface IOnNavigationItemSelectedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600055B RID: 1371
			[Register("onNavigationItemSelected", "(Landroid/view/MenuItem;)Z", "GetOnNavigationItemSelected_Landroid_view_MenuItem_Handler:Google.Android.Material.Navigation.NavigationView/IOnNavigationItemSelectedListenerInvoker, Xamarin.Google.Android.Material")]
			bool OnNavigationItemSelected(IMenuItem menuItem);
		}

		// Token: 0x02000060 RID: 96
		[Register("com/google/android/material/navigation/NavigationView$OnNavigationItemSelectedListener", DoNotGenerateAcw = true)]
		internal class IOnNavigationItemSelectedListenerInvoker : Java.Lang.Object, NavigationView.IOnNavigationItemSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000DA RID: 218
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x0000EEFC File Offset: 0x0000D0FC
			private static IntPtr java_class_ref
			{
				get
				{
					return NavigationView.IOnNavigationItemSelectedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x0600055D RID: 1373 RVA: 0x0000EF20 File Offset: 0x0000D120
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NavigationView.IOnNavigationItemSelectedListenerInvoker._members;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x0000EF27 File Offset: 0x0000D127
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600055F RID: 1375 RVA: 0x0000EF2F File Offset: 0x0000D12F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NavigationView.IOnNavigationItemSelectedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x0000EF3B File Offset: 0x0000D13B
			public static NavigationView.IOnNavigationItemSelectedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<NavigationView.IOnNavigationItemSelectedListener>(handle, transfer);
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x0000EF44 File Offset: 0x0000D144
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, NavigationView.IOnNavigationItemSelectedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.navigation.NavigationView.OnNavigationItemSelectedListener'.");
				}
				return handle;
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x0000EF6F File Offset: 0x0000D16F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
			public IOnNavigationItemSelectedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(NavigationView.IOnNavigationItemSelectedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
			private static Delegate GetOnNavigationItemSelected_Landroid_view_MenuItem_Handler()
			{
				if (NavigationView.IOnNavigationItemSelectedListenerInvoker.cb_onNavigationItemSelected_Landroid_view_MenuItem_ == null)
				{
					NavigationView.IOnNavigationItemSelectedListenerInvoker.cb_onNavigationItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(NavigationView.IOnNavigationItemSelectedListenerInvoker.n_OnNavigationItemSelected_Landroid_view_MenuItem_));
				}
				return NavigationView.IOnNavigationItemSelectedListenerInvoker.cb_onNavigationItemSelected_Landroid_view_MenuItem_;
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0000EFFC File Offset: 0x0000D1FC
			private static bool n_OnNavigationItemSelected_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_menuItem)
			{
				NavigationView.IOnNavigationItemSelectedListener @object = Java.Lang.Object.GetObject<NavigationView.IOnNavigationItemSelectedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_menuItem, JniHandleOwnership.DoNotTransfer);
				return @object.OnNavigationItemSelected(object2);
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0000F020 File Offset: 0x0000D220
			public unsafe bool OnNavigationItemSelected(IMenuItem menuItem)
			{
				if (this.id_onNavigationItemSelected_Landroid_view_MenuItem_ == IntPtr.Zero)
				{
					this.id_onNavigationItemSelected_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onNavigationItemSelected", "(Landroid/view/MenuItem;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((menuItem == null) ? IntPtr.Zero : ((Java.Lang.Object)menuItem).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onNavigationItemSelected_Landroid_view_MenuItem_, ptr);
			}

			// Token: 0x0400015F RID: 351
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/navigation/NavigationView$OnNavigationItemSelectedListener", typeof(NavigationView.IOnNavigationItemSelectedListenerInvoker));

			// Token: 0x04000160 RID: 352
			private IntPtr class_ref;

			// Token: 0x04000161 RID: 353
			private static Delegate cb_onNavigationItemSelected_Landroid_view_MenuItem_;

			// Token: 0x04000162 RID: 354
			private IntPtr id_onNavigationItemSelected_Landroid_view_MenuItem_;
		}

		// Token: 0x02000061 RID: 97
		public class NavigationItemSelectedEventArgs : EventArgs
		{
			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x0000F0B3 File Offset: 0x0000D2B3
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x06000569 RID: 1385 RVA: 0x0000F0BB File Offset: 0x0000D2BB
			public NavigationItemSelectedEventArgs(bool handled, IMenuItem menuItem)
			{
				this.handled = handled;
				this.menuItem = menuItem;
			}

			// Token: 0x04000163 RID: 355
			private bool handled;

			// Token: 0x04000164 RID: 356
			private IMenuItem menuItem;
		}

		// Token: 0x02000062 RID: 98
		[Register("mono/com/google/android/material/navigation/NavigationView_OnNavigationItemSelectedListenerImplementor")]
		internal sealed class IOnNavigationItemSelectedListenerImplementor : Java.Lang.Object, NavigationView.IOnNavigationItemSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600056A RID: 1386 RVA: 0x0000F0D1 File Offset: 0x0000D2D1
			public IOnNavigationItemSelectedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/material/navigation/NavigationView_OnNavigationItemSelectedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x0000F10C File Offset: 0x0000D30C
			public bool OnNavigationItemSelected(IMenuItem menuItem)
			{
				EventHandler<NavigationView.NavigationItemSelectedEventArgs> handler = this.Handler;
				if (handler == null)
				{
					return false;
				}
				NavigationView.NavigationItemSelectedEventArgs navigationItemSelectedEventArgs = new NavigationView.NavigationItemSelectedEventArgs(true, menuItem);
				handler(this.sender, navigationItemSelectedEventArgs);
				return navigationItemSelectedEventArgs.Handled;
			}

			// Token: 0x0600056C RID: 1388 RVA: 0x0000F140 File Offset: 0x0000D340
			internal static bool __IsEmpty(NavigationView.IOnNavigationItemSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000165 RID: 357
			private object sender;

			// Token: 0x04000166 RID: 358
			public EventHandler<NavigationView.NavigationItemSelectedEventArgs> Handler;
		}

		// Token: 0x02000063 RID: 99
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000167 RID: 359
			public static Func<NavigationView.IOnNavigationItemSelectedListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
