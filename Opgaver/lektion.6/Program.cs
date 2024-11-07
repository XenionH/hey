
//int [] numb = AssignNumbers(15);
struct {int Card[],enum Suit = {Hearts, Diamonds, Clubs, Spades,}} deck; 
enum Suit = {Hearts, Diamonds, Clubs, Spades,};
Suit suit = Suit.Hearts
Card[] deck = AssignCards(20);
int maxHearts = 0;
int	maxClubs = 0;
int maxDiamonds = 0;
int maxSpades = 0;
for(int i = 0; i < numb.Length; i++)
{
	Console.WriteLine(deck[i].suit + " " + deck[i].value);
	switch(deck[i].suit)
	{
		case suit.Hearts:
			if (deck[i].value > maxHearts)
				maxHearts = deck[i].value;
		case suit.Diamonds:
			if (deck[i].value > maxDiamonds)
				maxDiamonds = deck[i].value;
		case suit.Clubs:
			if (deck[i].value > maxClubs)
				maxClubs = deck[i].value;
		case suit.Spades:{
			if (deck[i].value > maxSpades)
				maxSpades = deck[i].value;
			break;
		}
	}
	
} 

Console.WriteLine("\nMax: " + maxHearts);
Console.WriteLine("\nMax: " + maxDiamonds);
Console.WriteLine("\nMax: " + maxClubs);
Console.WriteLine("\nMax: " + maxSpades);