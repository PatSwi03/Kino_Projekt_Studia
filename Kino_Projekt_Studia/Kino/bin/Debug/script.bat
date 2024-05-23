
@echo off
:Start
cls
echo Czy klient przylozyl karte? (tak/nie)
set /p response=
if /i "%response%" EQU "tak" (
    echo Generowanie losowych znakow...
    powershell -Command "Start-Sleep -s 3"
    echo Czy platnosc przebiegla pomyslnie? (tak/nie)
    set /p payment_response=
    if /i "%payment_response%" EQU "tak" (
        echo Transakcja zrealizowana pomyslnie
        pause
        exit
    ) else (
        echo Prosze ponowic probe
        goto Start
    )
) else (
    echo Prosze ponowic probe
    goto Start
)