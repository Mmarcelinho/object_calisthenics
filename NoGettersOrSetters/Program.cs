namespace NoGetterOrSetters;


public class program
{
    /*
    var tarefa = new tarefa();
    tarefa.Id = new Guid();
    tarefa.Titulo = Tarefa1;
    tarefa.Concluido = true;
    tarefa.DataCriacao = DateTime.Now;
    tarefa.Status = "Em Andamento";
    */

    static void Main(string[] args)
    {
        var tarefa = new Tarefa("Tarefa1");
        tarefa.IniciarTarefa();
        tarefa.ConcluirTarefa();
        Console.WriteLine(tarefa);
    }
}



public class Tarefa
{
    public Guid Id { get; init; }

    public string Titulo { get; private set; }

    public bool Concluido { get; private set; }

    public string Status { get; private set; }

    public DateTime DataCriacao { get; init; }

    public Tarefa(string titulo)
    {
        this.Id = Guid.NewGuid();
        this.Titulo = titulo;
        this.Status = "Pendente";
        this.DataCriacao = DateTime.Now;
    }
    public void IniciarTarefa() => Status = "Em Andamento";
    public void ConcluirTarefa()
    {
        if (Status == "Em Andamento")
        {
            Concluido = true;
            Status = "Concluida";
        }    
        else 
        Console.WriteLine("Tarefa não concluída");
    }

    public override string ToString() =>
        $"{this.Id} - {this.Titulo} - {this.Concluido} - {this.Status} - {this.DataCriacao}";



}


/*
public class Tarefa
{
    public Guid Id { get; set; }

    public string  Titulo { get; set; }

    public bool Concluido { get; set; }

    public string Status { get; set; }

    public DateTime DataCriacao { get; set; }

}
*/

