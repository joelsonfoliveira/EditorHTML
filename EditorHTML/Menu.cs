
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
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      handleMenuOptions(option);
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

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      System.Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      System.Console.WriteLine("===========");
      Console.SetCursorPosition(3, 4);
      System.Console.WriteLine("Selecione uma opção abaixo: ");
      Console.SetCursorPosition(3, 6);
      System.Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      System.Console.WriteLine("2 - Abrir arquivo");
      Console.SetCursorPosition(3, 9);
      System.Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);
      System.Console.Write("Opção: ");
    }

    public static void handleMenuOptions(short option)
    {
      switch (option)
      {
        case 1: System.Console.WriteLine("Editor"); break;
        case 2: System.Console.WriteLine("View"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }

  }
}
