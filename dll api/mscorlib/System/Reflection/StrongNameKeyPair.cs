using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Reflection
{
	/// <summary>Encapsulates access to a public or private key pair used to sign strong name assemblies.</summary>
	// Token: 0x020004E6 RID: 1254
	[ComVisible(true)]
	[Serializable]
	public class StrongNameKeyPair : ISerializable, IDeserializationCallback
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.StrongNameKeyPair" /> class, building the key pair from serialized data.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
		// Token: 0x06002412 RID: 9234 RVA: 0x0008ED50 File Offset: 0x0008CF50
		protected StrongNameKeyPair(SerializationInfo info, StreamingContext context)
		{
			this._publicKey = (byte[])info.GetValue("_publicKey", typeof(byte[]));
			this._keyPairContainer = info.GetString("_keyPairContainer");
			this._keyPairExported = info.GetBoolean("_keyPairExported");
			this._keyPairArray = (byte[])info.GetValue("_keyPairArray", typeof(byte[]));
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data required to reinstantiate the current <see cref="T:System.Reflection.StrongNameKeyPair" /> object.</summary>
		/// <param name="info">The object to be populated with serialization information.</param>
		/// <param name="context">The destination context of the serialization.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06002413 RID: 9235 RVA: 0x0008EDC8 File Offset: 0x0008CFC8
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_publicKey", this._publicKey, typeof(byte[]));
			info.AddValue("_keyPairContainer", this._keyPairContainer);
			info.AddValue("_keyPairExported", this._keyPairExported);
			info.AddValue("_keyPairArray", this._keyPairArray, typeof(byte[]));
		}

		/// <summary>Runs when the entire object graph has been deserialized.</summary>
		/// <param name="sender">The object that initiated the callback.</param>
		// Token: 0x06002414 RID: 9236 RVA: 0x00002A7D File Offset: 0x00000C7D
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0008EE30 File Offset: 0x0008D030
		private RSA GetRSA()
		{
			if (this._rsa != null)
			{
				return this._rsa;
			}
			if (this._keyPairArray != null)
			{
				try
				{
					this._rsa = CryptoConvert.FromCapiKeyBlob(this._keyPairArray);
				}
				catch
				{
					this._keyPairArray = null;
				}
			}
			return this._rsa;
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x0008EE88 File Offset: 0x0008D088
		internal StrongName StrongName()
		{
			RSA rsa = this.GetRSA();
			if (rsa != null)
			{
				return new StrongName(rsa);
			}
			if (this._publicKey != null)
			{
				return new StrongName(this._publicKey);
			}
			return null;
		}

		// Token: 0x04001158 RID: 4440
		private byte[] _publicKey;

		// Token: 0x04001159 RID: 4441
		private string _keyPairContainer;

		// Token: 0x0400115A RID: 4442
		private bool _keyPairExported;

		// Token: 0x0400115B RID: 4443
		private byte[] _keyPairArray;

		// Token: 0x0400115C RID: 4444
		[NonSerialized]
		private RSA _rsa;
	}
}
