using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200002A RID: 42
	[JniTypeSignature("Z", ArrayRank = 1, IsKeyword = true)]
	public sealed class JavaBooleanArray : JavaPrimitiveArray<bool>
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000AA0D File Offset: 0x00008C0D
		public JavaBooleanArray(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000AA18 File Offset: 0x00008C18
		public unsafe JavaBooleanArray(int length) : base(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewBooleanArray(JavaArray<bool>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000AA46 File Offset: 0x00008C46
		public JavaBooleanArray(IList<bool> value) : this(JavaArray<bool>.CheckLength(value))
		{
			this.CopyFrom(JavaPrimitiveArray<bool>.ToArray(value), 0, 0, value.Count);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000AA68 File Offset: 0x00008C68
		public unsafe JniBooleanArrayElements GetElements()
		{
			if (!base.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			bool* booleanArrayElements = JniEnvironment.Arrays.GetBooleanArrayElements(base.PeerReference, null);
			if (booleanArrayElements == null)
			{
				throw new InvalidOperationException("`JniEnvironment.Arrays.GetBooleanArrayElements()` returned NULL!");
			}
			return new JniBooleanArrayElements(base.PeerReference, booleanArrayElements, base.Length);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		public unsafe override int IndexOf(bool item)
		{
			int length = base.Length;
			if (length == 0)
			{
				return -1;
			}
			using (JniBooleanArrayElements elements = this.GetElements())
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

		// Token: 0x0600022D RID: 557 RVA: 0x0000AB2C File Offset: 0x00008D2C
		public unsafe override void Clear()
		{
			int length = base.Length;
			using (JniBooleanArrayElements elements = this.GetElements())
			{
				for (int i = 0; i < length; i++)
				{
					*elements[i] = false;
				}
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000AB78 File Offset: 0x00008D78
		public unsafe override void CopyTo(int sourceIndex, bool[] destinationArray, int destinationIndex, int length)
		{
			if (destinationArray == null)
			{
				throw new ArgumentNullException("destinationArray");
			}
			JavaArray<bool>.CheckArrayCopy(sourceIndex, base.Length, destinationIndex, destinationArray.Length, length);
			if (destinationArray.Length == 0)
			{
				return;
			}
			fixed (bool[] array = destinationArray)
			{
				bool* ptr;
				if (destinationArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.GetBooleanArrayRegion(base.PeerReference, sourceIndex, length, ptr + destinationIndex);
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		public unsafe override void CopyFrom(bool[] sourceArray, int sourceIndex, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				throw new ArgumentNullException("sourceArray");
			}
			JavaArray<bool>.CheckArrayCopy(sourceIndex, sourceArray.Length, destinationIndex, base.Length, length);
			if (sourceArray.Length == 0)
			{
				return;
			}
			fixed (bool[] array = sourceArray)
			{
				bool* ptr;
				if (sourceArray == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				JniEnvironment.Arrays.SetBooleanArrayRegion(base.PeerReference, destinationIndex, length, ptr + sourceIndex);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000AC35 File Offset: 0x00008E35
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || typeof(JavaPrimitiveArray<bool>) == targetType || typeof(JavaBooleanArray) == targetType;
		}

		// Token: 0x04000087 RID: 135
		internal static readonly JavaBooleanArray.ValueMarshaler ArrayMarshaler = new JavaBooleanArray.ValueMarshaler();

		// Token: 0x0200002B RID: 43
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<bool>>
		{
			// Token: 0x06000232 RID: 562 RVA: 0x0000AC70 File Offset: 0x00008E70
			public override IList<bool> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<bool>.CreateValue<JavaBooleanArray>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions o)
				{
					return new JavaBooleanArray(ref h, o);
				});
			}

			// Token: 0x06000233 RID: 563 RVA: 0x0000AC99 File Offset: 0x00008E99
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<bool> value, ParameterAttributes synchronize)
			{
				return JavaArray<bool>.CreateArgumentState<JavaBooleanArray>(value, synchronize, delegate(IList<bool> list, bool copy)
				{
					JavaBooleanArray javaBooleanArray = copy ? new JavaBooleanArray(list) : new JavaBooleanArray(list.Count);
					javaBooleanArray.forMarshalCollection = true;
					return javaBooleanArray;
				});
			}

			// Token: 0x06000234 RID: 564 RVA: 0x0000ACC1 File Offset: 0x00008EC1
			public override void DestroyGenericArgumentState(IList<bool> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<bool>.DestroyArgumentState<JavaBooleanArray>(value, ref state, synchronize);
			}
		}
	}
}
