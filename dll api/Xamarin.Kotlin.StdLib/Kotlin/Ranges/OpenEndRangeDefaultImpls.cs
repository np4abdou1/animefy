using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x020002A0 RID: 672
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/OpenEndRange$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class OpenEndRangeDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0006400C File Offset: 0x0006220C
		internal static IntPtr class_ref
		{
			get
			{
				return OpenEndRangeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x00064030 File Offset: 0x00062230
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OpenEndRangeDefaultImpls._members;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00064038 File Offset: 0x00062238
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OpenEndRangeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0006405C File Offset: 0x0006225C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OpenEndRangeDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00064068 File Offset: 0x00062268
		internal OpenEndRangeDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00064074 File Offset: 0x00062274
		[Register("contains", "(Lkotlin/ranges/OpenEndRange;Ljava/lang/Comparable;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static bool Contains(IOpenEndRange _this, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = OpenEndRangeDefaultImpls._members.StaticMethods.InvokeBooleanMethod("contains.(Lkotlin/ranges/OpenEndRange;Ljava/lang/Comparable;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00064104 File Offset: 0x00062304
		[Register("isEmpty", "(Lkotlin/ranges/OpenEndRange;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static bool IsEmpty(IOpenEndRange _this)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				result = OpenEndRangeDefaultImpls._members.StaticMethods.InvokeBooleanMethod("isEmpty.(Lkotlin/ranges/OpenEndRange;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return result;
		}

		// Token: 0x04000932 RID: 2354
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/OpenEndRange$DefaultImpls", typeof(OpenEndRangeDefaultImpls));
	}
}
