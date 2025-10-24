using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200002E RID: 46
	[JniTypeSignature("B", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaSByteArray : JavaPrimitiveArray<sbyte>
	{
		// Token: 0x0600023E RID: 574 RVA: 0x0000AD54 File Offset: 0x00008F54
		public JavaSByteArray(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000AD60 File Offset: 0x00008F60
		public unsafe JavaSByteArray(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewByteArray(JavaArray<sbyte>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000AD8E File Offset: 0x00008F8E
		public JavaSByteArray(IList<sbyte> value) : this(JavaArray<sbyte>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<sbyte>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000ADB0 File Offset: 0x00008FB0
		public unsafe JniSByteArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			sbyte* byteArrayElements = JniEnvironment.Arrays.GetByteArrayElements(base.PeerReference, null);
			if (byteArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetByteArrayElements()` returned NULL!");
			}
			return new JniSByteArrayElements(base.PeerReference, byteArrayElements, base.Length);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000AE10 File Offset: 0x00009010
		public unsafe override int IndexOf(sbyte item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniSByteArrayElements elements = this.GetElements())
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

		// Token: 0x06000243 RID: 579 RVA: 0x0000AE74 File Offset: 0x00009074
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniSByteArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = 0;
				}
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000AEC0 File Offset: 0x000090C0
		public unsafe override void CopyTo(int sourceIndex, sbyte[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<sbyte>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (sbyte[] array = destinationArray)
			{
				sbyte* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetByteArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000AF20 File Offset: 0x00009120
		public unsafe override void CopyFrom(sbyte[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<sbyte>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (sbyte[] array = sourceArray)
			{
				sbyte* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetByteArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000AF7D File Offset: 0x0000917D
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<sbyte>) == targetType || typeof(JavaSByteArray) == targetType;
		}

		// Token: 0x0400008C RID: 140
		internal static readonly JavaSByteArray.ValueMarshaler ArrayMarshaler = new JavaSByteArray.ValueMarshaler();

		// Token: 0x0200002F RID: 47
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<sbyte>>
		{
			// Token: 0x06000248 RID: 584 RVA: 0x0000AFB8 File Offset: 0x000091B8
			public override IList<sbyte> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<sbyte>.CreateValue<JavaSByteArray>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaSByteArray(ref h, o);
				});
			}

			// Token: 0x06000249 RID: 585 RVA: 0x0000AFE1 File Offset: 0x000091E1
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<sbyte> value, ParameterAttributes synchronize)
			{
				return JavaArray<sbyte>.CreateArgumentState<JavaSByteArray>(value, synchronize, delegate(IList<sbyte> list, bool copy)
				{
					JavaSByteArray javaSByteArray = copy ? new JavaSByteArray(list) : new JavaSByteArray(list.Count);
					javaSByteArray.forMarshalCollection = true;
					return javaSByteArray;
				});
			}

			// Token: 0x0600024A RID: 586 RVA: 0x0000B009 File Offset: 0x00009209
			public override void DestroyGenericArgumentState(IList<sbyte> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<sbyte>.DestroyArgumentState<JavaSByteArray>(value, ref state, synchronize);
			}
		}
	}
}
