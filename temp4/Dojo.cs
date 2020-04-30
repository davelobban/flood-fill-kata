namespace temp4
{
    public class Dojo
    {
        private readonly string[] _board;
        private char _filler;
        private char _cellToFill;

        public Dojo(string[] board)
        {
            _board = board;
        }

        public string[] Fill(int rowIndex, int colIndex, char filler)
        {
            _filler = filler;

            _cellToFill = _board[rowIndex].ToCharArray()[colIndex];

            FillAdjacentCells(rowIndex, colIndex);

            return _board;
        }

        private void FillAdjacentCells(int rowIndex, int colIndex)
        {
            if (!IsCellEmpty(rowIndex, colIndex))
            {
                return;
            }

            ReplaceCellValue(rowIndex, colIndex);

            FillAdjacentCells(rowIndex, colIndex + 1);
            FillAdjacentCells(rowIndex, colIndex - 1);
            FillAdjacentCells(rowIndex + 1, colIndex);
            FillAdjacentCells(rowIndex - 1, colIndex);
        }

        private bool IsCellEmpty(int rowIndex, int colIndex)
        {
            return rowIndex < _board.Length
                   && rowIndex > -1
                   && colIndex < _board[rowIndex].Length
                   && colIndex > -1
                   && _board[rowIndex].ToCharArray()[colIndex] == _cellToFill;
        }

        private void ReplaceCellValue(int rowIndex, int colIndex)
        {
            var rowItems = _board[rowIndex].ToCharArray();
            rowItems[colIndex] = _filler;
            _board[rowIndex] = string.Join("", rowItems);
        }
    }
}
