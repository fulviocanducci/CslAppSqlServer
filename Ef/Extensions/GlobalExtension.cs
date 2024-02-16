namespace Ef.Extensions;
public static class GlobalExtension
{
   public static string SpaceWith(this string? value, int length, char character = ' ')
   {
      if (value != null)
      {
         if (value.Length == length)
         {
            return value;
         }
         return value.AddCharacter(length - value.Length, character);
      }
      return value ?? "";
   }

   private static string AddCharacter(this string value, int length, char character)
   {
      string spaces = new(character, length);
      return $"{value}{spaces}";
   }
}