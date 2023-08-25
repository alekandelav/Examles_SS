
//вид 1

void Method()
{
    Console.WriteLine("Автор...");
}
Method();


//Вид 2

void Method(string msg)
{
    Console.WriteLine(msg);
}
//Method(msg:"Текст сообщения") // Аргумент msg к которому хотим указать

void Method21(string msg, int count)
{
    int // для показа определенного количества сообщений msg
    while (int < count)
    {   Console.WriteLine(msg);
    i++;  //если мы оставим count++ будет увеличиваться много раз надо поставить -> i++
    }
}
//Methode21("Текст", 4); //способ 1: вводим 4 чтобы открыть сообщение 4 раза
// Methode21(count: 4, msg: "Новый текст"); //2 пособ написать так наш метод с обозначением


//Вид 3

int Methode3()
{
    return DateTime.Now.Year;
}

int year = Methode3();
//Console.WriteLine(year);




//Вид 4 - принимает и возвращает

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
System.WriteLine(res) // Чтобы показать на эране какой результат, выводим консоль.