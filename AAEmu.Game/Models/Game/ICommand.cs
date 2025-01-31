﻿using AAEmu.Game.Models.Game.Char;
using AAEmu.Game.Utils.Scripts;

namespace AAEmu.Game.Models.Game;

public interface ICommand
{
    string[] CommandNames { get; set; }
    void Execute(Character character, string[] args, IMessageOutput messageOutput);
    string GetCommandLineHelp();
    string GetCommandHelpText();
}
