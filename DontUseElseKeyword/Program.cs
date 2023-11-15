namespace DontUseElseKeyword;

/*
Refatorando o método para eliminar o uso desnecessário de palavras-chave condicionais.
Ao simplificar a estrutura, tornamos o código mais conciso e fácil de entender.
*/

public class program
{
    public bool HorarioEntrada(int horario)
    {
        if (horario < 9)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HorarioEntrada2(int horario)
    {
        if (horario < 9)
        {
            return true;
        }

        return false;

    }

    public bool HorarioEntrada3(int horario)
    {
        return horario < 9;
    }
   
}

