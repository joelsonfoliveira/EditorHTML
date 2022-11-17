
namespace EditorHTML
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;

      DrawScreen();
    }

    public static void DrawScreen()
    {
      System.Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        System.Console.Write("-");
      }
      System.Console.Write("+");

      System.Console.Write("\n");

      for (int lines = 0; lines <= 10; lines++)
      {
        System.Console.Write("|");
        for (int i = 0; i <= 30; i++)
        {
          System.Console.Write(" ");
        }
        System.Console.Write("|");

        System.Console.Write("\n");
      }

      System.Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        System.Console.Write("-");
      }
      System.Console.Write("+");

    }
  }
}
