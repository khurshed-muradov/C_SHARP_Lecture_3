// Вид 1 - Они ничего не возвращают и ничего не принимают.
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1(); // Способ вызода метода.



// Вид 2 - Это методы, которые ничего не возвращают, но могут принимать какие-то аргументы.

void Method2(string msg) //Аргменты метода указаны в скобках
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

// Вид 2.1. - Это методы, которые ничего не возвращают, но могут принимать какие-то аргументы.

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i = i + 1;
    }
}
// Method21(msg: "Текст", count: 4);

// Вид 3 - Это методы, которые что-то возвращают, но ничего не принимают. 
// Если метод, что-то возвращает, то мы в обязательном порядке должны будем указать ТИП ДАННЫХ, значение которых мы ожидаем.

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);


// Вид 4 - Это методы, которые что-то принимают и что-то возвращают.

string Method4(int count, string test)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + test;
        i++;
    }
    return result;
}
string res = Method4(10, "Тест");
Console.WriteLine(res);