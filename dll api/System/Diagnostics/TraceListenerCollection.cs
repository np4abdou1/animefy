using System;
using System.Collections;
using System.Reflection;

namespace System.Diagnostics
{
	/// <summary>Provides a thread-safe list of <see cref="T:System.Diagnostics.TraceListener" /> objects.</summary>
	// Token: 0x020000C7 RID: 199
	[DefaultMember("Item")]
	public class TraceListenerCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x00024525 File Offset: 0x00022725
		internal TraceListenerCollection()
		{
			this.list = new ArrayList(1);
		}

		/// <summary>Gets the number of listeners in the list.</summary>
		/// <returns>The number of listeners in the list.</returns>
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00024539 File Offset: 0x00022739
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Adds a <see cref="T:System.Diagnostics.TraceListener" /> to the list.</summary>
		/// <param name="listener">A <see cref="T:System.Diagnostics.TraceListener" /> to add to the list. </param>
		/// <returns>The position at which the new listener was inserted.</returns>
		// Token: 0x060005DE RID: 1502 RVA: 0x00024548 File Offset: 0x00022748
		public int Add(TraceListener listener)
		{
			this.InitializeListener(listener);
			object critSec = TraceInternal.critSec;
			int result;
			lock (critSec)
			{
				result = this.list.Add(listener);
			}
			return result;
		}

		/// <summary>Clears all the listeners from the list.</summary>
		// Token: 0x060005DF RID: 1503 RVA: 0x00024598 File Offset: 0x00022798
		public void Clear()
		{
			this.list = new ArrayList();
		}

		/// <summary>Gets an enumerator for this list.</summary>
		/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x060005E0 RID: 1504 RVA: 0x000245A5 File Offset: 0x000227A5
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000245B2 File Offset: 0x000227B2
		internal void InitializeListener(TraceListener listener)
		{
			if (listener == null)
			{
				throw new ArgumentNullException("listener");
			}
			listener.IndentSize = TraceInternal.IndentSize;
			listener.IndentLevel = TraceInternal.IndentLevel;
		}

		/// <summary>Removes from the collection the <see cref="T:System.Diagnostics.TraceListener" /> at the specified index.</summary>
		/// <param name="index">The zero-based index of the <see cref="T:System.Diagnostics.TraceListener" /> to remove from the list. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> is not a valid index in the list. </exception>
		// Token: 0x060005E2 RID: 1506 RVA: 0x000245D8 File Offset: 0x000227D8
		public void RemoveAt(int index)
		{
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.RemoveAt(index);
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Diagnostics.TraceListener" /> at the specified index in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="index">The zero-based index of the <paramref name="value" /> to get.</param>
		/// <returns>The <see cref="T:System.Diagnostics.TraceListener" /> at the specified index.</returns>
		// Token: 0x170000D1 RID: 209
		object IList.this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				TraceListener traceListener = value as TraceListener;
				if (traceListener == null)
				{
					throw new ArgumentException(SR.GetString("Only TraceListeners can be added to a TraceListenerCollection."), "value");
				}
				this.InitializeListener(traceListener);
				this.list[index] = traceListener;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> is read-only</summary>
		/// <returns>Always <see langword="false" />.</returns>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000023F6 File Offset: 0x000005F6
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> has a fixed size.</summary>
		/// <returns>Always <see langword="false" />.</returns>
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000023F6 File Offset: 0x000005F6
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Adds a trace listener to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">The object to add to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <returns>The position into which the new trace listener was inserted.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is <see langword="null" />. -or-
		///         <paramref name="value" /> is not a <see cref="T:System.Diagnostics.TraceListener" />.</exception>
		// Token: 0x060005E7 RID: 1511 RVA: 0x00024670 File Offset: 0x00022870
		int IList.Add(object value)
		{
			TraceListener traceListener = value as TraceListener;
			if (traceListener == null)
			{
				throw new ArgumentException(SR.GetString("Only TraceListeners can be added to a TraceListenerCollection."), "value");
			}
			this.InitializeListener(traceListener);
			object critSec = TraceInternal.critSec;
			int result;
			lock (critSec)
			{
				result = this.list.Add(value);
			}
			return result;
		}

		/// <summary>Determines whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> contains a specific object.</summary>
		/// <param name="value">The object to locate in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Diagnostics.TraceListenerCollection" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060005E8 RID: 1512 RVA: 0x000246E0 File Offset: 0x000228E0
		bool IList.Contains(object value)
		{
			return this.list.Contains(value);
		}

		/// <summary>Determines the index of a specific object in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">The object to locate in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <returns>The index of <paramref name="value" /> if found in the <see cref="T:System.Diagnostics.TraceListenerCollection" />; otherwise, -1.</returns>
		// Token: 0x060005E9 RID: 1513 RVA: 0x000246EE File Offset: 0x000228EE
		int IList.IndexOf(object value)
		{
			return this.list.IndexOf(value);
		}

		/// <summary>Inserts a <see cref="T:System.Diagnostics.TraceListener" /> object at the specified position in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Diagnostics.TraceListener" /> object to insert into the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.Diagnostics.TraceListener" /> object.</exception>
		// Token: 0x060005EA RID: 1514 RVA: 0x000246FC File Offset: 0x000228FC
		void IList.Insert(int index, object value)
		{
			TraceListener traceListener = value as TraceListener;
			if (traceListener == null)
			{
				throw new ArgumentException(SR.GetString("Only TraceListeners can be added to a TraceListenerCollection."), "value");
			}
			this.InitializeListener(traceListener);
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.Insert(index, value);
			}
		}

		/// <summary>Removes an object from the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <param name="value">The object to remove from the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
		// Token: 0x060005EB RID: 1515 RVA: 0x00024768 File Offset: 0x00022968
		void IList.Remove(object value)
		{
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.Remove(value);
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
		/// <returns>The current <see cref="T:System.Diagnostics.TraceListenerCollection" /> object.</returns>
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00014B09 File Offset: 0x00012D09
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Diagnostics.TraceListenerCollection" /> is synchronized (thread safe).</summary>
		/// <returns>Always <see langword="true" />.</returns>
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00009518 File Offset: 0x00007718
		bool ICollection.IsSynchronized
		{
			get
			{
				return true;
			}
		}

		/// <summary>Copies a section of the current <see cref="T:System.Diagnostics.TraceListenerCollection" /> to the specified array of <see cref="T:System.Diagnostics.TraceListener" /> objects. </summary>
		/// <param name="array">The one-dimensional array of <see cref="T:System.Diagnostics.TraceListener" /> objects that is the destination of the elements copied from the <see cref="T:System.Diagnostics.TraceListenerCollection" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		// Token: 0x060005EE RID: 1518 RVA: 0x000247B0 File Offset: 0x000229B0
		void ICollection.CopyTo(Array array, int index)
		{
			object critSec = TraceInternal.critSec;
			lock (critSec)
			{
				this.list.CopyTo(array, index);
			}
		}

		// Token: 0x040003C8 RID: 968
		private ArrayList list;
	}
}
