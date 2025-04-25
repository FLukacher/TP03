namespace TP03.Models;

public static class Catalogo
{
    public static Dictionary<int, Disco> discos {get; set;}

    public static void InicializarCatalogo()
    {
        discos = new Dictionary<int, Disco>();
        Disco d1 = new Disco(1, "Soda Stereo", "Gustavo Cerati", "Signos", "signos.jpg");
        d1.temas.Add("Signos");
        d1.temas.Add("Persiana americana");
        d1.temas.Add("Prófugos");
        discos.Add(d1.id, d1);

        Disco d2 = new Disco(2, "Charly García", "Charly García", "Clics Modernos", "clicsModernos.jpg");
        d2.temas.Add("Nos siguen pegando abajo");
        d2.temas.Add("Los dinosaurios");
        d2.temas.Add("No me dejan salir");
        discos.Add(d2.id, d2);

        Disco d3 = new Disco(3, "Luis Alberto Spinetta", "Luis Alberto Spinetta", "Almendra", "almendra.jpg");
        d3.temas.Add("Muchacha ojos de papel");
        d3.temas.Add("Ana no duerme");
        d3.temas.Add("Color humano");
        discos.Add(d3.id, d3);

        Disco d4 = new Disco(4, "Fito Páez", "Fito Páez", "El amor después del amor", "amorDespuesDelAmor.jpg");
        d4.temas.Add("El amor después del amor");
        d4.temas.Add("A rodar mi vida");
        d4.temas.Add("Tumbas de la gloria");
        discos.Add(d4.id, d4);

        Disco d5 = new Disco(5, "Andrés Calamaro", "Andrés Calamaro", "Honestidad Brutal", "honestidadBrutal.jpg");
        d5.temas.Add("Te quiero igual");
        d5.temas.Add("La parte de adelante");
        d5.temas.Add("Paloma");
        discos.Add(d5.id, d5);

        Disco d6 = new Disco(6, "La Renga", "La Renga", "Despedazado por mil partes", "despedazadoPorMilPartes.jpg");
        d6.temas.Add("La balada del diablo y la muerte");
        d6.temas.Add("Panic show");
        d6.temas.Add("Veneno");
        discos.Add(d6.id, d6);

        Disco d7 = new Disco(7, "Patricio Rey y sus Redonditos de Ricota", "Indio Solari", "Oktubre", "oktubre.jpg");
        d7.temas.Add("Ji ji ji");
        d7.temas.Add("Preso en mi ciudad");
        d7.temas.Add("Ya nadie va a escuchar tu remera");
        discos.Add(d7.id, d7);

        Disco d8 = new Disco(8, "Babasónicos", "Gustavo Iglesias", "Infame", "infame.jpg");
        d8.temas.Add("Putita");
        d8.temas.Add("Irresponsables");
        d8.temas.Add("Yegua");
        discos.Add(d8.id, d8);

        Disco d9 = new Disco(9, "Los Auténticos Decadentes", "Los Auténticos Decadentes", "Mi vida loca", "miVidaLoca.jpg");
        d9.temas.Add("La guitarra");
        d9.temas.Add("El gran señor");
        d9.temas.Add("Entregá el marrón");
        discos.Add(d9.id, d9);

        Disco d10 = new Disco(10, "Abel Pintos", "Abel Pintos", "11", "11.jpg");
        d10.temas.Add("Motivos");
        d10.temas.Add("Cien años");
        d10.temas.Add("Cómo te extraño");
        discos.Add(d10.id, d10);
    }
}