# monowasm-regex-poc

A proof of concept for using [Mono/WASM](https://github.com/mono/mono/tree/master/sdks) to play with the .NET regular expression engine from within the browser.

## Monowhatnow?

**Mono** is an open-source implementation of the .NET infrastructure.

**WASM**, or WebAssembly, a runtime to run languages other than JavaScript in the browser.

Thus, Mono/WASM lets you run C# in the browser. (And [Blazor](https://blazor.net) builds on that to have an entire C# application framework in the browser.)

## Status

This is currently barely started.

## Goal

[regex101](https://regex101.com) lets you try regular expressions in the browser, and already supports multiple different engines (and therefore syntaxes). [Notably absent is .NET](https://github.com/firasdib/Regex101/issues/156), for lack of JavaScript re-implementation of .NET regular expression behavior.

The long-term goal of this project is to server as a proof of concept that WebAssembly can help fill this gap.
