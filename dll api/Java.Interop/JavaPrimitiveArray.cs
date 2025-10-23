using System;
using System.Collections.Generic;
using System.Linq;

namespace Java.Interop
{
	// Token: 0x0200000A RID: 10
	public abstract class JavaPrimitiveArray<T> : JavaArray<T>
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000026EF File Offset: 0x000008EF
		internal JavaPrimitiveArray(ref JniObjectReference reference, JniObjectReferenceOptions transfer) : base(ref reference, transfer)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000026F9 File Offset: 0x000008F9
		public override void DisposeUnlessReferenced()
		{
			if (this.forMarshalCollection)
			{
				base.Dispose();
				return;
			}
			base.DisposeUnlessReferenced();
		}

		// Token: 0x0600004F RID: 79
		public abstract void CopyTo(int sourceIndex, T[] destinationArray, int destinationIndex, int length);

		// Token: 0x06000050 RID: 80
		public abstract void CopyFrom(T[] sourceArray, int sourceIndex, int destinationIndex, int length);

		// Token: 0x17000014 RID: 20
		public override T this[int index]
		{
			get
			{
				T[] array = new T[1];
				this.CopyTo(index, array, 0, array.Length);
				return array[0];
			}
			set
			{
				if (index >= base.Length)
				{
					throw new ArgumentOutOfRangeException("index", "index >= Length");
				}
				T[] array = new T[]
				{
					value
				};
				this.CopyFrom(array, 0, index, array.Length);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002779 File Offset: 0x00000979
		public override void CopyTo(T[] array, int arrayIndex)
		{
			this.CopyTo(0, array, arrayIndex, base.Length);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000278C File Offset: 0x0000098C
		internal static T[] ToArray(IEnumerable<T> value)
		{
			T[] array = value as T[];
			if (array != null)
			{
				return array;
			}
			return value.ToArray<T>();
		}
	}
}
