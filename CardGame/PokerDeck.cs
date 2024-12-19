public class PokerDeck : Deck
{
    public override List<PlayingCardModel> DealCards()
    {
        List<PlayingCardModel> output = new ();

        for (int i = 0; i < 5; i++)
        {
            output.Add(DrawOneCard());
        }

        return output;
    }
}

