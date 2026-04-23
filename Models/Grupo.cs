namespace tp1_miklaski_falk.Models;

public class Grupo
{
    private Dictionary<int, Integrante> dicIntegrantes;

    public Grupo()
    {
        dicIntegrantes = new Dictionary<int, Integrante>();
    }

    public void CargaDatosManual()
    {
        Integrante integrante1 = new Integrante(1111, "Emanuel Miklaski", new DateTime(2009, 07, 25), "EmanuelMiklaski.jpg", new List<string>(){"Ari Mikla", "Noa Mikla"}, new List<string>(){"Futbol", "Leer", "Defensa", "Programar"});
        dicIntegrantes.Add(integrante1.getDni(), integrante1);

        Integrante integrante2 = new Integrante(2222, "Julian Falk", new DateTime(2009, 12, 31), "JulianFalk.jpg", new List<string>(){"Gera Falk", "Donner Falk"}, new List<string>(){"Fuchibola", "Leer", "Stam", "Boca Juniors", "Programar"});
        dicIntegrantes.Add(integrante2.getDni(), integrante2);
        
        Integrante integrante3 = new Integrante(6767, "Echu Mogue", new DateTime(2010, 06, 07), "EchuMogue.jpg", new List<string>(){"Mati Mogue", "Seba Mogue", "Martin Mogue"}, new List<string>(){"Futbol", "FIFA", "Fortnite", "Aprobar programación"});
        dicIntegrantes.Add(integrante3.getDni(), integrante3);
        }
    public Dictionary<int, Integrante> devolverIntegrantes()
    {
        return dicIntegrantes;
    }


}