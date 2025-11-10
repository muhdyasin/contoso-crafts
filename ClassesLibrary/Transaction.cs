namespace ClassesLibrary;
using Humanizer;

public record Transaction(decimal Amount, DateTime date,string Notes)
{
    public string AmountForHumans
    {
        get
        {
            return ((int)Amount).ToWords();
        }
    }
}

