using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text.Jdk8
{
	// Token: 0x020000F2 RID: 242
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/jdk8/RegexExtensionsJDK8Kt", DoNotGenerateAcw = true)]
	public sealed class RegexExtensionsJDK8Kt : Java.Lang.Object
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00021848 File Offset: 0x0001FA48
		internal static IntPtr class_ref
		{
			get
			{
				return RegexExtensionsJDK8Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002186C File Offset: 0x0001FA6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RegexExtensionsJDK8Kt._members;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00021874 File Offset: 0x0001FA74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RegexExtensionsJDK8Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00021898 File Offset: 0x0001FA98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RegexExtensionsJDK8Kt._members.ManagedPeerType;
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000218A4 File Offset: 0x0001FAA4
		internal RegexExtensionsJDK8Kt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000218B0 File Offset: 0x0001FAB0
		[Register("get", "(Lkotlin/text/MatchGroupCollection;Ljava/lang/String;)Lkotlin/text/MatchGroup;", "")]
		[return: Nullable(2)]
		public unsafe static MatchGroup Get(IMatchGroupCollection obj, string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			MatchGroup @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MatchGroup>(RegexExtensionsJDK8Kt._members.StaticMethods.InvokeObjectMethod("get.(Lkotlin/text/MatchGroupCollection;Ljava/lang/String;)Lkotlin/text/MatchGroup;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0400025A RID: 602
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/jdk8/RegexExtensionsJDK8Kt", typeof(RegexExtensionsJDK8Kt));
	}
}
