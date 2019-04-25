using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TheGame;

namespace TheGame.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void SetPlayerOneChoice_InputRock_SetPlayerOneChoiceToRock()
        {
            Game newGame = new Game();
            string input = "rock";
            newGame.SetPlayerOneChoice(input);
            Assert.AreEqual(input, newGame.GetPlayerOneChoice());
        }   
        [TestMethod]
        public void SetPlayerTwoChoice_InputRock_SetPlayerOneChoiceToRock()
        {
            Game newGame = new Game();
            string input = "rock";
            newGame.SetPlayerTwoChoice(input);
            Assert.AreEqual(input, newGame.GetPlayerTwoChoice());
        }   
        [TestMethod]
        public void SetWinner_InputSameChoice_OutputDraw()
        {
            Game newGame = new Game();
            string input = "rock";
            newGame.SetPlayerOneChoice(input);
            newGame.SetPlayerTwoChoice(input);
            newGame.SetWinner();
            Assert.AreEqual("draw", newGame.GetGameWinner());
        } 
        [TestMethod]
        public void SetWinner_PlayerOneScissors_PlayerTwoRock_OutputPlayerTwo()
        {
            Game newGame = new Game();
            newGame.SetPlayerOneChoice("scissors");
            newGame.SetPlayerTwoChoice("rock");
            newGame.SetWinner();
            Assert.AreEqual("playerTwo", newGame.GetGameWinner());
        }
        [TestMethod]
        public void SetWinner_PlayerOnePaper_PlayerTwoRock_OutputPlayerOne()
        {
            Game newGame = new Game();
            newGame.SetPlayerOneChoice("paper");
            newGame.SetPlayerTwoChoice("rock");
            newGame.SetWinner();
            Assert.AreEqual("playerOne", newGame.GetGameWinner());
        }
    }
}