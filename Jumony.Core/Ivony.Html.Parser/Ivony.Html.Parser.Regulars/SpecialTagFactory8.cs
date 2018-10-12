using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class SpecialTagFactory8 : RegexRunnerFactory
	{
        protected override RegexRunner CreateInstance()
		{
			return new SpecialTagRunner8();
		}
	}
}
