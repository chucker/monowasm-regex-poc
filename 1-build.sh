#!/bin/bash

WASM_SDK=../

csc /target:library -out:sample.dll \
    /noconfig /nostdlib \
    \
    /r:$WASM_SDK/wasm-bcl/wasm/mscorlib.dll \
    /r:$WASM_SDK/wasm-bcl/wasm/System.dll \
    /r:$WASM_SDK/wasm-bcl/wasm/System.Core.dll \
    /r:$WASM_SDK/wasm-bcl/wasm/Facades/netstandard.dll \
    /r:$WASM_SDK/wasm-bcl/wasm/System.Net.Http.dll \
    /r:$WASM_SDK/framework/WebAssembly.Bindings.dll \
    /r:$WASM_SDK/framework/WebAssembly.Net.Http.dll \
    \
    Wasm/DOMObject.cs sample.cs
