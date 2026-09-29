@echo off
echo ===================================================
echo   Starting RONY International Accounting Software
echo ===================================================

echo.
echo [1/3] Trusting Developer Certificates...
dotnet dev-certs https --trust

echo.
echo [2/3] Starting Backend API...
start cmd /k "cd backend\InternationalAccountingSystem.API && dotnet run"

echo.
echo [3/3] Starting Frontend Client...
start cmd /k "cd frontend\client && npm run dev"

echo.
echo Waiting for services to start...
timeout /t 5 /nobreak > nul

echo.
echo Opening Swagger and Frontend in your default browser...
start https://localhost:7100/swagger
start http://localhost:5173

echo.
echo Setup Complete! You can close this window now.
pause
