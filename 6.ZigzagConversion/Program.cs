

using System.Runtime.CompilerServices;

class ZigzagConversion
{
    static void Main()
    {
        string s = "PAYPALISHIRING";
        int numRows = 3;
        string[] rows = new string[numRows];
        for (int i = 0; i < numRows; i++)
        {
            rows[i] = "";
        }
        char[,] matrix = new char[numRows, s.Length];
        bool goingDown = true;
        int row = 0, col = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (row == 0)
            {
                goingDown = true;
                
            }
            else if (row == numRows - 1)
            {
                goingDown = false;
               
            }

            if (goingDown)
            {
                 matrix[row, col] = s[i];
                row++;
                
            }
            else
            {
                matrix[row, col] = s[i];
                row--;
                col++;
               
            }

        }

        // in ra
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (matrix[i, j] == '\0')
                    Console.Write("  ");
                else
                    Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }  
    }
}