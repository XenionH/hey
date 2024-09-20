Random rnd = new Random();
int dice = rnd.Next(6);
  
if (dice <= 3) {
	Console.WriteLine("Terningen slog mindre end 4");
} else {
	Console.WriteLine("Terningen slog 4 eller mere");
}
