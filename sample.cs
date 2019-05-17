using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using WebAssembly;
using WebAssembly.Net.Http.HttpClient;

using System.Text.RegularExpressions;

using Wasm; // FIXME better namespace naming?

namespace Regexr
{
    public static class Program
    {
        public static void EvaluateRegex(string pattern, string testString, JSObject outputElement)
        {
            string output;

            try
            {
                var sb = new System.Text.StringBuilder();

                Regex regex = new Regex(pattern);

                var matches = regex.Matches(testString);

                sb.AppendLine($"Got {matches.Count} matches:\n");

                foreach (Match match in matches)
                {
                    sb.AppendLine(match.Value);
                }

                output = sb.ToString();
            }
            catch (Exception ex)
            {
                output = $"Error evaluating regex: {ex}";
            }
            
            outputElement.SetObjectProperty("innerText", output);
        }
    }
}
