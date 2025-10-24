using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200003E RID: 62
	[JniTypeSignature("J", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaInt64Array : JavaPrimitiveArray<long>
	{
		// Token: 0x06000296 RID: 662 RVA: 0x0000BA86 File Offset: 0x00009C86
		public JavaInt64Array(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000BA90 File Offset: 0x00009C90
		public unsafe JavaInt64Array(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewLongArray(JavaArray<long>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000BABE File Offset: 0x00009CBE
		public JavaInt64Array(IList<long> value) : this(JavaArray<long>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<long>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		public unsafe JniInt64ArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			long* longArrayElements = JniEnvironment.Arrays.GetLongArrayElements(base.PeerReference, null);
			if (longArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetLongArrayElements()` returned NULL!");
			}
			return new JniInt64ArrayElements(base.PeerReference, longArrayElements, base.Length * 8);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000BB40 File Offset: 0x00009D40
		public unsafe override int IndexOf(long item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniInt64ArrayElements elements = this.GetElements())
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

		// Token: 0x0600029B RID: 667 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniInt64ArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = 0L;
				}
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		public unsafe override void CopyTo(int sourceIndex, long[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<long>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (long[] array = destinationArray)
			{
				long* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetLongArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000BC54 File Offset: 0x00009E54
		public unsafe override void CopyFrom(long[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<long>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (long[] array = sourceArray)
			{
				long* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetLongArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<long>) == targetType || typeof(JavaInt64Array) == targetType;
		}

		// Token: 0x040000A0 RID: 160
		internal static readonly JavaInt64Array.ValueMarshaler ArrayMarshaler = new JavaInt64Array.ValueMarshaler();

		// Token: 0x0200003F RID: 63
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<long>>
		{
			// Token: 0x060002A0 RID: 672 RVA: 0x0000BCEF File Offset: 0x00009EEF
			public override IList<long> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<long>.CreateValue<JavaInt64Array>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaInt64Array(ref h, o);
				});
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x0000BD18 File Offset: 0x00009F18
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<long> value, ParameterAttributes synchronize)
			{
				return JavaArray<long>.CreateArgumentState<JavaInt64Array>(value, synchronize, delegate(IList<long> list, bool copy)
				{
					JavaInt64Array javaInt64Array = copy ? new JavaInt64Array(list) : new JavaInt64Array(list.Count);
					javaInt64Array.forMarshalCollection = true;
					return javaInt64Array;
				});
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x0000BD40 File Offset: 0x00009F40
			public override void DestroyGenericArgumentState(IList<long> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<long>.DestroyArgumentState<JavaInt64Array>(value, ref state, synchronize);
			}
		}
	}
}
