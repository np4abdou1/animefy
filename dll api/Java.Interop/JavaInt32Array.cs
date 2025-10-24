using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200003A RID: 58
	[JniTypeSignature("I", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaInt32Array : JavaPrimitiveArray<int>
	{
		// Token: 0x06000280 RID: 640 RVA: 0x0000B73A File Offset: 0x0000993A
		public JavaInt32Array(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000B744 File Offset: 0x00009944
		public unsafe JavaInt32Array(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewIntArray(JavaArray<int>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000B772 File Offset: 0x00009972
		public JavaInt32Array(IList<int> value) : this(JavaArray<int>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<int>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000B794 File Offset: 0x00009994
		public unsafe JniInt32ArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			int* intArrayElements = JniEnvironment.Arrays.GetIntArrayElements(base.PeerReference, null);
			if (intArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetIntArrayElements()` returned NULL!");
			}
			return new JniInt32ArrayElements(base.PeerReference, intArrayElements, base.Length * 4);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000B7F4 File Offset: 0x000099F4
		public unsafe override int IndexOf(int item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniInt32ArrayElements elements = this.GetElements())
			{
				if (elements == null)
				{
					return -1;
				}
				for (int i = 0; i < length; i++)
				{
					if (*elements[i] == item)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000B858 File Offset: 0x00009A58
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniInt32ArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = 0;
				}
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		public unsafe override void CopyTo(int sourceIndex, int[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<int>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (int[] array = destinationArray)
			{
				int* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetIntArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000B904 File Offset: 0x00009B04
		public unsafe override void CopyFrom(int[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<int>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (int[] array = sourceArray)
			{
				int* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetIntArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000B964 File Offset: 0x00009B64
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<int>) == targetType || typeof(JavaInt32Array) == targetType;
		}

		// Token: 0x0400009B RID: 155
		internal static readonly JavaInt32Array.ValueMarshaler ArrayMarshaler = new JavaInt32Array.ValueMarshaler();

		// Token: 0x0200003B RID: 59
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<int>>
		{
			// Token: 0x0600028A RID: 650 RVA: 0x0000B99F File Offset: 0x00009B9F
			public override IList<int> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<int>.CreateValue<JavaInt32Array>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaInt32Array(ref h, o);
				});
			}

			// Token: 0x0600028B RID: 651 RVA: 0x0000B9C8 File Offset: 0x00009BC8
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<int> value, ParameterAttributes synchronize)
			{
				return JavaArray<int>.CreateArgumentState<JavaInt32Array>(value, synchronize, delegate(IList<int> list, bool copy)
				{
					JavaInt32Array javaInt32Array = copy ? new JavaInt32Array(list) : new JavaInt32Array(list.Count);
					javaInt32Array.forMarshalCollection = true;
					return javaInt32Array;
				});
			}

			// Token: 0x0600028C RID: 652 RVA: 0x0000B9F0 File Offset: 0x00009BF0
			public override void DestroyGenericArgumentState(IList<int> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<int>.DestroyArgumentState<JavaInt32Array>(value, ref state, synchronize);
			}
		}
	}
}
