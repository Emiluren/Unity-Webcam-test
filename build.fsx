// include Fake libs
#r "./packages/FAKE/tools/FakeLib.dll"

#r "/opt/Unity/Editor/Data/Managed/UnityEngine.dll"
#r "/opt/Unity/Editor/Data/Mono/lib/mono/2.0/mscorlib.dll"

open Fake

// Directories
let buildDir  = "./Assets/build/"
let deployDir = "./Assets/deploy/"


// Filesets
let appReferences  =
    !! "/**/*.csproj"
    ++ "/**/*.fsproj"

// version info
let version = "0.1"  // or retrieve from CI server

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir; deployDir]
)

Target "Build" (fun _ ->
    // compile all projects below src/app/
    MSBuildDebug buildDir "Build" appReferences
    |> Log "AppBuild-Output: "
)

Target "Deploy" (fun _ ->
    !! (buildDir + "/**/*.*")
    -- "*.zip"
    |> Zip buildDir (deployDir + "ApplicationName." + version + ".zip")
)

// Build order
"Clean"
  ==> "Build"
  ==> "Deploy"

// start build
RunTargetOrDefault "Build"
