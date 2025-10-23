using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x02000298 RID: 664
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/ClosedFloatingPointRange$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ClosedFloatingPointRangeDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00063180 File Offset: 0x00061380
		internal static IntPtr class_ref
		{
			get
			{
				return ClosedFloatingPointRangeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x000631A4 File Offset: 0x000613A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClosedFloatingPointRangeDefaultImpls._members;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x000631AC File Offset: 0x000613AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClosedFloatingPointRangeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x000631D0 File Offset: 0x000613D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClosedFloatingPointRangeDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000631DC File Offset: 0x000613DC
		internal ClosedFloatingPointRangeDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x000631E8 File Offset: 0x000613E8
		[Register("contains", "(Lkotlin/ranges/ClosedFloatingPointRange;Ljava/lang/Comparable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static bool Contains(IClosedFloatingPointRange _this, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ClosedFloatingPointRangeDefaultImpls._members.StaticMethods.InvokeBooleanMethod("contains.(Lkotlin/ranges/ClosedFloatingPointRange;Ljava/lang/Comparable;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00063278 File Offset: 0x00061478
		[Register("isEmpty", "(Lkotlin/ranges/ClosedFloatingPointRange;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static bool IsEmpty(IClosedFloatingPointRange _this)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				result = ClosedFloatingPointRangeDefaultImpls._members.StaticMethods.InvokeBooleanMethod("isEmpty.(Lkotlin/ranges/ClosedFloatingPointRange;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return result;
		}

		// Token: 0x04000916 RID: 2326
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ClosedFloatingPointRange$DefaultImpls", typeof(ClosedFloatingPointRangeDefaultImpls));
	}
}
