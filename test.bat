@echo off

Packages\xunit.runner.console.2.1.0\tools\xunit.console ^
Vilage.Fact\bin\Debug\Vilage.Fact.dll ^
	-parallel all ^
	-html Result.html ^
	-nologo ^
    -verbose
@echo on 