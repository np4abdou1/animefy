using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace AndroidX.RecyclerView.Widget
{
	// Token: 0x0200004A RID: 74
	[Register("androidx/recyclerview/widget/GridLayoutManager", DoNotGenerateAcw = true)]
	public class GridLayoutManager : LinearLayoutManager
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002080 File Offset: 0x00000280
		internal new static IntPtr class_ref
		{
			get
			{
				return GridLayoutManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GridLayoutManager._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GridLayoutManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GridLayoutManager._members.ManagedPeerType;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000020DC File Offset: 0x000002DC
		protected GridLayoutManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe GridLayoutManager(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				ptr[3] = new JniArgumentValue(defStyleRes);
				base.SetHandle(GridLayoutManager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GridLayoutManager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000021F0 File Offset: 0x000003F0
		[Register(".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe GridLayoutManager(Context context, int spanCount) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(spanCount);
				base.SetHandle(GridLayoutManager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GridLayoutManager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000022B0 File Offset: 0x000004B0
		[Register(".ctor", "(Landroid/content/Context;IIZ)V", "")]
		public unsafe GridLayoutManager(Context context, int spanCount, int orientation, bool reverseLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(spanCount);
				ptr[2] = new JniArgumentValue(orientation);
				ptr[3] = new JniArgumentValue(reverseLayout);
				base.SetHandle(GridLayoutManager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;IIZ)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GridLayoutManager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;IIZ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000023A0 File Offset: 0x000005A0
		private static Delegate GetGetSpanCountHandler()
		{
			if (GridLayoutManager.cb_getSpanCount == null)
			{
				GridLayoutManager.cb_getSpanCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GridLayoutManager.n_GetSpanCount));
			}
			return GridLayoutManager.cb_getSpanCount;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000023C4 File Offset: 0x000005C4
		private static int n_GetSpanCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GridLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanCount;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000023D3 File Offset: 0x000005D3
		private static Delegate GetSetSpanCount_IHandler()
		{
			if (GridLayoutManager.cb_setSpanCount_I == null)
			{
				GridLayoutManager.cb_setSpanCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(GridLayoutManager.n_SetSpanCount_I));
			}
			return GridLayoutManager.cb_setSpanCount_I;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000023F7 File Offset: 0x000005F7
		private static void n_SetSpanCount_I(IntPtr jnienv, IntPtr native__this, int spanCount)
		{
			Java.Lang.Object.GetObject<GridLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanCount = spanCount;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002407 File Offset: 0x00000607
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002420 File Offset: 0x00000620
		public unsafe virtual int SpanCount
		{
			[Register("getSpanCount", "()I", "GetGetSpanCountHandler")]
			get
			{
				return GridLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getSpanCount.()I", this, null);
			}
			[Register("setSpanCount", "(I)V", "GetSetSpanCount_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				GridLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setSpanCount.(I)V", this, ptr);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000245B File Offset: 0x0000065B
		private static Delegate GetIsUsingSpansToEstimateScrollbarDimensionsHandler()
		{
			if (GridLayoutManager.cb_isUsingSpansToEstimateScrollbarDimensions == null)
			{
				GridLayoutManager.cb_isUsingSpansToEstimateScrollbarDimensions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GridLayoutManager.n_IsUsingSpansToEstimateScrollbarDimensions));
			}
			return GridLayoutManager.cb_isUsingSpansToEstimateScrollbarDimensions;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000247F File Offset: 0x0000067F
		private static bool n_IsUsingSpansToEstimateScrollbarDimensions(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GridLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UsingSpansToEstimateScrollbarDimensions;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000248E File Offset: 0x0000068E
		private static Delegate GetSetUsingSpansToEstimateScrollbarDimensions_ZHandler()
		{
			if (GridLayoutManager.cb_setUsingSpansToEstimateScrollbarDimensions_Z == null)
			{
				GridLayoutManager.cb_setUsingSpansToEstimateScrollbarDimensions_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(GridLayoutManager.n_SetUsingSpansToEstimateScrollbarDimensions_Z));
			}
			return GridLayoutManager.cb_setUsingSpansToEstimateScrollbarDimensions_Z;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000024B2 File Offset: 0x000006B2
		private static void n_SetUsingSpansToEstimateScrollbarDimensions_Z(IntPtr jnienv, IntPtr native__this, bool useSpansToEstimateScrollBarDimensions)
		{
			Java.Lang.Object.GetObject<GridLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UsingSpansToEstimateScrollbarDimensions = useSpansToEstimateScrollBarDimensions;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000024C2 File Offset: 0x000006C2
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000024DC File Offset: 0x000006DC
		public unsafe virtual bool UsingSpansToEstimateScrollbarDimensions
		{
			[Register("isUsingSpansToEstimateScrollbarDimensions", "()Z", "GetIsUsingSpansToEstimateScrollbarDimensionsHandler")]
			get
			{
				return GridLayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isUsingSpansToEstimateScrollbarDimensions.()Z", this, null);
			}
			[Register("setUsingSpansToEstimateScrollbarDimensions", "(Z)V", "GetSetUsingSpansToEstimateScrollbarDimensions_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				GridLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setUsingSpansToEstimateScrollbarDimensions.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002517 File Offset: 0x00000717
		private static Delegate GetGetSpanSizeLookupHandler()
		{
			if (GridLayoutManager.cb_getSpanSizeLookup == null)
			{
				GridLayoutManager.cb_getSpanSizeLookup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GridLayoutManager.n_GetSpanSizeLookup));
			}
			return GridLayoutManager.cb_getSpanSizeLookup;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000253B File Offset: 0x0000073B
		private static IntPtr n_GetSpanSizeLookup(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GridLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSpanSizeLookup());
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002550 File Offset: 0x00000750
		[Register("getSpanSizeLookup", "()Landroidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup;", "GetGetSpanSizeLookupHandler")]
		public virtual GridLayoutManager.SpanSizeLookup GetSpanSizeLookup()
		{
			return Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(GridLayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("getSpanSizeLookup.()Landroidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002582 File Offset: 0x00000782
		private static Delegate GetSetSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_Handler()
		{
			if (GridLayoutManager.cb_setSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_ == null)
			{
				GridLayoutManager.cb_setSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GridLayoutManager.n_SetSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_));
			}
			return GridLayoutManager.cb_setSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000025A8 File Offset: 0x000007A8
		private static void n_SetSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_(IntPtr jnienv, IntPtr native__this, IntPtr native_spanSizeLookup)
		{
			GridLayoutManager @object = Java.Lang.Object.GetObject<GridLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GridLayoutManager.SpanSizeLookup object2 = Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(native_spanSizeLookup, JniHandleOwnership.DoNotTransfer);
			@object.SetSpanSizeLookup(object2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000025CC File Offset: 0x000007CC
		[Register("setSpanSizeLookup", "(Landroidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup;)V", "GetSetSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_Handler")]
		public unsafe virtual void SetSpanSizeLookup(GridLayoutManager.SpanSizeLookup spanSizeLookup)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((spanSizeLookup == null) ? IntPtr.Zero : spanSizeLookup.Handle);
				GridLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setSpanSizeLookup.(Landroidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(spanSizeLookup);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/GridLayoutManager", typeof(GridLayoutManager));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getSpanCount;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_setSpanCount_I;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_isUsingSpansToEstimateScrollbarDimensions;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_setUsingSpansToEstimateScrollbarDimensions_Z;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getSpanSizeLookup;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_setSpanSizeLookup_Landroidx_recyclerview_widget_GridLayoutManager_SpanSizeLookup_;

		// Token: 0x0200004B RID: 75
		[Register("androidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup", DoNotGenerateAcw = true)]
		public abstract class SpanSizeLookup : Java.Lang.Object
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000133 RID: 307 RVA: 0x0000264C File Offset: 0x0000084C
			internal static IntPtr class_ref
			{
				get
				{
					return GridLayoutManager.SpanSizeLookup._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000134 RID: 308 RVA: 0x00002670 File Offset: 0x00000870
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GridLayoutManager.SpanSizeLookup._members;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00002678 File Offset: 0x00000878
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GridLayoutManager.SpanSizeLookup._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000136 RID: 310 RVA: 0x0000269C File Offset: 0x0000089C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GridLayoutManager.SpanSizeLookup._members.ManagedPeerType;
				}
			}

			// Token: 0x06000137 RID: 311 RVA: 0x000026A8 File Offset: 0x000008A8
			protected SpanSizeLookup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000138 RID: 312 RVA: 0x000026B4 File Offset: 0x000008B4
			[Register(".ctor", "()V", "")]
			public SpanSizeLookup() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(GridLayoutManager.SpanSizeLookup._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				GridLayoutManager.SpanSizeLookup._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00002722 File Offset: 0x00000922
			private static Delegate GetIsSpanGroupIndexCacheEnabledHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_isSpanGroupIndexCacheEnabled == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_isSpanGroupIndexCacheEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GridLayoutManager.SpanSizeLookup.n_IsSpanGroupIndexCacheEnabled));
				}
				return GridLayoutManager.SpanSizeLookup.cb_isSpanGroupIndexCacheEnabled;
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00002746 File Offset: 0x00000946
			private static bool n_IsSpanGroupIndexCacheEnabled(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanGroupIndexCacheEnabled;
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00002755 File Offset: 0x00000955
			private static Delegate GetSetSpanGroupIndexCacheEnabled_ZHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_setSpanGroupIndexCacheEnabled_Z == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_setSpanGroupIndexCacheEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(GridLayoutManager.SpanSizeLookup.n_SetSpanGroupIndexCacheEnabled_Z));
				}
				return GridLayoutManager.SpanSizeLookup.cb_setSpanGroupIndexCacheEnabled_Z;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00002779 File Offset: 0x00000979
			private static void n_SetSpanGroupIndexCacheEnabled_Z(IntPtr jnienv, IntPtr native__this, bool cacheSpanGroupIndices)
			{
				Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanGroupIndexCacheEnabled = cacheSpanGroupIndices;
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600013D RID: 317 RVA: 0x00002789 File Offset: 0x00000989
			// (set) Token: 0x0600013E RID: 318 RVA: 0x000027A4 File Offset: 0x000009A4
			public unsafe virtual bool SpanGroupIndexCacheEnabled
			{
				[Register("isSpanGroupIndexCacheEnabled", "()Z", "GetIsSpanGroupIndexCacheEnabledHandler")]
				get
				{
					return GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualBooleanMethod("isSpanGroupIndexCacheEnabled.()Z", this, null);
				}
				[Register("setSpanGroupIndexCacheEnabled", "(Z)V", "GetSetSpanGroupIndexCacheEnabled_ZHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualVoidMethod("setSpanGroupIndexCacheEnabled.(Z)V", this, ptr);
				}
			}

			// Token: 0x0600013F RID: 319 RVA: 0x000027DF File Offset: 0x000009DF
			private static Delegate GetIsSpanIndexCacheEnabledHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_isSpanIndexCacheEnabled == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_isSpanIndexCacheEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GridLayoutManager.SpanSizeLookup.n_IsSpanIndexCacheEnabled));
				}
				return GridLayoutManager.SpanSizeLookup.cb_isSpanIndexCacheEnabled;
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00002803 File Offset: 0x00000A03
			private static bool n_IsSpanIndexCacheEnabled(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanIndexCacheEnabled;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00002812 File Offset: 0x00000A12
			private static Delegate GetSetSpanIndexCacheEnabled_ZHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_setSpanIndexCacheEnabled_Z == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_setSpanIndexCacheEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(GridLayoutManager.SpanSizeLookup.n_SetSpanIndexCacheEnabled_Z));
				}
				return GridLayoutManager.SpanSizeLookup.cb_setSpanIndexCacheEnabled_Z;
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00002836 File Offset: 0x00000A36
			private static void n_SetSpanIndexCacheEnabled_Z(IntPtr jnienv, IntPtr native__this, bool cacheSpanIndices)
			{
				Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanIndexCacheEnabled = cacheSpanIndices;
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000143 RID: 323 RVA: 0x00002846 File Offset: 0x00000A46
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00002860 File Offset: 0x00000A60
			public unsafe virtual bool SpanIndexCacheEnabled
			{
				[Register("isSpanIndexCacheEnabled", "()Z", "GetIsSpanIndexCacheEnabledHandler")]
				get
				{
					return GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualBooleanMethod("isSpanIndexCacheEnabled.()Z", this, null);
				}
				[Register("setSpanIndexCacheEnabled", "(Z)V", "GetSetSpanIndexCacheEnabled_ZHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualVoidMethod("setSpanIndexCacheEnabled.(Z)V", this, ptr);
				}
			}

			// Token: 0x06000145 RID: 325 RVA: 0x0000289B File Offset: 0x00000A9B
			private static Delegate GetGetSpanGroupIndex_IIHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_getSpanGroupIndex_II == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_getSpanGroupIndex_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(GridLayoutManager.SpanSizeLookup.n_GetSpanGroupIndex_II));
				}
				return GridLayoutManager.SpanSizeLookup.cb_getSpanGroupIndex_II;
			}

			// Token: 0x06000146 RID: 326 RVA: 0x000028BF File Offset: 0x00000ABF
			private static int n_GetSpanGroupIndex_II(IntPtr jnienv, IntPtr native__this, int adapterPosition, int spanCount)
			{
				return Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSpanGroupIndex(adapterPosition, spanCount);
			}

			// Token: 0x06000147 RID: 327 RVA: 0x000028D0 File Offset: 0x00000AD0
			[Register("getSpanGroupIndex", "(II)I", "GetGetSpanGroupIndex_IIHandler")]
			public unsafe virtual int GetSpanGroupIndex(int adapterPosition, int spanCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(adapterPosition);
				ptr[1] = new JniArgumentValue(spanCount);
				return GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualInt32Method("getSpanGroupIndex.(II)I", this, ptr);
			}

			// Token: 0x06000148 RID: 328 RVA: 0x0000291E File Offset: 0x00000B1E
			private static Delegate GetGetSpanIndex_IIHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_getSpanIndex_II == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_getSpanIndex_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(GridLayoutManager.SpanSizeLookup.n_GetSpanIndex_II));
				}
				return GridLayoutManager.SpanSizeLookup.cb_getSpanIndex_II;
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00002942 File Offset: 0x00000B42
			private static int n_GetSpanIndex_II(IntPtr jnienv, IntPtr native__this, int position, int spanCount)
			{
				return Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSpanIndex(position, spanCount);
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00002954 File Offset: 0x00000B54
			[Register("getSpanIndex", "(II)I", "GetGetSpanIndex_IIHandler")]
			public unsafe virtual int GetSpanIndex(int position, int spanCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				ptr[1] = new JniArgumentValue(spanCount);
				return GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualInt32Method("getSpanIndex.(II)I", this, ptr);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x000029A2 File Offset: 0x00000BA2
			private static Delegate GetGetSpanSize_IHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_getSpanSize_I == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_getSpanSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(GridLayoutManager.SpanSizeLookup.n_GetSpanSize_I));
				}
				return GridLayoutManager.SpanSizeLookup.cb_getSpanSize_I;
			}

			// Token: 0x0600014C RID: 332 RVA: 0x000029C6 File Offset: 0x00000BC6
			private static int n_GetSpanSize_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				return Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSpanSize(position);
			}

			// Token: 0x0600014D RID: 333
			[Register("getSpanSize", "(I)I", "GetGetSpanSize_IHandler")]
			public abstract int GetSpanSize(int position);

			// Token: 0x0600014E RID: 334 RVA: 0x000029D6 File Offset: 0x00000BD6
			private static Delegate GetInvalidateSpanGroupIndexCacheHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_invalidateSpanGroupIndexCache == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_invalidateSpanGroupIndexCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GridLayoutManager.SpanSizeLookup.n_InvalidateSpanGroupIndexCache));
				}
				return GridLayoutManager.SpanSizeLookup.cb_invalidateSpanGroupIndexCache;
			}

			// Token: 0x0600014F RID: 335 RVA: 0x000029FA File Offset: 0x00000BFA
			private static void n_InvalidateSpanGroupIndexCache(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateSpanGroupIndexCache();
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00002A09 File Offset: 0x00000C09
			[Register("invalidateSpanGroupIndexCache", "()V", "GetInvalidateSpanGroupIndexCacheHandler")]
			public virtual void InvalidateSpanGroupIndexCache()
			{
				GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualVoidMethod("invalidateSpanGroupIndexCache.()V", this, null);
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00002A22 File Offset: 0x00000C22
			private static Delegate GetInvalidateSpanIndexCacheHandler()
			{
				if (GridLayoutManager.SpanSizeLookup.cb_invalidateSpanIndexCache == null)
				{
					GridLayoutManager.SpanSizeLookup.cb_invalidateSpanIndexCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GridLayoutManager.SpanSizeLookup.n_InvalidateSpanIndexCache));
				}
				return GridLayoutManager.SpanSizeLookup.cb_invalidateSpanIndexCache;
			}

			// Token: 0x06000152 RID: 338 RVA: 0x00002A46 File Offset: 0x00000C46
			private static void n_InvalidateSpanIndexCache(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<GridLayoutManager.SpanSizeLookup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateSpanIndexCache();
			}

			// Token: 0x06000153 RID: 339 RVA: 0x00002A55 File Offset: 0x00000C55
			[Register("invalidateSpanIndexCache", "()V", "GetInvalidateSpanIndexCacheHandler")]
			public virtual void InvalidateSpanIndexCache()
			{
				GridLayoutManager.SpanSizeLookup._members.InstanceMethods.InvokeVirtualVoidMethod("invalidateSpanIndexCache.()V", this, null);
			}

			// Token: 0x0400000A RID: 10
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup", typeof(GridLayoutManager.SpanSizeLookup));

			// Token: 0x0400000B RID: 11
			private static Delegate cb_isSpanGroupIndexCacheEnabled;

			// Token: 0x0400000C RID: 12
			private static Delegate cb_setSpanGroupIndexCacheEnabled_Z;

			// Token: 0x0400000D RID: 13
			private static Delegate cb_isSpanIndexCacheEnabled;

			// Token: 0x0400000E RID: 14
			private static Delegate cb_setSpanIndexCacheEnabled_Z;

			// Token: 0x0400000F RID: 15
			private static Delegate cb_getSpanGroupIndex_II;

			// Token: 0x04000010 RID: 16
			private static Delegate cb_getSpanIndex_II;

			// Token: 0x04000011 RID: 17
			private static Delegate cb_getSpanSize_I;

			// Token: 0x04000012 RID: 18
			private static Delegate cb_invalidateSpanGroupIndexCache;

			// Token: 0x04000013 RID: 19
			private static Delegate cb_invalidateSpanIndexCache;
		}

		// Token: 0x0200004C RID: 76
		[Register("androidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup", DoNotGenerateAcw = true)]
		internal class SpanSizeLookupInvoker : GridLayoutManager.SpanSizeLookup
		{
			// Token: 0x06000155 RID: 341 RVA: 0x00002A89 File Offset: 0x00000C89
			public SpanSizeLookupInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00002A93 File Offset: 0x00000C93
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GridLayoutManager.SpanSizeLookupInvoker._members;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000157 RID: 343 RVA: 0x00002A9A File Offset: 0x00000C9A
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GridLayoutManager.SpanSizeLookupInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Register("getSpanSize", "(I)I", "GetGetSpanSize_IHandler")]
			public unsafe override int GetSpanSize(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				return GridLayoutManager.SpanSizeLookupInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSpanSize.(I)I", this, ptr);
			}

			// Token: 0x04000014 RID: 20
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/GridLayoutManager$SpanSizeLookup", typeof(GridLayoutManager.SpanSizeLookupInvoker));
		}
	}
}
