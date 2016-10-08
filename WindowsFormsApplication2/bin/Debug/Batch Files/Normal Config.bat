@echo off
if exist "C:\Users\tuba\Documents\My Games\Path of Exile\Playing Config.ini" (
	ren "C:\Users\tuba\Documents\My Games\Path of Exile\production_Config.ini" "Bot Config.ini"
	ren "C:\Users\tuba\Documents\My Games\Path of Exile\Playing Config.ini" "production_Config.ini"
)