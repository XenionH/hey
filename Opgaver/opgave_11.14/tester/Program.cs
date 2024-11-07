int[][] sudoku = new int[][] {	
	new int[] {1, 6, 4, 2, 9, 7, 8, 3, 5},
	new int[] {2, 5, 8, 4, 6, 3, 1, 7, 9},
	new int[] {9, 7, 3, 1, 8, 5, 4, 2, 6},
	new int[] {5, 4, 9, 8, 2, 6, 7, 1, 3},
	new int[] {3, 8, 2, 5, 7, 1, 6, 9, 4},
	new int[] {7, 1, 6, 3, 4, 9, 2, 5, 8},
	new int[] {8, 9, 1, 6, 5, 2, 3, 4, 7},
	new int[] {4, 3, 7, 9, 1, 8, 5, 6, 2},
	new int[] {6, 2, 5, 7, 3, 4, 9, 8, 1},
	};
//	disse 3 variabler bruges senere
int[] square = new int [9];
bool dups = true; 
bool okNum = true;
//First some for loops are made to check if the numbers in the rows and columns have duplicates, so all row have 1 through 9 and the same with columns. 
for (int i = 0; i < 9; i++)
{
	for (var j = 0; j < 9; j++)
	{
		for (var k = j + 1; k < 9; k++)
		{
			dups &= (sudoku[i][j] != sudoku[i][k]) ? true : false; //Here the values of the numbers of the rows is evaluated to see if they equal eachother
			dups &= (sudoku[j][i] != sudoku[k][i]) ? true : false; //and here is for the columns
		}
		okNum &= (0 < sudoku[i][j] && sudoku[i][j] < 10) ? true : false; // this is for making sure that no number is more than 9 and less than 1.
	}
}
for (var j = 0; j < 7 ; j = j + 3) //These for loops is for checking, that the squares have 1 through 9.
{
	for (var k = 0; k < 7; k = k + 3)
	{
		for (var l = 0; l < 3; l++)
		{
			square[l] = sudoku[0+k][l+j]; // It's done by making a new array from the 9 numbers of the squares
			square[l+3] = sudoku[1+k][l+j];
			square[l+6] = sudoku[2+k][l+j];
		}
		for (var i=0; i<square.Length; i++)
		{
			for (var n= i+1; n < square.Length; n++)
			{
				dups &= (square[i] != square[n]) ? true : false; //And then checking if the arrays have duplicates
			}	
		}
	}
}
bool correct = dups && okNum; //and last it compares dups which is the bool for checking for duplicates and oknum, which is to check that the number is less than 1 and more than 9.
string result = (correct == true) ? "This solution is CORRECT." : "This solution is WRONG."; 
Console.WriteLine(result);
























/* til at tjekke summen af rækker og kolonner
int sumRow = 0;
int sumColumn = 0;
bool checkRow = true;
bool checkColumn = true;
for (int i = 0; i < 9; i++) {
	for (int j = 0; j < 9; j++) {
		Console.Write(sudoku[i][j]);
		sumRow += sudoku[i][j];
		sumColumn += sudoku[j][i];
		if (sumRow == 45) {
			checkRow1 = true;
		} else {
			checkRow1 = false;
		} 
	}
	checkRow &= (sumRow == 45) ? true : false;
	checkColumn &= (sumColumn == 45) ? true : false;
	Console.Write(checkRow);
	Console.WriteLine("Sum af række " + (i + 1) + " = " + sumRow);
	Console.WriteLine("Sum af kolonne " + (i + 1) + " = " + sumColumn);
	sumRow = 0;
	sumColumn = 0;
}
*/