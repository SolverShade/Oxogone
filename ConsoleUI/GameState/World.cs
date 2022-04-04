﻿#region usingStatements 
using ConsoleUI.LevelGui;
using ConsoleUI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary.Mapping;
#endregion

namespace ConsoleUI.GameState
{
    public class World
    {
        protected Map _map { get; set; }
        protected Player _player { get; set; }
        protected Area currentArea { get; set; }
        protected CommandHandler commandHandler { get; set; }
        public World(Map map)
        {
            _map = map;
            _player = new Player(new Cordinate(10, 10));            
            currentArea = _map.Areas[_player.Cordinate.X, _player.Cordinate.Y];
            commandHandler = new CommandHandler(_player, _map);
        }

        public void UpdateWorld()
        {
            StoryText.DisplayAreaText(currentArea);
            MiniMap.Update(_player, _map);
            ActionWriter.PossibleActions();

            CheckForCombat();         

            commandHandler.HandleCommand();

            currentArea = _map.Areas[_player.Cordinate.X, _player.Cordinate.Y];

            UpdateWorld();
        }

        private void CheckForCombat()
        {
            if(currentArea.Mob != null)
            {
                StoryText.DisplayCombatText();
                ActionWriter.CombatActions();
            }            
        }


    }
}