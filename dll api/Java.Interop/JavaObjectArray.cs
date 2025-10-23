using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200000D RID: 13
	public class JavaObjectArray<T> : JavaArray<T>
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000026EF File Offset: 0x000008EF
		public JavaObjectArray(ref JniObjectReference handle, JniObjectReferenceOptions options) : base(ref handle, options)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002ECC File Offset: 0x000010CC
		private static JniObjectReference NewArray(int length)
		{
			JniTypeSignature jniTypeSignature = JniEnvironment.Runtime.TypeManager.GetTypeSignature(typeof(T));
			if (jniTypeSignature.SimpleReference == null)
			{
				jniTypeSignature = new JniTypeSignature("java/lang/Object", jniTypeSignature.ArrayRank, false);
			}
			if (jniTypeSignature.IsKeyword && jniTypeSignature.ArrayRank == 0)
			{
				jniTypeSignature = jniTypeSignature.GetPrimitivePeerTypeSignature();
			}
			JniObjectReference jniObjectReference;
			using (JniType jniType = new JniType(jniTypeSignature.Name))
			{
				JniObjectReference peerReference = jniType.PeerReference;
				jniObjectReference = default(JniObjectReference);
				jniObjectReference = JniEnvironment.Arrays.NewObjectArray(length, peerReference, jniObjectReference);
			}
			return jniObjectReference;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002F6C File Offset: 0x0000116C
		public unsafe JavaObjectArray(int length) : this(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			JniObjectReference jniObjectReference = JavaObjectArray<T>.NewArray(JavaArray<T>.CheckLength(length));
			base.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002F9C File Offset: 0x0000119C
		public JavaObjectArray(IList<T> value) : this(JavaArray<T>.CheckLength(value))
		{
			for (int i = 0; i < value.Count; i++)
			{
				this.SetElementAt(i, value[i]);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000026F9 File Offset: 0x000008F9
		public override void DisposeUnlessReferenced()
		{
			if (this.forMarshalCollection)
			{
				base.Dispose();
				return;
			}
			base.DisposeUnlessReferenced();
		}

		// Token: 0x1700001F RID: 31
		public override T this[int index]
		{
			get
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException("index", "index < 0 || index >= Length");
				}
				return this.GetElementAt(index);
			}
			set
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException("index", "index < 0 || index >= Length");
				}
				this.SetElementAt(index, value);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003024 File Offset: 0x00001224
		private T GetElementAt(int index)
		{
			JniObjectReference objectArrayElement = JniEnvironment.Arrays.GetObjectArrayElement(base.PeerReference, index);
			return JniEnvironment.Runtime.ValueManager.GetValue<T>(ref objectArrayElement, JniObjectReferenceOptions.CopyAndDispose, null);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003054 File Offset: 0x00001254
		private void SetElementAt(int index, T value)
		{
			JniValueMarshaler<T> valueMarshaler = JniEnvironment.Runtime.ValueManager.GetValueMarshaler<T>();
			JniValueMarshalerState jniValueMarshalerState = valueMarshaler.CreateGenericObjectReferenceArgumentState(value, ParameterAttributes.None);
			JniEnvironment.Arrays.SetObjectArrayElement(base.PeerReference, index, jniValueMarshalerState.ReferenceValue);
			valueMarshaler.DestroyGenericArgumentState(value, ref jniValueMarshalerState, ParameterAttributes.None);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003095 File Offset: 0x00001295
		public override IEnumerator<T> GetEnumerator()
		{
			int len = base.Length;
			int num;
			for (int i = 0; i < len; i = num)
			{
				yield return this.GetElementAt(i);
				num = i + 1;
			}
			yield break;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000030A4 File Offset: 0x000012A4
		public override void Clear()
		{
			int length = base.Length;
			JniValueMarshaler<T> valueMarshaler = JniEnvironment.Runtime.ValueManager.GetValueMarshaler<T>();
			JniValueMarshalerState jniValueMarshalerState = valueMarshaler.CreateArgumentState(default(T), ParameterAttributes.None);
			for (int i = 0; i < length; i++)
			{
				JniEnvironment.Arrays.SetObjectArrayElement(base.PeerReference, i, jniValueMarshalerState.ReferenceValue);
			}
			valueMarshaler.DestroyGenericArgumentState(default(T), ref jniValueMarshalerState, ParameterAttributes.None);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003114 File Offset: 0x00001314
		public override int IndexOf(T item)
		{
			int length = base.Length;
			for (int i = 0; i < length; i++)
			{
				T elementAt = this.GetElementAt(i);
				try
				{
					if (EqualityComparer<T>.Default.Equals(item, elementAt) || JniMarshal.RecursiveEquals(item, elementAt))
					{
						return i;
					}
				}
				finally
				{
					IJavaPeerable javaPeerable = elementAt as IJavaPeerable;
					if (javaPeerable != null)
					{
						javaPeerable.DisposeUnlessReferenced();
					}
				}
			}
			return -1;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003190 File Offset: 0x00001390
		public override void CopyTo(T[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			JavaArray<T>.CheckArrayCopy(0, base.Length, arrayIndex, array.Length, base.Length);
			this.CopyToList(array, arrayIndex);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000031C0 File Offset: 0x000013C0
		internal override void CopyToList(IList<T> list, int index)
		{
			int length = base.Length;
			for (int i = 0; i < length; i++)
			{
				T elementAt = this.GetElementAt(i);
				list[index + i] = elementAt;
				if (this.forMarshalCollection)
				{
					IJavaPeerable javaPeerable = elementAt as IJavaPeerable;
					if (javaPeerable != null)
					{
						javaPeerable.DisposeUnlessReferenced();
					}
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000320F File Offset: 0x0000140F
		internal override bool TargetTypeIsCurrentType(Type targetType)
		{
			return base.TargetTypeIsCurrentType(targetType) || targetType == typeof(JavaObjectArray<T>);
		}

		// Token: 0x0400001D RID: 29
		internal static readonly JavaObjectArray<T>.ValueMarshaler Instance = new JavaObjectArray<T>.ValueMarshaler();

		// Token: 0x0200000E RID: 14
		internal sealed class ValueMarshaler : JniValueMarshaler<IList<T>>
		{
			// Token: 0x06000099 RID: 153 RVA: 0x00003238 File Offset: 0x00001438
			public override IList<T> CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
			{
				return JavaArray<T>.CreateValue<JavaObjectArray<T>>(ref reference, options, targetType, delegate(ref JniObjectReference h, JniObjectReferenceOptions t)
				{
					return new JavaObjectArray<T>(ref h, t)
					{
						forMarshalCollection = true
					};
				});
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00003261 File Offset: 0x00001461
			public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IList<T> value, ParameterAttributes synchronize)
			{
				return JavaArray<T>.CreateArgumentState<JavaObjectArray<T>>(value, synchronize, delegate(IList<T> list, bool copy)
				{
					JavaObjectArray<T> javaObjectArray = copy ? new JavaObjectArray<T>(list) : new JavaObjectArray<T>(list.Count);
					javaObjectArray.forMarshalCollection = true;
					return javaObjectArray;
				});
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00003289 File Offset: 0x00001489
			public override void DestroyGenericArgumentState(IList<T> value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
			{
				JavaArray<T>.DestroyArgumentState<JavaObjectArray<T>>(value, ref state, synchronize);
			}
		}
	}
}
