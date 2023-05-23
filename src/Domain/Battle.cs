namespace Domain;

public class Battle
{
    public Battle(IEnumerable<Fleet> fleets)
    {
        this.Fleets = fleets;
    }
    
    public IEnumerable<Fleet> Fleets { get; }

    public BattleState State { get; set; } = BattleState.NotStarted;

    public int AreaWidth { get; init; } = 10;
    public int AreaHeight { get; init; } = 10;
}