using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace temp4
{
    public class Dojo
    {
        private string[] _initialBoard;

        public Dojo(string[] initialBoard)
        {
            _initialBoard = initialBoard;
        }

        public string[] Fill(int x, int y, char fillCharacter)
        {
            var row = _initialBoard[x];
            
            return new [] { _initialBoard[0], row.Replace(Convert.ToChar(" "),fillCharacter), _initialBoard[2] };
        }
    }
}
