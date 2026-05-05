@echo off
setlocal enabledelayedexpansion

cd /d "%~dp0"

set "DUNE_DIR=.\dune"
set "MT32_DIR=.\mt32rom"

where dotnet >nul 2>&1
if errorlevel 1 (
    echo dotnet CLI not found. Install the .NET SDK to run Cryogenic.
    exit /b 1
)

if not exist "%DUNE_DIR%\" (
    echo Directory %DUNE_DIR% not found.
    echo Please create the directory and copy the ENTIRE contents of your Dune CD 3.7 into %DUNE_DIR%
    exit /b 1
)

echo Checking Dune assets...
set "DUNE_EXE_PATH="
set "DUNE_DAT_PATH="
call :locate_asset "DNCDPRG.EXE" "%DUNE_DIR%" "dncdprg.exe" DUNE_EXE_PATH
call :locate_asset "DUNE.DAT"    "%DUNE_DIR%" "dune.dat"    DUNE_DAT_PATH
if not defined DUNE_EXE_PATH goto :missing_dune
if not defined DUNE_DAT_PATH goto :missing_dune
goto :dune_ok
:missing_dune
echo Please copy the entire Dune CD 3.7 into %DUNE_DIR%.
exit /b 1
:dune_ok

echo Checking MT-32 ROMs...
set "MT32_CONTROL_PATH="
set "MT32_PCM_PATH="
call :locate_asset "MT32_CONTROL.ROM" "%MT32_DIR%" "mt32_control.rom" MT32_CONTROL_PATH
call :locate_asset "MT32_PCM.ROM"     "%MT32_DIR%" "mt32_pcm.rom"     MT32_PCM_PATH
if not defined MT32_CONTROL_PATH goto :missing_mt32
if not defined MT32_PCM_PATH     goto :missing_mt32
goto :mt32_ok
:missing_mt32
echo Extract MT-32_v1.07_legacy_ROM_files.zip into %MT32_DIR% and retry.
exit /b 1
:mt32_ok

echo Running Cryogenic with arguments: -e "%DUNE_EXE_PATH%" -a "MID330 SBP2227" -m "%MT32_DIR%" -p 4096 --UseCodeOverride true --OplMode Opl3Gold %*

dotnet run --project src\Cryogenic -- -e "%DUNE_EXE_PATH%" -a "MID330 SBP2227" -m "%MT32_DIR%" -p 4096 --UseCodeOverride true --OplMode Opl3Gold %*
exit /b %errorlevel%

:: Subroutine: locate_asset <label> <dir> <pattern> <output-var>
:: Searches <dir> for <pattern> (case-insensitive on NTFS).
:: Prints found/missing status and stores the resolved path in <output-var>.
:locate_asset
set "_la_found="
for /f "delims=" %%F in ('dir /b /s /a-d "%~2\%~3" 2^>nul') do (
    set "_la_found=%%F"
    goto :locate_asset_done
)
:locate_asset_done
if defined _la_found (
    echo   %~1 -^> found: !_la_found!
    set "%~4=!_la_found!"
) else (
    echo   %~1 -^> missing
)
goto :eof
goto :eof
