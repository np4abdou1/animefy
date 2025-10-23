using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000032 RID: 50
	[JniTypeSignature("C", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaCharArray : JavaPrimitiveArray<char>
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0000B09F File Offset: 0x0000929F
		public JavaCharArray(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000B0AC File Offset: 0x000092AC
		public unsafe JavaCharArray(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewCharArray(JavaArray<char>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000B0DA File Offset: 0x000092DA
		public JavaCharArray(IList<char> value) : this(JavaArray<char>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<char>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000B0FC File Offset: 0x000092FC
		public unsafe JniCharArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			char* charArrayElements = JniEnvironment.Arrays.GetCharArrayElements(base.PeerReference, null);
			if (charArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetCharArrayElements()` returned NULL!");
			}
			return new JniCharArrayElements(base.PeerReference, charArrayElements, base.Length * 2);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000B15C File Offset: 0x0000935C
		public unsafe override int IndexOf(char item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniCharArrayElements elements = this.GetElements())
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

		// Token: 0x06000259 RID: 601 RVA: 0x0000B1C0 File Offset: 0x000093C0
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniCharArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = '\0';
				}
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000B20C File Offset: 0x0000940C
		public unsafe override void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<char>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (char[] array = destinationArray)
			{
				char* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetCharArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000B26C File Offset: 0x0000946C
		public unsafe override void CopyFrom(char[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<char>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (char[] array = sourceArray)
			{
				char* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetCharArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000B2CC File Offset: 0x000094CC
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<char>) == targetType || typeof(JavaCharArray) == targetType;
		}

		// Token: 0x04000091 RID: 145
		internal static readonly JavaCharArray.ValueMarshaler ArrayMarshaler = new JavaCharArray.ValueMarshaler();

		// Token: 0x02000033 RID: 51
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<char>>
		{
			// Token: 0x0600025E RID: 606 RVA: 0x0000B307 File Offset: 0x00009507
			public override IList<char> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<char>.CreateValue<JavaCharArray>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaCharArray(ref h, o);
				});
			}

			// Token: 0x0600025F RID: 607 RVA: 0x0000B330 File Offset: 0x00009530
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<char> value, ParameterAttributes synchronize)
			{
				return JavaArray<char>.CreateArgumentState<JavaCharArray>(value, synchronize, delegate(IList<char> list, bool copy)
				{
					JavaCharArray javaCharArray = copy ? new JavaCharArray(list) : new JavaCharArray(list.Count);
					javaCharArray.forMarshalCollection = true;
					return javaCharArray;
				});
			}

			// Token: 0x06000260 RID: 608 RVA: 0x0000B358 File Offset: 0x00009558
			public override void DestroyGenericArgumentState(IList<char> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<char>.DestroyArgumentState<JavaCharArray>(value, ref state, synchronize);
			}
		}
	}
}
