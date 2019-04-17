#!/bin/bash

WASM_SDK=../

mono $WASM_SDK/packager.exe \
    --copy=always --out=./publish \
    --asset=./sample.html --asset=server.py \
    sample.dll
