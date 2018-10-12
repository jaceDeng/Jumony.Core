using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class HtmlTagFactory9 : RegexRunnerFactory
	{
        protected override RegexRunner CreateInstance()
		{
			return new HtmlTagRunner9();
		}
	}
}
