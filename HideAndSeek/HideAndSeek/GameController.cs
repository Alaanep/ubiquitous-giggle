using System;
namespace HideAndSeek
{
    public class GameController
    {
        /// <summary>
        /// The player's current location in the house
        /// </summary>
        public Location CurrentLocation { get; set; }

        /// <summary>
        /// Returns the current status to show the player
        /// </summary>
        public string Status => throw new NotImplementedException();

        /// <summary>
        /// A prompt to display to the player
        /// </summary>
        public string Prompt => "Which direction  do you want to go: ";

        public GameController()
        {
            CurrentLocation = House.Entry;
        }

        /// <summary>
        /// Move to the location in direction
        /// </summary>
        /// <param name="direction">The direction to move</param>
        /// <returns>True if the player can move in that direction, false otherwise</returns>
        public bool Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Parses input from  the player and updates the status
        /// </summary>
        /// <param name="input">Input to parse</param>
        /// <returns>The results of parsing the input</returns>
        public string ParseInput(string input)
        {
            throw new NotImplementedException();
        }

    }
}
