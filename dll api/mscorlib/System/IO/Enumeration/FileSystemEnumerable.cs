using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.IO.Enumeration
{
	// Token: 0x0200056B RID: 1387
	public class FileSystemEnumerable<TResult> : IEnumerable<!0>, IEnumerable
	{
		// Token: 0x06002974 RID: 10612 RVA: 0x000A5818 File Offset: 0x000A3A18
		public FileSystemEnumerable(string directory, FileSystemEnumerable<TResult>.FindTransform transform, EnumerationOptions options = null)
		{
			if (directory == null)
			{
				throw new ArgumentNullException("directory");
			}
			this._directory = directory;
			if (transform == null)
			{
				throw new ArgumentNullException("transform");
			}
			this._transform = transform;
			this._options = (options ?? EnumerationOptions.Default);
			this._enumerator = new FileSystemEnumerable<TResult>.DelegateEnumerator(this);
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x000A5873 File Offset: 0x000A3A73
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x000A587B File Offset: 0x000A3A7B
		public FileSystemEnumerable<TResult>.FindPredicate ShouldIncludePredicate { get; set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000A5884 File Offset: 0x000A3A84
		public FileSystemEnumerable<TResult>.FindPredicate ShouldRecursePredicate { get; }

		// Token: 0x06002978 RID: 10616 RVA: 0x000A588C File Offset: 0x000A3A8C
		public IEnumerator<TResult> GetEnumerator()
		{
			return Interlocked.Exchange<FileSystemEnumerable<TResult>.DelegateEnumerator>(ref this._enumerator, null) ?? new FileSystemEnumerable<TResult>.DelegateEnumerator(this);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000A58A4 File Offset: 0x000A3AA4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400159E RID: 5534
		private FileSystemEnumerable<TResult>.DelegateEnumerator _enumerator;

		// Token: 0x0400159F RID: 5535
		private readonly FileSystemEnumerable<TResult>.FindTransform _transform;

		// Token: 0x040015A0 RID: 5536
		private readonly EnumerationOptions _options;

		// Token: 0x040015A1 RID: 5537
		private readonly string _directory;

		// Token: 0x0200056C RID: 1388
		// (Invoke) Token: 0x0600297B RID: 10619
		public delegate bool FindPredicate(ref FileSystemEntry entry);

		// Token: 0x0200056D RID: 1389
		// (Invoke) Token: 0x0600297F RID: 10623
		public delegate TResult FindTransform(ref FileSystemEntry entry);

		// Token: 0x0200056E RID: 1390
		private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
		{
			// Token: 0x06002982 RID: 10626 RVA: 0x000A58AC File Offset: 0x000A3AAC
			public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable) : base(enumerable._directory, enumerable._options)
			{
				this._enumerable = enumerable;
			}

			// Token: 0x06002983 RID: 10627 RVA: 0x000A58C7 File Offset: 0x000A3AC7
			protected override TResult TransformEntry(ref FileSystemEntry entry)
			{
				return this._enumerable._transform(ref entry);
			}

			// Token: 0x06002984 RID: 10628 RVA: 0x000A58DA File Offset: 0x000A3ADA
			protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
			{
				FileSystemEnumerable<TResult>.FindPredicate shouldRecursePredicate = this._enumerable.ShouldRecursePredicate;
				return shouldRecursePredicate == null || shouldRecursePredicate(ref entry);
			}

			// Token: 0x06002985 RID: 10629 RVA: 0x000A58F3 File Offset: 0x000A3AF3
			protected override bool ShouldIncludeEntry(ref FileSystemEntry entry)
			{
				FileSystemEnumerable<TResult>.FindPredicate shouldIncludePredicate = this._enumerable.ShouldIncludePredicate;
				return shouldIncludePredicate == null || shouldIncludePredicate(ref entry);
			}

			// Token: 0x040015A4 RID: 5540
			private readonly FileSystemEnumerable<TResult> _enumerable;
		}
	}
}
