using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Defines the set of information that constitutes input to security policy decisions. This class cannot be inherited.</summary>
	// Token: 0x02000292 RID: 658
	[ComVisible(true)]
	[Serializable]
	public sealed class Evidence : ICollection, IEnumerable
	{
		/// <summary>Initializes a new empty instance of the <see cref="T:System.Security.Policy.Evidence" /> class.</summary>
		// Token: 0x060016B7 RID: 5815 RVA: 0x00003ACD File Offset: 0x00001CCD
		public Evidence()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Evidence" /> class from a shallow copy of an existing one.</summary>
		/// <param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> instance from which to create the new instance. This instance is not deep-copied. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="evidence" /> parameter is not a valid instance of <see cref="T:System.Security.Policy.Evidence" />. </exception>
		// Token: 0x060016B8 RID: 5816 RVA: 0x0005D84A File Offset: 0x0005BA4A
		public Evidence(Evidence evidence)
		{
			if (evidence != null)
			{
				this.Merge(evidence);
			}
		}

		/// <summary>Gets the number of evidence objects in the evidence set.</summary>
		/// <returns>The number of evidence objects in the evidence set.</returns>
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0005D85C File Offset: 0x0005BA5C
		public int Count
		{
			get
			{
				int num = 0;
				if (this.hostEvidenceList != null)
				{
					num += this.hostEvidenceList.Count;
				}
				if (this.assemblyEvidenceList != null)
				{
					num += this.assemblyEvidenceList.Count;
				}
				return num;
			}
		}

		/// <summary>Gets a value indicating whether the evidence set is thread-safe.</summary>
		/// <returns>Always <see langword="false" /> because thread-safe evidence sets are not supported.</returns>
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets the synchronization root.</summary>
		/// <returns>Always <see langword="this" /> (<see langword="Me" /> in Visual Basic), because synchronization of evidence sets is not supported.</returns>
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x0000245A File Offset: 0x0000065A
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x0005D898 File Offset: 0x0005BA98
		internal ArrayList HostEvidenceList
		{
			get
			{
				if (this.hostEvidenceList == null)
				{
					this.hostEvidenceList = ArrayList.Synchronized(new ArrayList());
				}
				return this.hostEvidenceList;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x0005D8B8 File Offset: 0x0005BAB8
		internal ArrayList AssemblyEvidenceList
		{
			get
			{
				if (this.assemblyEvidenceList == null)
				{
					this.assemblyEvidenceList = ArrayList.Synchronized(new ArrayList());
				}
				return this.assemblyEvidenceList;
			}
		}

		/// <summary>Adds the specified assembly evidence to the evidence set.</summary>
		/// <param name="id">Any evidence object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="id" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="id" /> is not serializable.</exception>
		// Token: 0x060016BE RID: 5822 RVA: 0x0005D8D8 File Offset: 0x0005BAD8
		public void AddAssembly(object id)
		{
			this.AssemblyEvidenceList.Add(id);
		}

		/// <summary>Adds the specified evidence supplied by the host to the evidence set.</summary>
		/// <param name="id">Any evidence object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="id" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="id" /> is not serializable.</exception>
		// Token: 0x060016BF RID: 5823 RVA: 0x0005D8E7 File Offset: 0x0005BAE7
		public void AddHost(object id)
		{
			if (this._locked)
			{
				bool securityEnabled = SecurityManager.SecurityEnabled;
			}
			this.HostEvidenceList.Add(id);
		}

		/// <summary>Copies evidence objects to an <see cref="T:System.Array" />.</summary>
		/// <param name="array">The target array to which to copy evidence objects. </param>
		/// <param name="index">The zero-based position in the array to which to begin copying evidence objects. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index " />is outside the range of the target array<paramref name="." /></exception>
		// Token: 0x060016C0 RID: 5824 RVA: 0x0005D904 File Offset: 0x0005BB04
		public void CopyTo(Array array, int index)
		{
			int num = 0;
			if (this.hostEvidenceList != null)
			{
				num = this.hostEvidenceList.Count;
				if (num > 0)
				{
					this.hostEvidenceList.CopyTo(array, index);
				}
			}
			if (this.assemblyEvidenceList != null && this.assemblyEvidenceList.Count > 0)
			{
				this.assemblyEvidenceList.CopyTo(array, index + num);
			}
		}

		/// <summary>Enumerates all evidence in the set, both that provided by the host and that provided by the assembly.</summary>
		/// <returns>An enumerator for evidence added by both the <see cref="M:System.Security.Policy.Evidence.AddHost(System.Object)" /> method and the <see cref="M:System.Security.Policy.Evidence.AddAssembly(System.Object)" /> method.</returns>
		// Token: 0x060016C1 RID: 5825 RVA: 0x0005D960 File Offset: 0x0005BB60
		public IEnumerator GetEnumerator()
		{
			IEnumerator hostenum = null;
			if (this.hostEvidenceList != null)
			{
				hostenum = this.hostEvidenceList.GetEnumerator();
			}
			IEnumerator assemblyenum = null;
			if (this.assemblyEvidenceList != null)
			{
				assemblyenum = this.assemblyEvidenceList.GetEnumerator();
			}
			return new Evidence.EvidenceEnumerator(hostenum, assemblyenum);
		}

		/// <summary>Merges the specified evidence set into the current evidence set.</summary>
		/// <param name="evidence">The evidence set to be merged into the current evidence set. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="evidence" /> parameter is not a valid instance of <see cref="T:System.Security.Policy.Evidence" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///         <see cref="P:System.Security.Policy.Evidence.Locked" /> is <see langword="true" />, the code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlEvidence" />, and the <paramref name="evidence" /> parameter has a host list that is not empty. </exception>
		// Token: 0x060016C2 RID: 5826 RVA: 0x0005D9A0 File Offset: 0x0005BBA0
		public void Merge(Evidence evidence)
		{
			if (evidence != null && evidence.Count > 0)
			{
				if (evidence.hostEvidenceList != null)
				{
					foreach (object id in evidence.hostEvidenceList)
					{
						this.AddHost(id);
					}
				}
				if (evidence.assemblyEvidenceList != null)
				{
					foreach (object id2 in evidence.assemblyEvidenceList)
					{
						this.AddAssembly(id2);
					}
				}
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0005DA58 File Offset: 0x0005BC58
		internal static Evidence GetDefaultHostEvidence(Assembly a)
		{
			return new Evidence();
		}

		// Token: 0x040008F7 RID: 2295
		private bool _locked;

		// Token: 0x040008F8 RID: 2296
		private ArrayList hostEvidenceList;

		// Token: 0x040008F9 RID: 2297
		private ArrayList assemblyEvidenceList;

		// Token: 0x02000293 RID: 659
		private class EvidenceEnumerator : IEnumerator
		{
			// Token: 0x060016C4 RID: 5828 RVA: 0x0005DA5F File Offset: 0x0005BC5F
			public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum)
			{
				this.hostEnum = hostenum;
				this.assemblyEnum = assemblyenum;
				this.currentEnum = this.hostEnum;
			}

			// Token: 0x060016C5 RID: 5829 RVA: 0x0005DA84 File Offset: 0x0005BC84
			public bool MoveNext()
			{
				if (this.currentEnum == null)
				{
					return false;
				}
				bool flag = this.currentEnum.MoveNext();
				if (!flag && this.hostEnum == this.currentEnum && this.assemblyEnum != null)
				{
					this.currentEnum = this.assemblyEnum;
					flag = this.assemblyEnum.MoveNext();
				}
				return flag;
			}

			// Token: 0x060016C6 RID: 5830 RVA: 0x0005DADC File Offset: 0x0005BCDC
			public void Reset()
			{
				if (this.hostEnum != null)
				{
					this.hostEnum.Reset();
					this.currentEnum = this.hostEnum;
				}
				else
				{
					this.currentEnum = this.assemblyEnum;
				}
				if (this.assemblyEnum != null)
				{
					this.assemblyEnum.Reset();
				}
			}

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x060016C7 RID: 5831 RVA: 0x0005DB29 File Offset: 0x0005BD29
			public object Current
			{
				get
				{
					return this.currentEnum.Current;
				}
			}

			// Token: 0x040008FA RID: 2298
			private IEnumerator currentEnum;

			// Token: 0x040008FB RID: 2299
			private IEnumerator hostEnum;

			// Token: 0x040008FC RID: 2300
			private IEnumerator assemblyEnum;
		}
	}
}
