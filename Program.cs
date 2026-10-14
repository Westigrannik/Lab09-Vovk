// 1

// Console.WriteLine("Напишите АНГЛИЙСКОЕ слово");
// string word = Console.ReadLine().ToLower();
// int cc = 0;
// foreach (char i in word)
// {
//     if (i == 'a') cc++;
// }
// Console.WriteLine($"{word} имеет {cc} букв а");

// 2

// Console.Write("Имя файла: ");
// string filename = Console.ReadLine();

// if (filename.StartsWith("Lab")){
//     Console.WriteLine("Это Лабораторная");
// } else Console.WriteLine("Это не лабораторная");

// if (filename.EndsWith(".cs")){
//     Console.WriteLine("Это файл С#");
// } else if (filename.EndsWith(".png") || filename.EndsWith(".jpg")) {
//     Console.WriteLine("Это Изображение");
// } else Console.WriteLine("Неизвестный тип");

// if (filename.Contains("test")){
//     Console.WriteLine("Это тестовый файл");
// } else Console.WriteLine("Это не тестовый файл");

// 3

// Console.Write("Напишите предложение: ");
// string sent = Console.ReadLine();
// Console.WriteLine(sent.ToUpper());
// Console.WriteLine(sent.Replace(" ", "_"));
// if (sent.Contains("stop")) Console.WriteLine("СТОП СЛОВО НАЙДЕНО");

// 4

// string date = "2026-09-29";
// string a = date.Substring(8, 2);
// string b = date.Substring(4, 4);
// string c = date.Substring(0, 4);
// Console.WriteLine($"{a}{b}{c}");

// string numb = "89161234567";
// Console.WriteLine($"+7 ({numb.Substring(1, 3)}) {numb.Substring(4, 3)}-{numb.Substring(7, 2)}-{numb.Substring(9, 2)}");\

// 5

// Console.WriteLine("Напишите ангийское слово");
// string word = Console.ReadLine().ToLower();
// string glaz = "eyuoia";
// int cc = 0;
// int ccg = 0;
// Console.WriteLine(word.Length);
// for (int i = 0; i <= word.Length-1; i++){
//     char n = word[i];
//     if (n == ' ') cc++;
    
//     if (glaz.Contains(n)) ccg++;
//     } 
// Console.WriteLine(cc);
// Console.WriteLine(ccg);

// 6

// Console.WriteLine("Напишите слово");
// string word = Console.ReadLine().ToLower();
// string wordcopy = "";
// for (int i = word.Length-1; i >= 0; i--){
//     wordcopy += word[i];
// }
// Console.WriteLine(wordcopy);
// if (word == wordcopy) Console.WriteLine("Слово палиндром");

// Console.WriteLine("Напишите почту");
// string mail = Console.ReadLine().ToLower();
// bool fl1;
// bool fl2;
// bool fl3;
// bool fl4;
// bool fl5;
// // 1
// if (mail.Length > 4) fl1 = true;
// else {fl1 = false; Console.WriteLine("меньше 5 букв");}
// // 2
// int cc1 = 0;
// for (int i = 0; i <= mail.Length-1; i++){
//     if (mail[i] == '@') cc1++;
//     if (cc1>1) break;
// }
// if (cc1 == 1) fl2 = true;
// else {fl2 = false; Console.WriteLine("Не имеется @ или нельзя больше 1");}
// // 3
// if (mail[0] != '@' && mail[mail.Length-1] != '@') fl3 = true;
// else {fl3 = false; Console.WriteLine("Нельзя начинать или заканчивать на @");}
// // 4
// if (mail.Contains(' ')) {fl4 = false; Console.WriteLine("Содержит пробелы");}
// else fl4 = true;
// // 5
// if (mail.EndsWith(".ru") || mail.EndsWith(".com")) fl5 = true;
// else {fl5 = false; Console.WriteLine("Не оканчивается на .ru или .com");}

// if (fl1 && fl2 && fl3 && fl4 && fl5) Console.WriteLine("Почта принята");
// else Console.WriteLine("Почта не принята");

using System.Text;
Console.WriteLine("Напишите текст");
string word = Console.ReadLine();
var sb = new StringBuilder();
string glaz = "eyuioa";
for (int i = 0; i <= word.Length-1; i++){
    if (glaz.Contains(word[i])) continue;
    else sb.Append(word[i]);
}

Console.WriteLine(sb);