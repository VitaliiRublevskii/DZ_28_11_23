

// Задание 1

using System;

float maxA = 0, maxB = 0;
float sumA = 0, sumB = 0, quanA = 1, quanB = 1;
float sumEven = 0, sumOdd = 0;

Console.WriteLine("Введите количество элементов одномерного массива:");
int elem = int.Parse(Console.ReadLine());
int[] A = new int[elem];

Console.WriteLine("Введите элементы массива:");
float minA = 100;
for (int i = 0; i < A.Length; i++)
{
    A[i] = int.Parse(Console.ReadLine());
    sumA += A[i];
    quanA *= A[i];
    if (maxA < A[i]) maxA = A[i];
    if (minA > A[i]) minA = A[i];
    if (A[i] % 2 == 0) sumEven += A[i];
}

Console.WriteLine("Одномерный массив:");
for (int i = 0; i < A.Length;  i++)
    Console.Write($"{A[i]}\t");
Console.WriteLine();


Console.WriteLine("Введите количество элементов двумерного массива:");
int elem21 = int.Parse(Console.ReadLine());
int elem22 = int.Parse(Console.ReadLine());
float[,] B = new float[elem21, elem22];
float minB = 100;
Random random = new Random();
Console.WriteLine("Двумерный массив заполняется рандомными числами");
for (int i = 0; i < elem21; i++)
{
    for (int j = 0; j < elem22; j++)
    {
        B[i, j] = random.Next(1, 20);
        sumB += B[i, j];
        quanB *= B[i, j];
        if (maxB < B[i, j]) maxB = B[i, j];
        if (minB > B[i, j]) minB = B[i, j];
        if (j % 2 != 0) sumOdd += B[i, j];
    }
}
Console.WriteLine("Двумерный массив:");

for (int i = 0; i < elem21; i++)
{
    for (int j = 0; j < elem22; j++)
    {
        Console.Write($"{B[i, j]}\t");
    }
    Console.WriteLine();
}


Console.WriteLine($" Максимальный элемент двух массивом = {(maxA > maxB ? maxA : maxB)}");
Console.WriteLine($" Минимальный элемент двух массивом = {(minA < minB ? minA : minB)}");
Console.WriteLine($" Сумма элементов двух массивом = {sumA + sumB}");
Console.WriteLine($" Произведение элементов двух массивом = {quanA * quanB}");
Console.WriteLine($" Сумма четных элементов массива А = {sumEven}");
Console.WriteLine($" Сумма элементов нечетных столбцов массива В = {sumOdd}");




//  Задание  2

int[,] arr2 = new int[5, 5];

int minArr = 100, maxArr = -100, sumElem = 0;
int posImin = 0, posJmin = 0;
int posImax = 0, posJmax = 0;
bool count = false;
Random random = new Random();
Console.WriteLine("Двумерный массив заполняется рандомными числами");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arr2[i, j] = random.Next(-100, 100);

        if (minArr > arr2[i, j])
        {
            minArr = arr2[i, j];
            posImin = i;
            posJmin = j;
        }
        if (maxArr < arr2[i, j])
        {
            maxArr = arr2[i, j];
            posImax = i;
            posJmax = j;
        }
    }
}
Console.WriteLine("Двумерный массив:");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{arr2[i, j]}\t");

        if (i == posImin && j == posJmin || i == posImax && j == posJmax) {
            if (count)
            {
                count = false;
                continue;
            }
            else
            {
                count = true;
                continue;
            }
        }
        if (count)
        {
            sumElem += arr2[i, j];
        }
    }
    Console.WriteLine();
}

Console.WriteLine($" Минимальный элемент массива arr2 = {minArr}");
Console.WriteLine($" Максимальный элемент массива arr2 = {maxArr}");
Console.WriteLine($" Сумма элементов между мин и макс arr2 = {sumElem}");




//  Задание  3

char[] alphaArr = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к',
    'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ',
    'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

Console.WriteLine("Введите фразу, которую необходимо зашифровать: ");
string phrase = Console.ReadLine();

char[] phraseArr = phrase.ToCharArray();
char[] cipher = phraseArr;              //зашифрованная фраза
char[] decrypted = phraseArr;           // дешифрованная фраза

for (int i = 0; i < phraseArr.Length; i++)
{
    char ch = phraseArr[i]; 
    for (int j = 0; j < alphaArr.Length; j++) 
    {                                            
        if (ch == alphaArr[j]) 
        {                         
            int x = j + 3; 
            if (x > 33)
            {
                x = x % 33;
            }

            cipher[i] = alphaArr[x]; 
        }
        if (ch == ' ') 
        {
            cipher[i] = ' ';
        }
    }
}
Console.WriteLine(" Зашифрованная фраза: ");
for (int y = 0; y < cipher.Length; y++)
    Console.Write(cipher[y]);
Console.WriteLine();


for (int q = 0; q < phraseArr.Length; q++)
{
    char chr = phraseArr[q]; 
    for (int r = 0; r < alphaArr.Length; r++) 
    {                                           
        if (chr == alphaArr[r]) 
        {                         
            int m = r - 3; 
            if (m < 0)
            {
                m = 33 + m;
            }

            decrypted[q] = alphaArr[m]; 
        }
        if (chr == ' ') 
        {
            decrypted[q] = ' ';
        }
    }
}

Console.WriteLine(" Дешифрованная фраза: ");
for (int z = 0; z < decrypted.Length; z++)
    Console.Write(decrypted[z]);




//  Задание  4

using System;
Random random = new Random();
int[,] arr41 = new int[4, 4];
Console.WriteLine("\tМатрица arr41");

for (int i = 0; i < arr41.GetLength(0); i++)
{
    for (int j = 0; j < arr41.GetLength(1); j++)
    {
        arr41[i, j] = random.Next(1, 20);
        Console.Write($"{arr41[i, j]}\t");
    }
    Console.WriteLine();
}


int[,] arr42 = arr41;

Console.Write("\nВведите число, на которое нужно умножить матрицу:\t");
int choice4 = int.Parse(Console.ReadLine());
Console.WriteLine("\n\tМатрица arr41, после умножения на число:");
for (int i = 0; i < arr41.GetLength(0); i++)
{
    for (int j = 0; j < arr41.GetLength(1); j++)
    {
        arr41[i, j] *= choice4;
        Console.Write($"{arr41[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n\tМатрица arr42 (копия матрицы arr41): ");
for (int i = 0; i < arr42.GetLength(0); i++)
{
    for (int j = 0; j < arr42.GetLength(1); j++)
    {
        Console.Write($"{arr42[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n\tМатрица arr43 (сумма матриц arr41 & arr42:");
int[,] arr43 = new int[4, 4];
for (int i = 0; i < arr43.GetLength(0); i++)
{
    for (int j = 0; j < arr43.GetLength(1); j++)
    {
        arr43[i, j] = arr41[i, j] + arr42[i, j];
        Console.Write($"{arr43[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n\tМатрица arr44 (произведение матриц arr41 & arr42:");
int[,] arr44 = new int[4, 4];
for (int i = 0; i < arr41.GetLength(0); i++)
{
    for (int j = 0; j < arr42.GetLength(1); j++)
    {
        for (int k = 0; k < arr42.GetLength(0); k++)
        {
            arr44[i, j] += arr41[i, k] * arr42[k, j];
        }
        Console.Write($"{arr44[i, j]}\t");
    }
    Console.WriteLine();
}




//  Задание  5

Console.Write("Введите арифметическое выражение: \t");
string str5 = Console.ReadLine();

string[] str51 = str5.Split('+');
if (str51.Length > 1)
{
    int left = int.Parse(str51[0]);
    int right = int.Parse(str51[1]);
    Console.Write(left + right);
}
string[] str52 = str5.Split('-');
if (str52.Length > 1)
{
    int left = int.Parse(str52[0]);
    int right = int.Parse(str52[1]);
    Console.Write(left - right);
}
else Console.WriteLine("Некорректно указано выражение");




//  Задание  6

string str6 = "пользователь с клавиатуры вводит некоторый текст.";
string[] str61 = str6.Split('.');
string str62;

for (int i = 0; i < str61.Length; i++)
{
    str62 = str61[i];
    First(str62);
}


string First(string s)
{
    char[] char6 = s.ToCharArray();
    char6[0] = char.ToUpper(char6[0]);
    return new string(char6);
    Console.WriteLine(First(s));
}






//  Задание  7

Console.WriteLine("Введите текст : \t");
string text = Console.ReadLine();

Console.Write("Введите недопустимое слово : \t");
string stopWord = Console.ReadLine();

string[] words = text.Split(' ');

int count = 0;

foreach (var word in words)
{
    if (stopWord.Contains(word))
    {
        text = text.Replace(word, new string('*', word.Length));
        count++;
    }
}

Console.WriteLine("Измененный текст: " + text);
    
Console.WriteLine("Количество недопустимых слов: " + count);








