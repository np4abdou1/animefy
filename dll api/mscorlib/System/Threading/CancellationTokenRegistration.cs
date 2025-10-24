﻿using System;

namespace System.Threading
{
	/// <summary>Represents a callback delegate that has been registered with a <see cref="T:System.Threading.CancellationToken" />. </summary>
	// Token: 0x020001B9 RID: 441
	public readonly struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
	{
		// Token: 0x0600109B RID: 4251 RVA: 0x00044C62 File Offset: 0x00042E62
		internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
		{
			this.m_callbackInfo = callbackInfo;
			this.m_registrationInfo = registrationInfo;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00044C74 File Offset: 0x00042E74
		public bool Unregister()
		{
			return this.m_registrationInfo.Source != null && this.m_registrationInfo.Source.SafeAtomicRemove(this.m_registrationInfo.Index, this.m_callbackInfo) == this.m_callbackInfo;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.CancellationTokenRegistration" /> class.</summary>
		// Token: 0x0600109D RID: 4253 RVA: 0x00044CC8 File Offset: 0x00042EC8
		public void Dispose()
		{
			bool flag = this.Unregister();
			CancellationCallbackInfo callbackInfo = this.m_callbackInfo;
			if (callbackInfo != null)
			{
				CancellationTokenSource cancellationTokenSource = callbackInfo.CancellationTokenSource;
				if (cancellationTokenSource.IsCancellationRequested && !cancellationTokenSource.IsCancellationCompleted && !flag && cancellationTokenSource.ThreadIDExecutingCallbacks != Environment.CurrentManagedThreadId)
				{
					cancellationTokenSource.WaitForCallbackToComplete(this.m_callbackInfo);
				}
			}
		}

		/// <summary>Determines whether the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance is equal to the specified <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary>
		/// <param name="obj">The other object to which to compare this instance.</param>
		/// <returns>True, if both this and <paramref name="obj" /> are equal. False, otherwise.Two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal if they both refer to the output of a single call to the same Register method of a <see cref="T:System.Threading.CancellationToken" />.</returns>
		// Token: 0x0600109E RID: 4254 RVA: 0x00044D19 File Offset: 0x00042F19
		public override bool Equals(object obj)
		{
			return obj is CancellationTokenRegistration && this.Equals((CancellationTokenRegistration)obj);
		}

		/// <summary>Determines whether the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance is equal to the specified <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary>
		/// <param name="other">The other <see cref="T:System.Threading.CancellationTokenRegistration" /> to which to compare this instance.</param>
		/// <returns>True, if both this and <paramref name="other" /> are equal. False, otherwise. Two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal if they both refer to the output of a single call to the same Register method of a <see cref="T:System.Threading.CancellationToken" />.</returns>
		// Token: 0x0600109F RID: 4255 RVA: 0x00044D34 File Offset: 0x00042F34
		public bool Equals(CancellationTokenRegistration other)
		{
			return this.m_callbackInfo == other.m_callbackInfo && this.m_registrationInfo.Source == other.m_registrationInfo.Source && this.m_registrationInfo.Index == other.m_registrationInfo.Index;
		}

		/// <summary>Serves as a hash function for a <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance.</returns>
		// Token: 0x060010A0 RID: 4256 RVA: 0x00044D90 File Offset: 0x00042F90
		public override int GetHashCode()
		{
			if (this.m_registrationInfo.Source != null)
			{
				return this.m_registrationInfo.Source.GetHashCode() ^ this.m_registrationInfo.Index.GetHashCode();
			}
			return this.m_registrationInfo.Index.GetHashCode();
		}

		// Token: 0x0400064D RID: 1613
		private readonly CancellationCallbackInfo m_callbackInfo;

		// Token: 0x0400064E RID: 1614
		private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;
	}
}
