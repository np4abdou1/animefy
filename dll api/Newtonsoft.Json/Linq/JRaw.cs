using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017A RID: 378
	[NullableContext(1)]
	[Nullable(0)]
	public class JRaw : JValue
	{
		// Token: 0x06000C8E RID: 3214 RVA: 0x000384A4 File Offset: 0x000366A4
		public static Task<JRaw> CreateAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			JRaw.<CreateAsync>d__0 <CreateAsync>d__;
			<CreateAsync>d__.<>t__builder = AsyncTaskMethodBuilder<JRaw>.Create();
			<CreateAsync>d__.reader = reader;
			<CreateAsync>d__.cancellationToken = cancellationToken;
			<CreateAsync>d__.<>1__state = -1;
			<CreateAsync>d__.<>t__builder.Start<JRaw.<CreateAsync>d__0>(ref <CreateAsync>d__);
			return <CreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000384EF File Offset: 0x000366EF
		public JRaw(JRaw other) : base(other, null)
		{
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000384F9 File Offset: 0x000366F9
		internal JRaw(JRaw other, [Nullable(2)] JsonCloneSettings settings) : base(other, settings)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00038503 File Offset: 0x00036703
		[NullableContext(2)]
		public JRaw(object rawJson) : base(rawJson, JTokenType.Raw)
		{
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00038510 File Offset: 0x00036710
		public static JRaw Create(JsonReader reader)
		{
			JRaw result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				using (JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter))
				{
					jsonTextWriter.WriteToken(reader);
					result = new JRaw(stringWriter.ToString());
				}
			}
			return result;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00038578 File Offset: 0x00036778
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return new JRaw(this, settings);
		}
	}
}
