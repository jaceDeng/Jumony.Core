using System;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class BeginTagRunner4 : RegexRunner
	{
		protected unsafe override void Go()
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
			int num4;
			int num5;
			if (num == base.runtextstart && num < runtextend && runtext[num++] == '<')
			{
				runstack[--runstackpos] = num;
				runtrack[--runtrackpos] = 1;
				if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\u0004\0A[a{"))
				{
					num5 = (num4 = runtextend - num) + 1;
					while (--num5 > 0)
					{
						if (RegexRunner.CharInClass(runtext[num++], "\0\n\0-/0;A[_`a{"))
						{
							continue;
						}
						num--;
						break;
					}
					if (num4 > num5)
					{
						runtrack[--runtrackpos] = num4 - num5 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 2;
					}
					goto IL_0157;
				}
			}
			goto IL_07c0;
			IL_07c0:
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
				case 16:
					break;
				default:
					goto IL_084d;
				case 1:
					runstackpos++;
					continue;
				case 2:
					goto IL_086a;
				case 3:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				case 4:
					num = runtrack[runtrackpos++];
					runtrack[--runtrackpos] = num;
					runtrack[--runtrackpos] = 5;
					runstack[--runstackpos] = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runtrackpos);
					runstack[--runstackpos] = Crawlpos();
					runtrack[--runtrackpos] = 6;
					if (num < runtextend && runtext[num++] == '=')
					{
						num5 = (num4 = runtextend - num) + 1;
						while (--num5 > 0)
						{
							if (RegexRunner.CharInClass(runtext[num++], "\0\0\t\0\u0002\u0004\u0005\u0003\u0001\t\u0013\0"))
							{
								continue;
							}
							num--;
							break;
						}
						if (num4 > num5)
						{
							runtrack[--runtrackpos] = num4 - num5 - 1;
							runtrack[--runtrackpos] = num - 1;
							runtrack[--runtrackpos] = 7;
						}
						goto IL_02d3;
					}
					continue;
				case 5:
					num = runtrack[runtrackpos++];
					runtrack[--runtrackpos] = num;
					runtrack[--runtrackpos] = 10;
					runstack[--runstackpos] = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runtrackpos);
					runstack[--runstackpos] = Crawlpos();
					runtrack[--runtrackpos] = 6;
					if (num < runtextend && runtext[num++] == '=')
					{
						num5 = (num4 = runtextend - num) + 1;
						while (--num5 > 0)
						{
							if (RegexRunner.CharInClass(runtext[num++], "\0\0\t\0\u0002\u0004\u0005\u0003\u0001\t\u0013\0"))
							{
								continue;
							}
							num--;
							break;
						}
						if (num4 > num5)
						{
							runtrack[--runtrackpos] = num4 - num5 - 1;
							runtrack[--runtrackpos] = num - 1;
							runtrack[--runtrackpos] = 11;
						}
						goto IL_048f;
					}
					continue;
				case 6:
					runstackpos += 2;
					continue;
				case 7:
					num = runtrack[runtrackpos++];
					num5 = runtrack[runtrackpos++];
					if (num5 > 0)
					{
						runtrack[--runtrackpos] = num5 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 7;
					}
					goto IL_02d3;
				case 8:
					num = runtrack[runtrackpos++];
					num5 = runtrack[runtrackpos++];
					if (num5 > 0)
					{
						runtrack[--runtrackpos] = num5 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 8;
					}
					goto IL_0358;
				case 9:
				{
					int num17 = runtrack[runtrackpos++];
					if (num17 != Crawlpos())
					{
						do
						{
							Uncapture();
						}
						while (num17 != Crawlpos());
					}
					continue;
				}
				case 10:
					goto IL_09cf;
				case 11:
					num = runtrack[runtrackpos++];
					num5 = runtrack[runtrackpos++];
					if (num5 > 0)
					{
						runtrack[--runtrackpos] = num5 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 11;
					}
					goto IL_048f;
				case 12:
					num = runtrack[runtrackpos++];
					num5 = runtrack[runtrackpos++];
					if (num5 > 0)
					{
						runtrack[--runtrackpos] = num5 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 12;
					}
					goto IL_0514;
				case 13:
					goto IL_0a80;
				case 14:
					runstack[runstackpos] = runtrack[runtrackpos++];
					continue;
				case 15:
					goto IL_0ad8;
				case 17:
					{
						num5 = runtrack[runtrackpos++];
						runstack[--runstackpos] = runtrack[runtrackpos++];
						runstack[--runstackpos] = num5;
						continue;
					}
					IL_0514:
					if (num < runtextend)
					{
						goto IL_051d;
					}
					continue;
					IL_048f:
					if (num < runtextend && runtext[num++] == '"')
					{
						num5 = (num4 = runtextend - num) + 1;
						while (--num5 > 0)
						{
							if (runtext[num++] != '"')
							{
								continue;
							}
							num--;
							break;
						}
						if (num4 > num5)
						{
							runtrack[--runtrackpos] = num4 - num5 - 1;
							runtrack[--runtrackpos] = num - 1;
							runtrack[--runtrackpos] = 12;
						}
						goto IL_0514;
					}
					continue;
					IL_0358:
					if (num < runtextend)
					{
						goto IL_0361;
					}
					continue;
					IL_02d3:
					if (num < runtextend && runtext[num++] == '\'')
					{
						num5 = (num4 = runtextend - num) + 1;
						while (--num5 > 0)
						{
							if (runtext[num++] != '\'')
							{
								continue;
							}
							num--;
							break;
						}
						if (num4 > num5)
						{
							runtrack[--runtrackpos] = num4 - num5 - 1;
							runtrack[--runtrackpos] = num - 1;
							runtrack[--runtrackpos] = 8;
						}
						goto IL_0358;
					}
					continue;
				}
				break;
				IL_0ad8:
				if ((num5 = runstack[runstackpos++] - 1) >= 0)
				{
					goto IL_0aec;
				}
				runstack[runstackpos] = runtrack[runtrackpos++];
				runstack[--runstackpos] = num5;
				continue;
				IL_09cf:
				num = runtrack[runtrackpos++];
				if (num < runtextend && runtext[num++] == '=')
				{
					goto IL_058f;
				}
				continue;
				IL_0a80:
				num = runtrack[runtrackpos++];
				runstack[--runstackpos] = num;
				runtrack[--runtrackpos] = 14;
				if (runtrackpos > 116 && runstackpos > 87)
				{
					runtrack[--runtrackpos] = num;
					runtrack[--runtrackpos] = 4;
					if (num < runtextend && runtext[num++] != '=')
					{
						goto IL_058f;
					}
				}
				else
				{
					runtrack[--runtrackpos] = 18;
				}
				continue;
				IL_051d:
				if (runtext[num++] == '"')
				{
					num5 = runstack[runstackpos++];
					runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
					runtrack[--runtrackpos] = num5;
					runtrack[--runtrackpos] = 9;
					goto IL_058f;
				}
				continue;
				IL_0361:
				if (runtext[num++] == '\'')
				{
					num5 = runstack[runstackpos++];
					runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
					runtrack[--runtrackpos] = num5;
					runtrack[--runtrackpos] = 9;
					goto IL_058f;
				}
			}
			goto IL_064b;
			IL_0746:
			if (num < runtextend && runtext[num++] == '>' && num >= runtextend - 1 && (num >= runtextend || runtext[num] == '\n'))
			{
				num5 = runstack[runstackpos++];
				Capture(0, num5, num);
				runtrack[--runtrackpos] = num5;
				runtrack[--runtrackpos] = 3;
				goto IL_07b7;
			}
			goto IL_07c0;
			IL_0157:
			num5 = runstack[runstackpos++];
			Capture(1, num5, num);
			runtrack[--runtrackpos] = num5;
			runtrack[--runtrackpos] = 3;
			runstack[--runstackpos] = num;
			runtrack[--runtrackpos] = 1;
			runstack[--runstackpos] = -1;
			runtrack[--runtrackpos] = 1;
			goto IL_058f;
			IL_0aec:
			num = runstack[runstackpos++];
			runtrack[--runtrackpos] = num5;
			runtrack[--runtrackpos] = 17;
			goto IL_0746;
			IL_086a:
			num = runtrack[runtrackpos++];
			num5 = runtrack[runtrackpos++];
			if (num5 > 0)
			{
				runtrack[--runtrackpos] = num5 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_0157;
			IL_058f:
			int num51 = num5 = runstack[runstackpos++];
			if (num5 != -1)
			{
				runtrack[--runtrackpos] = num5;
			}
			else
			{
				runtrack[--runtrackpos] = num;
			}
			if (num51 != num)
			{
				runtrack[--runtrackpos] = num;
				runtrack[--runtrackpos] = 13;
			}
			else
			{
				runstack[--runstackpos] = num5;
				runtrack[--runtrackpos] = 14;
			}
			num5 = runstack[runstackpos++];
			Capture(2, num5, num);
			runtrack[--runtrackpos] = num5;
			runtrack[--runtrackpos] = 3;
			runstack[--runstackpos] = -1;
			runstack[--runstackpos] = 0;
			runtrack[--runtrackpos] = 6;
			goto IL_06b2;
			IL_06b2:
			num5 = runstack[runstackpos++];
			int num55 = num4 = runstack[runstackpos++];
			runtrack[--runtrackpos] = num4;
			if ((num55 != num || num5 < 0) && num5 < 1)
			{
				runstack[--runstackpos] = num;
				runstack[--runstackpos] = num5 + 1;
				runtrack[--runtrackpos] = 15;
				if (runtrackpos > 116 && runstackpos > 87)
				{
					goto IL_064b;
				}
				runtrack[--runtrackpos] = 16;
				goto IL_07c0;
			}
			runtrack[--runtrackpos] = num5;
			runtrack[--runtrackpos] = 17;
			goto IL_0746;
			IL_064b:
			runstack[--runstackpos] = num;
			runtrack[--runtrackpos] = 1;
			if (num < runtextend && runtext[num++] == '/')
			{
				num5 = runstack[runstackpos++];
				Capture(3, num5, num);
				runtrack[--runtrackpos] = num5;
				runtrack[--runtrackpos] = 3;
				goto IL_06b2;
			}
			goto IL_07c0;
			IL_084d:
			num = runtrack[runtrackpos++];
			goto IL_07b7;
			IL_07b7:
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
			base.runtrackcount = 29;
		}
	}
}
