@echo off
echo Starting LivingDoc generation... > %~dp0..\Scripts\LivingDocGeneration.log
cd %~dp0..\bin\debug\netcoreapp3.1
echo Changed directory to %cd% >> %~dp0..\Scripts\LivingDocGeneration.log
livingdoc test-assembly Dynamics365Project.dll -t TestExecution.json >> %~dp0..\Scripts\LivingDocGeneration.log 2>&1
echo LivingDoc generation completed. >> %~dp0..\Scripts\LivingDocGeneration.log
