using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class SpecialTagRunner8 : RegexRunner
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
			int num5;
			if (num == base.runtextstart && num < runtextend && runtext[num++] == '<')
			{
				runstack[--runstackpos] = num;
				runtrack[--runtrackpos] = 1;
				if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\u0004\0#&?@"))
				{
					num5 = runstack[runstackpos++];
					Capture(1, num5, num);
					runtrack[--runtrackpos] = num5;
					runtrack[--runtrackpos] = 2;
					runstack[--runstackpos] = num;
					runtrack[--runtrackpos] = 1;
					if ((num5 = runtextend - num) > 0)
					{
						runtrack[--runtrackpos] = num5 - 1;
						runtrack[--runtrackpos] = num;
						runtrack[--runtrackpos] = 3;
					}
					goto IL_015e;
				}
			}
			goto IL_0247;
			IL_030e:
			int num6;
			if (num6 > 0)
			{
				runtrack[--runtrackpos] = num6 - 1;
				runtrack[--runtrackpos] = num;
				runtrack[--runtrackpos] = 3;
			}
			goto IL_015e;
			IL_023e:
			base.runtextpos = num;
			return;
			IL_0247:
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
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				case 3:
					goto IL_02d8;
				}
				break;
				IL_02d8:
				num = runtrack[runtrackpos++];
				num6 = runtrack[runtrackpos++];
				if (!RegexRunner.CharInClass(runtext[num++], "\0\u0001\0\0"))
				{
					continue;
				}
				goto IL_030e;
			}
			num = runtrack[runtrackpos++];
			goto IL_023e;
			IL_015e:
			num5 = runstack[runstackpos++];
			Capture(2, num5, num);
			runtrack[--runtrackpos] = num5;
			runtrack[--runtrackpos] = 2;
			if (IsMatched(1) && (num5 = MatchLength(1)) <= runtextend - num)
			{
				num6 = MatchIndex(1) + num5;
				num += num5;
				while (true)
				{
					if (num5 <= 0)
					{
						break;
					}
					if (runtext[num6 - num5] == runtext[num - num5--])
					{
						continue;
					}
					goto IL_0247;
				}
				if (num < runtextend && runtext[num++] == '>')
				{
					num5 = runstack[runstackpos++];
					Capture(0, num5, num);
					runtrack[--runtrackpos] = num5;
					runtrack[--runtrackpos] = 2;
					goto IL_023e;
				}
			}
			goto IL_0247;
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
			base.runtrackcount = 8;
		}
	}
}
