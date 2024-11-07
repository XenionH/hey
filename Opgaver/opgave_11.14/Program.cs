/*int[][] sudoku = new int[][] {	
	new int[] {1, 6, 4, 2, 9, 7, 8, 3, 5},
	new int[] {2, 5, 8, 4, 6, 3, 1, 7, 9},
	new int[] {9, 7, 3, 1, 8, 5, 4, 2, 6},
	new int[] {5, 4, 9, 8, 2, 6, 7, 1, 3},
	new int[] {3, 8, 2, 5, 7, 1, 6, 9, 4},
	new int[] {7, 1, 6, 3, 4, 9, 2, 5, 8},
	new int[] {8, 9, 1, 6, 5, 2, 3, 4, 7},
	new int[] {4, 3, 7, 9, 1, 8, 5, 6, 2},
	new int[] {6, 2, 5, 7, 3, 4, 9, 8, 1},
	}; */

/* int [] row1 = sudoku[0][x];
Array.Sort(row1);
foreach (int i in row1){
Console.WriteLine(i); 
} */
int [] row = new int [9];
bool dups = true;
//måske kunne jeg konverterer rækker til nye arrays som derefter kan tjekkes
/*for (int u = 0; u < sudoku.Length ; u++)	{
	for (int o = 0; o < 9; o++) {
		row [o] = sudoku [u][o];
	}	*/
	
	if (row.Lenght != row.Distinct().count()) {
		dups &= true;
	} else {
		dups = false;
	}
	Console.WriteLine(row);
//}
	
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




