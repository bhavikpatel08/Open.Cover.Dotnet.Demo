﻿"..\..\..\packages\OpenCover.4.6.166\tools\OpenCover.Console.exe" -target:"..\..\..\packages\NUnit.Runners.2.6.4\tools\nunit-console.exe" -targetargs:"/nologo CodeCoverage.UnitTests.dll /noshadow" -excludebyattribute:"System.CodeDom.Compiler.GeneratedCodeAttribute" -register:user -output:"_CodeCoverageResult.xml"
"..\..\..\packages\ReportGenerator.2.2.0.0\tools\ReportGenerator.exe" "-reports:_CodeCoverageResult.xml" "-targetdir:_CodeCoverageReport"