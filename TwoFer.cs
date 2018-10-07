using System;

  public static class TwoFer
  {
    public static string Name(string input = null)
    {
        if (string.IsNullOrEmpty(input))
            return Output("you");
        return Output(input);
    }
    public static string Output(string input)
    {
        return $"One for {input}, one for me.";
    }
}
