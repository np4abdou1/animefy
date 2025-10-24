using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000E4 RID: 228
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/MatchResult$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class MatchResultDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00013C24 File Offset: 0x00011E24
		internal static IntPtr class_ref
		{
			get
			{
				return MatchResultDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00013C48 File Offset: 0x00011E48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MatchResultDefaultImpls._members;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00013C50 File Offset: 0x00011E50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MatchResultDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00013C74 File Offset: 0x00011E74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MatchResultDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00013C80 File Offset: 0x00011E80
		internal MatchResultDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00013C8C File Offset: 0x00011E8C
		[Register("getDestructured", "(Lkotlin/text/MatchResult;)Lkotlin/text/MatchResult$Destructured;", "")]
		public unsafe static MatchResultDestructured GetDestructured(IMatchResult _this)
		{
			MatchResultDestructured @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<MatchResultDestructured>(MatchResultDefaultImpls._members.StaticMethods.InvokeObjectMethod("getDestructured.(Lkotlin/text/MatchResult;)Lkotlin/text/MatchResult$Destructured;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x04000217 RID: 535
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/MatchResult$DefaultImpls", typeof(MatchResultDefaultImpls));
	}
}
