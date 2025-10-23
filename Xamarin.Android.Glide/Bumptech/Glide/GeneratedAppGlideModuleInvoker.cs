using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x02000037 RID: 55
	[Register("com/bumptech/glide/GeneratedAppGlideModule", DoNotGenerateAcw = true)]
	internal class GeneratedAppGlideModuleInvoker : GeneratedAppGlideModule
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00004AD1 File Offset: 0x00002CD1
		public GeneratedAppGlideModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00004ADB File Offset: 0x00002CDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GeneratedAppGlideModuleInvoker._members;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00004AE2 File Offset: 0x00002CE2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GeneratedAppGlideModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public override ICollection<Class> ExcludedModuleClasses
		{
			[Register("getExcludedModuleClasses", "()Ljava/util/Set;", "GetGetExcludedModuleClassesHandler")]
			get
			{
				return JavaSet<Class>.FromJniHandle(GeneratedAppGlideModuleInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getExcludedModuleClasses.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400003E RID: 62
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GeneratedAppGlideModule", typeof(GeneratedAppGlideModuleInvoker));
	}
}
