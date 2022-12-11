//функция для замены элементов в строке

Console.Clear();
string text = "Совсем недавно я решила завести свой собственный сад. Теперь там растут яблони,"
+ "вишни, кустики крыжовника, смородины и, конечно же, малины! В скором времени мой маленький сад" 
+ "запестрит яркими красками, а стол не обойдётся без блюд из этих замечательных фруктов и ягод.";

string replaceLetter (string oldText, char oldLetter, char newLetter){
    string newText = String.Empty;

    for (int i = 0; i < oldText.Length; i++)
    {
        if (oldText[i] == oldLetter) newText += newLetter;
        else newText += oldText[i];
    }

    return newText;
}

Console.WriteLine(text);
string newText = replaceLetter(text,' ', '|');
Console.WriteLine();
Console.WriteLine(newText);

newText = replaceLetter(newText,'а', 'А');
Console.WriteLine();
Console.WriteLine(newText);

newText = replaceLetter(newText,'н', 'Н');
Console.WriteLine();
Console.WriteLine(newText);
