using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using Mono.Security.Cryptography;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200002F RID: 47
	public class ChallengeResponse : IDisposable
	{
		// Token: 0x06000106 RID: 262 RVA: 0x000086A2 File Offset: 0x000068A2
		public ChallengeResponse()
		{
			this._disposed = false;
			this._lmpwd = new byte[21];
			this._ntpwd = new byte[21];
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000086CB File Offset: 0x000068CB
		public ChallengeResponse(string password, byte[] challenge) : this()
		{
			this.Password = password;
			this.Challenge = challenge;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000086E4 File Offset: 0x000068E4
		~ChallengeResponse()
		{
			if (!this._disposed)
			{
				this.Dispose();
			}
		}

		// Token: 0x1700004D RID: 77
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00008718 File Offset: 0x00006918
		public string Password
		{
			set
			{
				if (this._disposed)
				{
					throw new ObjectDisposedException("too late");
				}
				DES des = DES.Create();
				des.Mode = CipherMode.ECB;
				if (value == null || value.Length < 1)
				{
					Buffer.BlockCopy(ChallengeResponse.nullEncMagic, 0, this._lmpwd, 0, 8);
				}
				else
				{
					des.Key = this.PasswordToKey(value, 0);
					des.CreateEncryptor().TransformBlock(ChallengeResponse.magic, 0, 8, this._lmpwd, 0);
				}
				if (value == null || value.Length < 8)
				{
					Buffer.BlockCopy(ChallengeResponse.nullEncMagic, 0, this._lmpwd, 8, 8);
				}
				else
				{
					des.Key = this.PasswordToKey(value, 7);
					des.CreateEncryptor().TransformBlock(ChallengeResponse.magic, 0, 8, this._lmpwd, 8);
				}
				HashAlgorithm hashAlgorithm = MD4.Create();
				byte[] array = (value == null) ? new byte[0] : Encoding.Unicode.GetBytes(value);
				byte[] array2 = hashAlgorithm.ComputeHash(array);
				Buffer.BlockCopy(array2, 0, this._ntpwd, 0, 16);
				Array.Clear(array, 0, array.Length);
				Array.Clear(array2, 0, array2.Length);
				des.Clear();
			}
		}

		// Token: 0x1700004E RID: 78
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00008824 File Offset: 0x00006A24
		public byte[] Challenge
		{
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Challenge");
				}
				if (this._disposed)
				{
					throw new ObjectDisposedException("too late");
				}
				this._challenge = (byte[])value.Clone();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00008858 File Offset: 0x00006A58
		public byte[] LM
		{
			get
			{
				if (this._disposed)
				{
					throw new ObjectDisposedException("too late");
				}
				return this.GetResponse(this._lmpwd);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00008879 File Offset: 0x00006A79
		public byte[] NT
		{
			get
			{
				if (this._disposed)
				{
					throw new ObjectDisposedException("too late");
				}
				return this.GetResponse(this._ntpwd);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000889A File Offset: 0x00006A9A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000088AC File Offset: 0x00006AAC
		private void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				Array.Clear(this._lmpwd, 0, this._lmpwd.Length);
				Array.Clear(this._ntpwd, 0, this._ntpwd.Length);
				if (this._challenge != null)
				{
					Array.Clear(this._challenge, 0, this._challenge.Length);
				}
				this._disposed = true;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000890C File Offset: 0x00006B0C
		private byte[] GetResponse(byte[] pwd)
		{
			byte[] array = new byte[24];
			DES des = DES.Create();
			des.Mode = CipherMode.ECB;
			des.Key = this.PrepareDESKey(pwd, 0);
			des.CreateEncryptor().TransformBlock(this._challenge, 0, 8, array, 0);
			des.Key = this.PrepareDESKey(pwd, 7);
			des.CreateEncryptor().TransformBlock(this._challenge, 0, 8, array, 8);
			des.Key = this.PrepareDESKey(pwd, 14);
			des.CreateEncryptor().TransformBlock(this._challenge, 0, 8, array, 16);
			return array;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000899C File Offset: 0x00006B9C
		private byte[] PrepareDESKey(byte[] key56bits, int position)
		{
			return new byte[]
			{
				key56bits[position],
				(byte)((int)key56bits[position] << 7 | key56bits[position + 1] >> 1),
				(byte)((int)key56bits[position + 1] << 6 | key56bits[position + 2] >> 2),
				(byte)((int)key56bits[position + 2] << 5 | key56bits[position + 3] >> 3),
				(byte)((int)key56bits[position + 3] << 4 | key56bits[position + 4] >> 4),
				(byte)((int)key56bits[position + 4] << 3 | key56bits[position + 5] >> 5),
				(byte)((int)key56bits[position + 5] << 2 | key56bits[position + 6] >> 6),
				(byte)(key56bits[position + 6] << 1)
			};
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008A30 File Offset: 0x00006C30
		private byte[] PasswordToKey(string password, int position)
		{
			byte[] array = new byte[7];
			int charCount = Math.Min(password.Length - position, 7);
			Encoding.ASCII.GetBytes(password.ToUpper(CultureInfo.CurrentCulture), position, charCount, array, 0);
			byte[] result = this.PrepareDESKey(array, 0);
			Array.Clear(array, 0, array.Length);
			return result;
		}

		// Token: 0x04000086 RID: 134
		private static byte[] magic = new byte[]
		{
			75,
			71,
			83,
			33,
			64,
			35,
			36,
			37
		};

		// Token: 0x04000087 RID: 135
		private static byte[] nullEncMagic = new byte[]
		{
			170,
			211,
			180,
			53,
			181,
			20,
			4,
			238
		};

		// Token: 0x04000088 RID: 136
		private bool _disposed;

		// Token: 0x04000089 RID: 137
		private byte[] _challenge;

		// Token: 0x0400008A RID: 138
		private byte[] _lmpwd;

		// Token: 0x0400008B RID: 139
		private byte[] _ntpwd;
	}
}
