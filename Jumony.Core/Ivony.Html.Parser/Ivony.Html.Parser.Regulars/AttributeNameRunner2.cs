using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class AttributeNameRunner2 : RegexRunner
	{
		protected override void Go()
		{
			string runtext = base.runtext;
			int runtextstart = base.runtextstart;
			int runtextbeg = base.runtextbeg;
			int runtextend = base.runtextend;
			int runtextpos = base.runtextpos;
			int[] runtrack = base.runtrack;
			int runtrackpos = base.runtrackpos;
			int[] runstack = base.runstack;
			int runstackpos = base.runstackpos;
			runtrack[--runtrackpos] = runtextpos;
			runtrack[--runtrackpos] = 0;
			runstack[--runstackpos] = runtextpos;
			runtrack[--runtrackpos] = 1;
			int num;
			if (runtextpos <= runtextbeg)
			{
				runstack[--runstackpos] = runtextpos;
				runtrack[--runtrackpos] = 1;
				if (1 <= runtextend - runtextpos)
				{
					runtextpos++;
					num = 1;
					while (true)
					{
						if (!RegexRunner.CharInClass(runtext[runtextpos - num--], "\0\u0006\t-.:;_`\0\u0002\u0004\u0005\u0003\u0001\t\u0013\0"))
						{
							break;
						}
						if (num > 0)
						{
							continue;
						}
						goto IL_00da;
					}
				}
			}
			goto IL_01d9;
			IL_01d9:
			while (true)
			{
				base.runtrackpos = runtrackpos;
				base.runstackpos = runstackpos;
				EnsureStorage();
				runtrackpos = base.runtrackpos;
				runstackpos = base.runstackpos;
				runtrack = base.runtrack;
				runstack = base.runstack;
				switch (runtrack[runtrackpos++])
				{
				case 1:
					runstackpos++;
					continue;
				case 2:
					goto IL_024b;
				case 3:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				}
				break;
			}
			runtextpos = runtrack[runtrackpos++];
			goto IL_01d0;
			IL_01d0:
			base.runtextpos = runtextpos;
			return;
			IL_014e:
			num = runstack[runstackpos++];
			Capture(1, num, runtextpos);
			runtrack[--runtrackpos] = num;
			runtrack[--runtrackpos] = 3;
			if (runtextpos >= runtextend - 1 && (runtextpos >= runtextend || runtext[runtextpos] == '\n'))
			{
				num = runstack[runstackpos++];
				Capture(0, num, runtextpos);
				runtrack[--runtrackpos] = num;
				runtrack[--runtrackpos] = 3;
				goto IL_01d0;
			}
			goto IL_01d9;
			IL_024b:
			runtextpos = runtrack[runtrackpos++];
			num = runtrack[runtrackpos++];
			if (num > 0)
			{
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = runtextpos - 1;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_014e;
			IL_00da:
			int num10;
			num = (num10 = runtextend - runtextpos) + 1;
			while (--num > 0)
			{
				if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0006\t-.:;_`\0\u0002\u0004\u0005\u0003\u0001\t\u0013\0"))
				{
					continue;
				}
				runtextpos--;
				break;
			}
			if (num10 > num)
			{
				runtrack[--runtrackpos] = num10 - num - 1;
				runtrack[--runtrackpos] = runtextpos - 1;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_014e;
		}

		protected override bool FindFirstChar()
		{
			if (base.runtextpos > base.runtextbeg)
			{
				base.runtextpos = base.runtextend;
				return false;
			}
			return true;
		}

        protected override void InitTrackCount()
		{
			base.runtrackcount = 6;
		}
	}
}
