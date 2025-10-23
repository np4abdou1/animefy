using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000167 RID: 359
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged
	{
		// Token: 0x06000B61 RID: 2913 RVA: 0x00034B50 File Offset: 0x00032D50
		internal Task ReadTokenFromAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings options, CancellationToken cancellationToken = default(CancellationToken))
		{
			JContainer.<ReadTokenFromAsync>d__0 <ReadTokenFromAsync>d__;
			<ReadTokenFromAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReadTokenFromAsync>d__.<>4__this = this;
			<ReadTokenFromAsync>d__.reader = reader;
			<ReadTokenFromAsync>d__.options = options;
			<ReadTokenFromAsync>d__.cancellationToken = cancellationToken;
			<ReadTokenFromAsync>d__.<>1__state = -1;
			<ReadTokenFromAsync>d__.<>t__builder.Start<JContainer.<ReadTokenFromAsync>d__0>(ref <ReadTokenFromAsync>d__);
			return <ReadTokenFromAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00034BAC File Offset: 0x00032DAC
		private Task ReadContentFromAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			JContainer.<ReadContentFromAsync>d__1 <ReadContentFromAsync>d__;
			<ReadContentFromAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReadContentFromAsync>d__.<>4__this = this;
			<ReadContentFromAsync>d__.reader = reader;
			<ReadContentFromAsync>d__.settings = settings;
			<ReadContentFromAsync>d__.cancellationToken = cancellationToken;
			<ReadContentFromAsync>d__.<>1__state = -1;
			<ReadContentFromAsync>d__.<>t__builder.Start<JContainer.<ReadContentFromAsync>d__1>(ref <ReadContentFromAsync>d__);
			return <ReadContentFromAsync>d__.<>t__builder.Task;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000B63 RID: 2915 RVA: 0x00034C07 File Offset: 0x00032E07
		// (remove) Token: 0x06000B64 RID: 2916 RVA: 0x00034C20 File Offset: 0x00032E20
		public event ListChangedEventHandler ListChanged
		{
			add
			{
				this._listChanged = (ListChangedEventHandler)Delegate.Combine(this._listChanged, value);
			}
			remove
			{
				this._listChanged = (ListChangedEventHandler)Delegate.Remove(this._listChanged, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000B65 RID: 2917 RVA: 0x00034C39 File Offset: 0x00032E39
		// (remove) Token: 0x06000B66 RID: 2918 RVA: 0x00034C52 File Offset: 0x00032E52
		public event AddingNewEventHandler AddingNew
		{
			add
			{
				this._addingNew = (AddingNewEventHandler)Delegate.Combine(this._addingNew, value);
			}
			remove
			{
				this._addingNew = (AddingNewEventHandler)Delegate.Remove(this._addingNew, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000B67 RID: 2919 RVA: 0x00034C6B File Offset: 0x00032E6B
		// (remove) Token: 0x06000B68 RID: 2920 RVA: 0x00034C84 File Offset: 0x00032E84
		[Nullable(2)]
		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			[NullableContext(2)]
			add
			{
				this._collectionChanged = (NotifyCollectionChangedEventHandler)Delegate.Combine(this._collectionChanged, value);
			}
			[NullableContext(2)]
			remove
			{
				this._collectionChanged = (NotifyCollectionChangedEventHandler)Delegate.Remove(this._collectionChanged, value);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000B69 RID: 2921
		protected abstract IList<JToken> ChildrenTokens { get; }

		// Token: 0x06000B6A RID: 2922 RVA: 0x00034C9D File Offset: 0x00032E9D
		internal JContainer()
		{
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00034CA8 File Offset: 0x00032EA8
		internal JContainer(JContainer other, [Nullable(2)] JsonCloneSettings settings) : this()
		{
			ValidationUtils.ArgumentNotNull(other, "other");
			bool flag = settings == null || settings.CopyAnnotations;
			if (flag)
			{
				base.CopyAnnotations(this, other);
			}
			int num = 0;
			foreach (JToken content in ((IEnumerable<JToken>)other))
			{
				this.TryAddInternal(num, content, false, flag);
				num++;
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00034D24 File Offset: 0x00032F24
		internal void CheckReentrancy()
		{
			if (this._busy)
			{
				throw new InvalidOperationException("Cannot change {0} during a collection change event.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00034D49 File Offset: 0x00032F49
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			return new List<JToken>();
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00034D50 File Offset: 0x00032F50
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
			AddingNewEventHandler addingNew = this._addingNew;
			if (addingNew == null)
			{
				return;
			}
			addingNew(this, e);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00034D64 File Offset: 0x00032F64
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			ListChangedEventHandler listChanged = this._listChanged;
			if (listChanged != null)
			{
				this._busy = true;
				try
				{
					listChanged(this, e);
				}
				finally
				{
					this._busy = false;
				}
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00034DA4 File Offset: 0x00032FA4
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			NotifyCollectionChangedEventHandler collectionChanged = this._collectionChanged;
			if (collectionChanged != null)
			{
				this._busy = true;
				try
				{
					collectionChanged(this, e);
				}
				finally
				{
					this._busy = false;
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00034DE4 File Offset: 0x00032FE4
		public override bool HasValues
		{
			get
			{
				return this.ChildrenTokens.Count > 0;
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00034DF4 File Offset: 0x00032FF4
		internal bool ContentsEqual(JContainer container)
		{
			if (container == this)
			{
				return true;
			}
			IList<JToken> childrenTokens = this.ChildrenTokens;
			IList<JToken> childrenTokens2 = container.ChildrenTokens;
			if (childrenTokens.Count != childrenTokens2.Count)
			{
				return false;
			}
			for (int i = 0; i < childrenTokens.Count; i++)
			{
				if (!childrenTokens[i].DeepEquals(childrenTokens2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00034E50 File Offset: 0x00033050
		[Nullable(2)]
		public override JToken First
		{
			[NullableContext(2)]
			get
			{
				IList<JToken> childrenTokens = this.ChildrenTokens;
				if (childrenTokens.Count <= 0)
				{
					return null;
				}
				return childrenTokens[0];
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00034E78 File Offset: 0x00033078
		[Nullable(2)]
		public override JToken Last
		{
			[NullableContext(2)]
			get
			{
				IList<JToken> childrenTokens = this.ChildrenTokens;
				int count = childrenTokens.Count;
				if (count <= 0)
				{
					return null;
				}
				return childrenTokens[count - 1];
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00034EA2 File Offset: 0x000330A2
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public override JEnumerable<JToken> Children()
		{
			return new JEnumerable<JToken>(this.ChildrenTokens);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00034EAF File Offset: 0x000330AF
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public override IEnumerable<T> Values<T>()
		{
			return this.ChildrenTokens.Convert<JToken, T>();
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00034EBC File Offset: 0x000330BC
		public IEnumerable<JToken> Descendants()
		{
			return this.GetDescendants(false);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00034EC5 File Offset: 0x000330C5
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return this.GetDescendants(true);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00034ECE File Offset: 0x000330CE
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			if (self)
			{
				yield return this;
			}
			foreach (JToken o in this.ChildrenTokens)
			{
				yield return o;
				JContainer jcontainer = o as JContainer;
				if (jcontainer != null)
				{
					foreach (JToken jtoken in jcontainer.Descendants())
					{
						yield return jtoken;
					}
					IEnumerator<JToken> enumerator2 = null;
				}
				o = null;
			}
			IEnumerator<JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00034EE5 File Offset: 0x000330E5
		[NullableContext(2)]
		internal bool IsMultiContent([NotNullWhen(true)] object content)
		{
			return content is IEnumerable && !(content is string) && !(content is JToken) && !(content is byte[]);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00034F10 File Offset: 0x00033110
		internal JToken EnsureParentToken([Nullable(2)] JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			if (item == null)
			{
				return JValue.CreateNull();
			}
			if (skipParentCheck)
			{
				return item;
			}
			if (item.Parent != null || item == this || (item.HasValues && base.Root == item))
			{
				JsonCloneSettings settings = copyAnnotations ? null : JsonCloneSettings.SkipCopyAnnotations;
				item = item.CloneToken(settings);
			}
			return item;
		}

		// Token: 0x06000B7C RID: 2940
		[NullableContext(2)]
		internal abstract int IndexOfItem(JToken item);

		// Token: 0x06000B7D RID: 2941 RVA: 0x00034F60 File Offset: 0x00033160
		[NullableContext(2)]
		internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			IList<JToken> childrenTokens = this.ChildrenTokens;
			if (index > childrenTokens.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be within the bounds of the List.");
			}
			this.CheckReentrancy();
			item = this.EnsureParentToken(item, skipParentCheck, copyAnnotations);
			JToken jtoken = (index == 0) ? null : childrenTokens[index - 1];
			JToken jtoken2 = (index == childrenTokens.Count) ? null : childrenTokens[index];
			this.ValidateToken(item, null);
			item.Parent = this;
			item.Previous = jtoken;
			if (jtoken != null)
			{
				jtoken.Next = item;
			}
			item.Next = jtoken2;
			if (jtoken2 != null)
			{
				jtoken2.Previous = item;
			}
			childrenTokens.Insert(index, item);
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
			}
			return true;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00035028 File Offset: 0x00033228
		internal virtual void RemoveItemAt(int index)
		{
			IList<JToken> childrenTokens = this.ChildrenTokens;
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (index >= childrenTokens.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			this.CheckReentrancy();
			JToken jtoken = childrenTokens[index];
			JToken jtoken2 = (index == 0) ? null : childrenTokens[index - 1];
			JToken jtoken3 = (index == childrenTokens.Count - 1) ? null : childrenTokens[index + 1];
			if (jtoken2 != null)
			{
				jtoken2.Next = jtoken3;
			}
			if (jtoken3 != null)
			{
				jtoken3.Previous = jtoken2;
			}
			jtoken.Parent = null;
			jtoken.Previous = null;
			jtoken.Next = null;
			childrenTokens.RemoveAt(index);
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, jtoken, index));
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000350FC File Offset: 0x000332FC
		[NullableContext(2)]
		internal virtual bool RemoveItem(JToken item)
		{
			if (item != null)
			{
				int num = this.IndexOfItem(item);
				if (num >= 0)
				{
					this.RemoveItemAt(num);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00035122 File Offset: 0x00033322
		internal virtual JToken GetItem(int index)
		{
			return this.ChildrenTokens[index];
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00035130 File Offset: 0x00033330
		[NullableContext(2)]
		internal virtual void SetItem(int index, JToken item)
		{
			IList<JToken> childrenTokens = this.ChildrenTokens;
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (index >= childrenTokens.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			JToken jtoken = childrenTokens[index];
			if (JContainer.IsTokenUnchanged(jtoken, item))
			{
				return;
			}
			this.CheckReentrancy();
			item = this.EnsureParentToken(item, false, true);
			this.ValidateToken(item, jtoken);
			JToken jtoken2 = (index == 0) ? null : childrenTokens[index - 1];
			JToken jtoken3 = (index == childrenTokens.Count - 1) ? null : childrenTokens[index + 1];
			item.Parent = this;
			item.Previous = jtoken2;
			if (jtoken2 != null)
			{
				jtoken2.Next = item;
			}
			item.Next = jtoken3;
			if (jtoken3 != null)
			{
				jtoken3.Previous = item;
			}
			childrenTokens[index] = item;
			jtoken.Parent = null;
			jtoken.Previous = null;
			jtoken.Next = null;
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, item, jtoken, index));
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00035238 File Offset: 0x00033438
		internal virtual void ClearItems()
		{
			this.CheckReentrancy();
			IList<JToken> childrenTokens = this.ChildrenTokens;
			foreach (JToken jtoken in childrenTokens)
			{
				jtoken.Parent = null;
				jtoken.Previous = null;
				jtoken.Next = null;
			}
			childrenTokens.Clear();
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000352C8 File Offset: 0x000334C8
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
			if (existing == null || existing.Parent != this)
			{
				return;
			}
			int index = this.IndexOfItem(existing);
			this.SetItem(index, replacement);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000352F2 File Offset: 0x000334F2
		[NullableContext(2)]
		internal virtual bool ContainsItem(JToken item)
		{
			return this.IndexOfItem(item) != -1;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00035304 File Offset: 0x00033504
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (arrayIndex >= array.Length && arrayIndex != 0)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (this.Count > array.Length - arrayIndex)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (JToken value in this.ChildrenTokens)
			{
				array.SetValue(value, arrayIndex + num);
				num++;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000353B0 File Offset: 0x000335B0
		internal static bool IsTokenUnchanged(JToken currentValue, [Nullable(2)] JToken newValue)
		{
			JValue jvalue = currentValue as JValue;
			if (jvalue == null)
			{
				return false;
			}
			if (newValue == null)
			{
				return jvalue.Type == JTokenType.Null;
			}
			return jvalue.Equals(newValue);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000353DE File Offset: 0x000335DE
		internal virtual void ValidateToken(JToken o, [Nullable(2)] JToken existing)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			if (o.Type == JTokenType.Property)
			{
				throw new ArgumentException("Can not add {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00035415 File Offset: 0x00033615
		[NullableContext(2)]
		public virtual void Add(object content)
		{
			this.TryAddInternal(this.ChildrenTokens.Count, content, false, true);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0003542C File Offset: 0x0003362C
		[NullableContext(2)]
		internal bool TryAdd(object content)
		{
			return this.TryAddInternal(this.ChildrenTokens.Count, content, false, true);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00035442 File Offset: 0x00033642
		internal void AddAndSkipParentCheck(JToken token)
		{
			this.TryAddInternal(this.ChildrenTokens.Count, token, true, true);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00035459 File Offset: 0x00033659
		[NullableContext(2)]
		public void AddFirst(object content)
		{
			this.TryAddInternal(0, content, false, true);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00035468 File Offset: 0x00033668
		[NullableContext(2)]
		internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations)
		{
			if (this.IsMultiContent(content))
			{
				IEnumerable enumerable = (IEnumerable)content;
				int num = index;
				foreach (object content2 in enumerable)
				{
					this.TryAddInternal(num, content2, skipParentCheck, copyAnnotations);
					num++;
				}
				return true;
			}
			JToken item = JContainer.CreateFromContent(content);
			return this.InsertItem(index, item, skipParentCheck, copyAnnotations);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000354E8 File Offset: 0x000336E8
		internal static JToken CreateFromContent([Nullable(2)] object content)
		{
			JToken jtoken = content as JToken;
			if (jtoken != null)
			{
				return jtoken;
			}
			return new JValue(content);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00035507 File Offset: 0x00033707
		public JsonWriter CreateWriter()
		{
			return new JTokenWriter(this);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0003550F File Offset: 0x0003370F
		public void ReplaceAll(object content)
		{
			this.ClearItems();
			this.Add(content);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00033E50 File Offset: 0x00032050
		public void RemoveAll()
		{
			this.ClearItems();
		}

		// Token: 0x06000B91 RID: 2961
		internal abstract void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings);

		// Token: 0x06000B92 RID: 2962 RVA: 0x0003551E File Offset: 0x0003371E
		[NullableContext(2)]
		public void Merge(object content)
		{
			if (content == null)
			{
				return;
			}
			this.ValidateContent(content);
			this.MergeItem(content, null);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00035533 File Offset: 0x00033733
		[NullableContext(2)]
		public void Merge(object content, JsonMergeSettings settings)
		{
			if (content == null)
			{
				return;
			}
			this.ValidateContent(content);
			this.MergeItem(content, settings);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00035548 File Offset: 0x00033748
		private void ValidateContent(object content)
		{
			if (content.GetType().IsSubclassOf(typeof(JToken)))
			{
				return;
			}
			if (this.IsMultiContent(content))
			{
				return;
			}
			throw new ArgumentException("Could not determine JSON object type for type {0}.".FormatWith(CultureInfo.InvariantCulture, content.GetType()), "content");
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00035598 File Offset: 0x00033798
		internal void ReadTokenFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings options)
		{
			int depth = reader.Depth;
			if (!reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading {0} from JsonReader.".FormatWith(CultureInfo.InvariantCulture, base.GetType().Name));
			}
			this.ReadContentFrom(reader, options);
			if (reader.Depth > depth)
			{
				throw JsonReaderException.Create(reader, "Unexpected end of content while loading {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType().Name));
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00035608 File Offset: 0x00033808
		internal void ReadContentFrom(JsonReader r, [Nullable(2)] JsonLoadSettings settings)
		{
			ValidationUtils.ArgumentNotNull(r, "r");
			IJsonLineInfo lineInfo = r as IJsonLineInfo;
			JContainer jcontainer = this;
			for (;;)
			{
				JProperty jproperty = jcontainer as JProperty;
				if (jproperty != null && jproperty.Value != null)
				{
					if (jcontainer == this)
					{
						break;
					}
					jcontainer = jcontainer.Parent;
				}
				switch (r.TokenType)
				{
				case JsonToken.None:
					goto IL_1F2;
				case JsonToken.StartObject:
				{
					JObject jobject = new JObject();
					jobject.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jobject);
					jcontainer = jobject;
					goto IL_1F2;
				}
				case JsonToken.StartArray:
				{
					JArray jarray = new JArray();
					jarray.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jarray);
					jcontainer = jarray;
					goto IL_1F2;
				}
				case JsonToken.StartConstructor:
				{
					JConstructor jconstructor = new JConstructor(r.Value.ToString());
					jconstructor.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jconstructor);
					jcontainer = jconstructor;
					goto IL_1F2;
				}
				case JsonToken.PropertyName:
				{
					JProperty jproperty2 = JContainer.ReadProperty(r, settings, lineInfo, jcontainer);
					if (jproperty2 != null)
					{
						jcontainer = jproperty2;
						goto IL_1F2;
					}
					r.Skip();
					goto IL_1F2;
				}
				case JsonToken.Comment:
					if (settings != null && settings.CommentHandling == CommentHandling.Load)
					{
						JValue jvalue = JValue.CreateComment(r.Value.ToString());
						jvalue.SetLineInfo(lineInfo, settings);
						jcontainer.Add(jvalue);
						goto IL_1F2;
					}
					goto IL_1F2;
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.String:
				case JsonToken.Boolean:
				case JsonToken.Date:
				case JsonToken.Bytes:
				{
					JValue jvalue = new JValue(r.Value);
					jvalue.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jvalue);
					goto IL_1F2;
				}
				case JsonToken.Null:
				{
					JValue jvalue = JValue.CreateNull();
					jvalue.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jvalue);
					goto IL_1F2;
				}
				case JsonToken.Undefined:
				{
					JValue jvalue = JValue.CreateUndefined();
					jvalue.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jvalue);
					goto IL_1F2;
				}
				case JsonToken.EndObject:
					if (jcontainer == this)
					{
						return;
					}
					jcontainer = jcontainer.Parent;
					goto IL_1F2;
				case JsonToken.EndArray:
					if (jcontainer == this)
					{
						return;
					}
					jcontainer = jcontainer.Parent;
					goto IL_1F2;
				case JsonToken.EndConstructor:
					if (jcontainer == this)
					{
						return;
					}
					jcontainer = jcontainer.Parent;
					goto IL_1F2;
				}
				goto Block_4;
				IL_1F2:
				if (!r.Read())
				{
					return;
				}
			}
			return;
			Block_4:
			throw new InvalidOperationException("The JsonReader should not be on a token of type {0}.".FormatWith(CultureInfo.InvariantCulture, r.TokenType));
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00035814 File Offset: 0x00033A14
		[NullableContext(2)]
		private static JProperty ReadProperty([Nullable(1)] JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, [Nullable(1)] JContainer parent)
		{
			DuplicatePropertyNameHandling duplicatePropertyNameHandling = (settings != null) ? settings.DuplicatePropertyNameHandling : DuplicatePropertyNameHandling.Replace;
			JObject jobject = (JObject)parent;
			string text = r.Value.ToString();
			JProperty jproperty = jobject.Property(text, StringComparison.Ordinal);
			if (jproperty != null)
			{
				if (duplicatePropertyNameHandling == DuplicatePropertyNameHandling.Ignore)
				{
					return null;
				}
				if (duplicatePropertyNameHandling == DuplicatePropertyNameHandling.Error)
				{
					throw JsonReaderException.Create(r, "Property with the name '{0}' already exists in the current JSON object.".FormatWith(CultureInfo.InvariantCulture, text));
				}
			}
			JProperty jproperty2 = new JProperty(text);
			jproperty2.SetLineInfo(lineInfo, settings);
			if (jproperty == null)
			{
				parent.Add(jproperty2);
			}
			else
			{
				jproperty.Replace(jproperty2);
			}
			return jproperty2;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00035890 File Offset: 0x00033A90
		internal int ContentsHashCode()
		{
			int num = 0;
			foreach (JToken jtoken in this.ChildrenTokens)
			{
				num ^= jtoken.GetDeepHashCode();
			}
			return num;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000358E4 File Offset: 0x00033AE4
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return string.Empty;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000358EB File Offset: 0x00033AEB
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			ICustomTypeDescriptor customTypeDescriptor = this.First as ICustomTypeDescriptor;
			return ((customTypeDescriptor != null) ? customTypeDescriptor.GetProperties() : null) ?? new PropertyDescriptorCollection(CollectionUtils.ArrayEmpty<PropertyDescriptor>());
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00033E0C File Offset: 0x0003200C
		int IList<JToken>.IndexOf(JToken item)
		{
			return this.IndexOfItem(item);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00033E15 File Offset: 0x00032015
		void IList<JToken>.Insert(int index, JToken item)
		{
			this.InsertItem(index, item, false, true);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00033E22 File Offset: 0x00032022
		void IList<JToken>.RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x170001DE RID: 478
		JToken IList<JToken>.this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
			set
			{
				this.SetItem(index, value);
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00033E47 File Offset: 0x00032047
		void ICollection<JToken>.Add(JToken item)
		{
			this.Add(item);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00033E50 File Offset: 0x00032050
		void ICollection<JToken>.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00033E58 File Offset: 0x00032058
		bool ICollection<JToken>.Contains(JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00033E61 File Offset: 0x00032061
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
			this.CopyItemsTo(array, arrayIndex);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00016B42 File Offset: 0x00014D42
		bool ICollection<JToken>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00033E6B File Offset: 0x0003206B
		bool ICollection<JToken>.Remove(JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00035914 File Offset: 0x00033B14
		[NullableContext(2)]
		private JToken EnsureValue(object value)
		{
			if (value == null)
			{
				return null;
			}
			JToken jtoken = value as JToken;
			if (jtoken != null)
			{
				return jtoken;
			}
			throw new ArgumentException("Argument is not a JToken.");
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0003593C File Offset: 0x00033B3C
		[NullableContext(2)]
		int IList.Add(object value)
		{
			this.Add(this.EnsureValue(value));
			return this.Count - 1;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00033E50 File Offset: 0x00032050
		void IList.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00035953 File Offset: 0x00033B53
		[NullableContext(2)]
		bool IList.Contains(object value)
		{
			return this.ContainsItem(this.EnsureValue(value));
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00035962 File Offset: 0x00033B62
		[NullableContext(2)]
		int IList.IndexOf(object value)
		{
			return this.IndexOfItem(this.EnsureValue(value));
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00035971 File Offset: 0x00033B71
		[NullableContext(2)]
		void IList.Insert(int index, object value)
		{
			this.InsertItem(index, this.EnsureValue(value), false, false);
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00016B42 File Offset: 0x00014D42
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00016B42 File Offset: 0x00014D42
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00035984 File Offset: 0x00033B84
		[NullableContext(2)]
		void IList.Remove(object value)
		{
			this.RemoveItem(this.EnsureValue(value));
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00033E22 File Offset: 0x00032022
		void IList.RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x170001E2 RID: 482
		[Nullable(2)]
		object IList.this[int index]
		{
			[NullableContext(2)]
			get
			{
				return this.GetItem(index);
			}
			[NullableContext(2)]
			set
			{
				this.SetItem(index, this.EnsureValue(value));
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00033E61 File Offset: 0x00032061
		void ICollection.CopyTo(Array array, int index)
		{
			this.CopyItemsTo(array, index);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x000359A4 File Offset: 0x00033BA4
		public int Count
		{
			get
			{
				return this.ChildrenTokens.Count;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00016B42 File Offset: 0x00014D42
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000359B1 File Offset: 0x00033BB1
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000153AD File Offset: 0x000135AD
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000359D4 File Offset: 0x00033BD4
		object IBindingList.AddNew()
		{
			AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
			this.OnAddingNew(addingNewEventArgs);
			if (addingNewEventArgs.NewObject == null)
			{
				throw new JsonException("Could not determine new value to add to '{0}'.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
			JToken jtoken = addingNewEventArgs.NewObject as JToken;
			if (jtoken == null)
			{
				throw new JsonException("New item to be added to collection must be compatible with {0}.".FormatWith(CultureInfo.InvariantCulture, typeof(JToken)));
			}
			this.Add(jtoken);
			return jtoken;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00002E5B File Offset: 0x0000105B
		bool IBindingList.AllowEdit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00002E5B File Offset: 0x0000105B
		bool IBindingList.AllowNew
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00002E5B File Offset: 0x0000105B
		bool IBindingList.AllowRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0001F3BF File Offset: 0x0001D5BF
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0001F3BF File Offset: 0x0001D5BF
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00016B42 File Offset: 0x00014D42
		bool IBindingList.IsSorted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000153AD File Offset: 0x000135AD
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0001F3BF File Offset: 0x0001D5BF
		void IBindingList.RemoveSort()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00016B42 File Offset: 0x00014D42
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00035A47 File Offset: 0x00033C47
		[Nullable(2)]
		PropertyDescriptor IBindingList.SortProperty
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00002E5B File Offset: 0x0000105B
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00016B42 File Offset: 0x00014D42
		bool IBindingList.SupportsSearching
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00016B42 File Offset: 0x00014D42
		bool IBindingList.SupportsSorting
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00035A4C File Offset: 0x00033C4C
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, [Nullable(2)] JsonMergeSettings settings)
		{
			switch ((settings != null) ? settings.MergeArrayHandling : MergeArrayHandling.Concat)
			{
			case MergeArrayHandling.Concat:
				using (IEnumerator enumerator = content.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object content2 = enumerator.Current;
						target.Add(JContainer.CreateFromContent(content2));
					}
					return;
				}
				break;
			case MergeArrayHandling.Union:
				break;
			case MergeArrayHandling.Replace:
				goto IL_BC;
			case MergeArrayHandling.Merge:
				goto IL_108;
			default:
				goto IL_19E;
			}
			HashSet<JToken> hashSet = new HashSet<JToken>(target, JToken.EqualityComparer);
			using (IEnumerator enumerator = content.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object content3 = enumerator.Current;
					JToken jtoken = JContainer.CreateFromContent(content3);
					if (hashSet.Add(jtoken))
					{
						target.Add(jtoken);
					}
				}
				return;
			}
			IL_BC:
			if (target == content)
			{
				return;
			}
			target.ClearItems();
			using (IEnumerator enumerator = content.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object content4 = enumerator.Current;
					target.Add(JContainer.CreateFromContent(content4));
				}
				return;
			}
			IL_108:
			int num = 0;
			using (IEnumerator enumerator = content.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					if (num < target.Count)
					{
						JContainer jcontainer = target[num] as JContainer;
						if (jcontainer != null)
						{
							jcontainer.Merge(obj, settings);
						}
						else if (obj != null)
						{
							JToken jtoken2 = JContainer.CreateFromContent(obj);
							if (jtoken2.Type != JTokenType.Null)
							{
								target[num] = jtoken2;
							}
						}
					}
					else
					{
						target.Add(JContainer.CreateFromContent(obj));
					}
					num++;
				}
				return;
			}
			IL_19E:
			throw new ArgumentOutOfRangeException("settings", "Unexpected merge array handling when merging JSON.");
		}

		// Token: 0x0400069D RID: 1693
		[Nullable(2)]
		internal ListChangedEventHandler _listChanged;

		// Token: 0x0400069E RID: 1694
		[Nullable(2)]
		internal AddingNewEventHandler _addingNew;

		// Token: 0x0400069F RID: 1695
		[Nullable(2)]
		internal NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x040006A0 RID: 1696
		[Nullable(2)]
		private object _syncRoot;

		// Token: 0x040006A1 RID: 1697
		private bool _busy;
	}
}
