using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class AttributeNameFactory2 : RegexRunnerFactory
	{
		protected override RegexRunner CreateInstance()
		{
			return new AttributeNameRunner2();
		}
	}
}
