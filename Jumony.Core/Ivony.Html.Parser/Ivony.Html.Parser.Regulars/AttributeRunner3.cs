using System;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class AttributeRunner3 : RegexRunner
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
			runtrack[--runtrackpos] = num;
			runtrack[--runtrackpos] = 2;
			if (num == base.runtextstart)
			{
				goto IL_00c9;
			}
			goto IL_0932;
			IL_0932:
			int num15;
			int num7;
			while (true)
			{
				base.runtrackpos = runtrackpos;
				base.runstackpos = runstackpos;
				EnsureStorage();
				runtrackpos = base.runtrackpos;
				runstackpos = base.runstackpos;
				runtrack = base.runtrack;
				runstack = base.runstack;
				int num37;
				switch (runtrack[runtrackpos++])
				{
				case 15:
					if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\u0001\u0004\u0001\"#'(d"))
					{
						num7 = (num15 = runtextend - num) + 1;
						while (--num7 > 0)
						{
							if (RegexRunner.CharInClass(runtext[num++], "\u0001\0\u0001d"))
							{
								continue;
							}
							num--;
							break;
						}
						if (num15 > num7)
						{
							runtrack[--runtrackpos] = num15 - num7 - 1;
							runtrack[--runtrackpos] = num - 1;
							runtrack[--runtrackpos] = 13;
						}
						goto IL_05eb;
					}
					continue;
				case 1:
					runstackpos++;
					continue;
				case 2:
					goto IL_09ec;
				case 3:
					goto IL_09fd;
				case 4:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				case 5:
					num = runtrack[runtrackpos++];
					runstack[--runstackpos] = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runtrackpos);
					runstack[--runstackpos] = Crawlpos();
					runtrack[--runtrackpos] = 12;
					runstack[--runstackpos] = num;
					runtrack[--runtrackpos] = 1;
					runtrack[--runtrackpos] = num;
					runtrack[--runtrackpos] = 20;
					if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
					{
						goto IL_086e;
					}
					continue;
				case 6:
					goto IL_0a7d;
				case 7:
					goto IL_0acd;
				case 8:
					num = runtrack[runtrackpos++];
					runtrack[--runtrackpos] = num;
					runtrack[--runtrackpos] = 10;
					if (num < runtextend && runtext[num++] == '"')
					{
						runstack[--runstackpos] = num;
						runtrack[--runtrackpos] = 1;
						num7 = (num15 = runtextend - num) + 1;
						while (--num7 > 0)
						{
							if (runtext[num++] != '"')
							{
								continue;
							}
							num--;
							break;
						}
						if (num15 > num7)
						{
							runtrack[--runtrackpos] = num15 - num7 - 1;
							runtrack[--runtrackpos] = num - 1;
							runtrack[--runtrackpos] = 11;
						}
						goto IL_04bb;
					}
					continue;
				case 9:
					goto IL_0b2e;
				case 10:
					num = runtrack[runtrackpos++];
					runstack[--runstackpos] = num;
					runtrack[--runtrackpos] = 1;
					runstack[--runstackpos] = -1;
					runstack[--runstackpos] = 0;
					runtrack[--runtrackpos] = 12;
					goto IL_05eb;
				case 11:
					num = runtrack[runtrackpos++];
					num7 = runtrack[runtrackpos++];
					if (num7 > 0)
					{
						runtrack[--runtrackpos] = num7 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 11;
					}
					goto IL_04bb;
				case 12:
					runstackpos += 2;
					continue;
				case 13:
					num = runtrack[runtrackpos++];
					num7 = runtrack[runtrackpos++];
					if (num7 > 0)
					{
						runtrack[--runtrackpos] = num7 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 13;
					}
					goto IL_05eb;
				case 14:
					if ((num7 = runstack[runstackpos++] - 1) >= 0)
					{
						num = runstack[runstackpos++];
						runtrack[--runtrackpos] = num7;
						runtrack[--runtrackpos] = 16;
						goto IL_0682;
					}
					runstack[runstackpos] = runtrack[runtrackpos++];
					runstack[--runstackpos] = num7;
					continue;
				case 16:
					num7 = runtrack[runtrackpos++];
					runstack[--runstackpos] = runtrack[runtrackpos++];
					runstack[--runstackpos] = num7;
					continue;
				case 17:
					num = runtrack[runtrackpos++];
					if (num >= runtextend - 1 && (num >= runtextend || runtext[num] == '\n'))
					{
						goto IL_0730;
					}
					continue;
				case 18:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					continue;
				case 19:
				{
					int num11 = runtrack[runtrackpos++];
					if (num11 != Crawlpos())
					{
						do
						{
							Uncapture();
						}
						while (num11 != Crawlpos());
					}
					continue;
				}
				case 20:
					num = runtrack[runtrackpos++];
					if (num >= runtextend - 1 && (num >= runtextend || runtext[num] == '\n'))
					{
						goto IL_086e;
					}
					continue;
				case 21:
					{
						runstack[--runstackpos] = runtrack[runtrackpos++];
						continue;
					}
					IL_086e:
					num = (runtrack[--runtrackpos] = runstack[runstackpos++]);
					runtrack[--runtrackpos] = 21;
					num7 = runstack[runstackpos++];
					runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
					runtrack[--runtrackpos] = num7;
					runtrack[--runtrackpos] = 19;
					goto IL_08c9;
					IL_0682:
					runstack[--runstackpos] = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runtrackpos);
					runstack[--runstackpos] = Crawlpos();
					runtrack[--runtrackpos] = 12;
					runstack[--runstackpos] = num;
					runtrack[--runtrackpos] = 1;
					runtrack[--runtrackpos] = num;
					runtrack[--runtrackpos] = 17;
					if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
					{
						goto IL_0730;
					}
					continue;
					IL_0730:
					num = (runtrack[--runtrackpos] = runstack[runstackpos++]);
					runtrack[--runtrackpos] = 18;
					num7 = runstack[runstackpos++];
					runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
					runtrack[--runtrackpos] = num7;
					runtrack[--runtrackpos] = 19;
					num7 = runstack[runstackpos++];
					Capture(3, num7, num);
					runtrack[--runtrackpos] = num7;
					runtrack[--runtrackpos] = 4;
					goto IL_08c9;
					IL_04bb:
					num7 = runstack[runstackpos++];
					Capture(3, num7, num);
					runtrack[--runtrackpos] = num7;
					runtrack[--runtrackpos] = 4;
					if (num < runtextend && runtext[num++] == '"')
					{
						goto IL_08c9;
					}
					continue;
					IL_05eb:
					num7 = runstack[runstackpos++];
					num37 = (num15 = runstack[runstackpos++]);
					runtrack[--runtrackpos] = num15;
					if ((num37 != num || num7 < 0) && num7 < 1)
					{
						runstack[--runstackpos] = num;
						runstack[--runstackpos] = num7 + 1;
						runtrack[--runtrackpos] = 14;
						if (runtrackpos > 168 && runstackpos > 126)
						{
							goto case 15;
						}
						runtrack[--runtrackpos] = 15;
						continue;
					}
					runtrack[--runtrackpos] = num7;
					runtrack[--runtrackpos] = 16;
					goto IL_0682;
				}
				break;
				IL_09ec:
				num = runtrack[runtrackpos++];
				if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
				{
					goto IL_00c9;
				}
			}
			num = runtrack[runtrackpos++];
			goto IL_0929;
			IL_02fd:
			runtrack[--runtrackpos] = num;
			runtrack[--runtrackpos] = 8;
			if (num < runtextend && runtext[num++] == '\'')
			{
				runstack[--runstackpos] = num;
				runtrack[--runtrackpos] = 1;
				num7 = (num15 = runtextend - num) + 1;
				while (--num7 > 0)
				{
					if (runtext[num++] != '\'')
					{
						continue;
					}
					num--;
					break;
				}
				if (num15 > num7)
				{
					runtrack[--runtrackpos] = num15 - num7 - 1;
					runtrack[--runtrackpos] = num - 1;
					runtrack[--runtrackpos] = 9;
				}
				goto IL_03b2;
			}
			goto IL_0932;
			IL_0929:
			base.runtextpos = num;
			return;
			IL_0acd:
			num = runtrack[runtrackpos++];
			num7 = runtrack[runtrackpos++];
			if (num7 > 0)
			{
				runtrack[--runtrackpos] = num7 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 7;
			}
			goto IL_02fd;
			IL_08c9:
			num7 = runstack[runstackpos++];
			Capture(1, num7, num);
			runtrack[--runtrackpos] = num7;
			runtrack[--runtrackpos] = 4;
			num7 = runstack[runstackpos++];
			Capture(0, num7, num);
			runtrack[--runtrackpos] = num7;
			runtrack[--runtrackpos] = 4;
			goto IL_0929;
			IL_09fd:
			num = runtrack[runtrackpos++];
			num7 = runtrack[runtrackpos++];
			if (num7 > 0)
			{
				runtrack[--runtrackpos] = num7 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 3;
			}
			goto IL_01ae;
			IL_01ae:
			num7 = runstack[runstackpos++];
			Capture(2, num7, num);
			runtrack[--runtrackpos] = num7;
			runtrack[--runtrackpos] = 4;
			runtrack[--runtrackpos] = num;
			runtrack[--runtrackpos] = 5;
			num7 = (num15 = runtextend - num) + 1;
			while (--num7 > 0)
			{
				if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
				{
					continue;
				}
				num--;
				break;
			}
			if (num15 > num7)
			{
				runtrack[--runtrackpos] = num15 - num7 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 6;
			}
			goto IL_026a;
			IL_0a7d:
			num = runtrack[runtrackpos++];
			num7 = runtrack[runtrackpos++];
			if (num7 > 0)
			{
				runtrack[--runtrackpos] = num7 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 6;
			}
			goto IL_026a;
			IL_00c9:
			runstack[--runstackpos] = num;
			runtrack[--runtrackpos] = 1;
			runstack[--runstackpos] = num;
			runtrack[--runtrackpos] = 1;
			if (1 <= runtextend - num)
			{
				num++;
				num7 = 1;
				while (true)
				{
					if (!RegexRunner.CharInClass(runtext[num - num7--], "\0\u0006\t-.:;_`\0\u0002\u0004\u0005\u0003\u0001\t\u0013\0"))
					{
						break;
					}
					if (num7 > 0)
					{
						continue;
					}
					goto IL_013a;
				}
			}
			goto IL_0932;
			IL_026a:
			if (num < runtextend && runtext[num++] == '=')
			{
				num7 = (num15 = runtextend - num) + 1;
				while (--num7 > 0)
				{
					if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
					{
						continue;
					}
					num--;
					break;
				}
				if (num15 > num7)
				{
					runtrack[--runtrackpos] = num15 - num7 - 1;
					runtrack[--runtrackpos] = num - 1;
					runtrack[--runtrackpos] = 7;
				}
				goto IL_02fd;
			}
			goto IL_0932;
			IL_013a:
			num7 = (num15 = runtextend - num) + 1;
			while (--num7 > 0)
			{
				if (RegexRunner.CharInClass(runtext[num++], "\0\u0006\t-.:;_`\0\u0002\u0004\u0005\u0003\u0001\t\u0013\0"))
				{
					continue;
				}
				num--;
				break;
			}
			if (num15 > num7)
			{
				runtrack[--runtrackpos] = num15 - num7 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 3;
			}
			goto IL_01ae;
			IL_0b2e:
			num = runtrack[runtrackpos++];
			num7 = runtrack[runtrackpos++];
			if (num7 > 0)
			{
				runtrack[--runtrackpos] = num7 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 9;
			}
			goto IL_03b2;
			IL_03b2:
			num7 = runstack[runstackpos++];
			Capture(3, num7, num);
			runtrack[--runtrackpos] = num7;
			runtrack[--runtrackpos] = 4;
			if (num < runtextend && runtext[num++] == '\'')
			{
				goto IL_08c9;
			}
			goto IL_0932;
		}

		protected override bool FindFirstChar()
		{
			int num = base.runtextpos;
			string runtext = base.runtext;
			int num2 = base.runtextend - num;
			if (num2 > 0)
			{
				int result;
				while (true)
				{
					num2--;
					if (!RegexRunner.CharInClass(runtext[num++], "\0\u0006\n-.:;_`d\0\u0002\u0004\u0005\u0003\u0001\t\u0013\0"))
					{
						if (num2 > 0)
						{
							continue;
						}
						result = 0;
					}
					else
					{
						num--;
						result = 1;
					}
					break;
				}
				base.runtextpos = num;
				return (byte)result != 0;
			}
			return false;
		}

        protected override void InitTrackCount()
		{
			base.runtrackcount = 42;
		}
	}
}
