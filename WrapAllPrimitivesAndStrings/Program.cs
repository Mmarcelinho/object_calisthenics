namespace WrapAllPrimitivesAndStrings;

/*
Refatorando o código onde os tipos primitivos são encapsulados como objeto
Se um tipo primitivo tem um comportamento por exemplo CPF então esta variável deveria estar encapsulada em um Objeto CPF.
*/

public class Pessoa
{
    public string CPF { get; set; }
}

public class Pessoa2
{
    public CPF CPF { get; set; }
}

public class CPF
{
    public string Numero { get; set; }

    public CPF(string numero)
    {
        if (!CPFValido(numero))
            Console.WriteLine($"CPF {numero} está inválido");
        this.Numero = numero;
    }
    private void CPFValido(string numero)
    {
        //Implementação
    }
}

