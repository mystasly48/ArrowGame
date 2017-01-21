using System;
using System.Collections.Generic;

namespace ArrowGame {
  public class Arrow {
    public const string RightArrow = "→";
    public const string LeftArrow = "←";
    public const string UpArrow = "↑";
    public const string DownArrow = "↓";

    public static string GetArrow(ConsoleKey key) {
      switch (key) {
        case ConsoleKey.RightArrow:
          return RightArrow;
        case ConsoleKey.LeftArrow:
          return LeftArrow;
        case ConsoleKey.UpArrow:
          return UpArrow;
        case ConsoleKey.DownArrow:
          return DownArrow;
        default:
          throw new KeyNotFoundException();
      }
    }

    public static ConsoleKey GetArrow(string key) {
      switch (key) {
        case RightArrow:
          return ConsoleKey.RightArrow;
        case LeftArrow:
          return ConsoleKey.LeftArrow;
        case UpArrow:
          return ConsoleKey.UpArrow;
        case DownArrow:
          return ConsoleKey.DownArrow;
        default:
          throw new KeyNotFoundException();
      }
    }

    public static string GetArrow(int key) {
      switch (key) {
        case 0:
          return RightArrow;
        case 1:
          return LeftArrow;
        case 2:
          return UpArrow;
        case 3:
          return DownArrow;
        default:
          throw new KeyNotFoundException();
      }
    }
  }
}
