﻿using ConsoleMathGame.CoSat2023;

var menu = new Menu();
var date = DateTime.UtcNow;
string name = Helpers.GetName();

menu.ShowMenu(name, date);
