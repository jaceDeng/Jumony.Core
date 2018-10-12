using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class DoctypeDeclarationFactory6 : RegexRunnerFactory
	{
        protected override RegexRunner CreateInstance()
		{
			return new DoctypeDeclarationRunner6();
		}
	}
}
