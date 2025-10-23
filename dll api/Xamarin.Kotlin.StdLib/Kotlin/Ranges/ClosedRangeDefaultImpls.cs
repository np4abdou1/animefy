using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x0200029B RID: 667
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/ClosedRange$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ClosedRangeDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00063720 File Offset: 0x00061920
		internal static IntPtr class_ref
		{
			get
			{
				return ClosedRangeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00063744 File Offset: 0x00061944
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClosedRangeDefaultImpls._members;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0006374C File Offset: 0x0006194C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClosedRangeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00063770 File Offset: 0x00061970
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClosedRangeDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0006377C File Offset: 0x0006197C
		internal ClosedRangeDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00063788 File Offset: 0x00061988
		[Register("contains", "(Lkotlin/ranges/ClosedRange;Ljava/lang/Comparable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static bool Contains(IClosedRange _this, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ClosedRangeDefaultImpls._members.StaticMethods.InvokeBooleanMethod("contains.(Lkotlin/ranges/ClosedRange;Ljava/lang/Comparable;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00063818 File Offset: 0x00061A18
		[Register("isEmpty", "(Lkotlin/ranges/ClosedRange;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static bool IsEmpty(IClosedRange _this)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				result = ClosedRangeDefaultImpls._members.StaticMethods.InvokeBooleanMethod("isEmpty.(Lkotlin/ranges/ClosedRange;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return result;
		}

		// Token: 0x04000923 RID: 2339
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ClosedRange$DefaultImpls", typeof(ClosedRangeDefaultImpls));
	}
}
