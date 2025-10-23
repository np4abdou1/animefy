using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000132 RID: 306
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KType$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class KTypeDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00036B44 File Offset: 0x00034D44
		internal static IntPtr class_ref
		{
			get
			{
				return KTypeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00036B68 File Offset: 0x00034D68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KTypeDefaultImpls._members;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00036B70 File Offset: 0x00034D70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KTypeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00036B94 File Offset: 0x00034D94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KTypeDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00036BA0 File Offset: 0x00034DA0
		internal KTypeDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000556 RID: 1366
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KType$DefaultImpls", typeof(KTypeDefaultImpls));
	}
}
