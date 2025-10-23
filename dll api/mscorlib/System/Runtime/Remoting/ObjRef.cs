using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
	/// <summary>Stores all relevant information required to generate a proxy in order to communicate with a remote object.</summary>
	// Token: 0x02000309 RID: 777
	[ComVisible(true)]
	[Serializable]
	public class ObjRef : IObjectReference, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class with default values.</summary>
		// Token: 0x06001974 RID: 6516 RVA: 0x0006EC3C File Offset: 0x0006CE3C
		public ObjRef()
		{
			this.UpdateChannelInfo();
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0006EC4A File Offset: 0x0006CE4A
		internal ObjRef(string uri, IChannelInfo cinfo)
		{
			this.uri = uri;
			this.channel_info = cinfo;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0006EC60 File Offset: 0x0006CE60
		internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo)
		{
			string text = string.Copy(this.uri);
			ChannelInfo cinfo = new ChannelInfo(new CrossAppDomainData(domainId));
			ObjRef objRef = new ObjRef(text, cinfo);
			IRemotingTypeInfo remotingTypeInfo = (IRemotingTypeInfo)CADSerializer.DeserializeObjectSafe(tInfo);
			objRef.typeInfo = remotingTypeInfo;
			return objRef;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0006EC9D File Offset: 0x0006CE9D
		internal byte[] SerializeType()
		{
			if (this.typeInfo == null)
			{
				throw new Exception("Attempt to serialize a null TypeInfo.");
			}
			return CADSerializer.SerializeObject(this.typeInfo).GetBuffer();
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0006ECC2 File Offset: 0x0006CEC2
		internal ObjRef(Type type, string url, object remoteChannelData)
		{
			this.uri = url;
			this.typeInfo = new TypeInfo(type);
			if (remoteChannelData != null)
			{
				this.channel_info = new ChannelInfo(remoteChannelData);
			}
			this.flags |= ObjRef.WellKnowObjectRef;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class from serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination of the exception. </param>
		// Token: 0x06001979 RID: 6521 RVA: 0x0006ED00 File Offset: 0x0006CF00
		protected ObjRef(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = true;
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				if (!(name == "uri"))
				{
					if (!(name == "typeInfo"))
					{
						if (!(name == "channelInfo"))
						{
							if (!(name == "envoyInfo"))
							{
								if (!(name == "fIsMarshalled"))
								{
									if (!(name == "objrefFlags"))
									{
										throw new NotSupportedException();
									}
									this.flags = Convert.ToInt32(enumerator.Value);
								}
								else
								{
									object value = enumerator.Value;
									int num;
									if (value is string)
									{
										num = ((IConvertible)value).ToInt32(null);
									}
									else
									{
										num = (int)value;
									}
									if (num == 0)
									{
										flag = false;
									}
								}
							}
							else
							{
								this.envoyInfo = (IEnvoyInfo)enumerator.Value;
							}
						}
						else
						{
							this.channel_info = (IChannelInfo)enumerator.Value;
						}
					}
					else
					{
						this.typeInfo = (IRemotingTypeInfo)enumerator.Value;
					}
				}
				else
				{
					this.uri = (string)enumerator.Value;
				}
			}
			if (flag)
			{
				this.flags |= ObjRef.MarshalledObjectRef;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0006EE33 File Offset: 0x0006D033
		internal bool IsReferenceToWellKnow
		{
			get
			{
				return (this.flags & ObjRef.WellKnowObjectRef) > 0;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Runtime.Remoting.IChannelInfo" /> for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.IChannelInfo" /> interface for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0006EE44 File Offset: 0x0006D044
		public virtual IChannelInfo ChannelInfo
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.channel_info;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Runtime.Remoting.IEnvoyInfo" /> for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.IEnvoyInfo" /> interface for the <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x0006EE4C File Offset: 0x0006D04C
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0006EE54 File Offset: 0x0006D054
		public virtual IEnvoyInfo EnvoyInfo
		{
			get
			{
				return this.envoyInfo;
			}
			set
			{
				this.envoyInfo = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Runtime.Remoting.IRemotingTypeInfo" /> for the object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.IRemotingTypeInfo" /> for the object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</returns>
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x0006EE5D File Offset: 0x0006D05D
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x0006EE65 File Offset: 0x0006D065
		public virtual IRemotingTypeInfo TypeInfo
		{
			get
			{
				return this.typeInfo;
			}
			set
			{
				this.typeInfo = value;
			}
		}

		/// <summary>Gets or sets the URI of the specific object instance.</summary>
		/// <returns>The URI of the specific object instance.</returns>
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0006EE6E File Offset: 0x0006D06E
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0006EE76 File Offset: 0x0006D076
		public virtual string URI
		{
			get
			{
				return this.uri;
			}
			set
			{
				this.uri = value;
			}
		}

		/// <summary>Populates a specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the current <see cref="T:System.Runtime.Remoting.ObjRef" /> instance.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="context">The contextual information about the source or destination of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have serialization formatter permission. </exception>
		// Token: 0x06001982 RID: 6530 RVA: 0x0006EE80 File Offset: 0x0006D080
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(base.GetType());
			info.AddValue("uri", this.uri);
			info.AddValue("typeInfo", this.typeInfo, typeof(IRemotingTypeInfo));
			info.AddValue("envoyInfo", this.envoyInfo, typeof(IEnvoyInfo));
			info.AddValue("channelInfo", this.channel_info, typeof(IChannelInfo));
			info.AddValue("objrefFlags", this.flags);
		}

		/// <summary>Returns a reference to the remote object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</summary>
		/// <param name="context">The context where the current object resides. </param>
		/// <returns>A reference to the remote object that the <see cref="T:System.Runtime.Remoting.ObjRef" /> describes.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have serialization formatter permission. </exception>
		// Token: 0x06001983 RID: 6531 RVA: 0x0006EF0C File Offset: 0x0006D10C
		public virtual object GetRealObject(StreamingContext context)
		{
			if ((this.flags & ObjRef.MarshalledObjectRef) > 0)
			{
				return RemotingServices.Unmarshal(this);
			}
			return this;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0006EF25 File Offset: 0x0006D125
		internal void UpdateChannelInfo()
		{
			this.channel_info = new ChannelInfo();
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x0006EF32 File Offset: 0x0006D132
		internal Type ServerType
		{
			get
			{
				if (this._serverType == null)
				{
					this._serverType = Type.GetType(this.typeInfo.TypeName);
				}
				return this._serverType;
			}
		}

		// Token: 0x04000A9D RID: 2717
		private IChannelInfo channel_info;

		// Token: 0x04000A9E RID: 2718
		private string uri;

		// Token: 0x04000A9F RID: 2719
		private IRemotingTypeInfo typeInfo;

		// Token: 0x04000AA0 RID: 2720
		private IEnvoyInfo envoyInfo;

		// Token: 0x04000AA1 RID: 2721
		private int flags;

		// Token: 0x04000AA2 RID: 2722
		private Type _serverType;

		// Token: 0x04000AA3 RID: 2723
		private static int MarshalledObjectRef = 1;

		// Token: 0x04000AA4 RID: 2724
		private static int WellKnowObjectRef = 2;
	}
}
