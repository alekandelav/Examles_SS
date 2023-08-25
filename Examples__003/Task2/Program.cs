string Methode4(int count, string text)
{
    int i = 0; // возьмем цикл
    string result = String.Empty;
    
    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result; //завершаем
}

string res = Methode4(10, "QWERTY") // Нужно создать переменную и указать количество
System.WriteLine(res) // Чтобы показать на эране какой результат, выводим консоль