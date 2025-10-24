using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002C2 RID: 706
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/CharIterator", DoNotGenerateAcw = true)]
	internal class CharIteratorInvoker : CharIterator
	{
		// Token: 0x06002628 RID: 9768 RVA: 0x000A1D33 File Offset: 0x0009FF33
		public CharIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x000A1D3D File Offset: 0x0009FF3D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharIteratorInvoker._members;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000A1D44 File Offset: 0x0009FF44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000A1D50 File Offset: 0x0009FF50
		[Register("nextChar", "()C", "GetNextCharHandler")]
		public override char NextChar()
		{
			return CharIteratorInvoker._members.InstanceMethods.InvokeAbstractCharMethod("nextChar.()C", this, null);
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000A1D69 File Offset: 0x0009FF69
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return CharIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x0400099D RID: 2461
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/CharIterator", typeof(CharIteratorInvoker));
	}
}
