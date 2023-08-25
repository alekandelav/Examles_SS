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
Methode21("Текст", 4); //вводим 4 чтобы открыть сообщение 4 раза