// See https://aka.ms/new-console-template for more information
using Exercise2;
Console.WriteLine("\nДанн стих: \n" + ResultText.text);

Console.WriteLine("\nВыведем слова текста, которые содержат не более 6 букв:\n");
ResultText.GetWordsByLength(6);


Console.Write("\nУдалим из текста слова, заканчивающиеся на 'и': \n");
ResultText.DeleteWordByEndChar('и');

Console.WriteLine("\nСамое длинное слово в тексте: " + ResultText.FindMaxLengthWord());

Console.WriteLine("\nПроизведём частотный анализ текста: \n");
string[] arr = { "Новый", "год", "нам", "подарки" };
ResultText.FrequencyAnalysis(arr, ResultText.text);


