using System;
using System.Collections.Generic;

namespace TheGame
{
    public class Game
    {
        private string _playerOneChoice;
        private string _playerTwoChoice;

        private string _gameWinner;
  
        private Dictionary<string, string> _outcomesDictionary = new Dictionary<string, string>(){{"rockscissors", "rock"}, {"paperrock", "paper"}, {"paperscissors", "scissors"}};

        public void SetPlayerOneChoice(string choice)
        {
            _playerOneChoice = choice.ToLower();
        }
        public void SetPlayerTwoChoice(string choice)
        {
            _playerTwoChoice = choice.ToLower();
        }

        public string GetPlayerOneChoice()
        {
            return _playerOneChoice;
        }

        public string GetPlayerTwoChoice()
        {
            return _playerTwoChoice;
        }
        public string GetGameWinner()
        {
            return _gameWinner;
        }

        public void SetWinner()
        {
            if (_playerOneChoice == _playerTwoChoice)
            {
                _gameWinner = "Draw";
            }
            else
            {
                string[] matchup = new string[] {_playerOneChoice, _playerTwoChoice};
                Array.Sort(matchup);
                string matchupString = string.Join("" , matchup);
                string winningWeapon = _outcomesDictionary[matchupString];
                if(_playerOneChoice == winningWeapon)
                {
                    _gameWinner = "Player One Wins";
                }
                else
                {
                    _gameWinner = "Player Two Wins";
                }
            }
        }
    }
}