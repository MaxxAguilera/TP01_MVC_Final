namespace TP01MVC_FINAL.Models;

public class Grupo
{
    Dictionary<int, Integrante> integrantes;

    public Grupo()
    {
        this.integrantes = CargaDatosManual();
    }

    public Dictionary<int, Integrante> CargaDatosManual()
    {
        Dictionary<int, Integrante> integrantes = new Dictionary<int, Integrante>();
        List<string> familia1 = new List<string>(){"Nicolás", "María", "Bruno", "Chola"};
        List<string> intereses1 = new List<string>(){"Tiktok", "dibujar", "madrij"};
        Integrante integrante1 = new Integrante(502, "pipi", new DateTime(2010, 2, 21), "https://i.pinimg.com/236x/ef/7e/4b/ef7e4bff786803859497b830b60313c2.jpg", familia1, intereses1);
        integrantes.Add(integrante1.GetDni(), integrante1);

        List<string> familia2 = new List<string>(){"luciana", "big nine", "wada", "Chiru"};
        List<string> intereses2 = new List<string>(){"Tiktok", "racing", "musica"};
        Integrante integrante2 = new Integrante(503, "lil nine", new DateTime(2010, 3, 19), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXOhL0PDtXcriLPxjw_UGw9mV2gPQ8I78JSA&s", familia2, intereses2);
        integrantes.Add(integrante2.GetDni(), integrante2);
        return integrantes;
    } 

    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return this.integrantes;
    }

    public Integrante GetIntegrante(int dni)
    {    
        if(integrantes.ContainsKey(dni)) return integrantes[dni];
        return null;
    }
}