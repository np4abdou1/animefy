using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Security.Claims
{
	/// <summary>Represents a claim.</summary>
	// Token: 0x020002F9 RID: 761
	[Serializable]
	public class Claim
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified claim type, value, value type, issuer, original issuer and subject.</summary>
		/// <param name="type">The claim type.</param>
		/// <param name="value">The claim value.</param>
		/// <param name="valueType">The claim value type. If this parameter is <see langword="null" />, then <see cref="F:System.Security.Claims.ClaimValueTypes.String" /> is used.</param>
		/// <param name="issuer">The claim issuer. If this parameter is empty or <see langword="null" />, then <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" /> is used.</param>
		/// <param name="originalIssuer">The original issuer of the claim. If this parameter is empty or <see langword="null" />, then the <see cref="P:System.Security.Claims.Claim.OriginalIssuer" /> property is set to the value of the <see cref="P:System.Security.Claims.Claim.Issuer" /> property.</param>
		/// <param name="subject">The subject that this claim describes.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> or <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x0600191E RID: 6430 RVA: 0x0006D99C File Offset: 0x0006BB9C
		public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) : this(type, value, valueType, issuer, originalIssuer, subject, null, null)
		{
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0006D9BC File Offset: 0x0006BBBC
		internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
		{
			this.m_propertyLock = new object();
			base..ctor();
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.m_type = type;
			this.m_value = value;
			if (string.IsNullOrEmpty(valueType))
			{
				this.m_valueType = "http://www.w3.org/2001/XMLSchema#string";
			}
			else
			{
				this.m_valueType = valueType;
			}
			if (string.IsNullOrEmpty(issuer))
			{
				this.m_issuer = "LOCAL AUTHORITY";
			}
			else
			{
				this.m_issuer = issuer;
			}
			if (string.IsNullOrEmpty(originalIssuer))
			{
				this.m_originalIssuer = this.m_issuer;
			}
			else
			{
				this.m_originalIssuer = originalIssuer;
			}
			this.m_subject = subject;
			if (propertyKey != null)
			{
				this.Properties.Add(propertyKey, propertyValue);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified security claim, and subject.</summary>
		/// <param name="other">The security claim.</param>
		/// <param name="subject">The subject that this claim describes.</param>
		// Token: 0x06001920 RID: 6432 RVA: 0x0006DA78 File Offset: 0x0006BC78
		protected Claim(Claim other, ClaimsIdentity subject)
		{
			this.m_propertyLock = new object();
			base..ctor();
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.m_issuer = other.m_issuer;
			this.m_originalIssuer = other.m_originalIssuer;
			this.m_subject = subject;
			this.m_type = other.m_type;
			this.m_value = other.m_value;
			this.m_valueType = other.m_valueType;
			if (other.m_properties != null)
			{
				this.m_properties = new Dictionary<string, string>();
				foreach (string key in other.m_properties.Keys)
				{
					this.m_properties.Add(key, other.m_properties[key]);
				}
			}
			if (other.m_userSerializationData != null)
			{
				this.m_userSerializationData = (other.m_userSerializationData.Clone() as byte[]);
			}
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0006DB74 File Offset: 0x0006BD74
		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context)
		{
			this.m_propertyLock = new object();
		}

		/// <summary>Gets a dictionary that contains additional properties associated with this claim.</summary>
		/// <returns>A dictionary that contains additional properties associated with the claim. The properties are represented as name-value pairs.</returns>
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0006DB84 File Offset: 0x0006BD84
		public IDictionary<string, string> Properties
		{
			get
			{
				if (this.m_properties == null)
				{
					object propertyLock = this.m_propertyLock;
					lock (propertyLock)
					{
						if (this.m_properties == null)
						{
							this.m_properties = new Dictionary<string, string>();
						}
					}
				}
				return this.m_properties;
			}
		}

		/// <summary>Gets the subject of the claim.</summary>
		/// <returns>The subject of the claim.</returns>
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x0006DBE0 File Offset: 0x0006BDE0
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x0006DBE8 File Offset: 0x0006BDE8
		public ClaimsIdentity Subject
		{
			get
			{
				return this.m_subject;
			}
			internal set
			{
				this.m_subject = value;
			}
		}

		/// <summary>Gets the claim type of the claim.</summary>
		/// <returns>The claim type.</returns>
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0006DBF1 File Offset: 0x0006BDF1
		public string Type
		{
			get
			{
				return this.m_type;
			}
		}

		/// <summary>Gets the value of the claim.</summary>
		/// <returns>The claim value.</returns>
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0006DBF9 File Offset: 0x0006BDF9
		public string Value
		{
			get
			{
				return this.m_value;
			}
		}

		/// <summary>Returns a new <see cref="T:System.Security.Claims.Claim" /> object copied from this object. The subject of the new claim is set to the specified ClaimsIdentity.</summary>
		/// <param name="identity">The intended subject of the new claim.</param>
		/// <returns>The new claim object.</returns>
		// Token: 0x06001927 RID: 6439 RVA: 0x0006DC01 File Offset: 0x0006BE01
		public virtual Claim Clone(ClaimsIdentity identity)
		{
			return new Claim(this, identity);
		}

		/// <summary>Returns a string representation of this <see cref="T:System.Security.Claims.Claim" /> object.</summary>
		/// <returns>The string representation of this <see cref="T:System.Security.Claims.Claim" /> object.</returns>
		// Token: 0x06001928 RID: 6440 RVA: 0x0006DC0A File Offset: 0x0006BE0A
		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}: {1}", this.m_type, this.m_value);
		}

		// Token: 0x04000A6F RID: 2671
		private string m_issuer;

		// Token: 0x04000A70 RID: 2672
		private string m_originalIssuer;

		// Token: 0x04000A71 RID: 2673
		private string m_type;

		// Token: 0x04000A72 RID: 2674
		private string m_value;

		// Token: 0x04000A73 RID: 2675
		private string m_valueType;

		// Token: 0x04000A74 RID: 2676
		[NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x04000A75 RID: 2677
		private Dictionary<string, string> m_properties;

		// Token: 0x04000A76 RID: 2678
		[NonSerialized]
		private object m_propertyLock;

		// Token: 0x04000A77 RID: 2679
		[NonSerialized]
		private ClaimsIdentity m_subject;
	}
}
