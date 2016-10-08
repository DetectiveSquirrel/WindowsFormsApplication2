@echo off
if exist "C:\Users\tuba\Documents\My Games\Path of Exile\Bot Config.ini" (
	ren "C:\Users\tuba\Documents\My Games\Path of Exile\production_Config.ini" "Playing Config.ini"
	ren "C:\Users\tuba\Documents\My Games\Path of Exile\Bot Config.ini" "production_Config.ini"
)