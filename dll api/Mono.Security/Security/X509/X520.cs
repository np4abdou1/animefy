using System;
using System.Text;

namespace Mono.Security.X509
{
	// Token: 0x0200001B RID: 27
	public class X520
	{
		// Token: 0x0200001C RID: 28
		public abstract class AttributeTypeAndValue
		{
			// Token: 0x060000E6 RID: 230 RVA: 0x00008111 File Offset: 0x00006311
			protected AttributeTypeAndValue(string oid, int upperBound)
			{
				this.oid = oid;
				this.upperBound = upperBound;
				this.encoding = byte.MaxValue;
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00008132 File Offset: 0x00006332
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding)
			{
				this.oid = oid;
				this.upperBound = upperBound;
				this.encoding = encoding;
			}

			// Token: 0x1700004A RID: 74
			// (set) Token: 0x060000E8 RID: 232 RVA: 0x00008150 File Offset: 0x00006350
			public string Value
			{
				set
				{
					if (this.attrValue != null && this.attrValue.Length > this.upperBound)
					{
						throw new FormatException(string.Format(Locale.GetText("Value length bigger than upperbound ({0})."), this.upperBound));
					}
					this.attrValue = value;
				}
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x000081A0 File Offset: 0x000063A0
			internal ASN1 GetASN1(byte encoding)
			{
				byte b = encoding;
				if (b == 255)
				{
					b = this.SelectBestEncoding();
				}
				ASN1 asn = new ASN1(48);
				asn.Add(ASN1Convert.FromOid(this.oid));
				if (b != 19)
				{
					if (b != 22)
					{
						if (b == 30)
						{
							asn.Add(new ASN1(30, Encoding.BigEndianUnicode.GetBytes(this.attrValue)));
						}
					}
					else
					{
						asn.Add(new ASN1(22, Encoding.ASCII.GetBytes(this.attrValue)));
					}
				}
				else
				{
					asn.Add(new ASN1(19, Encoding.ASCII.GetBytes(this.attrValue)));
				}
				return asn;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00008248 File Offset: 0x00006448
			internal ASN1 GetASN1()
			{
				return this.GetASN1(this.encoding);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00008258 File Offset: 0x00006458
			private byte SelectBestEncoding()
			{
				foreach (char c in this.attrValue)
				{
					if (c == '@' || c == '_')
					{
						return 30;
					}
					if (c > '\u007f')
					{
						return 30;
					}
				}
				return 19;
			}

			// Token: 0x0400007F RID: 127
			private string oid;

			// Token: 0x04000080 RID: 128
			private string attrValue;

			// Token: 0x04000081 RID: 129
			private int upperBound;

			// Token: 0x04000082 RID: 130
			private byte encoding;
		}

		// Token: 0x0200001D RID: 29
		public class CommonName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000EC RID: 236 RVA: 0x0000829C File Offset: 0x0000649C
			public CommonName() : base("2.5.4.3", 64)
			{
			}
		}

		// Token: 0x0200001E RID: 30
		public class SerialNumber : X520.AttributeTypeAndValue
		{
			// Token: 0x060000ED RID: 237 RVA: 0x000082AB File Offset: 0x000064AB
			public SerialNumber() : base("2.5.4.5", 64, 19)
			{
			}
		}

		// Token: 0x0200001F RID: 31
		public class LocalityName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000EE RID: 238 RVA: 0x000082BC File Offset: 0x000064BC
			public LocalityName() : base("2.5.4.7", 128)
			{
			}
		}

		// Token: 0x02000020 RID: 32
		public class StateOrProvinceName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000EF RID: 239 RVA: 0x000082CE File Offset: 0x000064CE
			public StateOrProvinceName() : base("2.5.4.8", 128)
			{
			}
		}

		// Token: 0x02000021 RID: 33
		public class OrganizationName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F0 RID: 240 RVA: 0x000082E0 File Offset: 0x000064E0
			public OrganizationName() : base("2.5.4.10", 64)
			{
			}
		}

		// Token: 0x02000022 RID: 34
		public class OrganizationalUnitName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F1 RID: 241 RVA: 0x000082EF File Offset: 0x000064EF
			public OrganizationalUnitName() : base("2.5.4.11", 64)
			{
			}
		}

		// Token: 0x02000023 RID: 35
		public class EmailAddress : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F2 RID: 242 RVA: 0x000082FE File Offset: 0x000064FE
			public EmailAddress() : base("1.2.840.113549.1.9.1", 128, 22)
			{
			}
		}

		// Token: 0x02000024 RID: 36
		public class DomainComponent : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F3 RID: 243 RVA: 0x00008312 File Offset: 0x00006512
			public DomainComponent() : base("0.9.2342.19200300.100.1.25", int.MaxValue, 22)
			{
			}
		}

		// Token: 0x02000025 RID: 37
		public class UserId : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x00008326 File Offset: 0x00006526
			public UserId() : base("0.9.2342.19200300.100.1.1", 256)
			{
			}
		}

		// Token: 0x02000026 RID: 38
		public class Oid : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F5 RID: 245 RVA: 0x00008338 File Offset: 0x00006538
			public Oid(string oid) : base(oid, int.MaxValue)
			{
			}
		}

		// Token: 0x02000027 RID: 39
		public class Title : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F6 RID: 246 RVA: 0x00008346 File Offset: 0x00006546
			public Title() : base("2.5.4.12", 64)
			{
			}
		}

		// Token: 0x02000028 RID: 40
		public class CountryName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F7 RID: 247 RVA: 0x00008355 File Offset: 0x00006555
			public CountryName() : base("2.5.4.6", 2, 19)
			{
			}
		}

		// Token: 0x02000029 RID: 41
		public class DnQualifier : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F8 RID: 248 RVA: 0x00008365 File Offset: 0x00006565
			public DnQualifier() : base("2.5.4.46", 2, 19)
			{
			}
		}

		// Token: 0x0200002A RID: 42
		public class Surname : X520.AttributeTypeAndValue
		{
			// Token: 0x060000F9 RID: 249 RVA: 0x00008375 File Offset: 0x00006575
			public Surname() : base("2.5.4.4", 32768)
			{
			}
		}

		// Token: 0x0200002B RID: 43
		public class GivenName : X520.AttributeTypeAndValue
		{
			// Token: 0x060000FA RID: 250 RVA: 0x00008387 File Offset: 0x00006587
			public GivenName() : base("2.5.4.42", 16)
			{
			}
		}

		// Token: 0x0200002C RID: 44
		public class Initial : X520.AttributeTypeAndValue
		{
			// Token: 0x060000FB RID: 251 RVA: 0x00008396 File Offset: 0x00006596
			public Initial() : base("2.5.4.43", 5)
			{
			}
		}
	}
}
