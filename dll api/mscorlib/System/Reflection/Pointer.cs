using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Provides a wrapper class for pointers.</summary>
	// Token: 0x020004B1 RID: 1201
	[CLSCompliant(false)]
	public sealed class Pointer : ISerializable
	{
		// Token: 0x06002190 RID: 8592 RVA: 0x0008A78F File Offset: 0x0008898F
		private unsafe Pointer(void* ptr, Type ptrType)
		{
			this._ptr = ptr;
			this._ptrType = ptrType;
		}

		/// <summary>Boxes the supplied unmanaged memory pointer and the type associated with that pointer into a managed <see cref="T:System.Reflection.Pointer" /> wrapper object. The value and the type are saved so they can be accessed from the native code during an invocation.</summary>
		/// <param name="ptr">The supplied unmanaged memory pointer. </param>
		/// <param name="type">The type associated with the <paramref name="ptr" /> parameter. </param>
		/// <returns>A pointer object.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not a pointer. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		// Token: 0x06002191 RID: 8593 RVA: 0x0008A7A8 File Offset: 0x000889A8
		public unsafe static object Box(void* ptr, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (!type.IsPointer)
			{
				throw new ArgumentException("Type must be a Pointer.", "ptr");
			}
			if (!type.IsRuntimeImplemented())
			{
				throw new ArgumentException("Type must be a type provided by the runtime.", "ptr");
			}
			return new Pointer(ptr, type);
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name, fusion log, and additional exception information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x06002192 RID: 8594 RVA: 0x0002FCDD File Offset: 0x0002DEDD
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x04001043 RID: 4163
		private unsafe readonly void* _ptr;

		// Token: 0x04001044 RID: 4164
		private readonly Type _ptrType;
	}
}
