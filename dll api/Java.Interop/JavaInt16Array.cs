using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000036 RID: 54
	[JniTypeSignature("S", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaInt16Array : JavaPrimitiveArray<short>
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0000B3EE File Offset: 0x000095EE
		public JavaInt16Array(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000B3F8 File Offset: 0x000095F8
		public unsafe JavaInt16Array(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewShortArray(JavaArray<short>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000B426 File Offset: 0x00009626
		public JavaInt16Array(IList<short> value) : this(JavaArray<short>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<short>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000B448 File Offset: 0x00009648
		public unsafe JniInt16ArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			short* shortArrayElements = JniEnvironment.Arrays.GetShortArrayElements(base.PeerReference, null);
			if (shortArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetShortArrayElements()` returned NULL!");
			}
			return new JniInt16ArrayElements(base.PeerReference, shortArrayElements, base.Length * 2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000B4A8 File Offset: 0x000096A8
		public unsafe override int IndexOf(short item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniInt16ArrayElements elements = this.GetElements())
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

		// Token: 0x0600026F RID: 623 RVA: 0x0000B50C File Offset: 0x0000970C
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniInt16ArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = 0;
				}
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000B558 File Offset: 0x00009758
		public unsafe override void CopyTo(int sourceIndex, short[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<short>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (short[] array = destinationArray)
			{
				short* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetShortArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000B5B8 File Offset: 0x000097B8
		public unsafe override void CopyFrom(short[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<short>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (short[] array = sourceArray)
			{
				short* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetShortArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000B618 File Offset: 0x00009818
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<short>) == targetType || typeof(JavaInt16Array) == targetType;
		}

		// Token: 0x04000096 RID: 150
		internal static readonly JavaInt16Array.ValueMarshaler ArrayMarshaler = new JavaInt16Array.ValueMarshaler();

		// Token: 0x02000037 RID: 55
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<short>>
		{
			// Token: 0x06000274 RID: 628 RVA: 0x0000B653 File Offset: 0x00009853
			public override IList<short> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<short>.CreateValue<JavaInt16Array>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaInt16Array(ref h, o);
				});
			}

			// Token: 0x06000275 RID: 629 RVA: 0x0000B67C File Offset: 0x0000987C
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<short> value, ParameterAttributes synchronize)
			{
				return JavaArray<short>.CreateArgumentState<JavaInt16Array>(value, synchronize, delegate(IList<short> list, bool copy)
				{
					JavaInt16Array javaInt16Array = copy ? new JavaInt16Array(list) : new JavaInt16Array(list.Count);
					javaInt16Array.forMarshalCollection = true;
					return javaInt16Array;
				});
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0000B6A4 File Offset: 0x000098A4
			public override void DestroyGenericArgumentState(IList<short> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<short>.DestroyArgumentState<JavaInt16Array>(value, ref state, synchronize);
			}
		}
	}
}
