class Program
{
    private static void Main(string[] args)
    {
        BlackJackDeck deck = new BlackJackDeck();

        var hand = deck.DealCards();

        foreach (var card in hand)
        {
            Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
        }

        Console.ReadLine();
    }
}