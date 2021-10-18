namespace Game
{
  public abstract class RPS
  {
     public abstract int Choice {get;}

    public string Shoot()
    {
      if(Choice == 2)
      {
        return "PAPER";
      }
      if(Choice == 3)
      {
        return "SCISSORS";
      }
    return "ROCK";
    }
  }
}