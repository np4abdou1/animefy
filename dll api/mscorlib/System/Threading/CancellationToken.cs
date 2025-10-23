using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	/// <summary>Propagates notification that operations should be canceled.</summary>
	// Token: 0x020001B3 RID: 435
	[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	public readonly struct CancellationToken
	{
		/// <summary>Returns an empty <see cref="T:System.Threading.CancellationToken" /> value.</summary>
		/// <returns>An empty cancellation token. </returns>
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000443A4 File Offset: 0x000425A4
		public static CancellationToken None
		{
			get
			{
				return default(CancellationToken);
			}
		}

		/// <summary>Gets whether cancellation has been requested for this token.</summary>
		/// <returns>
		///     <see langword="true" /> if cancellation has been requested for this token; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x000443BA File Offset: 0x000425BA
		public bool IsCancellationRequested
		{
			get
			{
				return this._source != null && this._source.IsCancellationRequested;
			}
		}

		/// <summary>Gets whether this token is capable of being in the canceled state. </summary>
		/// <returns>
		///     <see langword="true" /> if this token is capable of being in the canceled state; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x000443D1 File Offset: 0x000425D1
		public bool CanBeCanceled
		{
			get
			{
				return this._source != null;
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000443DC File Offset: 0x000425DC
		internal CancellationToken(CancellationTokenSource source)
		{
			this._source = source;
		}

		/// <summary>Initializes the <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="canceled">The canceled state for the token.</param>
		// Token: 0x0600106B RID: 4203 RVA: 0x000443E5 File Offset: 0x000425E5
		public CancellationToken(bool canceled)
		{
			this = new CancellationToken(canceled ? CancellationTokenSource.s_canceledSource : null);
		}

		/// <summary>Registers a delegate that will be called when this <see cref="T:System.Threading.CancellationToken" /> is canceled.</summary>
		/// <param name="callback">The delegate to be executed when the <see cref="T:System.Threading.CancellationToken" /> is canceled.</param>
		/// <returns>The <see cref="T:System.Threading.CancellationTokenRegistration" /> instance that can be used to deregister the callback.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="callback" /> is null.</exception>
		// Token: 0x0600106C RID: 4204 RVA: 0x000443F8 File Offset: 0x000425F8
		public CancellationTokenRegistration Register(Action callback)
		{
			Action<object> callback2 = CancellationToken.s_actionToActionObjShunt;
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			return this.Register(callback2, callback, false, true);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00044417 File Offset: 0x00042617
		internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state)
		{
			return this.Register(callback, state, false, false);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00044424 File Offset: 0x00042624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			CancellationTokenSource source = this._source;
			if (source == null)
			{
				return default(CancellationTokenRegistration);
			}
			return source.InternalRegister(callback, state, useSynchronizationContext ? SynchronizationContext.Current : null, useExecutionContext ? ExecutionContext.Capture() : null);
		}

		/// <summary>Determines whether the current <see cref="T:System.Threading.CancellationToken" /> instance is equal to the specified token.</summary>
		/// <param name="other">The other <see cref="T:System.Threading.CancellationToken" /> to which to compare this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the instances are equal; otherwise, <see langword="false" />. Two tokens are equal if they are associated with the same <see cref="T:System.Threading.CancellationTokenSource" /> or if they were both constructed from public <see cref="T:System.Threading.CancellationToken" /> constructors and their <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> values are equal.</returns>
		// Token: 0x0600106F RID: 4207 RVA: 0x00044472 File Offset: 0x00042672
		public bool Equals(CancellationToken other)
		{
			return this._source == other._source;
		}

		/// <summary>Determines whether the current <see cref="T:System.Threading.CancellationToken" /> instance is equal to the specified <see cref="T:System.Object" />.</summary>
		/// <param name="other">The other object to which to compare this instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="other" /> is a <see cref="T:System.Threading.CancellationToken" /> and if the two instances are equal; otherwise, <see langword="false" />. Two tokens are equal if they are associated with the same <see cref="T:System.Threading.CancellationTokenSource" /> or if they were both constructed from public <see cref="T:System.Threading.CancellationToken" /> constructors and their <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> values are equal.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		// Token: 0x06001070 RID: 4208 RVA: 0x00044482 File Offset: 0x00042682
		public override bool Equals(object other)
		{
			return other is CancellationToken && this.Equals((CancellationToken)other);
		}

		/// <summary>Serves as a hash function for a <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Threading.CancellationToken" /> instance.</returns>
		// Token: 0x06001071 RID: 4209 RVA: 0x0004449A File Offset: 0x0004269A
		public override int GetHashCode()
		{
			return (this._source ?? CancellationTokenSource.s_neverCanceledSource).GetHashCode();
		}

		/// <summary>Determines whether two <see cref="T:System.Threading.CancellationToken" /> instances are equal.</summary>
		/// <param name="left">The first instance.</param>
		/// <param name="right">The second instance.</param>
		/// <returns>
		///     <see langword="true" /> if the instances are equal; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		// Token: 0x06001072 RID: 4210 RVA: 0x000444B0 File Offset: 0x000426B0
		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			return left.Equals(right);
		}

		/// <summary>Determines whether two <see cref="T:System.Threading.CancellationToken" /> instances are not equal.</summary>
		/// <param name="left">The first instance.</param>
		/// <param name="right">The second instance.</param>
		/// <returns>
		///     <see langword="true" /> if the instances are not equal; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		// Token: 0x06001073 RID: 4211 RVA: 0x000444BA File Offset: 0x000426BA
		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			return !left.Equals(right);
		}

		/// <summary>Throws a <see cref="T:System.OperationCanceledException" /> if this token has had cancellation requested.</summary>
		/// <exception cref="T:System.OperationCanceledException">The token has had cancellation requested.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
		// Token: 0x06001074 RID: 4212 RVA: 0x000444C7 File Offset: 0x000426C7
		public void ThrowIfCancellationRequested()
		{
			if (this.IsCancellationRequested)
			{
				this.ThrowOperationCanceledException();
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000444D7 File Offset: 0x000426D7
		private void ThrowOperationCanceledException()
		{
			throw new OperationCanceledException("The operation was canceled.", this);
		}

		// Token: 0x04000641 RID: 1601
		private readonly CancellationTokenSource _source;

		// Token: 0x04000642 RID: 1602
		private static readonly Action<object> s_actionToActionObjShunt = delegate(object obj)
		{
			((Action)obj)();
		};
	}
}
