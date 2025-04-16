//from here
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections#indexable-collections

//create a list
List<string> salmons = [ "chinook", "coho", "pink", "sockeye" ];

//remove coho from list
salmons.Remove( "coho" );

//iterate through the list
foreach (var salmon in salmons )
  {
  Console.Write( salmon + " " );
  }

//output: chinook pink sockeye