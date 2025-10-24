using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x02000057 RID: 87
	internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000819A File Offset: 0x0000639A
		internal new MonoBtlsX509LookupMono.BoringX509LookupMonoHandle Handle
		{
			get
			{
				return (MonoBtlsX509LookupMono.BoringX509LookupMonoHandle)base.Handle;
			}
		}

		// Token: 0x06000222 RID: 546
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_lookup_mono_new();

		// Token: 0x06000223 RID: 547
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func);

		// Token: 0x06000224 RID: 548
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle);

		// Token: 0x06000225 RID: 549 RVA: 0x000081A8 File Offset: 0x000063A8
		internal MonoBtlsX509LookupMono() : base(new MonoBtlsX509LookupMono.BoringX509LookupMonoHandle(MonoBtlsX509LookupMono.mono_btls_x509_lookup_mono_new()))
		{
			this.gch = GCHandle.Alloc(this);
			this.instance = GCHandle.ToIntPtr(this.gch);
			this.bySubjectFunc = new MonoBtlsX509LookupMono.BySubjectFunc(MonoBtlsX509LookupMono.OnGetBySubject);
			this.bySubjectFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsX509LookupMono.BySubjectFunc>(this.bySubjectFunc);
			MonoBtlsX509LookupMono.mono_btls_x509_lookup_mono_init(this.Handle.DangerousGetHandle(), this.instance, this.bySubjectFuncPtr);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008221 File Offset: 0x00006421
		internal void Install(MonoBtlsX509Lookup lookup)
		{
			if (this.lookup != null)
			{
				throw new InvalidOperationException();
			}
			this.lookup = lookup;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00008238 File Offset: 0x00006438
		protected void AddCertificate(MonoBtlsX509 certificate)
		{
			this.lookup.AddCertificate(certificate);
		}

		// Token: 0x06000228 RID: 552
		protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name);

		// Token: 0x06000229 RID: 553 RVA: 0x00008248 File Offset: 0x00006448
		private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr)
		{
			int result;
			try
			{
				MonoBtlsX509Name.BoringX509NameHandle boringX509NameHandle = null;
				try
				{
					MonoBtlsX509LookupMono monoBtlsX509LookupMono = (MonoBtlsX509LookupMono)GCHandle.FromIntPtr(instance).Target;
					boringX509NameHandle = new MonoBtlsX509Name.BoringX509NameHandle(name_ptr, false);
					MonoBtlsX509Name name = new MonoBtlsX509Name(boringX509NameHandle);
					MonoBtlsX509 monoBtlsX = monoBtlsX509LookupMono.OnGetBySubject(name);
					if (monoBtlsX != null)
					{
						x509_ptr = monoBtlsX.Handle.StealHandle();
						result = 1;
					}
					else
					{
						x509_ptr = IntPtr.Zero;
						result = 0;
					}
				}
				finally
				{
					if (boringX509NameHandle != null)
					{
						boringX509NameHandle.Dispose();
					}
				}
			}
			catch (Exception arg)
			{
				Console.WriteLine("LOOKUP METHOD - GET BY SUBJECT EX: {0}", arg);
				x509_ptr = IntPtr.Zero;
				result = 0;
			}
			return result;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000082E4 File Offset: 0x000064E4
		protected override void Close()
		{
			try
			{
				if (this.gch.IsAllocated)
				{
					this.gch.Free();
				}
			}
			finally
			{
				this.instance = IntPtr.Zero;
				this.bySubjectFunc = null;
				this.bySubjectFuncPtr = IntPtr.Zero;
				base.Close();
			}
		}

		// Token: 0x04000124 RID: 292
		private GCHandle gch;

		// Token: 0x04000125 RID: 293
		private IntPtr instance;

		// Token: 0x04000126 RID: 294
		private MonoBtlsX509LookupMono.BySubjectFunc bySubjectFunc;

		// Token: 0x04000127 RID: 295
		private IntPtr bySubjectFuncPtr;

		// Token: 0x04000128 RID: 296
		private MonoBtlsX509Lookup lookup;

		// Token: 0x02000058 RID: 88
		internal class BoringX509LookupMonoHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x0600022B RID: 555 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringX509LookupMonoHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00008340 File Offset: 0x00006540
			protected override bool ReleaseHandle()
			{
				MonoBtlsX509LookupMono.mono_btls_x509_lookup_mono_free(this.handle);
				return true;
			}
		}

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate int BySubjectFunc(IntPtr instance, IntPtr name, out IntPtr x509_ptr);
	}
}
