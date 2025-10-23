using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003EF RID: 1007
	internal sealed class SerStack
	{
		// Token: 0x06001EF7 RID: 7927 RVA: 0x00085976 File Offset: 0x00083B76
		internal SerStack(string stackId)
		{
			this.stackId = stackId;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00085998 File Offset: 0x00083B98
		internal void Push(object obj)
		{
			if (this.top == this.objects.Length - 1)
			{
				this.IncreaseCapacity();
			}
			object[] array = this.objects;
			int num = this.top + 1;
			this.top = num;
			array[num] = obj;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000859D8 File Offset: 0x00083BD8
		internal object Pop()
		{
			if (this.top < 0)
			{
				return null;
			}
			object result = this.objects[this.top];
			object[] array = this.objects;
			int num = this.top;
			this.top = num - 1;
			array[num] = null;
			return result;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00085A18 File Offset: 0x00083C18
		internal void IncreaseCapacity()
		{
			object[] destinationArray = new object[this.objects.Length * 2];
			Array.Copy(this.objects, 0, destinationArray, 0, this.objects.Length);
			this.objects = destinationArray;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00085A52 File Offset: 0x00083C52
		internal object Peek()
		{
			if (this.top < 0)
			{
				return null;
			}
			return this.objects[this.top];
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00085A6C File Offset: 0x00083C6C
		internal object PeekPeek()
		{
			if (this.top < 1)
			{
				return null;
			}
			return this.objects[this.top - 1];
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00085A88 File Offset: 0x00083C88
		internal bool IsEmpty()
		{
			return this.top <= 0;
		}

		// Token: 0x04000E3F RID: 3647
		internal object[] objects = new object[5];

		// Token: 0x04000E40 RID: 3648
		internal string stackId;

		// Token: 0x04000E41 RID: 3649
		internal int top = -1;
	}
}
