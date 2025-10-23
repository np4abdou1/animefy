using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000046 RID: 70
	[JniTypeSignature("D", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaDoubleArray : JavaPrimitiveArray<double>
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0000C126 File Offset: 0x0000A326
		public JavaDoubleArray(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000C130 File Offset: 0x0000A330
		public unsafe JavaDoubleArray(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewDoubleArray(JavaArray<double>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000C15E File Offset: 0x0000A35E
		public JavaDoubleArray(IList<double> value) : this(JavaArray<double>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<double>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000C180 File Offset: 0x0000A380
		public unsafe JniDoubleArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			double* doubleArrayElements = JniEnvironment.Arrays.GetDoubleArrayElements(base.PeerReference, null);
			if (doubleArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetDoubleArrayElements()` returned NULL!");
			}
			return new JniDoubleArrayElements(base.PeerReference, doubleArrayElements, base.Length * 8);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		public unsafe override int IndexOf(double item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniDoubleArrayElements elements = this.GetElements())
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

		// Token: 0x060002C7 RID: 711 RVA: 0x0000C244 File Offset: 0x0000A444
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniDoubleArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = 0.0;
				}
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000C298 File Offset: 0x0000A498
		public unsafe override void CopyTo(int sourceIndex, double[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<double>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (double[] array = destinationArray)
			{
				double* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetDoubleArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		public unsafe override void CopyFrom(double[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<double>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (double[] array = sourceArray)
			{
				double* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetDoubleArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000C358 File Offset: 0x0000A558
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<double>) == targetType || typeof(JavaDoubleArray) == targetType;
		}

		// Token: 0x040000AA RID: 170
		internal static readonly JavaDoubleArray.ValueMarshaler ArrayMarshaler = new JavaDoubleArray.ValueMarshaler();

		// Token: 0x02000047 RID: 71
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<double>>
		{
			// Token: 0x060002CC RID: 716 RVA: 0x0000C393 File Offset: 0x0000A593
			public override IList<double> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<double>.CreateValue<JavaDoubleArray>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaDoubleArray(ref h, o);
				});
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0000C3BC File Offset: 0x0000A5BC
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<double> value, ParameterAttributes synchronize)
			{
				return JavaArray<double>.CreateArgumentState<JavaDoubleArray>(value, synchronize, delegate(IList<double> list, bool copy)
				{
					JavaDoubleArray javaDoubleArray = copy ? new JavaDoubleArray(list) : new JavaDoubleArray(list.Count);
					javaDoubleArray.forMarshalCollection = true;
					return javaDoubleArray;
				});
			}

			// Token: 0x060002CE RID: 718 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
			public override void DestroyGenericArgumentState(IList<double> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<double>.DestroyArgumentState<JavaDoubleArray>(value, ref state, synchronize);
			}
		}
	}
}
