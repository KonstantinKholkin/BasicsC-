using System;
using System.Text;
using System.Collections.Generic;

namespace Exercise2
{
    /*
 Задача2
   Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. 
В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
Здесь требуется использовать класс Dictionary.

Выполнил Холкин Константин Юрьевич
*/
    class ResultText
    {
        static public string text;

       
        static ResultText()
        {
            text = "Новый Год! Новый Год!\nКаждый, кого-то, в гости ждет!\nЖдут детишки, ждут зайчишки\nЖдет и маленький братишка!\n" +
                   "Сколько ж, к нам придет народу ?\nСобрались бы все по ходу...\nЧтобы Дедушка Мороз,\nНам подарки бы принес!\n" +
                   "Чтобы, елки на макушках\nЗасияли бы в игрушках...\nЧтобы, каждому под ней\nНабралось по больше пней!\n" +
                   " Этот пень, зовется, -Книжка\nПро смышленого мальчишку\nБабушка ее купила\nИ в придачу, -кусок мыла.\n" +
                   "Этот пень, зовется, -Зайка,\nОн недавно из лужайки...\nДедушка его...";
        }

        
       
        static public void GetWordsByLength(int len)//Выводит слова сообщения, которые содержат не более n букв
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t'});
            Console.WriteLine($"Вывод слов, длинной не более {len} :\n ");
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write($"{word}   ");
            }
        }

        
        
        static public void DeleteWordByEndChar(char ch)//Удаляет из сообщения все слова, которые заканчиваются на заданный символ
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            Console.WriteLine($"Будут удалены слова, оканчивающиеся на символ {ch} +:\n ");
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write($"{word}  ");
                    text.Replace(word, " ");
                }
                
            }
           
        }

       
        
        static public string FindMaxLengthWord() //Находит самое длинное слово сообщения
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;
            
            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            
            return maxWord;
        }

              
       
       
        static  public void FrequencyAnalysis(string[] words, string text) //Производит частотный анализ текста
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] textWords = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                foreach (string wordInText in textWords)
                {
                    if (word == "")
                        continue;
                    if (wordInText == word)
                    {
                        if (word == "")
                            continue;
                        if (wordFrequency.ContainsKey(word))
                            wordFrequency[word] += 1;
                        else
                            wordFrequency.Add(word, 1);
                    }
                }
            }
            
            ICollection<string> keys = wordFrequency.Keys;

            String result = String.Format("{0,-10} {1,-10}\n\n", "Слово", "Частота появления");

            foreach (string key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, wordFrequency[key]);
            Console.WriteLine($"\n{result}");
        }
        public void Print()
        {
            Console.WriteLine("\nДанн стих: \n" + ResultText.text);

            Console.WriteLine("\nВыведем слова текста, которые содержат не более 6 букв:\n");
            ResultText.GetWordsByLength(6);


            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'и': \n");
            ResultText.DeleteWordByEndChar('и');

            Console.WriteLine("\nСамое длинное слово в тексте: " + ResultText.FindMaxLengthWord());

            Console.WriteLine("\nПроизведём частотный анализ текста: \n");
            string[] arr = { "Новый", "год", "нам", "подарки" };
            ResultText.FrequencyAnalysis(arr, ResultText.text);
        }
    }
}