#!/bin/sh

fsharpc --target:library -o Assets/build/GameLogic.dll \
        -r /opt/Unity/Editor/Data/Managed/UnityEngine.dll \
        -r /opt/Unity/Editor/Data/Mono/lib/mono/2.0/mscorlib.dll \
        -r packages/FSharp.Core/lib/net35/FSharp.Core.dll \
        --noframework GameLogic/GameLogic.fs
