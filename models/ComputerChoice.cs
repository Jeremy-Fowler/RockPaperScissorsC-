using System;

namespace Game
{
  public class ComputerChoice : RPS
  {
    private Random _r = new Random();
        public override int Choice => _r.Next(1, 4);
  }
}