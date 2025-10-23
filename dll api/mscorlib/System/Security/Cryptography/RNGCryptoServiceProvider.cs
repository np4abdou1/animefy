using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Security.Cryptography
{
	/// <summary>Implements a cryptographic Random Number Generator (RNG) using the implementation provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
	// Token: 0x020002E7 RID: 743
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		// Token: 0x060018A1 RID: 6305 RVA: 0x0006BE7B File Offset: 0x0006A07B
		static RNGCryptoServiceProvider()
		{
			if (RNGCryptoServiceProvider.RngOpen())
			{
				RNGCryptoServiceProvider._lock = new object();
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class.</summary>
		// Token: 0x060018A2 RID: 6306 RVA: 0x0006BE8E File Offset: 0x0006A08E
		public RNGCryptoServiceProvider()
		{
			this._handle = RNGCryptoServiceProvider.RngInitialize(null, IntPtr.Zero);
			this.Check();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class.</summary>
		/// <param name="rgb">A byte array. This value is ignored.</param>
		// Token: 0x060018A3 RID: 6307 RVA: 0x0006BEB0 File Offset: 0x0006A0B0
		public unsafe RNGCryptoServiceProvider(byte[] rgb)
		{
			fixed (byte[] array = rgb)
			{
				byte* seed;
				if (rgb == null || array.Length == 0)
				{
					seed = null;
				}
				else
				{
					seed = &array[0];
				}
				this._handle = RNGCryptoServiceProvider.RngInitialize(seed, (rgb != null) ? ((IntPtr)rgb.Length) : IntPtr.Zero);
			}
			this.Check();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class with the specified parameters.</summary>
		/// <param name="cspParams">The parameters to pass to the cryptographic service provider (CSP). </param>
		// Token: 0x060018A4 RID: 6308 RVA: 0x0006BE8E File Offset: 0x0006A08E
		public RNGCryptoServiceProvider(CspParameters cspParams)
		{
			this._handle = RNGCryptoServiceProvider.RngInitialize(null, IntPtr.Zero);
			this.Check();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class.</summary>
		/// <param name="str">The string input. This parameter is ignored.</param>
		// Token: 0x060018A5 RID: 6309 RVA: 0x0006BF04 File Offset: 0x0006A104
		public unsafe RNGCryptoServiceProvider(string str)
		{
			if (str == null)
			{
				this._handle = RNGCryptoServiceProvider.RngInitialize(null, IntPtr.Zero);
			}
			else
			{
				byte[] bytes = Encoding.UTF8.GetBytes(str);
				byte[] array;
				byte* seed;
				if ((array = bytes) == null || array.Length == 0)
				{
					seed = null;
				}
				else
				{
					seed = &array[0];
				}
				this._handle = RNGCryptoServiceProvider.RngInitialize(seed, (IntPtr)bytes.Length);
				array = null;
			}
			this.Check();
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0006BF6E File Offset: 0x0006A16E
		private void Check()
		{
			if (this._handle == IntPtr.Zero)
			{
				throw new CryptographicException(Locale.GetText("Couldn't access random source."));
			}
		}

		// Token: 0x060018A7 RID: 6311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool RngOpen();

		// Token: 0x060018A8 RID: 6312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr RngInitialize(byte* seed, IntPtr seed_length);

		// Token: 0x060018A9 RID: 6313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length);

		// Token: 0x060018AA RID: 6314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RngClose(IntPtr handle);

		/// <summary>Fills an array of bytes with a cryptographically strong sequence of random values.</summary>
		/// <param name="data">The array to fill with a cryptographically strong sequence of random values. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />.</exception>
		// Token: 0x060018AB RID: 6315 RVA: 0x0006BF94 File Offset: 0x0006A194
		public unsafe override void GetBytes(byte[] data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			fixed (byte[] array = data)
			{
				byte* data2;
				if (data == null || array.Length == 0)
				{
					data2 = null;
				}
				else
				{
					data2 = &array[0];
				}
				if (RNGCryptoServiceProvider._lock == null)
				{
					this._handle = RNGCryptoServiceProvider.RngGetBytes(this._handle, data2, (IntPtr)((long)data.Length));
				}
				else
				{
					object @lock = RNGCryptoServiceProvider._lock;
					lock (@lock)
					{
						this._handle = RNGCryptoServiceProvider.RngGetBytes(this._handle, data2, (IntPtr)((long)data.Length));
					}
				}
			}
			this.Check();
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0006C038 File Offset: 0x0006A238
		~RNGCryptoServiceProvider()
		{
			if (this._handle != IntPtr.Zero)
			{
				RNGCryptoServiceProvider.RngClose(this._handle);
				this._handle = IntPtr.Zero;
			}
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0006C088 File Offset: 0x0006A288
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x04000A30 RID: 2608
		private static object _lock;

		// Token: 0x04000A31 RID: 2609
		private IntPtr _handle;
	}
}
