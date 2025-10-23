using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F1 RID: 1009
	[Serializable]
	internal sealed class IntSizedArray : ICloneable
	{
		// Token: 0x06001F05 RID: 7941 RVA: 0x00085C70 File Offset: 0x00083E70
		public IntSizedArray()
		{
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00085C94 File Offset: 0x00083E94
		private IntSizedArray(IntSizedArray sizedArray)
		{
			this.objects = new int[sizedArray.objects.Length];
			sizedArray.objects.CopyTo(this.objects, 0);
			this.negObjects = new int[sizedArray.negObjects.Length];
			sizedArray.negObjects.CopyTo(this.negObjects, 0);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00085D0A File Offset: 0x00083F0A
		public object Clone()
		{
			return new IntSizedArray(this);
		}

		// Token: 0x170003EF RID: 1007
		internal int this[int index]
		{
			get
			{
				if (index < 0)
				{
					if (-index > this.negObjects.Length - 1)
					{
						return 0;
					}
					return this.negObjects[-index];
				}
				else
				{
					if (index > this.objects.Length - 1)
					{
						return 0;
					}
					return this.objects[index];
				}
			}
			set
			{
				if (index < 0)
				{
					if (-index > this.negObjects.Length - 1)
					{
						this.IncreaseCapacity(index);
					}
					this.negObjects[-index] = value;
					return;
				}
				if (index > this.objects.Length - 1)
				{
					this.IncreaseCapacity(index);
				}
				this.objects[index] = value;
			}
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00085D9C File Offset: 0x00083F9C
		internal void IncreaseCapacity(int index)
		{
			try
			{
				if (index < 0)
				{
					int[] destinationArray = new int[Math.Max(this.negObjects.Length * 2, -index + 1)];
					Array.Copy(this.negObjects, 0, destinationArray, 0, this.negObjects.Length);
					this.negObjects = destinationArray;
				}
				else
				{
					int[] destinationArray2 = new int[Math.Max(this.objects.Length * 2, index + 1)];
					Array.Copy(this.objects, 0, destinationArray2, 0, this.objects.Length);
					this.objects = destinationArray2;
				}
			}
			catch (Exception)
			{
				throw new SerializationException(Environment.GetResourceString("Invalid BinaryFormatter stream."));
			}
		}

		// Token: 0x04000E44 RID: 3652
		internal int[] objects = new int[16];

		// Token: 0x04000E45 RID: 3653
		internal int[] negObjects = new int[4];
	}
}
