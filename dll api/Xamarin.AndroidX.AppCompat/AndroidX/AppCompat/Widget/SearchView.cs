using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.AppCompat.View;
using AndroidX.CursorAdapter.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x0200006D RID: 109
	[Register("androidx/appcompat/widget/SearchView", DoNotGenerateAcw = true)]
	public class SearchView : LinearLayoutCompat, ICollapsibleActionView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000154C0 File Offset: 0x000136C0
		internal new static IntPtr class_ref
		{
			get
			{
				return SearchView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000154E4 File Offset: 0x000136E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SearchView._members;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000154EC File Offset: 0x000136EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SearchView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00015510 File Offset: 0x00013710
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SearchView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0001551C File Offset: 0x0001371C
		protected SearchView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00015528 File Offset: 0x00013728
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SearchView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(SearchView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SearchView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000155D8 File Offset: 0x000137D8
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SearchView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(SearchView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SearchView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000156B4 File Offset: 0x000138B4
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SearchView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(SearchView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SearchView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000157A4 File Offset: 0x000139A4
		private static Delegate GetIsIconifiedHandler()
		{
			if (SearchView.cb_isIconified == null)
			{
				SearchView.cb_isIconified = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SearchView.n_IsIconified));
			}
			return SearchView.cb_isIconified;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000157C8 File Offset: 0x000139C8
		private static bool n_IsIconified(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iconified;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000157D7 File Offset: 0x000139D7
		private static Delegate GetSetIconified_ZHandler()
		{
			if (SearchView.cb_setIconified_Z == null)
			{
				SearchView.cb_setIconified_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SearchView.n_SetIconified_Z));
			}
			return SearchView.cb_setIconified_Z;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x000157FB File Offset: 0x000139FB
		private static void n_SetIconified_Z(IntPtr jnienv, IntPtr native__this, bool iconify)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iconified = iconify;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0001580B File Offset: 0x00013A0B
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00015824 File Offset: 0x00013A24
		public unsafe virtual bool Iconified
		{
			[Register("isIconified", "()Z", "GetIsIconifiedHandler")]
			get
			{
				return SearchView._members.InstanceMethods.InvokeVirtualBooleanMethod("isIconified.()Z", this, null);
			}
			[Register("setIconified", "(Z)V", "GetSetIconified_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setIconified.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001585F File Offset: 0x00013A5F
		private static Delegate GetGetImeOptionsHandler()
		{
			if (SearchView.cb_getImeOptions == null)
			{
				SearchView.cb_getImeOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SearchView.n_GetImeOptions));
			}
			return SearchView.cb_getImeOptions;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00015883 File Offset: 0x00013A83
		private static int n_GetImeOptions(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ImeOptions;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00015892 File Offset: 0x00013A92
		private static Delegate GetSetImeOptions_IHandler()
		{
			if (SearchView.cb_setImeOptions_I == null)
			{
				SearchView.cb_setImeOptions_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SearchView.n_SetImeOptions_I));
			}
			return SearchView.cb_setImeOptions_I;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000158B6 File Offset: 0x00013AB6
		private static void n_SetImeOptions_I(IntPtr jnienv, IntPtr native__this, int imeOptions)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ImeOptions = imeOptions;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000158C6 File Offset: 0x00013AC6
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x000158E0 File Offset: 0x00013AE0
		public unsafe virtual int ImeOptions
		{
			[Register("getImeOptions", "()I", "GetGetImeOptionsHandler")]
			get
			{
				return SearchView._members.InstanceMethods.InvokeVirtualInt32Method("getImeOptions.()I", this, null);
			}
			[Register("setImeOptions", "(I)V", "GetSetImeOptions_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setImeOptions.(I)V", this, ptr);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0001591B File Offset: 0x00013B1B
		private static Delegate GetGetInputTypeHandler()
		{
			if (SearchView.cb_getInputType == null)
			{
				SearchView.cb_getInputType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SearchView.n_GetInputType));
			}
			return SearchView.cb_getInputType;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0001593F File Offset: 0x00013B3F
		private static int n_GetInputType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InputType;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001594E File Offset: 0x00013B4E
		private static Delegate GetSetInputType_IHandler()
		{
			if (SearchView.cb_setInputType_I == null)
			{
				SearchView.cb_setInputType_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SearchView.n_SetInputType_I));
			}
			return SearchView.cb_setInputType_I;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00015972 File Offset: 0x00013B72
		private static void n_SetInputType_I(IntPtr jnienv, IntPtr native__this, int inputType)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InputType = inputType;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00015982 File Offset: 0x00013B82
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x0001599C File Offset: 0x00013B9C
		public unsafe virtual int InputType
		{
			[Register("getInputType", "()I", "GetGetInputTypeHandler")]
			get
			{
				return SearchView._members.InstanceMethods.InvokeVirtualInt32Method("getInputType.()I", this, null);
			}
			[Register("setInputType", "(I)V", "GetSetInputType_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setInputType.(I)V", this, ptr);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000159D7 File Offset: 0x00013BD7
		private static Delegate GetIsIconfiedByDefaultHandler()
		{
			if (SearchView.cb_isIconfiedByDefault == null)
			{
				SearchView.cb_isIconfiedByDefault = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SearchView.n_IsIconfiedByDefault));
			}
			return SearchView.cb_isIconfiedByDefault;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000159FB File Offset: 0x00013BFB
		private static bool n_IsIconfiedByDefault(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsIconfiedByDefault;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00015A0A File Offset: 0x00013C0A
		public virtual bool IsIconfiedByDefault
		{
			[Register("isIconfiedByDefault", "()Z", "GetIsIconfiedByDefaultHandler")]
			get
			{
				return SearchView._members.InstanceMethods.InvokeVirtualBooleanMethod("isIconfiedByDefault.()Z", this, null);
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00015A23 File Offset: 0x00013C23
		private static Delegate GetGetMaxWidthHandler()
		{
			if (SearchView.cb_getMaxWidth == null)
			{
				SearchView.cb_getMaxWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SearchView.n_GetMaxWidth));
			}
			return SearchView.cb_getMaxWidth;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00015A47 File Offset: 0x00013C47
		private static int n_GetMaxWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxWidth;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00015A56 File Offset: 0x00013C56
		private static Delegate GetSetMaxWidth_IHandler()
		{
			if (SearchView.cb_setMaxWidth_I == null)
			{
				SearchView.cb_setMaxWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SearchView.n_SetMaxWidth_I));
			}
			return SearchView.cb_setMaxWidth_I;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00015A7A File Offset: 0x00013C7A
		private static void n_SetMaxWidth_I(IntPtr jnienv, IntPtr native__this, int maxpixels)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxWidth = maxpixels;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00015A8A File Offset: 0x00013C8A
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00015AA4 File Offset: 0x00013CA4
		public unsafe virtual int MaxWidth
		{
			[Register("getMaxWidth", "()I", "GetGetMaxWidthHandler")]
			get
			{
				return SearchView._members.InstanceMethods.InvokeVirtualInt32Method("getMaxWidth.()I", this, null);
			}
			[Register("setMaxWidth", "(I)V", "GetSetMaxWidth_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxWidth.(I)V", this, ptr);
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00015ADF File Offset: 0x00013CDF
		private static Delegate GetGetQueryHandler()
		{
			if (SearchView.cb_getQuery == null)
			{
				SearchView.cb_getQuery = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SearchView.n_GetQuery));
			}
			return SearchView.cb_getQuery;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00015B03 File Offset: 0x00013D03
		private static IntPtr n_GetQuery(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QueryFormatted);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00015B18 File Offset: 0x00013D18
		public virtual ICharSequence QueryFormatted
		{
			[Register("getQuery", "()Ljava/lang/CharSequence;", "GetGetQueryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(SearchView._members.InstanceMethods.InvokeVirtualObjectMethod("getQuery.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00015B4A File Offset: 0x00013D4A
		public string Query
		{
			get
			{
				if (this.QueryFormatted != null)
				{
					return this.QueryFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00015B61 File Offset: 0x00013D61
		private static Delegate GetGetQueryHintHandler()
		{
			if (SearchView.cb_getQueryHint == null)
			{
				SearchView.cb_getQueryHint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SearchView.n_GetQueryHint));
			}
			return SearchView.cb_getQueryHint;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00015B85 File Offset: 0x00013D85
		private static IntPtr n_GetQueryHint(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QueryHintFormatted);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00015B99 File Offset: 0x00013D99
		private static Delegate GetSetQueryHint_Ljava_lang_CharSequence_Handler()
		{
			if (SearchView.cb_setQueryHint_Ljava_lang_CharSequence_ == null)
			{
				SearchView.cb_setQueryHint_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetQueryHint_Ljava_lang_CharSequence_));
			}
			return SearchView.cb_setQueryHint_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00015BC0 File Offset: 0x00013DC0
		private static void n_SetQueryHint_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_hint)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_hint, JniHandleOwnership.DoNotTransfer);
			@object.QueryHintFormatted = object2;
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00015BE4 File Offset: 0x00013DE4
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00015C18 File Offset: 0x00013E18
		public unsafe virtual ICharSequence QueryHintFormatted
		{
			[Register("getQueryHint", "()Ljava/lang/CharSequence;", "GetGetQueryHintHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(SearchView._members.InstanceMethods.InvokeVirtualObjectMethod("getQueryHint.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setQueryHint", "(Ljava/lang/CharSequence;)V", "GetSetQueryHint_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setQueryHint.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00015C7C File Offset: 0x00013E7C
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00015C94 File Offset: 0x00013E94
		public string QueryHint
		{
			get
			{
				if (this.QueryHintFormatted != null)
				{
					return this.QueryHintFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.QueryHintFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00015CBE File Offset: 0x00013EBE
		private static Delegate GetIsQueryRefinementEnabledHandler()
		{
			if (SearchView.cb_isQueryRefinementEnabled == null)
			{
				SearchView.cb_isQueryRefinementEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SearchView.n_IsQueryRefinementEnabled));
			}
			return SearchView.cb_isQueryRefinementEnabled;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00015CE2 File Offset: 0x00013EE2
		private static bool n_IsQueryRefinementEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QueryRefinementEnabled;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00015CF1 File Offset: 0x00013EF1
		private static Delegate GetSetQueryRefinementEnabled_ZHandler()
		{
			if (SearchView.cb_setQueryRefinementEnabled_Z == null)
			{
				SearchView.cb_setQueryRefinementEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SearchView.n_SetQueryRefinementEnabled_Z));
			}
			return SearchView.cb_setQueryRefinementEnabled_Z;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00015D15 File Offset: 0x00013F15
		private static void n_SetQueryRefinementEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enable)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QueryRefinementEnabled = enable;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00015D25 File Offset: 0x00013F25
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x00015D40 File Offset: 0x00013F40
		public unsafe virtual bool QueryRefinementEnabled
		{
			[Register("isQueryRefinementEnabled", "()Z", "GetIsQueryRefinementEnabledHandler")]
			get
			{
				return SearchView._members.InstanceMethods.InvokeVirtualBooleanMethod("isQueryRefinementEnabled.()Z", this, null);
			}
			[Register("setQueryRefinementEnabled", "(Z)V", "GetSetQueryRefinementEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setQueryRefinementEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00015D7B File Offset: 0x00013F7B
		private static Delegate GetIsSubmitButtonEnabledHandler()
		{
			if (SearchView.cb_isSubmitButtonEnabled == null)
			{
				SearchView.cb_isSubmitButtonEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SearchView.n_IsSubmitButtonEnabled));
			}
			return SearchView.cb_isSubmitButtonEnabled;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00015D9F File Offset: 0x00013F9F
		private static bool n_IsSubmitButtonEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubmitButtonEnabled;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00015DAE File Offset: 0x00013FAE
		private static Delegate GetSetSubmitButtonEnabled_ZHandler()
		{
			if (SearchView.cb_setSubmitButtonEnabled_Z == null)
			{
				SearchView.cb_setSubmitButtonEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SearchView.n_SetSubmitButtonEnabled_Z));
			}
			return SearchView.cb_setSubmitButtonEnabled_Z;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00015DD2 File Offset: 0x00013FD2
		private static void n_SetSubmitButtonEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubmitButtonEnabled = enabled;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00015DE2 File Offset: 0x00013FE2
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00015DFC File Offset: 0x00013FFC
		public unsafe virtual bool SubmitButtonEnabled
		{
			[Register("isSubmitButtonEnabled", "()Z", "GetIsSubmitButtonEnabledHandler")]
			get
			{
				return SearchView._members.InstanceMethods.InvokeVirtualBooleanMethod("isSubmitButtonEnabled.()Z", this, null);
			}
			[Register("setSubmitButtonEnabled", "(Z)V", "GetSetSubmitButtonEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setSubmitButtonEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00015E37 File Offset: 0x00014037
		private static Delegate GetGetSuggestionsAdapterHandler()
		{
			if (SearchView.cb_getSuggestionsAdapter == null)
			{
				SearchView.cb_getSuggestionsAdapter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SearchView.n_GetSuggestionsAdapter));
			}
			return SearchView.cb_getSuggestionsAdapter;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00015E5B File Offset: 0x0001405B
		private static IntPtr n_GetSuggestionsAdapter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SuggestionsAdapter);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00015E6F File Offset: 0x0001406F
		private static Delegate GetSetSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_Handler()
		{
			if (SearchView.cb_setSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_ == null)
			{
				SearchView.cb_setSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_));
			}
			return SearchView.cb_setSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00015E94 File Offset: 0x00014094
		private static void n_SetSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CursorAdapter object2 = Java.Lang.Object.GetObject<CursorAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.SuggestionsAdapter = object2;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00015EB8 File Offset: 0x000140B8
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00015EEC File Offset: 0x000140EC
		public unsafe virtual CursorAdapter SuggestionsAdapter
		{
			[Register("getSuggestionsAdapter", "()Landroidx/cursoradapter/widget/CursorAdapter;", "GetGetSuggestionsAdapterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CursorAdapter>(SearchView._members.InstanceMethods.InvokeVirtualObjectMethod("getSuggestionsAdapter.()Landroidx/cursoradapter/widget/CursorAdapter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSuggestionsAdapter", "(Landroidx/cursoradapter/widget/CursorAdapter;)V", "GetSetSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setSuggestionsAdapter.(Landroidx/cursoradapter/widget/CursorAdapter;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00015F50 File Offset: 0x00014150
		private static Delegate GetOnActionViewCollapsedHandler()
		{
			if (SearchView.cb_onActionViewCollapsed == null)
			{
				SearchView.cb_onActionViewCollapsed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SearchView.n_OnActionViewCollapsed));
			}
			return SearchView.cb_onActionViewCollapsed;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00015F74 File Offset: 0x00014174
		private static void n_OnActionViewCollapsed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnActionViewCollapsed();
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00015F83 File Offset: 0x00014183
		[Register("onActionViewCollapsed", "()V", "GetOnActionViewCollapsedHandler")]
		public virtual void OnActionViewCollapsed()
		{
			SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("onActionViewCollapsed.()V", this, null);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00015F9C File Offset: 0x0001419C
		private static Delegate GetOnActionViewExpandedHandler()
		{
			if (SearchView.cb_onActionViewExpanded == null)
			{
				SearchView.cb_onActionViewExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SearchView.n_OnActionViewExpanded));
			}
			return SearchView.cb_onActionViewExpanded;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00015FC0 File Offset: 0x000141C0
		private static void n_OnActionViewExpanded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnActionViewExpanded();
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00015FCF File Offset: 0x000141CF
		[Register("onActionViewExpanded", "()V", "GetOnActionViewExpandedHandler")]
		public virtual void OnActionViewExpanded()
		{
			SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("onActionViewExpanded.()V", this, null);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00015FE8 File Offset: 0x000141E8
		private static Delegate GetOnQueryRefine_Ljava_lang_CharSequence_Handler()
		{
			if (SearchView.cb_onQueryRefine_Ljava_lang_CharSequence_ == null)
			{
				SearchView.cb_onQueryRefine_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_OnQueryRefine_Ljava_lang_CharSequence_));
			}
			return SearchView.cb_onQueryRefine_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0001600C File Offset: 0x0001420C
		private static void n_OnQueryRefine_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_queryText)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_queryText, JniHandleOwnership.DoNotTransfer);
			@object.OnQueryRefine(object2);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00016030 File Offset: 0x00014230
		[Register("onQueryRefine", "(Ljava/lang/CharSequence;)V", "GetOnQueryRefine_Ljava_lang_CharSequence_Handler")]
		protected unsafe virtual void OnQueryRefine(ICharSequence queryText)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(queryText);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("onQueryRefine.(Ljava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(queryText);
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00016094 File Offset: 0x00014294
		protected void OnQueryRefine(string queryText)
		{
			Java.Lang.String @string = (queryText == null) ? null : new Java.Lang.String(queryText);
			this.OnQueryRefine(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000160BE File Offset: 0x000142BE
		private static Delegate GetSetAppSearchData_Landroid_os_Bundle_Handler()
		{
			if (SearchView.cb_setAppSearchData_Landroid_os_Bundle_ == null)
			{
				SearchView.cb_setAppSearchData_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetAppSearchData_Landroid_os_Bundle_));
			}
			return SearchView.cb_setAppSearchData_Landroid_os_Bundle_;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000160E4 File Offset: 0x000142E4
		private static void n_SetAppSearchData_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_appSearchData)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_appSearchData, JniHandleOwnership.DoNotTransfer);
			@object.SetAppSearchData(object2);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00016108 File Offset: 0x00014308
		[Register("setAppSearchData", "(Landroid/os/Bundle;)V", "GetSetAppSearchData_Landroid_os_Bundle_Handler")]
		public unsafe virtual void SetAppSearchData(Bundle appSearchData)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((appSearchData == null) ? IntPtr.Zero : appSearchData.Handle);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setAppSearchData.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(appSearchData);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0001616C File Offset: 0x0001436C
		private static Delegate GetSetIconifiedByDefault_ZHandler()
		{
			if (SearchView.cb_setIconifiedByDefault_Z == null)
			{
				SearchView.cb_setIconifiedByDefault_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SearchView.n_SetIconifiedByDefault_Z));
			}
			return SearchView.cb_setIconifiedByDefault_Z;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00016190 File Offset: 0x00014390
		private static void n_SetIconifiedByDefault_Z(IntPtr jnienv, IntPtr native__this, bool iconified)
		{
			Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIconifiedByDefault(iconified);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000161A0 File Offset: 0x000143A0
		[Register("setIconifiedByDefault", "(Z)V", "GetSetIconifiedByDefault_ZHandler")]
		public unsafe virtual void SetIconifiedByDefault(bool iconified)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(iconified);
			SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setIconifiedByDefault.(Z)V", this, ptr);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000161DB File Offset: 0x000143DB
		private static Delegate GetSetOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_Handler()
		{
			if (SearchView.cb_setOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_ == null)
			{
				SearchView.cb_setOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_));
			}
			return SearchView.cb_setOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00016200 File Offset: 0x00014400
		private static void n_SetOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SearchView.IOnCloseListener object2 = Java.Lang.Object.GetObject<SearchView.IOnCloseListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnCloseListener(object2);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00016224 File Offset: 0x00014424
		[Register("setOnCloseListener", "(Landroidx/appcompat/widget/SearchView$OnCloseListener;)V", "GetSetOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_Handler")]
		public unsafe virtual void SetOnCloseListener(SearchView.IOnCloseListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnCloseListener.(Landroidx/appcompat/widget/SearchView$OnCloseListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0001628C File Offset: 0x0001448C
		private static Delegate GetSetOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_Handler()
		{
			if (SearchView.cb_setOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_ == null)
			{
				SearchView.cb_setOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_));
			}
			return SearchView.cb_setOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000162B0 File Offset: 0x000144B0
		private static void n_SetOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnFocusChangeListener object2 = Java.Lang.Object.GetObject<View.IOnFocusChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnQueryTextFocusChangeListener(object2);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000162D4 File Offset: 0x000144D4
		[Register("setOnQueryTextFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V", "GetSetOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_Handler")]
		public unsafe virtual void SetOnQueryTextFocusChangeListener(View.IOnFocusChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnQueryTextFocusChangeListener.(Landroid/view/View$OnFocusChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0001633C File Offset: 0x0001453C
		private static Delegate GetSetOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_Handler()
		{
			if (SearchView.cb_setOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_ == null)
			{
				SearchView.cb_setOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_));
			}
			return SearchView.cb_setOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00016360 File Offset: 0x00014560
		private static void n_SetOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SearchView.IOnQueryTextListener object2 = Java.Lang.Object.GetObject<SearchView.IOnQueryTextListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnQueryTextListener(object2);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00016384 File Offset: 0x00014584
		[Register("setOnQueryTextListener", "(Landroidx/appcompat/widget/SearchView$OnQueryTextListener;)V", "GetSetOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_Handler")]
		public unsafe virtual void SetOnQueryTextListener(SearchView.IOnQueryTextListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnQueryTextListener.(Landroidx/appcompat/widget/SearchView$OnQueryTextListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000163EC File Offset: 0x000145EC
		private static Delegate GetSetOnSearchClickListener_Landroid_view_View_OnClickListener_Handler()
		{
			if (SearchView.cb_setOnSearchClickListener_Landroid_view_View_OnClickListener_ == null)
			{
				SearchView.cb_setOnSearchClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetOnSearchClickListener_Landroid_view_View_OnClickListener_));
			}
			return SearchView.cb_setOnSearchClickListener_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00016410 File Offset: 0x00014610
		private static void n_SetOnSearchClickListener_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnSearchClickListener(object2);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00016434 File Offset: 0x00014634
		[Register("setOnSearchClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetOnSearchClickListener_Landroid_view_View_OnClickListener_Handler")]
		public unsafe virtual void SetOnSearchClickListener(View.IOnClickListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnSearchClickListener.(Landroid/view/View$OnClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0001649C File Offset: 0x0001469C
		private static Delegate GetSetOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_Handler()
		{
			if (SearchView.cb_setOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_ == null)
			{
				SearchView.cb_setOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_));
			}
			return SearchView.cb_setOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000164C0 File Offset: 0x000146C0
		private static void n_SetOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SearchView.IOnSuggestionListener object2 = Java.Lang.Object.GetObject<SearchView.IOnSuggestionListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnSuggestionListener(object2);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000164E4 File Offset: 0x000146E4
		[Register("setOnSuggestionListener", "(Landroidx/appcompat/widget/SearchView$OnSuggestionListener;)V", "GetSetOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_Handler")]
		public unsafe virtual void SetOnSuggestionListener(SearchView.IOnSuggestionListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnSuggestionListener.(Landroidx/appcompat/widget/SearchView$OnSuggestionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0001654C File Offset: 0x0001474C
		private static Delegate GetSetQuery_Ljava_lang_CharSequence_ZHandler()
		{
			if (SearchView.cb_setQuery_Ljava_lang_CharSequence_Z == null)
			{
				SearchView.cb_setQuery_Ljava_lang_CharSequence_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(SearchView.n_SetQuery_Ljava_lang_CharSequence_Z));
			}
			return SearchView.cb_setQuery_Ljava_lang_CharSequence_Z;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00016570 File Offset: 0x00014770
		private static void n_SetQuery_Ljava_lang_CharSequence_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_query, bool submit)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_query, JniHandleOwnership.DoNotTransfer);
			@object.SetQuery(object2, submit);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00016594 File Offset: 0x00014794
		[Register("setQuery", "(Ljava/lang/CharSequence;Z)V", "GetSetQuery_Ljava_lang_CharSequence_ZHandler")]
		public unsafe virtual void SetQuery(ICharSequence query, bool submit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(query);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(submit);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setQuery.(Ljava/lang/CharSequence;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(query);
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00016608 File Offset: 0x00014808
		public void SetQuery(string query, bool submit)
		{
			Java.Lang.String @string = (query == null) ? null : new Java.Lang.String(query);
			this.SetQuery(@string, submit);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00016633 File Offset: 0x00014833
		private static Delegate GetSetSearchableInfo_Landroid_app_SearchableInfo_Handler()
		{
			if (SearchView.cb_setSearchableInfo_Landroid_app_SearchableInfo_ == null)
			{
				SearchView.cb_setSearchableInfo_Landroid_app_SearchableInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SearchView.n_SetSearchableInfo_Landroid_app_SearchableInfo_));
			}
			return SearchView.cb_setSearchableInfo_Landroid_app_SearchableInfo_;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00016658 File Offset: 0x00014858
		private static void n_SetSearchableInfo_Landroid_app_SearchableInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_searchable)
		{
			SearchView @object = Java.Lang.Object.GetObject<SearchView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SearchableInfo object2 = Java.Lang.Object.GetObject<SearchableInfo>(native_searchable, JniHandleOwnership.DoNotTransfer);
			@object.SetSearchableInfo(object2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001667C File Offset: 0x0001487C
		[Register("setSearchableInfo", "(Landroid/app/SearchableInfo;)V", "GetSetSearchableInfo_Landroid_app_SearchableInfo_Handler")]
		public unsafe virtual void SetSearchableInfo(SearchableInfo searchable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((searchable == null) ? IntPtr.Zero : searchable.Handle);
				SearchView._members.InstanceMethods.InvokeVirtualVoidMethod("setSearchableInfo.(Landroid/app/SearchableInfo;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(searchable);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000888 RID: 2184 RVA: 0x000166E0 File Offset: 0x000148E0
		// (remove) Token: 0x06000889 RID: 2185 RVA: 0x0001672C File Offset: 0x0001492C
		public event EventHandler<SearchView.CloseEventArgs> Close
		{
			add
			{
				EventHelper.AddEventHandler<SearchView.IOnCloseListener, SearchView.IOnCloseListenerImplementor>(ref this.weak_implementor_SetOnCloseListener, new Func<SearchView.IOnCloseListenerImplementor>(this.__CreateIOnCloseListenerImplementor), new Action<SearchView.IOnCloseListener>(this.SetOnCloseListener), delegate(SearchView.IOnCloseListenerImplementor __h)
				{
					__h.Handler = (EventHandler<SearchView.CloseEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<SearchView.IOnCloseListenerImplementor, bool> empty;
				if ((empty = SearchView.<>O.<0>____IsEmpty) == null)
				{
					empty = (SearchView.<>O.<0>____IsEmpty = new Func<SearchView.IOnCloseListenerImplementor, bool>(SearchView.IOnCloseListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<SearchView.IOnCloseListener, SearchView.IOnCloseListenerImplementor>(ref this.weak_implementor_SetOnCloseListener, empty, delegate(SearchView.IOnCloseListener __v)
				{
					this.SetOnCloseListener(null);
				}, delegate(SearchView.IOnCloseListenerImplementor __h)
				{
					__h.Handler = (EventHandler<SearchView.CloseEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0001678B File Offset: 0x0001498B
		private SearchView.IOnCloseListenerImplementor __CreateIOnCloseListenerImplementor()
		{
			return new SearchView.IOnCloseListenerImplementor(this);
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600088B RID: 2187 RVA: 0x00016794 File Offset: 0x00014994
		// (remove) Token: 0x0600088C RID: 2188 RVA: 0x000167E0 File Offset: 0x000149E0
		public event EventHandler<SearchView.QueryTextChangeEventArgs> QueryTextChange
		{
			add
			{
				EventHelper.AddEventHandler<SearchView.IOnQueryTextListener, SearchView.IOnQueryTextListenerImplementor>(ref this.weak_implementor_SetOnQueryTextListener, new Func<SearchView.IOnQueryTextListenerImplementor>(this.__CreateIOnQueryTextListenerImplementor), new Action<SearchView.IOnQueryTextListener>(this.SetOnQueryTextListener), delegate(SearchView.IOnQueryTextListenerImplementor __h)
				{
					__h.OnQueryTextChangeHandler = (EventHandler<SearchView.QueryTextChangeEventArgs>)Delegate.Combine(__h.OnQueryTextChangeHandler, value);
				});
			}
			remove
			{
				Func<SearchView.IOnQueryTextListenerImplementor, bool> empty;
				if ((empty = SearchView.<>O.<1>____IsEmpty) == null)
				{
					empty = (SearchView.<>O.<1>____IsEmpty = new Func<SearchView.IOnQueryTextListenerImplementor, bool>(SearchView.IOnQueryTextListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<SearchView.IOnQueryTextListener, SearchView.IOnQueryTextListenerImplementor>(ref this.weak_implementor_SetOnQueryTextListener, empty, delegate(SearchView.IOnQueryTextListener __v)
				{
					this.SetOnQueryTextListener(null);
				}, delegate(SearchView.IOnQueryTextListenerImplementor __h)
				{
					__h.OnQueryTextChangeHandler = (EventHandler<SearchView.QueryTextChangeEventArgs>)Delegate.Remove(__h.OnQueryTextChangeHandler, value);
				});
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600088D RID: 2189 RVA: 0x00016840 File Offset: 0x00014A40
		// (remove) Token: 0x0600088E RID: 2190 RVA: 0x0001688C File Offset: 0x00014A8C
		public event EventHandler<SearchView.QueryTextSubmitEventArgs> QueryTextSubmit
		{
			add
			{
				EventHelper.AddEventHandler<SearchView.IOnQueryTextListener, SearchView.IOnQueryTextListenerImplementor>(ref this.weak_implementor_SetOnQueryTextListener, new Func<SearchView.IOnQueryTextListenerImplementor>(this.__CreateIOnQueryTextListenerImplementor), new Action<SearchView.IOnQueryTextListener>(this.SetOnQueryTextListener), delegate(SearchView.IOnQueryTextListenerImplementor __h)
				{
					__h.OnQueryTextSubmitHandler = (EventHandler<SearchView.QueryTextSubmitEventArgs>)Delegate.Combine(__h.OnQueryTextSubmitHandler, value);
				});
			}
			remove
			{
				Func<SearchView.IOnQueryTextListenerImplementor, bool> empty;
				if ((empty = SearchView.<>O.<1>____IsEmpty) == null)
				{
					empty = (SearchView.<>O.<1>____IsEmpty = new Func<SearchView.IOnQueryTextListenerImplementor, bool>(SearchView.IOnQueryTextListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<SearchView.IOnQueryTextListener, SearchView.IOnQueryTextListenerImplementor>(ref this.weak_implementor_SetOnQueryTextListener, empty, delegate(SearchView.IOnQueryTextListener __v)
				{
					this.SetOnQueryTextListener(null);
				}, delegate(SearchView.IOnQueryTextListenerImplementor __h)
				{
					__h.OnQueryTextSubmitHandler = (EventHandler<SearchView.QueryTextSubmitEventArgs>)Delegate.Remove(__h.OnQueryTextSubmitHandler, value);
				});
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000168EB File Offset: 0x00014AEB
		private SearchView.IOnQueryTextListenerImplementor __CreateIOnQueryTextListenerImplementor()
		{
			return new SearchView.IOnQueryTextListenerImplementor(this);
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000890 RID: 2192 RVA: 0x000168F4 File Offset: 0x00014AF4
		// (remove) Token: 0x06000891 RID: 2193 RVA: 0x00016940 File Offset: 0x00014B40
		public event EventHandler<SearchView.SuggestionClickEventArgs> SuggestionClick
		{
			add
			{
				EventHelper.AddEventHandler<SearchView.IOnSuggestionListener, SearchView.IOnSuggestionListenerImplementor>(ref this.weak_implementor_SetOnSuggestionListener, new Func<SearchView.IOnSuggestionListenerImplementor>(this.__CreateIOnSuggestionListenerImplementor), new Action<SearchView.IOnSuggestionListener>(this.SetOnSuggestionListener), delegate(SearchView.IOnSuggestionListenerImplementor __h)
				{
					__h.OnSuggestionClickHandler = (EventHandler<SearchView.SuggestionClickEventArgs>)Delegate.Combine(__h.OnSuggestionClickHandler, value);
				});
			}
			remove
			{
				Func<SearchView.IOnSuggestionListenerImplementor, bool> empty;
				if ((empty = SearchView.<>O.<2>____IsEmpty) == null)
				{
					empty = (SearchView.<>O.<2>____IsEmpty = new Func<SearchView.IOnSuggestionListenerImplementor, bool>(SearchView.IOnSuggestionListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<SearchView.IOnSuggestionListener, SearchView.IOnSuggestionListenerImplementor>(ref this.weak_implementor_SetOnSuggestionListener, empty, delegate(SearchView.IOnSuggestionListener __v)
				{
					this.SetOnSuggestionListener(null);
				}, delegate(SearchView.IOnSuggestionListenerImplementor __h)
				{
					__h.OnSuggestionClickHandler = (EventHandler<SearchView.SuggestionClickEventArgs>)Delegate.Remove(__h.OnSuggestionClickHandler, value);
				});
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000892 RID: 2194 RVA: 0x000169A0 File Offset: 0x00014BA0
		// (remove) Token: 0x06000893 RID: 2195 RVA: 0x000169EC File Offset: 0x00014BEC
		public event EventHandler<SearchView.SuggestionSelectEventArgs> SuggestionSelect
		{
			add
			{
				EventHelper.AddEventHandler<SearchView.IOnSuggestionListener, SearchView.IOnSuggestionListenerImplementor>(ref this.weak_implementor_SetOnSuggestionListener, new Func<SearchView.IOnSuggestionListenerImplementor>(this.__CreateIOnSuggestionListenerImplementor), new Action<SearchView.IOnSuggestionListener>(this.SetOnSuggestionListener), delegate(SearchView.IOnSuggestionListenerImplementor __h)
				{
					__h.OnSuggestionSelectHandler = (EventHandler<SearchView.SuggestionSelectEventArgs>)Delegate.Combine(__h.OnSuggestionSelectHandler, value);
				});
			}
			remove
			{
				Func<SearchView.IOnSuggestionListenerImplementor, bool> empty;
				if ((empty = SearchView.<>O.<2>____IsEmpty) == null)
				{
					empty = (SearchView.<>O.<2>____IsEmpty = new Func<SearchView.IOnSuggestionListenerImplementor, bool>(SearchView.IOnSuggestionListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<SearchView.IOnSuggestionListener, SearchView.IOnSuggestionListenerImplementor>(ref this.weak_implementor_SetOnSuggestionListener, empty, delegate(SearchView.IOnSuggestionListener __v)
				{
					this.SetOnSuggestionListener(null);
				}, delegate(SearchView.IOnSuggestionListenerImplementor __h)
				{
					__h.OnSuggestionSelectHandler = (EventHandler<SearchView.SuggestionSelectEventArgs>)Delegate.Remove(__h.OnSuggestionSelectHandler, value);
				});
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00016A4B File Offset: 0x00014C4B
		private SearchView.IOnSuggestionListenerImplementor __CreateIOnSuggestionListenerImplementor()
		{
			return new SearchView.IOnSuggestionListenerImplementor(this);
		}

		// Token: 0x0400024F RID: 591
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/SearchView", typeof(SearchView));

		// Token: 0x04000250 RID: 592
		private static Delegate cb_isIconified;

		// Token: 0x04000251 RID: 593
		private static Delegate cb_setIconified_Z;

		// Token: 0x04000252 RID: 594
		private static Delegate cb_getImeOptions;

		// Token: 0x04000253 RID: 595
		private static Delegate cb_setImeOptions_I;

		// Token: 0x04000254 RID: 596
		private static Delegate cb_getInputType;

		// Token: 0x04000255 RID: 597
		private static Delegate cb_setInputType_I;

		// Token: 0x04000256 RID: 598
		private static Delegate cb_isIconfiedByDefault;

		// Token: 0x04000257 RID: 599
		private static Delegate cb_getMaxWidth;

		// Token: 0x04000258 RID: 600
		private static Delegate cb_setMaxWidth_I;

		// Token: 0x04000259 RID: 601
		private static Delegate cb_getQuery;

		// Token: 0x0400025A RID: 602
		private static Delegate cb_getQueryHint;

		// Token: 0x0400025B RID: 603
		private static Delegate cb_setQueryHint_Ljava_lang_CharSequence_;

		// Token: 0x0400025C RID: 604
		private static Delegate cb_isQueryRefinementEnabled;

		// Token: 0x0400025D RID: 605
		private static Delegate cb_setQueryRefinementEnabled_Z;

		// Token: 0x0400025E RID: 606
		private static Delegate cb_isSubmitButtonEnabled;

		// Token: 0x0400025F RID: 607
		private static Delegate cb_setSubmitButtonEnabled_Z;

		// Token: 0x04000260 RID: 608
		private static Delegate cb_getSuggestionsAdapter;

		// Token: 0x04000261 RID: 609
		private static Delegate cb_setSuggestionsAdapter_Landroidx_cursoradapter_widget_CursorAdapter_;

		// Token: 0x04000262 RID: 610
		private static Delegate cb_onActionViewCollapsed;

		// Token: 0x04000263 RID: 611
		private static Delegate cb_onActionViewExpanded;

		// Token: 0x04000264 RID: 612
		private static Delegate cb_onQueryRefine_Ljava_lang_CharSequence_;

		// Token: 0x04000265 RID: 613
		private static Delegate cb_setAppSearchData_Landroid_os_Bundle_;

		// Token: 0x04000266 RID: 614
		private static Delegate cb_setIconifiedByDefault_Z;

		// Token: 0x04000267 RID: 615
		private static Delegate cb_setOnCloseListener_Landroidx_appcompat_widget_SearchView_OnCloseListener_;

		// Token: 0x04000268 RID: 616
		private static Delegate cb_setOnQueryTextFocusChangeListener_Landroid_view_View_OnFocusChangeListener_;

		// Token: 0x04000269 RID: 617
		private static Delegate cb_setOnQueryTextListener_Landroidx_appcompat_widget_SearchView_OnQueryTextListener_;

		// Token: 0x0400026A RID: 618
		private static Delegate cb_setOnSearchClickListener_Landroid_view_View_OnClickListener_;

		// Token: 0x0400026B RID: 619
		private static Delegate cb_setOnSuggestionListener_Landroidx_appcompat_widget_SearchView_OnSuggestionListener_;

		// Token: 0x0400026C RID: 620
		private static Delegate cb_setQuery_Ljava_lang_CharSequence_Z;

		// Token: 0x0400026D RID: 621
		private static Delegate cb_setSearchableInfo_Landroid_app_SearchableInfo_;

		// Token: 0x0400026E RID: 622
		private WeakReference weak_implementor_SetOnCloseListener;

		// Token: 0x0400026F RID: 623
		private WeakReference weak_implementor_SetOnQueryTextListener;

		// Token: 0x04000270 RID: 624
		private WeakReference weak_implementor_SetOnSuggestionListener;

		// Token: 0x0200006E RID: 110
		[Register("androidx/appcompat/widget/SearchView$OnCloseListener", "", "AndroidX.AppCompat.Widget.SearchView/IOnCloseListenerInvoker")]
		public interface IOnCloseListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000896 RID: 2198
			[Register("onClose", "()Z", "GetOnCloseHandler:AndroidX.AppCompat.Widget.SearchView/IOnCloseListenerInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnClose();
		}

		// Token: 0x0200006F RID: 111
		[Register("androidx/appcompat/widget/SearchView$OnCloseListener", DoNotGenerateAcw = true)]
		internal class IOnCloseListenerInvoker : Java.Lang.Object, SearchView.IOnCloseListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000897 RID: 2199 RVA: 0x00016A70 File Offset: 0x00014C70
			private static IntPtr java_class_ref
			{
				get
				{
					return SearchView.IOnCloseListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000898 RID: 2200 RVA: 0x00016A94 File Offset: 0x00014C94
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SearchView.IOnCloseListenerInvoker._members;
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000899 RID: 2201 RVA: 0x00016A9B File Offset: 0x00014C9B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x0600089A RID: 2202 RVA: 0x00016AA3 File Offset: 0x00014CA3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SearchView.IOnCloseListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600089B RID: 2203 RVA: 0x00016AAF File Offset: 0x00014CAF
			public static SearchView.IOnCloseListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SearchView.IOnCloseListener>(handle, transfer);
			}

			// Token: 0x0600089C RID: 2204 RVA: 0x00016AB8 File Offset: 0x00014CB8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SearchView.IOnCloseListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.widget.SearchView.OnCloseListener'.");
				}
				return handle;
			}

			// Token: 0x0600089D RID: 2205 RVA: 0x00016AE3 File Offset: 0x00014CE3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600089E RID: 2206 RVA: 0x00016B14 File Offset: 0x00014D14
			public IOnCloseListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SearchView.IOnCloseListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600089F RID: 2207 RVA: 0x00016B4C File Offset: 0x00014D4C
			private static Delegate GetOnCloseHandler()
			{
				if (SearchView.IOnCloseListenerInvoker.cb_onClose == null)
				{
					SearchView.IOnCloseListenerInvoker.cb_onClose = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SearchView.IOnCloseListenerInvoker.n_OnClose));
				}
				return SearchView.IOnCloseListenerInvoker.cb_onClose;
			}

			// Token: 0x060008A0 RID: 2208 RVA: 0x00016B70 File Offset: 0x00014D70
			private static bool n_OnClose(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<SearchView.IOnCloseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnClose();
			}

			// Token: 0x060008A1 RID: 2209 RVA: 0x00016B7F File Offset: 0x00014D7F
			public bool OnClose()
			{
				if (this.id_onClose == IntPtr.Zero)
				{
					this.id_onClose = JNIEnv.GetMethodID(this.class_ref, "onClose", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onClose);
			}

			// Token: 0x04000271 RID: 625
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/SearchView$OnCloseListener", typeof(SearchView.IOnCloseListenerInvoker));

			// Token: 0x04000272 RID: 626
			private IntPtr class_ref;

			// Token: 0x04000273 RID: 627
			private static Delegate cb_onClose;

			// Token: 0x04000274 RID: 628
			private IntPtr id_onClose;
		}

		// Token: 0x02000070 RID: 112
		public class CloseEventArgs : EventArgs
		{
			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00016BDA File Offset: 0x00014DDA
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x00016BE2 File Offset: 0x00014DE2
			public CloseEventArgs(bool handled)
			{
				this.handled = handled;
			}

			// Token: 0x04000275 RID: 629
			private bool handled;
		}

		// Token: 0x02000071 RID: 113
		[Register("mono/androidx/appcompat/widget/SearchView_OnCloseListenerImplementor")]
		internal sealed class IOnCloseListenerImplementor : Java.Lang.Object, SearchView.IOnCloseListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060008A5 RID: 2213 RVA: 0x00016BF1 File Offset: 0x00014DF1
			public IOnCloseListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/appcompat/widget/SearchView_OnCloseListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x00016C2C File Offset: 0x00014E2C
			public bool OnClose()
			{
				EventHandler<SearchView.CloseEventArgs> handler = this.Handler;
				if (handler == null)
				{
					return false;
				}
				SearchView.CloseEventArgs closeEventArgs = new SearchView.CloseEventArgs(true);
				handler(this.sender, closeEventArgs);
				return closeEventArgs.Handled;
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x00016C5F File Offset: 0x00014E5F
			internal static bool __IsEmpty(SearchView.IOnCloseListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000276 RID: 630
			private object sender;

			// Token: 0x04000277 RID: 631
			public EventHandler<SearchView.CloseEventArgs> Handler;
		}

		// Token: 0x02000072 RID: 114
		[Register("androidx/appcompat/widget/SearchView$OnQueryTextListener", "", "AndroidX.AppCompat.Widget.SearchView/IOnQueryTextListenerInvoker")]
		public interface IOnQueryTextListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060008A8 RID: 2216
			[Register("onQueryTextChange", "(Ljava/lang/String;)Z", "GetOnQueryTextChange_Ljava_lang_String_Handler:AndroidX.AppCompat.Widget.SearchView/IOnQueryTextListenerInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnQueryTextChange(string newText);

			// Token: 0x060008A9 RID: 2217
			[Register("onQueryTextSubmit", "(Ljava/lang/String;)Z", "GetOnQueryTextSubmit_Ljava_lang_String_Handler:AndroidX.AppCompat.Widget.SearchView/IOnQueryTextListenerInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnQueryTextSubmit(string newText);
		}

		// Token: 0x02000073 RID: 115
		[Register("androidx/appcompat/widget/SearchView$OnQueryTextListener", DoNotGenerateAcw = true)]
		internal class IOnQueryTextListenerInvoker : Java.Lang.Object, SearchView.IOnQueryTextListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060008AA RID: 2218 RVA: 0x00016C6C File Offset: 0x00014E6C
			private static IntPtr java_class_ref
			{
				get
				{
					return SearchView.IOnQueryTextListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060008AB RID: 2219 RVA: 0x00016C90 File Offset: 0x00014E90
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SearchView.IOnQueryTextListenerInvoker._members;
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060008AC RID: 2220 RVA: 0x00016C97 File Offset: 0x00014E97
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060008AD RID: 2221 RVA: 0x00016C9F File Offset: 0x00014E9F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SearchView.IOnQueryTextListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x00016CAB File Offset: 0x00014EAB
			public static SearchView.IOnQueryTextListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SearchView.IOnQueryTextListener>(handle, transfer);
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x00016CB4 File Offset: 0x00014EB4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SearchView.IOnQueryTextListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.widget.SearchView.OnQueryTextListener'.");
				}
				return handle;
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x00016CDF File Offset: 0x00014EDF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00016D10 File Offset: 0x00014F10
			public IOnQueryTextListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SearchView.IOnQueryTextListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x00016D48 File Offset: 0x00014F48
			private static Delegate GetOnQueryTextChange_Ljava_lang_String_Handler()
			{
				if (SearchView.IOnQueryTextListenerInvoker.cb_onQueryTextChange_Ljava_lang_String_ == null)
				{
					SearchView.IOnQueryTextListenerInvoker.cb_onQueryTextChange_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(SearchView.IOnQueryTextListenerInvoker.n_OnQueryTextChange_Ljava_lang_String_));
				}
				return SearchView.IOnQueryTextListenerInvoker.cb_onQueryTextChange_Ljava_lang_String_;
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x00016D6C File Offset: 0x00014F6C
			private static bool n_OnQueryTextChange_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_newText)
			{
				SearchView.IOnQueryTextListener @object = Java.Lang.Object.GetObject<SearchView.IOnQueryTextListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_newText, JniHandleOwnership.DoNotTransfer);
				return @object.OnQueryTextChange(@string);
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x00016D90 File Offset: 0x00014F90
			public unsafe bool OnQueryTextChange(string newText)
			{
				if (this.id_onQueryTextChange_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_onQueryTextChange_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onQueryTextChange", "(Ljava/lang/String;)Z");
				}
				IntPtr intPtr = JNIEnv.NewString(newText);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_onQueryTextChange_Ljava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
				return result;
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x00016E01 File Offset: 0x00015001
			private static Delegate GetOnQueryTextSubmit_Ljava_lang_String_Handler()
			{
				if (SearchView.IOnQueryTextListenerInvoker.cb_onQueryTextSubmit_Ljava_lang_String_ == null)
				{
					SearchView.IOnQueryTextListenerInvoker.cb_onQueryTextSubmit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(SearchView.IOnQueryTextListenerInvoker.n_OnQueryTextSubmit_Ljava_lang_String_));
				}
				return SearchView.IOnQueryTextListenerInvoker.cb_onQueryTextSubmit_Ljava_lang_String_;
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x00016E28 File Offset: 0x00015028
			private static bool n_OnQueryTextSubmit_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_newText)
			{
				SearchView.IOnQueryTextListener @object = Java.Lang.Object.GetObject<SearchView.IOnQueryTextListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_newText, JniHandleOwnership.DoNotTransfer);
				return @object.OnQueryTextSubmit(@string);
			}

			// Token: 0x060008B7 RID: 2231 RVA: 0x00016E4C File Offset: 0x0001504C
			public unsafe bool OnQueryTextSubmit(string newText)
			{
				if (this.id_onQueryTextSubmit_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_onQueryTextSubmit_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onQueryTextSubmit", "(Ljava/lang/String;)Z");
				}
				IntPtr intPtr = JNIEnv.NewString(newText);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_onQueryTextSubmit_Ljava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
				return result;
			}

			// Token: 0x04000278 RID: 632
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/SearchView$OnQueryTextListener", typeof(SearchView.IOnQueryTextListenerInvoker));

			// Token: 0x04000279 RID: 633
			private IntPtr class_ref;

			// Token: 0x0400027A RID: 634
			private static Delegate cb_onQueryTextChange_Ljava_lang_String_;

			// Token: 0x0400027B RID: 635
			private IntPtr id_onQueryTextChange_Ljava_lang_String_;

			// Token: 0x0400027C RID: 636
			private static Delegate cb_onQueryTextSubmit_Ljava_lang_String_;

			// Token: 0x0400027D RID: 637
			private IntPtr id_onQueryTextSubmit_Ljava_lang_String_;
		}

		// Token: 0x02000074 RID: 116
		public class QueryTextChangeEventArgs : EventArgs
		{
			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00016ED8 File Offset: 0x000150D8
			// (set) Token: 0x060008BA RID: 2234 RVA: 0x00016EE0 File Offset: 0x000150E0
			public bool Handled
			{
				get
				{
					return this.handled;
				}
				set
				{
					this.handled = value;
				}
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x00016EE9 File Offset: 0x000150E9
			public QueryTextChangeEventArgs(bool handled, string newText)
			{
				this.handled = handled;
				this.newText = newText;
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060008BC RID: 2236 RVA: 0x00016EFF File Offset: 0x000150FF
			public string NewText
			{
				get
				{
					return this.newText;
				}
			}

			// Token: 0x0400027E RID: 638
			private bool handled;

			// Token: 0x0400027F RID: 639
			private string newText;
		}

		// Token: 0x02000075 RID: 117
		public class QueryTextSubmitEventArgs : EventArgs
		{
			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060008BD RID: 2237 RVA: 0x00016F07 File Offset: 0x00015107
			// (set) Token: 0x060008BE RID: 2238 RVA: 0x00016F0F File Offset: 0x0001510F
			public bool Handled
			{
				get
				{
					return this.handled;
				}
				set
				{
					this.handled = value;
				}
			}

			// Token: 0x060008BF RID: 2239 RVA: 0x00016F18 File Offset: 0x00015118
			public QueryTextSubmitEventArgs(bool handled, string newText)
			{
				this.handled = handled;
				this.newText = newText;
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00016F2E File Offset: 0x0001512E
			public string NewText
			{
				get
				{
					return this.newText;
				}
			}

			// Token: 0x04000280 RID: 640
			private bool handled;

			// Token: 0x04000281 RID: 641
			private string newText;
		}

		// Token: 0x02000076 RID: 118
		[Register("mono/androidx/appcompat/widget/SearchView_OnQueryTextListenerImplementor")]
		internal sealed class IOnQueryTextListenerImplementor : Java.Lang.Object, SearchView.IOnQueryTextListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060008C1 RID: 2241 RVA: 0x00016F36 File Offset: 0x00015136
			public IOnQueryTextListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/appcompat/widget/SearchView_OnQueryTextListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060008C2 RID: 2242 RVA: 0x00016F70 File Offset: 0x00015170
			public bool OnQueryTextChange(string newText)
			{
				EventHandler<SearchView.QueryTextChangeEventArgs> onQueryTextChangeHandler = this.OnQueryTextChangeHandler;
				if (onQueryTextChangeHandler == null)
				{
					return false;
				}
				SearchView.QueryTextChangeEventArgs queryTextChangeEventArgs = new SearchView.QueryTextChangeEventArgs(true, newText);
				onQueryTextChangeHandler(this.sender, queryTextChangeEventArgs);
				return queryTextChangeEventArgs.Handled;
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x00016FA4 File Offset: 0x000151A4
			public bool OnQueryTextSubmit(string newText)
			{
				EventHandler<SearchView.QueryTextSubmitEventArgs> onQueryTextSubmitHandler = this.OnQueryTextSubmitHandler;
				if (onQueryTextSubmitHandler == null)
				{
					return false;
				}
				SearchView.QueryTextSubmitEventArgs queryTextSubmitEventArgs = new SearchView.QueryTextSubmitEventArgs(true, newText);
				onQueryTextSubmitHandler(this.sender, queryTextSubmitEventArgs);
				return queryTextSubmitEventArgs.Handled;
			}

			// Token: 0x060008C4 RID: 2244 RVA: 0x00016FD8 File Offset: 0x000151D8
			internal static bool __IsEmpty(SearchView.IOnQueryTextListenerImplementor value)
			{
				return value.OnQueryTextChangeHandler == null && value.OnQueryTextSubmitHandler == null;
			}

			// Token: 0x04000282 RID: 642
			private object sender;

			// Token: 0x04000283 RID: 643
			public EventHandler<SearchView.QueryTextChangeEventArgs> OnQueryTextChangeHandler;

			// Token: 0x04000284 RID: 644
			public EventHandler<SearchView.QueryTextSubmitEventArgs> OnQueryTextSubmitHandler;
		}

		// Token: 0x02000077 RID: 119
		[Register("androidx/appcompat/widget/SearchView$OnSuggestionListener", "", "AndroidX.AppCompat.Widget.SearchView/IOnSuggestionListenerInvoker")]
		public interface IOnSuggestionListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060008C5 RID: 2245
			[Register("onSuggestionClick", "(I)Z", "GetOnSuggestionClick_IHandler:AndroidX.AppCompat.Widget.SearchView/IOnSuggestionListenerInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnSuggestionClick(int position);

			// Token: 0x060008C6 RID: 2246
			[Register("onSuggestionSelect", "(I)Z", "GetOnSuggestionSelect_IHandler:AndroidX.AppCompat.Widget.SearchView/IOnSuggestionListenerInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnSuggestionSelect(int position);
		}

		// Token: 0x02000078 RID: 120
		[Register("androidx/appcompat/widget/SearchView$OnSuggestionListener", DoNotGenerateAcw = true)]
		internal class IOnSuggestionListenerInvoker : Java.Lang.Object, SearchView.IOnSuggestionListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00016FF0 File Offset: 0x000151F0
			private static IntPtr java_class_ref
			{
				get
				{
					return SearchView.IOnSuggestionListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00017014 File Offset: 0x00015214
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SearchView.IOnSuggestionListenerInvoker._members;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0001701B File Offset: 0x0001521B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060008CA RID: 2250 RVA: 0x00017023 File Offset: 0x00015223
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SearchView.IOnSuggestionListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060008CB RID: 2251 RVA: 0x0001702F File Offset: 0x0001522F
			public static SearchView.IOnSuggestionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SearchView.IOnSuggestionListener>(handle, transfer);
			}

			// Token: 0x060008CC RID: 2252 RVA: 0x00017038 File Offset: 0x00015238
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SearchView.IOnSuggestionListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.widget.SearchView.OnSuggestionListener'.");
				}
				return handle;
			}

			// Token: 0x060008CD RID: 2253 RVA: 0x00017063 File Offset: 0x00015263
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060008CE RID: 2254 RVA: 0x00017094 File Offset: 0x00015294
			public IOnSuggestionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SearchView.IOnSuggestionListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060008CF RID: 2255 RVA: 0x000170CC File Offset: 0x000152CC
			private static Delegate GetOnSuggestionClick_IHandler()
			{
				if (SearchView.IOnSuggestionListenerInvoker.cb_onSuggestionClick_I == null)
				{
					SearchView.IOnSuggestionListenerInvoker.cb_onSuggestionClick_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(SearchView.IOnSuggestionListenerInvoker.n_OnSuggestionClick_I));
				}
				return SearchView.IOnSuggestionListenerInvoker.cb_onSuggestionClick_I;
			}

			// Token: 0x060008D0 RID: 2256 RVA: 0x000170F0 File Offset: 0x000152F0
			private static bool n_OnSuggestionClick_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				return Java.Lang.Object.GetObject<SearchView.IOnSuggestionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSuggestionClick(position);
			}

			// Token: 0x060008D1 RID: 2257 RVA: 0x00017100 File Offset: 0x00015300
			public unsafe bool OnSuggestionClick(int position)
			{
				if (this.id_onSuggestionClick_I == IntPtr.Zero)
				{
					this.id_onSuggestionClick_I = JNIEnv.GetMethodID(this.class_ref, "onSuggestionClick", "(I)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(position);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onSuggestionClick_I, ptr);
			}

			// Token: 0x060008D2 RID: 2258 RVA: 0x00017164 File Offset: 0x00015364
			private static Delegate GetOnSuggestionSelect_IHandler()
			{
				if (SearchView.IOnSuggestionListenerInvoker.cb_onSuggestionSelect_I == null)
				{
					SearchView.IOnSuggestionListenerInvoker.cb_onSuggestionSelect_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(SearchView.IOnSuggestionListenerInvoker.n_OnSuggestionSelect_I));
				}
				return SearchView.IOnSuggestionListenerInvoker.cb_onSuggestionSelect_I;
			}

			// Token: 0x060008D3 RID: 2259 RVA: 0x00017188 File Offset: 0x00015388
			private static bool n_OnSuggestionSelect_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				return Java.Lang.Object.GetObject<SearchView.IOnSuggestionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSuggestionSelect(position);
			}

			// Token: 0x060008D4 RID: 2260 RVA: 0x00017198 File Offset: 0x00015398
			public unsafe bool OnSuggestionSelect(int position)
			{
				if (this.id_onSuggestionSelect_I == IntPtr.Zero)
				{
					this.id_onSuggestionSelect_I = JNIEnv.GetMethodID(this.class_ref, "onSuggestionSelect", "(I)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(position);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onSuggestionSelect_I, ptr);
			}

			// Token: 0x04000285 RID: 645
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/SearchView$OnSuggestionListener", typeof(SearchView.IOnSuggestionListenerInvoker));

			// Token: 0x04000286 RID: 646
			private IntPtr class_ref;

			// Token: 0x04000287 RID: 647
			private static Delegate cb_onSuggestionClick_I;

			// Token: 0x04000288 RID: 648
			private IntPtr id_onSuggestionClick_I;

			// Token: 0x04000289 RID: 649
			private static Delegate cb_onSuggestionSelect_I;

			// Token: 0x0400028A RID: 650
			private IntPtr id_onSuggestionSelect_I;
		}

		// Token: 0x02000079 RID: 121
		public class SuggestionClickEventArgs : EventArgs
		{
			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00017217 File Offset: 0x00015417
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x060008D7 RID: 2263 RVA: 0x0001721F File Offset: 0x0001541F
			public SuggestionClickEventArgs(bool handled, int position)
			{
				this.handled = handled;
				this.position = position;
			}

			// Token: 0x0400028B RID: 651
			private bool handled;

			// Token: 0x0400028C RID: 652
			private int position;
		}

		// Token: 0x0200007A RID: 122
		public class SuggestionSelectEventArgs : EventArgs
		{
			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00017235 File Offset: 0x00015435
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x060008D9 RID: 2265 RVA: 0x0001723D File Offset: 0x0001543D
			public SuggestionSelectEventArgs(bool handled, int position)
			{
				this.handled = handled;
				this.position = position;
			}

			// Token: 0x0400028D RID: 653
			private bool handled;

			// Token: 0x0400028E RID: 654
			private int position;
		}

		// Token: 0x0200007B RID: 123
		[Register("mono/androidx/appcompat/widget/SearchView_OnSuggestionListenerImplementor")]
		internal sealed class IOnSuggestionListenerImplementor : Java.Lang.Object, SearchView.IOnSuggestionListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060008DA RID: 2266 RVA: 0x00017253 File Offset: 0x00015453
			public IOnSuggestionListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/appcompat/widget/SearchView_OnSuggestionListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060008DB RID: 2267 RVA: 0x0001728C File Offset: 0x0001548C
			public bool OnSuggestionClick(int position)
			{
				EventHandler<SearchView.SuggestionClickEventArgs> onSuggestionClickHandler = this.OnSuggestionClickHandler;
				if (onSuggestionClickHandler == null)
				{
					return false;
				}
				SearchView.SuggestionClickEventArgs suggestionClickEventArgs = new SearchView.SuggestionClickEventArgs(true, position);
				onSuggestionClickHandler(this.sender, suggestionClickEventArgs);
				return suggestionClickEventArgs.Handled;
			}

			// Token: 0x060008DC RID: 2268 RVA: 0x000172C0 File Offset: 0x000154C0
			public bool OnSuggestionSelect(int position)
			{
				EventHandler<SearchView.SuggestionSelectEventArgs> onSuggestionSelectHandler = this.OnSuggestionSelectHandler;
				if (onSuggestionSelectHandler == null)
				{
					return false;
				}
				SearchView.SuggestionSelectEventArgs suggestionSelectEventArgs = new SearchView.SuggestionSelectEventArgs(true, position);
				onSuggestionSelectHandler(this.sender, suggestionSelectEventArgs);
				return suggestionSelectEventArgs.Handled;
			}

			// Token: 0x060008DD RID: 2269 RVA: 0x000172F4 File Offset: 0x000154F4
			internal static bool __IsEmpty(SearchView.IOnSuggestionListenerImplementor value)
			{
				return value.OnSuggestionClickHandler == null && value.OnSuggestionSelectHandler == null;
			}

			// Token: 0x0400028F RID: 655
			private object sender;

			// Token: 0x04000290 RID: 656
			public EventHandler<SearchView.SuggestionClickEventArgs> OnSuggestionClickHandler;

			// Token: 0x04000291 RID: 657
			public EventHandler<SearchView.SuggestionSelectEventArgs> OnSuggestionSelectHandler;
		}

		// Token: 0x0200007C RID: 124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000292 RID: 658
			public static Func<SearchView.IOnCloseListenerImplementor, bool> <0>____IsEmpty;

			// Token: 0x04000293 RID: 659
			public static Func<SearchView.IOnQueryTextListenerImplementor, bool> <1>____IsEmpty;

			// Token: 0x04000294 RID: 660
			public static Func<SearchView.IOnSuggestionListenerImplementor, bool> <2>____IsEmpty;
		}
	}
}
