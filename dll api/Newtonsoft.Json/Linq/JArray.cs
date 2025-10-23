using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000161 RID: 353
	[NullableContext(1)]
	[Nullable(0)]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		// Token: 0x06000B1E RID: 2846 RVA: 0x00033A7C File Offset: 0x00031C7C
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			JArray.<WriteToAsync>d__0 <WriteToAsync>d__;
			<WriteToAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteToAsync>d__.<>4__this = this;
			<WriteToAsync>d__.writer = writer;
			<WriteToAsync>d__.cancellationToken = cancellationToken;
			<WriteToAsync>d__.converters = converters;
			<WriteToAsync>d__.<>1__state = -1;
			<WriteToAsync>d__.<>t__builder.Start<JArray.<WriteToAsync>d__0>(ref <WriteToAsync>d__);
			return <WriteToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00033AD7 File Offset: 0x00031CD7
		public new static Task<JArray> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JArray.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00033AE4 File Offset: 0x00031CE4
		public new static Task<JArray> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			JArray.<LoadAsync>d__2 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<JArray>.Create();
			<LoadAsync>d__.reader = reader;
			<LoadAsync>d__.settings = settings;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<JArray.<LoadAsync>d__2>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00033B37 File Offset: 0x00031D37
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00033B3F File Offset: 0x00031D3F
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Array;
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00033B42 File Offset: 0x00031D42
		public JArray()
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00033B55 File Offset: 0x00031D55
		public JArray(JArray other) : base(other, null)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00033B6A File Offset: 0x00031D6A
		internal JArray(JArray other, [Nullable(2)] JsonCloneSettings settings) : base(other, settings)
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00033B7F File Offset: 0x00031D7F
		public JArray(params object[] content) : this(content)
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00033B88 File Offset: 0x00031D88
		public JArray(object content)
		{
			this.Add(content);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00033BA4 File Offset: 0x00031DA4
		internal override bool DeepEquals(JToken node)
		{
			JArray jarray = node as JArray;
			return jarray != null && base.ContentsEqual(jarray);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00033BC4 File Offset: 0x00031DC4
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings = null)
		{
			return new JArray(this, settings);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00033BCD File Offset: 0x00031DCD
		public new static JArray Load(JsonReader reader)
		{
			return JArray.Load(reader, null);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00033BD8 File Offset: 0x00031DD8
		public new static JArray Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JArray from JsonReader.");
			}
			reader.MoveToContent();
			if (reader.TokenType != JsonToken.StartArray)
			{
				throw JsonReaderException.Create(reader, "Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			JArray jarray = new JArray();
			jarray.SetLineInfo(reader as IJsonLineInfo, settings);
			jarray.ReadTokenFrom(reader, settings);
			return jarray;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00033C4C File Offset: 0x00031E4C
		public new static JArray Parse(string json)
		{
			return JArray.Parse(json, null);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00033C58 File Offset: 0x00031E58
		public new static JArray Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			JArray result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				JArray jarray = JArray.Load(jsonReader, settings);
				while (jsonReader.Read())
				{
				}
				result = jarray;
			}
			return result;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00033CA0 File Offset: 0x00031EA0
		public new static JArray FromObject(object o)
		{
			return JArray.FromObject(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00033CB0 File Offset: 0x00031EB0
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			JToken jtoken = JToken.FromObjectInternal(o, jsonSerializer);
			if (jtoken.Type != JTokenType.Array)
			{
				throw new ArgumentException("Object serialized to {0}. JArray instance expected.".FormatWith(CultureInfo.InvariantCulture, jtoken.Type));
			}
			return (JArray)jtoken;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00033CF4 File Offset: 0x00031EF4
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartArray();
			for (int i = 0; i < this._values.Count; i++)
			{
				this._values[i].WriteTo(writer, converters);
			}
			writer.WriteEndArray();
		}

		// Token: 0x170001D3 RID: 467
		[Nullable(2)]
		public override JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				ValidationUtils.ArgumentNotNull(key, "key");
				if (!(key is int))
				{
					throw new ArgumentException("Accessed JArray values with invalid key value: {0}. Int32 array index expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				return this.GetItem((int)key);
			}
			[param: Nullable(2)]
			set
			{
				ValidationUtils.ArgumentNotNull(key, "key");
				if (!(key is int))
				{
					throw new ArgumentException("Set JArray values with invalid key value: {0}. Int32 array index expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				this.SetItem((int)key, value);
			}
		}

		// Token: 0x170001D4 RID: 468
		public JToken this[int index]
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

		// Token: 0x06000B35 RID: 2869 RVA: 0x00033DC2 File Offset: 0x00031FC2
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			if (item == null)
			{
				return -1;
			}
			return this._values.IndexOfReference(item);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00033DD8 File Offset: 0x00031FD8
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
			IEnumerable enumerable = (base.IsMultiContent(content) || content is JArray) ? ((IEnumerable)content) : null;
			if (enumerable == null)
			{
				return;
			}
			JContainer.MergeEnumerableContent(this, enumerable, settings);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00033E0C File Offset: 0x0003200C
		public int IndexOf(JToken item)
		{
			return this.IndexOfItem(item);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00033E15 File Offset: 0x00032015
		public void Insert(int index, JToken item)
		{
			this.InsertItem(index, item, false, true);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00033E22 File Offset: 0x00032022
		public void RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00033E2C File Offset: 0x0003202C
		public IEnumerator<JToken> GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00033E47 File Offset: 0x00032047
		public void Add(JToken item)
		{
			this.Add(item);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00033E50 File Offset: 0x00032050
		public void Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00033E58 File Offset: 0x00032058
		public bool Contains(JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00033E61 File Offset: 0x00032061
		public void CopyTo(JToken[] array, int arrayIndex)
		{
			this.CopyItemsTo(array, arrayIndex);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00016B42 File Offset: 0x00014D42
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00033E6B File Offset: 0x0003206B
		public bool Remove(JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00033E74 File Offset: 0x00032074
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x0400067A RID: 1658
		private readonly List<JToken> _values = new List<JToken>();
	}
}
