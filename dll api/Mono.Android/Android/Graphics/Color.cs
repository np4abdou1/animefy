using System;
using Java.Interop;

namespace Android.Graphics
{
	// Token: 0x02000232 RID: 562
	[JniValueMarshaler(typeof(ColorValueMarshaler))]
	public struct Color
	{
		// Token: 0x060013CA RID: 5066 RVA: 0x00033371 File Offset: 0x00031571
		public Color(int argb)
		{
			this.color = argb;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00033371 File Offset: 0x00031571
		private Color(uint argb)
		{
			this.color = (int)argb;
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0003337A File Offset: 0x0003157A
		public byte A
		{
			get
			{
				return (byte)(this.color >> 24);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00033386 File Offset: 0x00031586
		public byte B
		{
			get
			{
				return (byte)this.color;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0003338F File Offset: 0x0003158F
		public byte G
		{
			get
			{
				return (byte)(this.color >> 8);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0003339A File Offset: 0x0003159A
		public byte R
		{
			get
			{
				return (byte)(this.color >> 16);
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000333A6 File Offset: 0x000315A6
		public int ToArgb()
		{
			return this.color;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x000333B0 File Offset: 0x000315B0
		public override string ToString()
		{
			return string.Format("Color [A={0}, R={1}, G={2}, B={3}]", new object[]
			{
				this.A,
				this.R,
				this.G,
				this.B
			});
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00033408 File Offset: 0x00031608
		public override bool Equals(object obj)
		{
			if (!(obj is Color))
			{
				return false;
			}
			Color right = (Color)obj;
			return this == right;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00033432 File Offset: 0x00031632
		public static bool operator ==(Color left, Color right)
		{
			return left.color == right.color;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000333A6 File Offset: 0x000315A6
		public static implicit operator int(Color c)
		{
			return c.color;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000333A6 File Offset: 0x000315A6
		public override int GetHashCode()
		{
			return this.color;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00033442 File Offset: 0x00031642
		public static Color ParseColor(string colorString)
		{
			return new Color(ColorObject.ParseColor(colorString));
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0003344F File Offset: 0x0003164F
		public static Color Black
		{
			get
			{
				return new Color(4278190080U);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0003345B File Offset: 0x0003165B
		public static Color Gold
		{
			get
			{
				return new Color(4294956800U);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00033467 File Offset: 0x00031667
		public static Color Red
		{
			get
			{
				return new Color(4294901760U);
			}
		}

		// Token: 0x040008BC RID: 2236
		private int color;
	}
}
