using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000EE RID: 238
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/Typography", DoNotGenerateAcw = true)]
	public sealed class Typography : Java.Lang.Object
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00020DB0 File Offset: 0x0001EFB0
		[Register("INSTANCE")]
		public static Typography Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<Typography>(Typography._members.StaticFields.GetObjectValue("INSTANCE.Lkotlin/text/Typography;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00020DE0 File Offset: 0x0001EFE0
		internal static IntPtr class_ref
		{
			get
			{
				return Typography._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00020E04 File Offset: 0x0001F004
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Typography._members;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00020E0C File Offset: 0x0001F00C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Typography._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00020E30 File Offset: 0x0001F030
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Typography._members.ManagedPeerType;
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00020E3C File Offset: 0x0001F03C
		internal Typography(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400022D RID: 557
		[Register("almostEqual")]
		public const char AlmostEqual = '≈';

		// Token: 0x0400022E RID: 558
		[Register("amp")]
		public const char Amp = '&';

		// Token: 0x0400022F RID: 559
		[Register("bullet")]
		public const char Bullet = '•';

		// Token: 0x04000230 RID: 560
		[Register("cent")]
		public const char Cent = '¢';

		// Token: 0x04000231 RID: 561
		[Register("copyright")]
		public const char Copyright = '©';

		// Token: 0x04000232 RID: 562
		[Register("dagger")]
		public const char Dagger = '†';

		// Token: 0x04000233 RID: 563
		[Register("degree")]
		public const char Degree = '°';

		// Token: 0x04000234 RID: 564
		[Register("dollar")]
		public const char Dollar = '$';

		// Token: 0x04000235 RID: 565
		[Register("doubleDagger")]
		public const char DoubleDagger = '‡';

		// Token: 0x04000236 RID: 566
		[Register("doublePrime")]
		public const char DoublePrime = '″';

		// Token: 0x04000237 RID: 567
		[Register("ellipsis")]
		public const char Ellipsis = '…';

		// Token: 0x04000238 RID: 568
		[Register("euro")]
		public const char Euro = '€';

		// Token: 0x04000239 RID: 569
		[Register("greater")]
		public const char Greater = '>';

		// Token: 0x0400023A RID: 570
		[Register("greaterOrEqual")]
		public const char GreaterOrEqual = '≥';

		// Token: 0x0400023B RID: 571
		[Register("half")]
		public const char Half = '½';

		// Token: 0x0400023C RID: 572
		[Register("leftDoubleQuote")]
		public const char LeftDoubleQuote = '“';

		// Token: 0x0400023D RID: 573
		[Register("leftGuillemet")]
		public const char LeftGuillemet = '«';

		// Token: 0x0400023E RID: 574
		[Register("leftGuillemete")]
		[Obsolete("deprecated")]
		public const char LeftGuillemete = '«';

		// Token: 0x0400023F RID: 575
		[Register("leftSingleQuote")]
		public const char LeftSingleQuote = '‘';

		// Token: 0x04000240 RID: 576
		[Register("less")]
		public const char Less = '<';

		// Token: 0x04000241 RID: 577
		[Register("lessOrEqual")]
		public const char LessOrEqual = '≤';

		// Token: 0x04000242 RID: 578
		[Register("lowDoubleQuote")]
		public const char LowDoubleQuote = '„';

		// Token: 0x04000243 RID: 579
		[Register("lowSingleQuote")]
		public const char LowSingleQuote = '‚';

		// Token: 0x04000244 RID: 580
		[Register("mdash")]
		public const char Mdash = '—';

		// Token: 0x04000245 RID: 581
		[Register("middleDot")]
		public const char MiddleDot = '·';

		// Token: 0x04000246 RID: 582
		[Register("nbsp")]
		public const char Nbsp = '\u00a0';

		// Token: 0x04000247 RID: 583
		[Register("ndash")]
		public const char Ndash = '–';

		// Token: 0x04000248 RID: 584
		[Register("notEqual")]
		public const char NotEqual = '≠';

		// Token: 0x04000249 RID: 585
		[Register("paragraph")]
		public const char Paragraph = '¶';

		// Token: 0x0400024A RID: 586
		[Register("plusMinus")]
		public const char PlusMinus = '±';

		// Token: 0x0400024B RID: 587
		[Register("pound")]
		public const char Pound = '£';

		// Token: 0x0400024C RID: 588
		[Register("prime")]
		public const char Prime = '′';

		// Token: 0x0400024D RID: 589
		[Register("quote")]
		public const char Quote = '"';

		// Token: 0x0400024E RID: 590
		[Register("registered")]
		public const char Registered = '®';

		// Token: 0x0400024F RID: 591
		[Register("rightDoubleQuote")]
		public const char RightDoubleQuote = '”';

		// Token: 0x04000250 RID: 592
		[Register("rightGuillemet")]
		public const char RightGuillemet = '»';

		// Token: 0x04000251 RID: 593
		[Register("rightGuillemete")]
		[Obsolete("deprecated")]
		public const char RightGuillemete = '»';

		// Token: 0x04000252 RID: 594
		[Register("rightSingleQuote")]
		public const char RightSingleQuote = '’';

		// Token: 0x04000253 RID: 595
		[Register("section")]
		public const char Section = '§';

		// Token: 0x04000254 RID: 596
		[Register("times")]
		public const char Times = '×';

		// Token: 0x04000255 RID: 597
		[Register("tm")]
		public const char Tm = '™';

		// Token: 0x04000256 RID: 598
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/Typography", typeof(Typography));
	}
}
