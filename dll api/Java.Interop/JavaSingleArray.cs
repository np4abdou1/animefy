using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000042 RID: 66
	[JniTypeSignature("F", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaSingleArray : JavaPrimitiveArray<float>
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0000BDD6 File Offset: 0x00009FD6
		public JavaSingleArray(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public unsafe JavaSingleArray(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewFloatArray(JavaArray<float>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000BE0E File Offset: 0x0000A00E
		public JavaSingleArray(IList<float> value) : this(JavaArray<float>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<float>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000BE30 File Offset: 0x0000A030
		public unsafe JniSingleArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			float* floatArrayElements = JniEnvironment.Arrays.GetFloatArrayElements(base.PeerReference, null);
			if (floatArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetFloatArrayElements()` returned NULL!");
			}
			return new JniSingleArrayElements(base.PeerReference, floatArrayElements, base.Length * 4);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000BE90 File Offset: 0x0000A090
		public unsafe override int IndexOf(float item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniSingleArrayElements elements = this.GetElements())
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

		// Token: 0x060002B1 RID: 689 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniSingleArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = 0f;
				}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000BF44 File Offset: 0x0000A144
		public unsafe override void CopyTo(int sourceIndex, float[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<float>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (float[] array = destinationArray)
			{
				float* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetFloatArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		public unsafe override void CopyFrom(float[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<float>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (float[] array = sourceArray)
			{
				float* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetFloatArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000C004 File Offset: 0x0000A204
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<float>) == targetType || typeof(JavaSingleArray) == targetType;
		}

		// Token: 0x040000A5 RID: 165
		internal static readonly JavaSingleArray.ValueMarshaler ArrayMarshaler = new JavaSingleArray.ValueMarshaler();

		// Token: 0x02000043 RID: 67
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<float>>
		{
			// Token: 0x060002B6 RID: 694 RVA: 0x0000C03F File Offset: 0x0000A23F
			public override IList<float> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<float>.CreateValue<JavaSingleArray>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaSingleArray(ref h, o);
				});
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0000C068 File Offset: 0x0000A268
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<float> value, ParameterAttributes synchronize)
			{
				return JavaArray<float>.CreateArgumentState<JavaSingleArray>(value, synchronize, delegate(IList<float> list, bool copy)
				{
					JavaSingleArray javaSingleArray = copy ? new JavaSingleArray(list) : new JavaSingleArray(list.Count);
					javaSingleArray.forMarshalCollection = true;
					return javaSingleArray;
				});
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x0000C090 File Offset: 0x0000A290
			public override void DestroyGenericArgumentState(IList<float> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<float>.DestroyArgumentState<JavaSingleArray>(value, ref state, synchronize);
			}
		}
	}
}
