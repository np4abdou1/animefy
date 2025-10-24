using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using Mono;

namespace System.Reflection
{
	/// <summary>Describes an assembly's unique identity in full.</summary>
	// Token: 0x020004D0 RID: 1232
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_AssemblyName))]
	[ClassInterface(ClassInterfaceType.None)]
	[Serializable]
	[StructLayout(0)]
	public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyName" /> class.</summary>
		// Token: 0x060022D3 RID: 8915 RVA: 0x0008C066 File Offset: 0x0008A266
		public AssemblyName()
		{
			this.versioncompat = AssemblyVersionCompatibility.SameMachine;
		}

		// Token: 0x060022D4 RID: 8916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined);

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyName" /> class with the specified display name.</summary>
		/// <param name="assemblyName">The display name of the assembly, as returned by the <see cref="P:System.Reflection.AssemblyName.FullName" /> property.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="assemblyName" /> is a zero length string. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.The referenced assembly could not be found, or could not be loaded.</exception>
		// Token: 0x060022D5 RID: 8917 RVA: 0x0008C078 File Offset: 0x0008A278
		public unsafe AssemblyName(string assemblyName)
		{
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			if (assemblyName.Length < 1)
			{
				throw new ArgumentException("assemblyName cannot have zero length.");
			}
			using (SafeStringMarshal safeStringMarshal = RuntimeMarshal.MarshalString(assemblyName))
			{
				MonoAssemblyName monoAssemblyName;
				bool addVersion;
				bool defaultToken;
				if (!AssemblyName.ParseAssemblyName(safeStringMarshal.Value, out monoAssemblyName, out addVersion, out defaultToken))
				{
					throw new FileLoadException("The assembly name is invalid.");
				}
				try
				{
					this.FillName(&monoAssemblyName, null, addVersion, false, defaultToken, false);
				}
				finally
				{
					RuntimeMarshal.FreeAssemblyName(ref monoAssemblyName, false);
				}
			}
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0008C118 File Offset: 0x0008A318
		internal AssemblyName(SerializationInfo si, StreamingContext sc)
		{
			this.name = si.GetString("_Name");
			this.codebase = si.GetString("_CodeBase");
			this.version = (Version)si.GetValue("_Version", typeof(Version));
			this.publicKey = (byte[])si.GetValue("_PublicKey", typeof(byte[]));
			this.keyToken = (byte[])si.GetValue("_PublicKeyToken", typeof(byte[]));
			this.hashalg = (AssemblyHashAlgorithm)si.GetValue("_HashAlgorithm", typeof(AssemblyHashAlgorithm));
			this.keypair = (StrongNameKeyPair)si.GetValue("_StrongNameKeyPair", typeof(StrongNameKeyPair));
			this.versioncompat = (AssemblyVersionCompatibility)si.GetValue("_VersionCompatibility", typeof(AssemblyVersionCompatibility));
			this.flags = (AssemblyNameFlags)si.GetValue("_Flags", typeof(AssemblyNameFlags));
			int @int = si.GetInt32("_CultureInfo");
			if (@int != -1)
			{
				this.cultureinfo = new CultureInfo(@int);
			}
		}

		/// <summary>Gets or sets the simple name of the assembly. This is usually, but not necessarily, the file name of the manifest file of the assembly, minus its extension.</summary>
		/// <returns>The simple name of the assembly.</returns>
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x0008C249 File Offset: 0x0008A449
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x0008C251 File Offset: 0x0008A451
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets or sets the location of the assembly as a URL.</summary>
		/// <returns>A string that is the URL location of the assembly. </returns>
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0008C25A File Offset: 0x0008A45A
		public string CodeBase
		{
			get
			{
				return this.codebase;
			}
		}

		/// <summary>Gets or sets the culture supported by the assembly.</summary>
		/// <returns>An object that represents the culture supported by the assembly.</returns>
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x0008C262 File Offset: 0x0008A462
		public CultureInfo CultureInfo
		{
			get
			{
				return this.cultureinfo;
			}
		}

		/// <summary>Gets or sets the attributes of the assembly.</summary>
		/// <returns>A value that represents the attributes of the assembly.</returns>
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x0008C26A File Offset: 0x0008A46A
		public AssemblyNameFlags Flags
		{
			get
			{
				return this.flags;
			}
		}

		/// <summary>Gets the full name of the assembly, also known as the display name.</summary>
		/// <returns>A string that is the full name of the assembly, also known as the display name.</returns>
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x0008C274 File Offset: 0x0008A474
		public string FullName
		{
			get
			{
				if (this.name == null)
				{
					return string.Empty;
				}
				StringBuilder stringBuilder = new StringBuilder();
				if (char.IsWhiteSpace(this.name[0]))
				{
					stringBuilder.Append("\"" + this.name + "\"");
				}
				else
				{
					stringBuilder.Append(this.name);
				}
				if (this.Version != null)
				{
					stringBuilder.Append(", Version=");
					stringBuilder.Append(this.Version.ToString());
				}
				if (this.cultureinfo != null)
				{
					stringBuilder.Append(", Culture=");
					if (this.cultureinfo.LCID == CultureInfo.InvariantCulture.LCID)
					{
						stringBuilder.Append("neutral");
					}
					else
					{
						stringBuilder.Append(this.cultureinfo.Name);
					}
				}
				byte[] array = this.InternalGetPublicKeyToken();
				if (array != null)
				{
					if (array.Length == 0)
					{
						stringBuilder.Append(", PublicKeyToken=null");
					}
					else
					{
						stringBuilder.Append(", PublicKeyToken=");
						for (int i = 0; i < array.Length; i++)
						{
							stringBuilder.Append(array[i].ToString("x2"));
						}
					}
				}
				if ((this.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					stringBuilder.Append(", Retargetable=Yes");
				}
				return stringBuilder.ToString();
			}
		}

		/// <summary>Gets or sets the public and private cryptographic key pair that is used to create a strong name signature for the assembly.</summary>
		/// <returns>The public and private cryptographic key pair to be used to create a strong name for the assembly.</returns>
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x0008C3B8 File Offset: 0x0008A5B8
		public StrongNameKeyPair KeyPair
		{
			get
			{
				return this.keypair;
			}
		}

		/// <summary>Gets or sets the major, minor, build, and revision numbers of the assembly.</summary>
		/// <returns>An object that represents the major, minor, build, and revision numbers of the assembly.</returns>
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x0008C3C0 File Offset: 0x0008A5C0
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x0008C3C8 File Offset: 0x0008A5C8
		public Version Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
				if (value == null)
				{
					this.major = (this.minor = (this.build = (this.revision = 0)));
					return;
				}
				this.major = value.Major;
				this.minor = value.Minor;
				this.build = value.Build;
				this.revision = value.Revision;
			}
		}

		/// <summary>Returns the full name of the assembly, also known as the display name.</summary>
		/// <returns>The full name of the assembly, or the class name if the full name cannot be determined.</returns>
		// Token: 0x060022E0 RID: 8928 RVA: 0x0008C438 File Offset: 0x0008A638
		public override string ToString()
		{
			string fullName = this.FullName;
			if (fullName == null)
			{
				return base.ToString();
			}
			return fullName;
		}

		/// <summary>Gets the public key of the assembly.</summary>
		/// <returns>A byte array that contains the public key of the assembly.</returns>
		/// <exception cref="T:System.Security.SecurityException">A public key was provided (for example, by using the <see cref="M:System.Reflection.AssemblyName.SetPublicKey(System.Byte[])" /> method), but no public key token was provided. </exception>
		// Token: 0x060022E1 RID: 8929 RVA: 0x0008C457 File Offset: 0x0008A657
		public byte[] GetPublicKey()
		{
			return this.publicKey;
		}

		/// <summary>Gets the public key token, which is the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed.</summary>
		/// <returns>A byte array that contains the public key token.</returns>
		// Token: 0x060022E2 RID: 8930 RVA: 0x0008C460 File Offset: 0x0008A660
		public byte[] GetPublicKeyToken()
		{
			if (this.keyToken != null)
			{
				return this.keyToken;
			}
			if (this.publicKey == null)
			{
				return null;
			}
			if (this.publicKey.Length == 0)
			{
				return EmptyArray<byte>.Value;
			}
			if (!this.IsPublicKeyValid)
			{
				throw new SecurityException("The public key is not valid.");
			}
			this.keyToken = this.ComputePublicKeyToken();
			return this.keyToken;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0008C4BC File Offset: 0x0008A6BC
		private bool IsPublicKeyValid
		{
			get
			{
				if (this.publicKey.Length == 16)
				{
					int i = 0;
					int num = 0;
					while (i < this.publicKey.Length)
					{
						num += (int)this.publicKey[i++];
					}
					if (num == 4)
					{
						return true;
					}
				}
				byte b = this.publicKey[0];
				if (b != 0)
				{
					if (b == 6)
					{
						return true;
					}
					if (b != 7)
					{
					}
				}
				else if (this.publicKey.Length > 12 && this.publicKey[12] == 6)
				{
					return true;
				}
				return false;
			}
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0008C530 File Offset: 0x0008A730
		private byte[] InternalGetPublicKeyToken()
		{
			if (this.keyToken != null)
			{
				return this.keyToken;
			}
			if (this.publicKey == null)
			{
				return null;
			}
			if (this.publicKey.Length == 0)
			{
				return EmptyArray<byte>.Value;
			}
			if (!this.IsPublicKeyValid)
			{
				throw new SecurityException("The public key is not valid.");
			}
			return this.ComputePublicKeyToken();
		}

		// Token: 0x060022E5 RID: 8933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void get_public_token(byte* token, byte* pubkey, int len);

		// Token: 0x060022E6 RID: 8934 RVA: 0x0008C580 File Offset: 0x0008A780
		private unsafe byte[] ComputePublicKeyToken()
		{
			byte[] array2;
			byte[] array = array2 = new byte[8];
			byte* token;
			if (array == null || array2.Length == 0)
			{
				token = null;
			}
			else
			{
				token = &array2[0];
			}
			byte[] array3;
			byte* pubkey;
			if ((array3 = this.publicKey) == null || array3.Length == 0)
			{
				pubkey = null;
			}
			else
			{
				pubkey = &array3[0];
			}
			AssemblyName.get_public_token(token, pubkey, this.publicKey.Length);
			array3 = null;
			array2 = null;
			return array;
		}

		/// <summary>Sets the public key identifying the assembly.</summary>
		/// <param name="publicKey">A byte array containing the public key of the assembly. </param>
		// Token: 0x060022E7 RID: 8935 RVA: 0x0008C5DB File Offset: 0x0008A7DB
		public void SetPublicKey(byte[] publicKey)
		{
			if (publicKey == null)
			{
				this.flags ^= AssemblyNameFlags.PublicKey;
			}
			else
			{
				this.flags |= AssemblyNameFlags.PublicKey;
			}
			this.publicKey = publicKey;
		}

		/// <summary>Sets the public key token, which is the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed.</summary>
		/// <param name="publicKeyToken">A byte array containing the public key token of the assembly. </param>
		// Token: 0x060022E8 RID: 8936 RVA: 0x0008C605 File Offset: 0x0008A805
		public void SetPublicKeyToken(byte[] publicKeyToken)
		{
			this.keyToken = publicKeyToken;
		}

		/// <summary>Gets serialization information with all the data needed to recreate an instance of this <see langword="AssemblyName" />.</summary>
		/// <param name="info">The object to be populated with serialization information. </param>
		/// <param name="context">The destination context of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x060022E9 RID: 8937 RVA: 0x0008C610 File Offset: 0x0008A810
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("_Name", this.name);
			info.AddValue("_PublicKey", this.publicKey);
			info.AddValue("_PublicKeyToken", this.keyToken);
			info.AddValue("_CultureInfo", (this.cultureinfo != null) ? this.cultureinfo.LCID : -1);
			info.AddValue("_CodeBase", this.codebase);
			info.AddValue("_Version", this.Version);
			info.AddValue("_HashAlgorithm", this.hashalg);
			info.AddValue("_HashAlgorithmForControl", AssemblyHashAlgorithm.None);
			info.AddValue("_StrongNameKeyPair", this.keypair);
			info.AddValue("_VersionCompatibility", this.versioncompat);
			info.AddValue("_Flags", this.flags);
			info.AddValue("_HashForControl", null);
		}

		/// <summary>Makes a copy of this <see cref="T:System.Reflection.AssemblyName" /> object.</summary>
		/// <returns>An object that is a copy of this <see cref="T:System.Reflection.AssemblyName" /> object.</returns>
		// Token: 0x060022EA RID: 8938 RVA: 0x0008C714 File Offset: 0x0008A914
		public object Clone()
		{
			return new AssemblyName
			{
				name = this.name,
				codebase = this.codebase,
				major = this.major,
				minor = this.minor,
				build = this.build,
				revision = this.revision,
				version = this.version,
				cultureinfo = this.cultureinfo,
				flags = this.flags,
				hashalg = this.hashalg,
				keypair = this.keypair,
				publicKey = this.publicKey,
				keyToken = this.keyToken,
				versioncompat = this.versioncompat,
				processor_architecture = this.processor_architecture
			};
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event. </param>
		// Token: 0x060022EB RID: 8939 RVA: 0x0008C7DA File Offset: 0x0008A9DA
		public void OnDeserialization(object sender)
		{
			this.Version = this.version;
		}

		// Token: 0x060022EC RID: 8940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern MonoAssemblyName* GetNativeName(IntPtr assembly_ptr);

		// Token: 0x060022ED RID: 8941 RVA: 0x0008C7E8 File Offset: 0x0008A9E8
		internal unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
			this.name = RuntimeMarshal.PtrToUtf8String(native->name);
			this.major = (int)native->major;
			this.minor = (int)native->minor;
			this.build = (int)native->build;
			this.revision = (int)native->revision;
			this.flags = (AssemblyNameFlags)native->flags;
			this.hashalg = (AssemblyHashAlgorithm)native->hash_alg;
			this.versioncompat = AssemblyVersionCompatibility.SameMachine;
			this.processor_architecture = (ProcessorArchitecture)native->arch;
			if (addVersion)
			{
				this.version = new Version(this.major, this.minor, this.build, this.revision);
			}
			this.codebase = codeBase;
			if (native->culture != IntPtr.Zero)
			{
				this.cultureinfo = CultureInfo.CreateCulture(RuntimeMarshal.PtrToUtf8String(native->culture), assemblyRef);
			}
			if (native->public_key != IntPtr.Zero)
			{
				this.publicKey = RuntimeMarshal.DecodeBlobArray(native->public_key);
				this.flags |= AssemblyNameFlags.PublicKey;
			}
			else if (addPublickey)
			{
				this.publicKey = EmptyArray<byte>.Value;
				this.flags |= AssemblyNameFlags.PublicKey;
			}
			if (native->public_key_token.FixedElementField != 0)
			{
				byte[] array = new byte[8];
				int i = 0;
				int num = 0;
				while (i < 8)
				{
					array[i] = (byte)(RuntimeMarshal.AsciHexDigitValue((int)(*(ref native->public_key_token.FixedElementField + num++))) << 4);
					byte[] array2 = array;
					int num2 = i;
					array2[num2] |= (byte)RuntimeMarshal.AsciHexDigitValue((int)(*(ref native->public_key_token.FixedElementField + num++)));
					i++;
				}
				this.keyToken = array;
				return;
			}
			if (defaultToken)
			{
				this.keyToken = EmptyArray<byte>.Value;
			}
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0008C984 File Offset: 0x0008AB84
		internal unsafe static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			AssemblyName assemblyName = new AssemblyName();
			MonoAssemblyName* nativeName = AssemblyName.GetNativeName(assembly.MonoAssembly);
			assemblyName.FillName(nativeName, fillCodebase ? assembly.CodeBase : null, true, true, true, false);
			return assemblyName;
		}

		// Token: 0x040010F5 RID: 4341
		private string name;

		// Token: 0x040010F6 RID: 4342
		private string codebase;

		// Token: 0x040010F7 RID: 4343
		private int major;

		// Token: 0x040010F8 RID: 4344
		private int minor;

		// Token: 0x040010F9 RID: 4345
		private int build;

		// Token: 0x040010FA RID: 4346
		private int revision;

		// Token: 0x040010FB RID: 4347
		private CultureInfo cultureinfo;

		// Token: 0x040010FC RID: 4348
		private AssemblyNameFlags flags;

		// Token: 0x040010FD RID: 4349
		private AssemblyHashAlgorithm hashalg;

		// Token: 0x040010FE RID: 4350
		private StrongNameKeyPair keypair;

		// Token: 0x040010FF RID: 4351
		private byte[] publicKey;

		// Token: 0x04001100 RID: 4352
		private byte[] keyToken;

		// Token: 0x04001101 RID: 4353
		private AssemblyVersionCompatibility versioncompat;

		// Token: 0x04001102 RID: 4354
		private Version version;

		// Token: 0x04001103 RID: 4355
		private ProcessorArchitecture processor_architecture;

		// Token: 0x04001104 RID: 4356
		private AssemblyContentType contentType;
	}
}
