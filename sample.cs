using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using WebAssembly;
using WebAssembly.Net.Http.HttpClient;

using Wasm; // FIXME better namespace naming?

namespace Regexr
{
    class Program
    {
        static DOMObject navigator;
        static DOMObject global;
        static string BaseApiUrl = string.Empty;
        static HttpClient httpClient;

        static void Main(string[] args)
        {
            global = new DOMObject(string.Empty);
            navigator = new DOMObject("navigator");

            using (var window = (JSObject)WebAssembly.Runtime.GetGlobalObject("window"))
            {}
        }
    }
}
