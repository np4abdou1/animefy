using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Ranges;

namespace Kotlin.Text
{
	// Token: 0x020000E7 RID: 231
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/MatchResult", DoNotGenerateAcw = true)]
	internal class IMatchResultInvoker : Java.Lang.Object, IMatchResult, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00013E0C File Offset: 0x0001200C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMatchResultInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00013E30 File Offset: 0x00012030
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMatchResultInvoker._members;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00013E37 File Offset: 0x00012037
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00013E3F File Offset: 0x0001203F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMatchResultInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00013E4B File Offset: 0x0001204B
		[NullableContext(2)]
		public static IMatchResult GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMatchResult>(handle, transfer);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00013E54 File Offset: 0x00012054
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMatchResultInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.text.MatchResult'.");
			}
			return handle;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00013E7F File Offset: 0x0001207F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00013EB0 File Offset: 0x000120B0
		public IMatchResultInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMatchResultInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00013EE8 File Offset: 0x000120E8
		private static Delegate GetGetDestructuredHandler()
		{
			if (IMatchResultInvoker.cb_getDestructured == null)
			{
				IMatchResultInvoker.cb_getDestructured = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchResultInvoker.n_GetDestructured));
			}
			return IMatchResultInvoker.cb_getDestructured;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00013F0C File Offset: 0x0001210C
		private static IntPtr n_GetDestructured(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destructured);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00013F20 File Offset: 0x00012120
		public MatchResultDestructured Destructured
		{
			get
			{
				if (this.id_getDestructured == IntPtr.Zero)
				{
					this.id_getDestructured = JNIEnv.GetMethodID(this.class_ref, "getDestructured", "()Lkotlin/text/MatchResult$Destructured;");
				}
				return Java.Lang.Object.GetObject<MatchResultDestructured>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDestructured), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00013F71 File Offset: 0x00012171
		private static Delegate GetGetGroupValuesHandler()
		{
			if (IMatchResultInvoker.cb_getGroupValues == null)
			{
				IMatchResultInvoker.cb_getGroupValues = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchResultInvoker.n_GetGroupValues));
			}
			return IMatchResultInvoker.cb_getGroupValues;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00013F95 File Offset: 0x00012195
		private static IntPtr n_GetGroupValues(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GroupValues);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00013FAC File Offset: 0x000121AC
		public IList<string> GroupValues
		{
			get
			{
				if (this.id_getGroupValues == IntPtr.Zero)
				{
					this.id_getGroupValues = JNIEnv.GetMethodID(this.class_ref, "getGroupValues", "()Ljava/util/List;");
				}
				return JavaList<string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getGroupValues), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00013FFD File Offset: 0x000121FD
		private static Delegate GetGetGroupsHandler()
		{
			if (IMatchResultInvoker.cb_getGroups == null)
			{
				IMatchResultInvoker.cb_getGroups = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchResultInvoker.n_GetGroups));
			}
			return IMatchResultInvoker.cb_getGroups;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00014021 File Offset: 0x00012221
		private static IntPtr n_GetGroups(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Groups);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00014038 File Offset: 0x00012238
		public IMatchGroupCollection Groups
		{
			get
			{
				if (this.id_getGroups == IntPtr.Zero)
				{
					this.id_getGroups = JNIEnv.GetMethodID(this.class_ref, "getGroups", "()Lkotlin/text/MatchGroupCollection;");
				}
				return Java.Lang.Object.GetObject<IMatchGroupCollection>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGroups), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00014089 File Offset: 0x00012289
		private static Delegate GetGetRangeHandler()
		{
			if (IMatchResultInvoker.cb_getRange == null)
			{
				IMatchResultInvoker.cb_getRange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchResultInvoker.n_GetRange));
			}
			return IMatchResultInvoker.cb_getRange;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000140AD File Offset: 0x000122AD
		private static IntPtr n_GetRange(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Range);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000140C4 File Offset: 0x000122C4
		public IntRange Range
		{
			get
			{
				if (this.id_getRange == IntPtr.Zero)
				{
					this.id_getRange = JNIEnv.GetMethodID(this.class_ref, "getRange", "()Lkotlin/ranges/IntRange;");
				}
				return Java.Lang.Object.GetObject<IntRange>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRange), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00014115 File Offset: 0x00012315
		private static Delegate GetGetValueHandler()
		{
			if (IMatchResultInvoker.cb_getValue == null)
			{
				IMatchResultInvoker.cb_getValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchResultInvoker.n_GetValue));
			}
			return IMatchResultInvoker.cb_getValue;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00014139 File Offset: 0x00012339
		private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value);
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00014150 File Offset: 0x00012350
		public string Value
		{
			get
			{
				if (this.id_getValue == IntPtr.Zero)
				{
					this.id_getValue = JNIEnv.GetMethodID(this.class_ref, "getValue", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000141A1 File Offset: 0x000123A1
		private static Delegate GetNextHandler()
		{
			if (IMatchResultInvoker.cb_next == null)
			{
				IMatchResultInvoker.cb_next = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchResultInvoker.n_Next));
			}
			return IMatchResultInvoker.cb_next;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000141C5 File Offset: 0x000123C5
		private static IntPtr n_Next(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Next());
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000141DC File Offset: 0x000123DC
		[NullableContext(2)]
		public IMatchResult Next()
		{
			if (this.id_next == IntPtr.Zero)
			{
				this.id_next = JNIEnv.GetMethodID(this.class_ref, "next", "()Lkotlin/text/MatchResult;");
			}
			return Java.Lang.Object.GetObject<IMatchResult>(JNIEnv.CallObjectMethod(base.Handle, this.id_next), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000219 RID: 537
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/MatchResult", typeof(IMatchResultInvoker));

		// Token: 0x0400021A RID: 538
		private IntPtr class_ref;

		// Token: 0x0400021B RID: 539
		[Nullable(2)]
		private static Delegate cb_getDestructured;

		// Token: 0x0400021C RID: 540
		private IntPtr id_getDestructured;

		// Token: 0x0400021D RID: 541
		[Nullable(2)]
		private static Delegate cb_getGroupValues;

		// Token: 0x0400021E RID: 542
		private IntPtr id_getGroupValues;

		// Token: 0x0400021F RID: 543
		[Nullable(2)]
		private static Delegate cb_getGroups;

		// Token: 0x04000220 RID: 544
		private IntPtr id_getGroups;

		// Token: 0x04000221 RID: 545
		[Nullable(2)]
		private static Delegate cb_getRange;

		// Token: 0x04000222 RID: 546
		private IntPtr id_getRange;

		// Token: 0x04000223 RID: 547
		[Nullable(2)]
		private static Delegate cb_getValue;

		// Token: 0x04000224 RID: 548
		private IntPtr id_getValue;

		// Token: 0x04000225 RID: 549
		[Nullable(2)]
		private static Delegate cb_next;

		// Token: 0x04000226 RID: 550
		private IntPtr id_next;
	}
}
