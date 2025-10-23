using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Drawable
{
	// Token: 0x020000F3 RID: 243
	[Register("com/bumptech/glide/load/resource/drawable/DrawableResource", DoNotGenerateAcw = true)]
	internal class DrawableResourceInvoker : DrawableResource, IResource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x00025A2F File Offset: 0x00023C2F
		public DrawableResourceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00025A39 File Offset: 0x00023C39
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableResourceInvoker._members;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00025A40 File Offset: 0x00023C40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableResourceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00025A4C File Offset: 0x00023C4C
		public override Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(DrawableResourceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00025A7E File Offset: 0x00023C7E
		public override int Size
		{
			[Register("getSize", "()I", "GetGetSizeHandler")]
			get
			{
				return DrawableResourceInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00025A97 File Offset: 0x00023C97
		[Register("recycle", "()V", "GetRecycleHandler")]
		public override void Recycle()
		{
			DrawableResourceInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x040002ED RID: 749
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/DrawableResource", typeof(DrawableResourceInvoker));
	}
}
