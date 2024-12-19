
public class BlackJackDeck : Deck
{
    public override List<PlayingCardModel> DealCards()
    {
        List<PlayingCardModel> output = new();

        for (int i = 0; i < 2; i++)
        {
            output.Add(DrawOneCard());
        }

        return output;
    }

    public PlayingCardModel RequestCard()
    {
        return DrawOneCard();
    }
}

