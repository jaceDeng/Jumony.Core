using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class AttributeFactory3 : RegexRunnerFactory
	{
        protected override RegexRunner CreateInstance()
		{
			return new AttributeRunner3();
		}
	}
}
