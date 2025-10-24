using System;
using Android.Graphics;
using Bumptech.Glide.Load.Engine;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource
{
	// Token: 0x020000E1 RID: 225
	internal class ImageDecoderResourceDecoder
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x000233F3 File Offset: 0x000215F3
		public IResource Decode(Java.Lang.Object source, int requestedWidth, int requestedHeight, Options options)
		{
			return this.Decode((ImageDecoder.Source)source, requestedWidth, requestedHeight, options);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00023405 File Offset: 0x00021605
		public bool Handles(Java.Lang.Object source, Options options)
		{
			return this.Handles((ImageDecoder.Source)source, options);
		}
	}
}
