using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class TagNameFactory1 : RegexRunnerFactory
	{
        protected override RegexRunner CreateInstance()
		{
			return new TagNameRunner1();
		}
	}
}
