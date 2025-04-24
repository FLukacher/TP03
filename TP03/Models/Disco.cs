namespace TP03.Models;

public class Disco
{
    public string nombreDisco {get; private set;}
    public int id {get; set;}
    public string nombreArtista { get; private set; }
    public string nombreProductor {get; private set; }
    public List<string> temas {get; private set;}
    public string foto {get; private set;}

    public Disco(int id, string nombreArtista, string nombreProductor, string nombreDisco)
    {
        this.nombreDisco = nombreDisco;
        this.id = id;
        this.nombreArtista = nombreArtista;
        this.nombreProductor = nombreProductor;
        this.temas = new List<string>();
        this.foto = nombreDisco;
    }


}
