using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading
{
	/// <summary>Provides thread-local storage of data.</summary>
	/// <typeparam name="T">Specifies the type of data stored per-thread.</typeparam>
	// Token: 0x020001CC RID: 460
	[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<>))]
	[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
	public class ThreadLocal<T> : IDisposable
	{
		/// <summary>Initializes the <see cref="T:System.Threading.ThreadLocal`1" /> instance with the specified <paramref name="valueFactory" /> function and a flag that indicates whether all values are accessible from any thread.</summary>
		/// <param name="valueFactory">The <see cref="T:System.Func`1" /> invoked to produce a lazily-initialized value when an attempt is made to retrieve <see cref="P:System.Threading.ThreadLocal`1.Value" /> without it having been previously initialized.</param>
		/// <param name="trackAllValues">
		///       <see langword="true" /> to track all values set on the instance and expose them through the <see cref="P:System.Threading.ThreadLocal`1.Values" /> property; <see langword="false" /> otherwise.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="valueFactory" /> is a <see langword="null" /> reference (<see langword="Nothing" /> in Visual Basic).</exception>
		// Token: 0x060010FA RID: 4346 RVA: 0x000465C8 File Offset: 0x000447C8
		public ThreadLocal(Func<T> valueFactory, bool trackAllValues)
		{
			if (valueFactory == null)
			{
				throw new ArgumentNullException("valueFactory");
			}
			this.Initialize(valueFactory, trackAllValues);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000465F4 File Offset: 0x000447F4
		private void Initialize(Func<T> valueFactory, bool trackAllValues)
		{
			this.m_valueFactory = valueFactory;
			this.m_trackAllValues = trackAllValues;
			try
			{
			}
			finally
			{
				this.m_idComplement = ~ThreadLocal<T>.s_idManager.GetId();
				this.m_initialized = true;
			}
		}

		/// <summary>Releases the resources used by this <see cref="T:System.Threading.ThreadLocal`1" /> instance.</summary>
		// Token: 0x060010FC RID: 4348 RVA: 0x0004663C File Offset: 0x0004483C
		~ThreadLocal()
		{
			this.Dispose(false);
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ThreadLocal`1" /> class.</summary>
		// Token: 0x060010FD RID: 4349 RVA: 0x0004666C File Offset: 0x0004486C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the resources used by this <see cref="T:System.Threading.ThreadLocal`1" /> instance.</summary>
		/// <param name="disposing">A Boolean value that indicates whether this method is being called due to a call to <see cref="M:System.Threading.ThreadLocal`1.Dispose" />.</param>
		// Token: 0x060010FE RID: 4350 RVA: 0x0004667C File Offset: 0x0004487C
		protected virtual void Dispose(bool disposing)
		{
			ThreadLocal<T>.IdManager obj = ThreadLocal<T>.s_idManager;
			int num;
			lock (obj)
			{
				num = ~this.m_idComplement;
				this.m_idComplement = 0;
				if (num < 0 || !this.m_initialized)
				{
					return;
				}
				this.m_initialized = false;
				for (ThreadLocal<T>.LinkedSlot next = this.m_linkedSlot.Next; next != null; next = next.Next)
				{
					ThreadLocal<T>.LinkedSlotVolatile[] slotArray = next.SlotArray;
					if (slotArray != null)
					{
						next.SlotArray = null;
						slotArray[num].Value.Value = default(T);
						slotArray[num].Value = null;
					}
				}
			}
			this.m_linkedSlot = null;
			ThreadLocal<T>.s_idManager.ReturnId(num);
		}

		/// <summary>Creates and returns a string representation of this instance for the current thread.</summary>
		/// <returns>The result of calling <see cref="M:System.Object.ToString" /> on the <see cref="P:System.Threading.ThreadLocal`1.Value" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
		/// <exception cref="T:System.NullReferenceException">The <see cref="P:System.Threading.ThreadLocal`1.Value" /> for the current thread is a null reference (Nothing in Visual Basic).</exception>
		/// <exception cref="T:System.InvalidOperationException">The initialization function attempted to reference <see cref="P:System.Threading.ThreadLocal`1.Value" /> recursively.</exception>
		/// <exception cref="T:System.MissingMemberException">No default constructor is provided and no value factory is supplied.</exception>
		// Token: 0x060010FF RID: 4351 RVA: 0x00046750 File Offset: 0x00044950
		public override string ToString()
		{
			T value = this.Value;
			return value.ToString();
		}

		/// <summary>Gets or sets the value of this instance for the current thread.</summary>
		/// <returns>Returns an instance of the object that this ThreadLocal is responsible for initializing.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The initialization function attempted to reference <see cref="P:System.Threading.ThreadLocal`1.Value" /> recursively.</exception>
		/// <exception cref="T:System.MissingMemberException">No default constructor is provided and no value factory is supplied.</exception>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00046774 File Offset: 0x00044974
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x000467C8 File Offset: 0x000449C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			get
			{
				ThreadLocal<T>.LinkedSlotVolatile[] array = ThreadLocal<T>.ts_slotArray;
				int num = ~this.m_idComplement;
				ThreadLocal<T>.LinkedSlot value;
				if (array != null && num >= 0 && num < array.Length && (value = array[num].Value) != null && this.m_initialized)
				{
					return value.Value;
				}
				return this.GetValueSlow();
			}
			set
			{
				ThreadLocal<T>.LinkedSlotVolatile[] array = ThreadLocal<T>.ts_slotArray;
				int num = ~this.m_idComplement;
				ThreadLocal<T>.LinkedSlot value2;
				if (array != null && num >= 0 && num < array.Length && (value2 = array[num].Value) != null && this.m_initialized)
				{
					value2.Value = value;
					return;
				}
				this.SetValueSlow(value, array);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0004681C File Offset: 0x00044A1C
		private T GetValueSlow()
		{
			if (~this.m_idComplement < 0)
			{
				throw new ObjectDisposedException(Environment.GetResourceString("The ThreadLocal object has been disposed."));
			}
			Debugger.NotifyOfCrossThreadDependency();
			T t;
			if (this.m_valueFactory == null)
			{
				t = default(T);
			}
			else
			{
				t = this.m_valueFactory();
				if (this.IsValueCreated)
				{
					throw new InvalidOperationException(Environment.GetResourceString("ValueFactory attempted to access the Value property of this instance."));
				}
			}
			this.Value = t;
			return t;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00046888 File Offset: 0x00044A88
		private void SetValueSlow(T value, ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
		{
			int num = ~this.m_idComplement;
			if (num < 0)
			{
				throw new ObjectDisposedException(Environment.GetResourceString("The ThreadLocal object has been disposed."));
			}
			if (slotArray == null)
			{
				slotArray = new ThreadLocal<T>.LinkedSlotVolatile[ThreadLocal<T>.GetNewTableSize(num + 1)];
				ThreadLocal<T>.ts_finalizationHelper = new ThreadLocal<T>.FinalizationHelper(slotArray, this.m_trackAllValues);
				ThreadLocal<T>.ts_slotArray = slotArray;
			}
			if (num >= slotArray.Length)
			{
				this.GrowTable(ref slotArray, num + 1);
				ThreadLocal<T>.ts_finalizationHelper.SlotArray = slotArray;
				ThreadLocal<T>.ts_slotArray = slotArray;
			}
			if (slotArray[num].Value == null)
			{
				this.CreateLinkedSlot(slotArray, num, value);
				return;
			}
			ThreadLocal<T>.LinkedSlot value2 = slotArray[num].Value;
			if (!this.m_initialized)
			{
				throw new ObjectDisposedException(Environment.GetResourceString("The ThreadLocal object has been disposed."));
			}
			value2.Value = value;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00046944 File Offset: 0x00044B44
		private void CreateLinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, int id, T value)
		{
			ThreadLocal<T>.LinkedSlot linkedSlot = new ThreadLocal<T>.LinkedSlot(slotArray);
			ThreadLocal<T>.IdManager obj = ThreadLocal<T>.s_idManager;
			lock (obj)
			{
				if (!this.m_initialized)
				{
					throw new ObjectDisposedException(Environment.GetResourceString("The ThreadLocal object has been disposed."));
				}
				ThreadLocal<T>.LinkedSlot next = this.m_linkedSlot.Next;
				linkedSlot.Next = next;
				linkedSlot.Previous = this.m_linkedSlot;
				linkedSlot.Value = value;
				if (next != null)
				{
					next.Previous = linkedSlot;
				}
				this.m_linkedSlot.Next = linkedSlot;
				slotArray[id].Value = linkedSlot;
			}
		}

		/// <summary>Gets a list for all of the values currently stored by all of the threads that have accessed this instance.</summary>
		/// <returns>A list for all of the values currently stored by all of the threads that have accessed this instance.</returns>
		/// <exception cref="T:System.InvalidOperationException">Values stored by all threads are not available because this instance was initialized with the <paramref name="trackAllValues" /> argument set to <see langword="false" /> in the call to a class constructor. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000469F4 File Offset: 0x00044BF4
		public IList<T> Values
		{
			get
			{
				if (!this.m_trackAllValues)
				{
					throw new InvalidOperationException(Environment.GetResourceString("The ThreadLocal object is not tracking values. To use the Values property, use a ThreadLocal constructor that accepts the trackAllValues parameter and set the parameter to true."));
				}
				List<T> valuesAsList = this.GetValuesAsList();
				if (valuesAsList == null)
				{
					throw new ObjectDisposedException(Environment.GetResourceString("The ThreadLocal object has been disposed."));
				}
				return valuesAsList;
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00046A28 File Offset: 0x00044C28
		private List<T> GetValuesAsList()
		{
			List<T> list = new List<T>();
			if (~this.m_idComplement == -1)
			{
				return null;
			}
			for (ThreadLocal<T>.LinkedSlot next = this.m_linkedSlot.Next; next != null; next = next.Next)
			{
				list.Add(next.Value);
			}
			return list;
		}

		/// <summary>Gets whether <see cref="P:System.Threading.ThreadLocal`1.Value" /> is initialized on the current thread.</summary>
		/// <returns>true if <see cref="P:System.Threading.ThreadLocal`1.Value" /> is initialized on the current thread; otherwise false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00046A70 File Offset: 0x00044C70
		public bool IsValueCreated
		{
			get
			{
				int num = ~this.m_idComplement;
				if (num < 0)
				{
					throw new ObjectDisposedException(Environment.GetResourceString("The ThreadLocal object has been disposed."));
				}
				ThreadLocal<T>.LinkedSlotVolatile[] array = ThreadLocal<T>.ts_slotArray;
				return array != null && num < array.Length && array[num].Value != null;
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00046ABC File Offset: 0x00044CBC
		private void GrowTable(ref ThreadLocal<T>.LinkedSlotVolatile[] table, int minLength)
		{
			ThreadLocal<T>.LinkedSlotVolatile[] array = new ThreadLocal<T>.LinkedSlotVolatile[ThreadLocal<T>.GetNewTableSize(minLength)];
			ThreadLocal<T>.IdManager obj = ThreadLocal<T>.s_idManager;
			lock (obj)
			{
				for (int i = 0; i < table.Length; i++)
				{
					ThreadLocal<T>.LinkedSlot value = table[i].Value;
					if (value != null && value.SlotArray != null)
					{
						value.SlotArray = array;
						array[i] = table[i];
					}
				}
			}
			table = array;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00046B4C File Offset: 0x00044D4C
		private static int GetNewTableSize(int minSize)
		{
			if (minSize > 2146435071)
			{
				return int.MaxValue;
			}
			int num = minSize - 1;
			num |= num >> 1;
			num |= num >> 2;
			num |= num >> 4;
			num |= num >> 8;
			num |= num >> 16;
			num++;
			if (num > 2146435071)
			{
				num = 2146435071;
			}
			return num;
		}

		// Token: 0x04000689 RID: 1673
		private Func<T> m_valueFactory;

		// Token: 0x0400068A RID: 1674
		[ThreadStatic]
		private static ThreadLocal<T>.LinkedSlotVolatile[] ts_slotArray;

		// Token: 0x0400068B RID: 1675
		[ThreadStatic]
		private static ThreadLocal<T>.FinalizationHelper ts_finalizationHelper;

		// Token: 0x0400068C RID: 1676
		private int m_idComplement;

		// Token: 0x0400068D RID: 1677
		private volatile bool m_initialized;

		// Token: 0x0400068E RID: 1678
		private static ThreadLocal<T>.IdManager s_idManager = new ThreadLocal<T>.IdManager();

		// Token: 0x0400068F RID: 1679
		private ThreadLocal<T>.LinkedSlot m_linkedSlot = new ThreadLocal<T>.LinkedSlot(null);

		// Token: 0x04000690 RID: 1680
		private bool m_trackAllValues;

		// Token: 0x020001CD RID: 461
		private struct LinkedSlotVolatile
		{
			// Token: 0x04000691 RID: 1681
			internal volatile ThreadLocal<T>.LinkedSlot Value;
		}

		// Token: 0x020001CE RID: 462
		private sealed class LinkedSlot
		{
			// Token: 0x0600110B RID: 4363 RVA: 0x00046BAB File Offset: 0x00044DAB
			internal LinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
			{
				this.SlotArray = slotArray;
			}

			// Token: 0x04000692 RID: 1682
			internal volatile ThreadLocal<T>.LinkedSlot Next;

			// Token: 0x04000693 RID: 1683
			internal volatile ThreadLocal<T>.LinkedSlot Previous;

			// Token: 0x04000694 RID: 1684
			internal volatile ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			// Token: 0x04000695 RID: 1685
			internal T Value;
		}

		// Token: 0x020001CF RID: 463
		private class IdManager
		{
			// Token: 0x0600110C RID: 4364 RVA: 0x00046BBC File Offset: 0x00044DBC
			internal int GetId()
			{
				List<bool> freeIds = this.m_freeIds;
				int result;
				lock (freeIds)
				{
					int num = this.m_nextIdToTry;
					while (num < this.m_freeIds.Count && !this.m_freeIds[num])
					{
						num++;
					}
					if (num == this.m_freeIds.Count)
					{
						this.m_freeIds.Add(false);
					}
					else
					{
						this.m_freeIds[num] = false;
					}
					this.m_nextIdToTry = num + 1;
					result = num;
				}
				return result;
			}

			// Token: 0x0600110D RID: 4365 RVA: 0x00046C54 File Offset: 0x00044E54
			internal void ReturnId(int id)
			{
				List<bool> freeIds = this.m_freeIds;
				lock (freeIds)
				{
					this.m_freeIds[id] = true;
					if (id < this.m_nextIdToTry)
					{
						this.m_nextIdToTry = id;
					}
				}
			}

			// Token: 0x04000696 RID: 1686
			private int m_nextIdToTry;

			// Token: 0x04000697 RID: 1687
			private List<bool> m_freeIds = new List<bool>();
		}

		// Token: 0x020001D0 RID: 464
		private class FinalizationHelper
		{
			// Token: 0x0600110F RID: 4367 RVA: 0x00046CBF File Offset: 0x00044EBF
			internal FinalizationHelper(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, bool trackAllValues)
			{
				this.SlotArray = slotArray;
				this.m_trackAllValues = trackAllValues;
			}

			// Token: 0x06001110 RID: 4368 RVA: 0x00046CD8 File Offset: 0x00044ED8
			protected override void Finalize()
			{
				try
				{
					ThreadLocal<T>.LinkedSlotVolatile[] slotArray = this.SlotArray;
					for (int i = 0; i < slotArray.Length; i++)
					{
						ThreadLocal<T>.LinkedSlot value = slotArray[i].Value;
						if (value != null)
						{
							if (this.m_trackAllValues)
							{
								value.SlotArray = null;
							}
							else
							{
								ThreadLocal<T>.IdManager s_idManager = ThreadLocal<T>.s_idManager;
								lock (s_idManager)
								{
									if (value.Next != null)
									{
										value.Next.Previous = value.Previous;
									}
									value.Previous.Next = value.Next;
								}
							}
						}
					}
				}
				finally
				{
					base.Finalize();
				}
			}

			// Token: 0x04000698 RID: 1688
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			// Token: 0x04000699 RID: 1689
			private bool m_trackAllValues;
		}
	}
}
