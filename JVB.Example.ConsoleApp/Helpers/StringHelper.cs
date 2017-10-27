using RestSharp;

namespace JVB.Example.ConsoleApp.Helpers
{
    public static class StringHelper
    {
        public static string RemoveExtraEscapeCharacters(IRestResponse response)
        {
            var v = response.Content;
            var g = v.Replace("\"", "\\");
            g = g.Replace("\\\\", "\"");
            g = g.Trim('\\');
            return g;
        }
    }
}
