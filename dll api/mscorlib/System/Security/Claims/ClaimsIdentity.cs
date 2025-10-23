using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;

namespace System.Security.Claims
{
	/// <summary>Represents a claims-based identity.</summary>
	// Token: 0x020002FA RID: 762
	[ComVisible(true)]
	[Serializable]
	public class ClaimsIdentity : IIdentity
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class with an empty claims collection.</summary>
		// Token: 0x06001929 RID: 6441 RVA: 0x0006DC27 File Offset: 0x0006BE27
		public ClaimsIdentity() : this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class using an enumerated collection of <see cref="T:System.Security.Claims.Claim" /> objects.</summary>
		/// <param name="claims">The claims with which to populate the claims identity.</param>
		// Token: 0x0600192A RID: 6442 RVA: 0x0006DC30 File Offset: 0x0006BE30
		public ClaimsIdentity(IEnumerable<Claim> claims) : this(null, claims, null, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class from the specified <see cref="T:System.Security.Principal.IIdentity" /> using the specified claims, authentication type, name claim type, and role claim type.</summary>
		/// <param name="identity">The identity from which to base the new claims identity.</param>
		/// <param name="claims">The claims with which to populate the new claims identity.</param>
		/// <param name="authenticationType">The type of authentication used.</param>
		/// <param name="nameType">The claim type to use for name claims.</param>
		/// <param name="roleType">The claim type to use for role claims.</param>
		// Token: 0x0600192B RID: 6443 RVA: 0x0006DC3D File Offset: 0x0006BE3D
		public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) : this(identity, claims, authenticationType, nameType, roleType, true)
		{
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0006DC50 File Offset: 0x0006BE50
		internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
		{
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			bool flag = false;
			bool flag2 = false;
			if (checkAuthType && identity != null && string.IsNullOrEmpty(authenticationType))
			{
				if (identity is WindowsIdentity)
				{
					try
					{
						this.m_authenticationType = identity.AuthenticationType;
						goto IL_85;
					}
					catch (UnauthorizedAccessException)
					{
						this.m_authenticationType = null;
						goto IL_85;
					}
				}
				this.m_authenticationType = identity.AuthenticationType;
			}
			else
			{
				this.m_authenticationType = authenticationType;
			}
			IL_85:
			if (!string.IsNullOrEmpty(nameType))
			{
				this.m_nameType = nameType;
				flag = true;
			}
			if (!string.IsNullOrEmpty(roleType))
			{
				this.m_roleType = roleType;
				flag2 = true;
			}
			ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
			if (claimsIdentity != null)
			{
				this.m_label = claimsIdentity.m_label;
				if (!flag)
				{
					this.m_nameType = claimsIdentity.m_nameType;
				}
				if (!flag2)
				{
					this.m_roleType = claimsIdentity.m_roleType;
				}
				this.m_bootstrapContext = claimsIdentity.m_bootstrapContext;
				if (claimsIdentity.Actor != null)
				{
					if (this.IsCircular(claimsIdentity.Actor))
					{
						throw new InvalidOperationException(Environment.GetResourceString("Actor cannot be set so that circular directed graph will exist chaining the subjects together."));
					}
					if (!AppContextSwitches.SetActorAsReferenceWhenCopyingClaimsIdentity)
					{
						this.m_actor = claimsIdentity.Actor.Clone();
					}
					else
					{
						this.m_actor = claimsIdentity.Actor;
					}
				}
				if (claimsIdentity is WindowsIdentity && !(this is WindowsIdentity))
				{
					this.SafeAddClaims(claimsIdentity.Claims);
				}
				else
				{
					this.SafeAddClaims(claimsIdentity.m_instanceClaims);
				}
				if (claimsIdentity.m_userSerializationData != null)
				{
					this.m_userSerializationData = (claimsIdentity.m_userSerializationData.Clone() as byte[]);
				}
			}
			else if (identity != null && !string.IsNullOrEmpty(identity.Name))
			{
				this.SafeAddClaim(new Claim(this.m_nameType, identity.Name, "http://www.w3.org/2001/XMLSchema#string", "LOCAL AUTHORITY", "LOCAL AUTHORITY", this));
			}
			if (claims != null)
			{
				this.SafeAddClaims(claims);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class from a serialized stream created by using <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary>
		/// <param name="info">The serialized data.</param>
		/// <param name="context">The context for serialization.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is null.</exception>
		// Token: 0x0600192D RID: 6445 RVA: 0x0006DE34 File Offset: 0x0006C034
		[SecurityCritical]
		protected ClaimsIdentity(SerializationInfo info, StreamingContext context)
		{
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.Deserialize(info, context, true);
		}

		/// <summary>Gets the authentication type.</summary>
		/// <returns>The authentication type.</returns>
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0006DE95 File Offset: 0x0006C095
		public virtual string AuthenticationType
		{
			get
			{
				return this.m_authenticationType;
			}
		}

		/// <summary>Gets or sets the identity of the calling party that was granted delegation rights.</summary>
		/// <returns>The calling party that was granted delegation rights.</returns>
		/// <exception cref="T:System.InvalidOperationException">An attempt to set the property to the current instance occurs.</exception>
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0006DE9D File Offset: 0x0006C09D
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0006DEA5 File Offset: 0x0006C0A5
		public ClaimsIdentity Actor
		{
			get
			{
				return this.m_actor;
			}
			set
			{
				if (value != null && this.IsCircular(value))
				{
					throw new InvalidOperationException(Environment.GetResourceString("Actor cannot be set so that circular directed graph will exist chaining the subjects together."));
				}
				this.m_actor = value;
			}
		}

		/// <summary>Gets the claims associated with this claims identity.</summary>
		/// <returns>The collection of claims associated with this claims identity.</returns>
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0006DECA File Offset: 0x0006C0CA
		public virtual IEnumerable<Claim> Claims
		{
			get
			{
				int num;
				for (int i = 0; i < this.m_instanceClaims.Count; i = num + 1)
				{
					yield return this.m_instanceClaims[i];
					num = i;
				}
				if (this.m_externalClaims != null)
				{
					for (int i = 0; i < this.m_externalClaims.Count; i = num + 1)
					{
						if (this.m_externalClaims[i] != null)
						{
							foreach (Claim claim in this.m_externalClaims[i])
							{
								yield return claim;
							}
							IEnumerator<Claim> enumerator = null;
						}
						num = i;
					}
				}
				yield break;
				yield break;
			}
		}

		/// <summary>Gets the name of this claims identity.</summary>
		/// <returns>The name or <see langword="null" />.</returns>
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0006DEDC File Offset: 0x0006C0DC
		public virtual string Name
		{
			get
			{
				Claim claim = this.FindFirst(this.m_nameType);
				if (claim != null)
				{
					return claim.Value;
				}
				return null;
			}
		}

		/// <summary>Returns a new <see cref="T:System.Security.Claims.ClaimsIdentity" /> copied from this claims identity.</summary>
		/// <returns>A copy of the current instance.</returns>
		// Token: 0x06001933 RID: 6451 RVA: 0x0006DF04 File Offset: 0x0006C104
		public virtual ClaimsIdentity Clone()
		{
			ClaimsIdentity claimsIdentity = new ClaimsIdentity(this.m_instanceClaims);
			claimsIdentity.m_authenticationType = this.m_authenticationType;
			claimsIdentity.m_bootstrapContext = this.m_bootstrapContext;
			claimsIdentity.m_label = this.m_label;
			claimsIdentity.m_nameType = this.m_nameType;
			claimsIdentity.m_roleType = this.m_roleType;
			if (this.Actor != null)
			{
				if (this.IsCircular(this.Actor))
				{
					throw new InvalidOperationException(Environment.GetResourceString("Actor cannot be set so that circular directed graph will exist chaining the subjects together."));
				}
				if (!AppContextSwitches.SetActorAsReferenceWhenCopyingClaimsIdentity)
				{
					claimsIdentity.Actor = this.Actor.Clone();
				}
				else
				{
					claimsIdentity.Actor = this.Actor;
				}
			}
			return claimsIdentity;
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0006DFA8 File Offset: 0x0006C1A8
		[SecuritySafeCritical]
		private void SafeAddClaims(IEnumerable<Claim> claims)
		{
			foreach (Claim claim in claims)
			{
				if (claim.Subject == this)
				{
					this.m_instanceClaims.Add(claim);
				}
				else
				{
					this.m_instanceClaims.Add(claim.Clone(this));
				}
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0006E014 File Offset: 0x0006C214
		[SecuritySafeCritical]
		private void SafeAddClaim(Claim claim)
		{
			if (claim.Subject == this)
			{
				this.m_instanceClaims.Add(claim);
				return;
			}
			this.m_instanceClaims.Add(claim.Clone(this));
		}

		/// <summary>Retrieves the first claim with the specified claim type.</summary>
		/// <param name="type">The claim type to match.</param>
		/// <returns>The first matching claim or <see langword="null" /> if no match is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is null.</exception>
		// Token: 0x06001936 RID: 6454 RVA: 0x0006E040 File Offset: 0x0006C240
		public virtual Claim FindFirst(string type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			foreach (Claim claim in this.Claims)
			{
				if (claim != null && string.Equals(claim.Type, type, StringComparison.OrdinalIgnoreCase))
				{
					return claim;
				}
			}
			return null;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0006E0B0 File Offset: 0x0006C2B0
		[OnSerializing]
		[SecurityCritical]
		private void OnSerializingMethod(StreamingContext context)
		{
			if (this is ISerializable)
			{
				return;
			}
			this.m_serializedClaims = this.SerializeClaims();
			this.m_serializedNameType = this.m_nameType;
			this.m_serializedRoleType = this.m_roleType;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0006E0E0 File Offset: 0x0006C2E0
		[OnDeserialized]
		[SecurityCritical]
		private void OnDeserializedMethod(StreamingContext context)
		{
			if (this is ISerializable)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.m_serializedClaims))
			{
				this.DeserializeClaims(this.m_serializedClaims);
				this.m_serializedClaims = null;
			}
			this.m_nameType = (string.IsNullOrEmpty(this.m_serializedNameType) ? "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name" : this.m_serializedNameType);
			this.m_roleType = (string.IsNullOrEmpty(this.m_serializedRoleType) ? "http://schemas.microsoft.com/ws/2008/06/identity/claims/role" : this.m_serializedRoleType);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0006E156 File Offset: 0x0006C356
		[OnDeserializing]
		private void OnDeserializingMethod(StreamingContext context)
		{
			if (this is ISerializable)
			{
				return;
			}
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
		}

		/// <summary>Populates the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with data needed to serialize the current <see cref="T:System.Security.Claims.ClaimsIdentity" /> object.</summary>
		/// <param name="info">The object to populate with data.</param>
		/// <param name="context">The destination for this serialization. Can be <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x0600193A RID: 6458 RVA: 0x0006E178 File Offset: 0x0006C378
		[SecurityCritical]
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			info.AddValue("System.Security.ClaimsIdentity.version", this.m_version);
			if (!string.IsNullOrEmpty(this.m_authenticationType))
			{
				info.AddValue("System.Security.ClaimsIdentity.authenticationType", this.m_authenticationType);
			}
			info.AddValue("System.Security.ClaimsIdentity.nameClaimType", this.m_nameType);
			info.AddValue("System.Security.ClaimsIdentity.roleClaimType", this.m_roleType);
			if (!string.IsNullOrEmpty(this.m_label))
			{
				info.AddValue("System.Security.ClaimsIdentity.label", this.m_label);
			}
			if (this.m_actor != null)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					binaryFormatter.Serialize(memoryStream, this.m_actor, null, false);
					info.AddValue("System.Security.ClaimsIdentity.actor", Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length));
				}
			}
			info.AddValue("System.Security.ClaimsIdentity.claims", this.SerializeClaims());
			if (this.m_bootstrapContext != null)
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					binaryFormatter.Serialize(memoryStream2, this.m_bootstrapContext, null, false);
					info.AddValue("System.Security.ClaimsIdentity.bootstrapContext", Convert.ToBase64String(memoryStream2.GetBuffer(), 0, (int)memoryStream2.Length));
				}
			}
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0006E2C4 File Offset: 0x0006C4C4
		[SecurityCritical]
		private void DeserializeClaims(string serializedClaims)
		{
			if (!string.IsNullOrEmpty(serializedClaims))
			{
				using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(serializedClaims)))
				{
					this.m_instanceClaims = (List<Claim>)new BinaryFormatter().Deserialize(memoryStream, null, false);
					for (int i = 0; i < this.m_instanceClaims.Count; i++)
					{
						this.m_instanceClaims[i].Subject = this;
					}
				}
			}
			if (this.m_instanceClaims == null)
			{
				this.m_instanceClaims = new List<Claim>();
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0006E354 File Offset: 0x0006C554
		[SecurityCritical]
		private string SerializeClaims()
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(memoryStream, this.m_instanceClaims, null, false);
				result = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
			}
			return result;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0006E3AC File Offset: 0x0006C5AC
		private bool IsCircular(ClaimsIdentity subject)
		{
			if (this == subject)
			{
				return true;
			}
			ClaimsIdentity claimsIdentity = subject;
			while (claimsIdentity.Actor != null)
			{
				if (this == claimsIdentity.Actor)
				{
					return true;
				}
				claimsIdentity = claimsIdentity.Actor;
			}
			return false;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
		[SecurityCritical]
		private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			BinaryFormatter binaryFormatter;
			if (useContext)
			{
				binaryFormatter = new BinaryFormatter(null, context);
			}
			else
			{
				binaryFormatter = new BinaryFormatter();
			}
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
				if (num <= 959168042U)
				{
					if (num <= 623923795U)
					{
						if (num != 373632733U)
						{
							if (num == 623923795U)
							{
								if (name == "System.Security.ClaimsIdentity.roleClaimType")
								{
									this.m_roleType = info.GetString("System.Security.ClaimsIdentity.roleClaimType");
								}
							}
						}
						else if (name == "System.Security.ClaimsIdentity.label")
						{
							this.m_label = info.GetString("System.Security.ClaimsIdentity.label");
						}
					}
					else if (num != 656336169U)
					{
						if (num == 959168042U)
						{
							if (name == "System.Security.ClaimsIdentity.nameClaimType")
							{
								this.m_nameType = info.GetString("System.Security.ClaimsIdentity.nameClaimType");
							}
						}
					}
					else if (name == "System.Security.ClaimsIdentity.authenticationType")
					{
						this.m_authenticationType = info.GetString("System.Security.ClaimsIdentity.authenticationType");
					}
				}
				else if (num <= 1476368026U)
				{
					if (num != 1453716852U)
					{
						if (num != 1476368026U)
						{
							continue;
						}
						if (!(name == "System.Security.ClaimsIdentity.actor"))
						{
							continue;
						}
						using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(info.GetString("System.Security.ClaimsIdentity.actor"))))
						{
							this.m_actor = (ClaimsIdentity)binaryFormatter.Deserialize(memoryStream, null, false);
							continue;
						}
					}
					else if (!(name == "System.Security.ClaimsIdentity.claims"))
					{
						continue;
					}
					this.DeserializeClaims(info.GetString("System.Security.ClaimsIdentity.claims"));
				}
				else if (num != 2480284791U)
				{
					if (num == 3659022112U)
					{
						if (name == "System.Security.ClaimsIdentity.bootstrapContext")
						{
							using (MemoryStream memoryStream2 = new MemoryStream(Convert.FromBase64String(info.GetString("System.Security.ClaimsIdentity.bootstrapContext"))))
							{
								this.m_bootstrapContext = binaryFormatter.Deserialize(memoryStream2, null, false);
							}
						}
					}
				}
				else if (name == "System.Security.ClaimsIdentity.version")
				{
					info.GetString("System.Security.ClaimsIdentity.version");
				}
			}
		}

		// Token: 0x04000A78 RID: 2680
		[NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000A79 RID: 2681
		[NonSerialized]
		private List<Claim> m_instanceClaims;

		// Token: 0x04000A7A RID: 2682
		[NonSerialized]
		private Collection<IEnumerable<Claim>> m_externalClaims;

		// Token: 0x04000A7B RID: 2683
		[NonSerialized]
		private string m_nameType;

		// Token: 0x04000A7C RID: 2684
		[NonSerialized]
		private string m_roleType;

		// Token: 0x04000A7D RID: 2685
		[OptionalField(VersionAdded = 2)]
		private string m_version;

		// Token: 0x04000A7E RID: 2686
		[OptionalField(VersionAdded = 2)]
		private ClaimsIdentity m_actor;

		// Token: 0x04000A7F RID: 2687
		[OptionalField(VersionAdded = 2)]
		private string m_authenticationType;

		// Token: 0x04000A80 RID: 2688
		[OptionalField(VersionAdded = 2)]
		private object m_bootstrapContext;

		// Token: 0x04000A81 RID: 2689
		[OptionalField(VersionAdded = 2)]
		private string m_label;

		// Token: 0x04000A82 RID: 2690
		[OptionalField(VersionAdded = 2)]
		private string m_serializedNameType;

		// Token: 0x04000A83 RID: 2691
		[OptionalField(VersionAdded = 2)]
		private string m_serializedRoleType;

		// Token: 0x04000A84 RID: 2692
		[OptionalField(VersionAdded = 2)]
		private string m_serializedClaims;
	}
}
