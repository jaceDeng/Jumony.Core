using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class EndTagFactory5 : RegexRunnerFactory
	{
        protected override RegexRunner CreateInstance()
		{
			return new EndTagRunner5();
		}
	}
}
