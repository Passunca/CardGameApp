public abstract class Deck
{
    protected List<PlayingCardModel> fullDeck = new();
    protected List<PlayingCardModel> drawPile = new();
    protected List<PlayingCardModel> discardPile = new();

    protected Deck()
    {
        CreateDeck();
        ShuffleDeck();
    }

    protected void CreateDeck()
    {
        fullDeck.Clear();

        for (int suit = 0; suit < 4; suit++)
        {
            for (int val = 0; val < 13; val++)
            {
                fullDeck.Add(new PlayingCardModel() { Suit = (CardSuit)suit, Value = (CardValue)val });
            }
        }
    }

    public virtual void ShuffleDeck()
    {
        var rand = new Random();
        drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
    }

    public abstract List<PlayingCardModel> DealCards();

    protected virtual PlayingCardModel DrawOneCard()
    {
        PlayingCardModel output = drawPile.Take(1).First();
        drawPile.Remove(output);

        return output;
    }

    public virtual List<PlayingCardModel> RequestsCards(List<PlayingCardModel> cardsToDiscard)
    {
        List<PlayingCardModel> output = new List<PlayingCardModel>();

        foreach (var card in cardsToDiscard)
        {
            output.Add(DrawOneCard());
            discardPile.Add(card);
        }

        return output;
    }
}

