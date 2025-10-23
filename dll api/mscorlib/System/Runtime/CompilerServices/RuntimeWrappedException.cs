using System;
using System.Runtime.Serialization;

namespace System.Runtime.CompilerServices
{
	/// <summary>Wraps an exception that does not derive from the <see cref="T:System.Exception" /> class. This class cannot be inherited.</summary>
	// Token: 0x02000451 RID: 1105
	[Serializable]
	public sealed class RuntimeWrappedException : Exception
	{
		// Token: 0x06002018 RID: 8216 RVA: 0x00087F6F File Offset: 0x0008616F
		public RuntimeWrappedException(object thrownObject) : base("An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.")
		{
			base.HResult = -2146233026;
			this._wrappedException = thrownObject;
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00087F8E File Offset: 0x0008618E
		private RuntimeWrappedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._wrappedException = info.GetValue("WrappedException", typeof(object));
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with information about the exception.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
		// Token: 0x0600201A RID: 8218 RVA: 0x00087FB3 File Offset: 0x000861B3
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("WrappedException", this._wrappedException, typeof(object));
		}

		// Token: 0x04000F47 RID: 3911
		private object _wrappedException;
	}
}
