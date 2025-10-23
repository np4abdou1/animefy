using System;
using System.Diagnostics;
using System.Threading;

namespace System
{
	/// <summary>Provides support for lazy initialization.</summary>
	/// <typeparam name="T">The type of object that is being lazily initialized.</typeparam>
	// Token: 0x020000CD RID: 205
	[DebuggerTypeProxy(typeof(LazyDebugView<>))]
	[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
	[Serializable]
	public class Lazy<T>
	{
		// Token: 0x060006B3 RID: 1715 RVA: 0x0001CB69 File Offset: 0x0001AD69
		private static T CreateViaDefaultConstructor()
		{
			return (T)((object)LazyHelper.CreateViaDefaultConstructor(typeof(T)));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Lazy`1" /> class. When lazy initialization occurs, the default constructor of the target type is used.</summary>
		// Token: 0x060006B4 RID: 1716 RVA: 0x0001CB7F File Offset: 0x0001AD7F
		public Lazy() : this(null, LazyThreadSafetyMode.ExecutionAndPublication, true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Lazy`1" /> class. When lazy initialization occurs, the specified initialization function is used.</summary>
		/// <param name="valueFactory">The delegate that is invoked to produce the lazily initialized value when it is needed.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="valueFactory" /> is <see langword="null" />. </exception>
		// Token: 0x060006B5 RID: 1717 RVA: 0x0001CB8A File Offset: 0x0001AD8A
		public Lazy(Func<T> valueFactory) : this(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication, false)
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001CB95 File Offset: 0x0001AD95
		private Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
			if (valueFactory == null && !useDefaultConstructor)
			{
				throw new ArgumentNullException("valueFactory");
			}
			this._factory = valueFactory;
			this._state = LazyHelper.Create(mode, useDefaultConstructor);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001CBC4 File Offset: 0x0001ADC4
		private void ViaConstructor()
		{
			this._value = Lazy<T>.CreateViaDefaultConstructor();
			this._state = null;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		private void ViaFactory(LazyThreadSafetyMode mode)
		{
			try
			{
				Func<T> factory = this._factory;
				if (factory == null)
				{
					throw new InvalidOperationException("ValueFactory attempted to access the Value property of this instance.");
				}
				this._factory = null;
				this._value = factory();
				this._state = null;
			}
			catch (Exception exception)
			{
				this._state = new LazyHelper(mode, exception);
				throw;
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001CC40 File Offset: 0x0001AE40
		private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor)
		{
			lock (executionAndPublication)
			{
				if (this._state == executionAndPublication)
				{
					if (useDefaultConstructor)
					{
						this.ViaConstructor();
					}
					else
					{
						this.ViaFactory(LazyThreadSafetyMode.ExecutionAndPublication);
					}
				}
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001CC94 File Offset: 0x0001AE94
		private void PublicationOnly(LazyHelper publicationOnly, T possibleValue)
		{
			if (Interlocked.CompareExchange<LazyHelper>(ref this._state, LazyHelper.PublicationOnlyWaitForOtherThreadToPublish, publicationOnly) == publicationOnly)
			{
				this._factory = null;
				this._value = possibleValue;
				this._state = null;
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001CCC1 File Offset: 0x0001AEC1
		private void PublicationOnlyViaConstructor(LazyHelper initializer)
		{
			this.PublicationOnly(initializer, Lazy<T>.CreateViaDefaultConstructor());
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		private void PublicationOnlyViaFactory(LazyHelper initializer)
		{
			Func<T> factory = this._factory;
			if (factory == null)
			{
				this.PublicationOnlyWaitForOtherThreadToPublish();
				return;
			}
			this.PublicationOnly(initializer, factory());
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001CCFC File Offset: 0x0001AEFC
		private void PublicationOnlyWaitForOtherThreadToPublish()
		{
			SpinWait spinWait = default(SpinWait);
			while (this._state != null)
			{
				spinWait.SpinOnce();
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001CD24 File Offset: 0x0001AF24
		private T CreateValue()
		{
			LazyHelper state = this._state;
			if (state != null)
			{
				switch (state.State)
				{
				case LazyState.NoneViaConstructor:
					this.ViaConstructor();
					goto IL_84;
				case LazyState.NoneViaFactory:
					this.ViaFactory(LazyThreadSafetyMode.None);
					goto IL_84;
				case LazyState.PublicationOnlyViaConstructor:
					this.PublicationOnlyViaConstructor(state);
					goto IL_84;
				case LazyState.PublicationOnlyViaFactory:
					this.PublicationOnlyViaFactory(state);
					goto IL_84;
				case LazyState.PublicationOnlyWait:
					this.PublicationOnlyWaitForOtherThreadToPublish();
					goto IL_84;
				case LazyState.ExecutionAndPublicationViaConstructor:
					this.ExecutionAndPublication(state, true);
					goto IL_84;
				case LazyState.ExecutionAndPublicationViaFactory:
					this.ExecutionAndPublication(state, false);
					goto IL_84;
				}
				state.ThrowException();
			}
			IL_84:
			return this.Value;
		}

		/// <summary>Creates and returns a string representation of the <see cref="P:System.Lazy`1.Value" /> property for this instance.</summary>
		/// <returns>The result of calling the <see cref="M:System.Object.ToString" /> method on the <see cref="P:System.Lazy`1.Value" /> property for this instance, if the value has been created (that is, if the <see cref="P:System.Lazy`1.IsValueCreated" /> property returns <see langword="true" />). Otherwise, a string indicating that the value has not been created. </returns>
		/// <exception cref="T:System.NullReferenceException">The <see cref="P:System.Lazy`1.Value" /> property is <see langword="null" />.</exception>
		// Token: 0x060006BF RID: 1727 RVA: 0x0001CDBC File Offset: 0x0001AFBC
		public override string ToString()
		{
			if (!this.IsValueCreated)
			{
				return "Value is not created.";
			}
			T value = this.Value;
			return value.ToString();
		}

		/// <summary>Gets a value that indicates whether a value has been created for this <see cref="T:System.Lazy`1" /> instance.</summary>
		/// <returns>
		///     <see langword="true" /> if a value has been created for this <see cref="T:System.Lazy`1" /> instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001CDEB File Offset: 0x0001AFEB
		public bool IsValueCreated
		{
			get
			{
				return this._state == null;
			}
		}

		/// <summary>Gets the lazily initialized value of the current <see cref="T:System.Lazy`1" /> instance.</summary>
		/// <returns>The lazily initialized value of the current <see cref="T:System.Lazy`1" /> instance.</returns>
		/// <exception cref="T:System.MemberAccessException">The <see cref="T:System.Lazy`1" /> instance is initialized to use the default constructor of the type that is being lazily initialized, and permissions to access the constructor are missing. </exception>
		/// <exception cref="T:System.MissingMemberException">The <see cref="T:System.Lazy`1" /> instance is initialized to use the default constructor of the type that is being lazily initialized, and that type does not have a public, parameterless constructor. </exception>
		/// <exception cref="T:System.InvalidOperationException">The initialization function tries to access <see cref="P:System.Lazy`1.Value" /> on this instance. </exception>
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			get
			{
				if (this._state != null)
				{
					return this.CreateValue();
				}
				return this._value;
			}
		}

		// Token: 0x04000327 RID: 807
		private volatile LazyHelper _state;

		// Token: 0x04000328 RID: 808
		private Func<T> _factory;

		// Token: 0x04000329 RID: 809
		private T _value;
	}
}
