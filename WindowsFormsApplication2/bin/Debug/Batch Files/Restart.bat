taskkill /f /im "PathOfExile.exe" >nul
cd /d "C:\Program Files (x86)\Grinding Gear Games\Path of Exile\"
start PathOfExile.exe --nosound --noasync -gc 2
timeout /t 3
cd /d "Z:\RoboBuddy\"
start Robo.exe --autostart
taskkill /IM cmd.exe