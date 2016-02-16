using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSAvancado
{
    class Program
    {        
        static void Main(string[] args)
        {
            CalculadoraImp calcImpl = new CalculadoraImp();
            Calculadora calc = new Calculadora();

            int a = 10;
            int b = 5;
            
            try
            {
                calc.Soma = new SomaDel(calcImpl.Soma);
                calc.Divide = new DivideDel(calcImpl.Divide);
                calc.Multiply = new MultiplyDel(calcImpl.Multiply);
                calc.Pow = new PowDel(calcImpl.Pow);
                calc.Subtraction = new SubDel(calcImpl.Subtraction);
                calc.Sqrt = new SqrtDel(calcImpl.Sqrt);

                Console.WriteLine(string.Format("{0} + {1} = {2}", a, b, calc.Soma(a,b)));
                Console.WriteLine(string.Format("{0} / {1} = {2}",a , b, calc.Divide(a, b)));
                Console.WriteLine(string.Format("{0} * {1} = {2}", a, b, calc.Multiply(a, b)));
                Console.WriteLine(string.Format("{0} ^ {1} = {2}", a, b, calc.Pow(a, b)));
                Console.WriteLine(string.Format("{0} - {1} = {2}", a, b, calc.Subtraction(a, b)));
                Console.WriteLine(string.Format("SQRT({0}) = {1}", a, calc.Sqrt(a)));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}


/*
            LogCliente Impressao = new ImplementationInterface();

            Cliente c = new Cliente()
            {
                Nome = "teste1",
                Idade = 20,
                Documento = "312314341-09"
            };

            ClienteDB db = new ClienteDB();
            db.Log = new ImplementationInterface();
            db.AddCliente(c);

*/







/*string text = @"<teste>
                    <att1>Nome</att1>
                    <att2>Endereco</att2>
                </teste>";
/*
    Validar se o nó att1 existe
    Validar se o nó att3 existe
    Validar se o no att2 possui o valor endereco


Regex regAtt1 = new Regex(@"\<att1\>(\w+)\<\/att1\>", RegexOptions.IgnoreCase | RegexOptions.Multiline);

if (regAtt1.IsMatch(text))  
{
    Console.WriteLine("ATT1 EXISTE!");
    //Groups[0] retorna o grupo todo
    Console.WriteLine("Valor de att1 == " + regAtt1.Match(text).Groups[1].Value);
}

Regex regAtt3 = new Regex("<att3>\\w.*</att3>", RegexOptions.IgnoreCase | RegexOptions.Multiline);

if (regAtt3.IsMatch(text))
{
    Console.WriteLine("ATT3 EXISTE!");
}

Regex regAtt2 = new Regex("<att2>Endereco</att2>", RegexOptions.IgnoreCase | RegexOptions.Multiline);

if (regAtt2.IsMatch(text))
{
    Console.WriteLine("ATT2 POSSUI ENDERECO!");
}

/*
    Imprima na tela o valor do no teste
    Imprima o valor do no att2

Regex reg = new Regex(@"", RegexOptions.IgnoreCase | RegexOptions.Multiline);

if (reg.IsMatch(text))
{
    Console.WriteLine("Valor do nó == " + reg.Match(text).Groups[0].Value);
}*/

/*string text = @"objeto: {
                    Nome: aluno,
                    Endereco: Rua,
                    Sexo: M
                }";

    /*imprimir nome da propriedade e valor
      imprimir quantas propriedades o objeto possui
      acrescentar nova propriedade Idade: 20 e testar novamente*/


/*Regex reg = new Regex(@"(?<tag>\w+):.(?<value>\w+)", RegexOptions.IgnoreCase | RegexOptions.Multiline);

if (reg.IsMatch(text))  
{
    foreach (Match m in reg.Matches(text))
    {
        Console.WriteLine("Valor da tag: " + m.Groups["tag"] + "     Valor: " + m.Groups["value"]);                    
    }

    Console.WriteLine(reg.Matches(text).Count);

}*/
