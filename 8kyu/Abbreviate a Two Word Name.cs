/*
Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

patrick feeney => P.F
*/

//Solution

public class Kata
{
    public static string AbbrevName(string name)
    {
        int spaceIndex = name.IndexOf(' ');
        char firstInitial = char.ToUpper(name[0]);
        char lastInitial = char.ToUpper(name[spaceIndex + 1]);
        return $"{firstInitial}.{lastInitial}";
    }
}
