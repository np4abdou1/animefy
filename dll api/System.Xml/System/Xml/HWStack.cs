using System;

namespace System.Xml
{
	// Token: 0x0200015A RID: 346
	internal class HWStack : ICloneable
	{
		// Token: 0x06000CE6 RID: 3302 RVA: 0x0004EA5A File Offset: 0x0004CC5A
		internal HWStack(int GrowthRate) : this(GrowthRate, int.MaxValue)
		{
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0004EA68 File Offset: 0x0004CC68
		internal HWStack(int GrowthRate, int limit)
		{
			this.growthRate = GrowthRate;
			this.used = 0;
			this.stack = new object[GrowthRate];
			this.size = GrowthRate;
			this.limit = limit;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0004EA98 File Offset: 0x0004CC98
		internal object Push()
		{
			if (this.used == this.size)
			{
				if (this.limit <= this.used)
				{
					throw new XmlException("Stack overflow.", string.Empty);
				}
				object[] destinationArray = new object[this.size + this.growthRate];
				if (this.used > 0)
				{
					Array.Copy(this.stack, 0, destinationArray, 0, this.used);
				}
				this.stack = destinationArray;
				this.size += this.growthRate;
			}
			object[] array = this.stack;
			int num = this.used;
			this.used = num + 1;
			return array[num];
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0004EB33 File Offset: 0x0004CD33
		internal object Pop()
		{
			if (0 < this.used)
			{
				this.used--;
				return this.stack[this.used];
			}
			return null;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0004EB5B File Offset: 0x0004CD5B
		internal object Peek()
		{
			if (this.used <= 0)
			{
				return null;
			}
			return this.stack[this.used - 1];
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0004EB77 File Offset: 0x0004CD77
		internal void AddToTop(object o)
		{
			if (this.used > 0)
			{
				this.stack[this.used - 1] = o;
			}
		}

		// Token: 0x170002B5 RID: 693
		internal object this[int index]
		{
			get
			{
				if (index >= 0 && index < this.used)
				{
					return this.stack[index];
				}
				throw new IndexOutOfRangeException();
			}
			set
			{
				if (index >= 0 && index < this.used)
				{
					this.stack[index] = value;
					return;
				}
				throw new IndexOutOfRangeException();
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0004EBCD File Offset: 0x0004CDCD
		internal int Length
		{
			get
			{
				return this.used;
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0004EBD5 File Offset: 0x0004CDD5
		private HWStack(object[] stack, int growthRate, int used, int size)
		{
			this.stack = stack;
			this.growthRate = growthRate;
			this.used = used;
			this.size = size;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0004EBFA File Offset: 0x0004CDFA
		public object Clone()
		{
			return new HWStack((object[])this.stack.Clone(), this.growthRate, this.used, this.size);
		}

		// Token: 0x040008F0 RID: 2288
		private object[] stack;

		// Token: 0x040008F1 RID: 2289
		private int growthRate;

		// Token: 0x040008F2 RID: 2290
		private int used;

		// Token: 0x040008F3 RID: 2291
		private int size;

		// Token: 0x040008F4 RID: 2292
		private int limit;
	}
}
