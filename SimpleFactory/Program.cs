// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    System.Console.WriteLine("请输入数字A: ");
    string? strNumberA = Console.ReadLine();
    System.Console.WriteLine("请选择运算符号(+、-、*、/): ");
    string? strOperate = Console.ReadLine();
    System.Console.WriteLine("请输入数字B: ");
    string? strNumberB = Console.ReadLine();
    string strResult = "";
    switch(strOperate)
    {
        case "+":
            strResult = Convert.ToString(Convert.ToDouble(strNumberA)
            + Convert.ToDouble(strNumberB));
        break;
        case "-":
            strResult = Convert.ToString(Convert.ToDouble(strNumberA)
            - Convert.ToDouble(strNumberB));
        break;
        case "*":
            strResult = Convert.ToString(Convert.ToDouble(strNumberA)
            * Convert.ToDouble(strNumberB));
        break;
        case "/":
        if(strNumberB != "0")
        {
            strResult = Convert.ToString(Convert.ToDouble(strNumberA)
            / Convert.ToDouble(strNumberB));
        }
        else
        {
            strResult = "除数不能为0";
        }
        break;
    }
    System.Console.WriteLine($"结果是: {strResult}");
    Console.ReadLine();
}
catch(Exception ex)
{
    System.Console.WriteLine($"您的输入有错：{ex.Message}");
}
