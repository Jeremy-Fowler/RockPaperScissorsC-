namespace Game
{
  public class Result
  {
    public string GameResults(string userResult, string computerResult)
    {
      if(userResult == computerResult){
        return "YOU TIED";
      }
      else if(userResult == "ROCK" && computerResult == "SCISSORS" || userResult == "SCISSORS" && computerResult == "PAPER" || userResult == "PAPER" && computerResult == "ROCK")
      {
        return "YOU WIN";
      }
      else
      return "YOU LOSE";
    }
  }
}