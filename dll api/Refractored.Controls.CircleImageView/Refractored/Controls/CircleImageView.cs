using System;
using Android.Content;
using Android.Util;

namespace Refractored.Controls
{
	// Token: 0x02000002 RID: 2
	public class CircleImageView : _BaseCircleImageView
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public CircleImageView(Context context) : base(context)
		{
			this.Initialize();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205F File Offset: 0x0000025F
		public CircleImageView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			this.Initialize();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206F File Offset: 0x0000026F
		public CircleImageView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			this.Initialize();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		private void Initialize()
		{
		}
	}
}
