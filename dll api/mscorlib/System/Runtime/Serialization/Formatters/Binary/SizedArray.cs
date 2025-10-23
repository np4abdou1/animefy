using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F0 RID: 1008
	[Serializable]
	internal sealed class SizedArray : ICloneable
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x00085A96 File Offset: 0x00083C96
		internal SizedArray()
		{
			this.objects = new object[16];
			this.negObjects = new object[4];
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00085AB7 File Offset: 0x00083CB7
		internal SizedArray(int length)
		{
			this.objects = new object[length];
			this.negObjects = new object[length];
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00085AD8 File Offset: 0x00083CD8
		private SizedArray(SizedArray sizedArray)
		{
			this.objects = new object[sizedArray.objects.Length];
			sizedArray.objects.CopyTo(this.objects, 0);
			this.negObjects = new object[sizedArray.negObjects.Length];
			sizedArray.negObjects.CopyTo(this.negObjects, 0);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00085B35 File Offset: 0x00083D35
		public object Clone()
		{
			return new SizedArray(this);
		}

		// Token: 0x170003EE RID: 1006
		internal object this[int index]
		{
			get
			{
				if (index < 0)
				{
					if (-index > this.negObjects.Length - 1)
					{
						return null;
					}
					return this.negObjects[-index];
				}
				else
				{
					if (index > this.objects.Length - 1)
					{
						return null;
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
				object obj = this.objects[index];
				this.objects[index] = value;
			}
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00085BCC File Offset: 0x00083DCC
		internal void IncreaseCapacity(int index)
		{
			try
			{
				if (index < 0)
				{
					object[] destinationArray = new object[Math.Max(this.negObjects.Length * 2, -index + 1)];
					Array.Copy(this.negObjects, 0, destinationArray, 0, this.negObjects.Length);
					this.negObjects = destinationArray;
				}
				else
				{
					object[] destinationArray2 = new object[Math.Max(this.objects.Length * 2, index + 1)];
					Array.Copy(this.objects, 0, destinationArray2, 0, this.objects.Length);
					this.objects = destinationArray2;
				}
			}
			catch (Exception)
			{
				throw new SerializationException(Environment.GetResourceString("Invalid BinaryFormatter stream."));
			}
		}

		// Token: 0x04000E42 RID: 3650
		internal object[] objects;

		// Token: 0x04000E43 RID: 3651
		internal object[] negObjects;
	}
}
