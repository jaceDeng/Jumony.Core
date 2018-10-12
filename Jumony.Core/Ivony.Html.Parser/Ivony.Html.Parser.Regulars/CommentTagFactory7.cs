using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class CommentTagFactory7 : RegexRunnerFactory
	{
        protected override RegexRunner CreateInstance()
		{
			return new CommentTagRunner7();
		}
	}
}
