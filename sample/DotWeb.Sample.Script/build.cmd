rem csc /noconfig /nowarn:1701,1702 /nostdlib+ /errorreport:prompt /warn:4 /define:DEBUG;TRACE /reference:F:\src\git\DotWeb\build\bin\Debug\DotWeb.System.dll /reference:F:\src\git\DotWeb\build\bin\Debug\DotWeb.Client.dll /debug+ /debug:full /filealign:512 /optimize- /out:obj\Debug\DotWeb.Sample.Script.module /target:module ExtScript.cs Properties\AssemblyInfo.cs SimpleScript.cs Test\Sandbox.cs Test\Expando.cs Test\NativeCallback.cs Test\EventHandler.cs Test\Sanity.cs Tuple.cs
csc /noconfig /nowarn:1701,1702 /errorreport:prompt /warn:4 /define:DEBUG;TRACE /reference:F:\src\git\DotWeb\build\bin\Debug\Hosted-DotWeb.Client.dll /debug+ /debug:full /filealign:512 /optimize- /out:obj\Debug\Hosted-DotWeb.Sample.Script.dll /target:library ExtScript.cs Properties\AssemblyInfo.cs SimpleScript.cs Test\Sandbox.cs Test\Expando.cs Test\NativeCallback.cs Test\EventHandler.cs Test\Sanity.cs Tuple.cs
rem al obj\Debug\DotWeb.Sample.Script.module obj\Debug\Hosted-DotWeb.Sample.Script.module /target:library /out:obj\Debug\Hosted-DotWeb.Sample.Script.dll
