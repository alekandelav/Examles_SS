string Methode1(int count, string text)
{
    int i = 0; // возьмем цикл
    string result = String.Empty;
      
    for( int i = 0; i <= count; i++)
    {
        result = result + text;
        // i++  убираем так как создали  for( int i = 0; < count; i++)
    }
    return result; //завершаем
}

string res = Methode1 (10, "qwerty"); // Нужно создать переменную и указать количество
System.WriteLine(res); // Чтобы показать на эране какой результат, выводим консоль