using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class HtmlTagRunner9 : RegexRunner
	{
        protected override void Go()
		{
			string runtext = base.runtext;
			int runtextstart = base.runtextstart;
			int runtextbeg = base.runtextbeg;
			int runtextend = base.runtextend;
			int num = base.runtextpos;
			int[] runtrack = base.runtrack;
			int runtrackpos = base.runtrackpos;
			int[] runstack = base.runstack;
			int runstackpos = base.runstackpos;
			runtrack[--runtrackpos] = num;
			runtrack[--runtrackpos] = 0;
			runstack[--runstackpos] = num;
			runtrack[--runtrackpos] = 1;
			int num3;
			if (num == base.runtextstart)
			{
				runstack[--runstackpos] = num;
				runtrack[--runtrackpos] = 1;
				if (num < runtextend && runtext[num++] == '<' && 1 <= runtextend - num)
				{
					num++;
					num3 = 1;
					while (true)
					{
						if (!RegexRunner.CharInClass(runtext[num - num3--], "\0\u0001\0\0"))
						{
							break;
						}
						if (num3 > 0)
						{
							continue;
						}
						goto IL_00fd;
					}
				}
			}
			goto IL_01b8;
			IL_0130:
			if (num < runtextend && runtext[num++] == '>')
			{
				num3 = runstack[runstackpos++];
				Capture(1, num3, num);
				runtrack[--runtrackpos] = num3;
				runtrack[--runtrackpos] = 3;
				num3 = runstack[runstackpos++];
				Capture(0, num3, num);
				runtrack[--runtrackpos] = num3;
				runtrack[--runtrackpos] = 3;
				goto IL_01af;
			}
			goto IL_01b8;
			IL_00fd:
			if ((num3 = runtextend - num) > 0)
			{
				runtrack[--runtrackpos] = num3 - 1;
				runtrack[--runtrackpos] = num;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_0130;
			IL_0260:
			int num8;
			if (num8 > 0)
			{
				runtrack[--runtrackpos] = num8 - 1;
				runtrack[--runtrackpos] = num;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_0130;
			IL_01b8:
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
					goto IL_022a;
				case 3:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				}
				break;
				IL_022a:
				num = runtrack[runtrackpos++];
				num8 = runtrack[runtrackpos++];
				if (!RegexRunner.CharInClass(runtext[num++], "\0\u0001\0\0"))
				{
					continue;
				}
				goto IL_0260;
			}
			num = runtrack[runtrackpos++];
			goto IL_01af;
			IL_01af:
			base.runtextpos = num;
		}

        protected override bool FindFirstChar()
		{
			if (base.runtextpos > base.runtextstart)
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
