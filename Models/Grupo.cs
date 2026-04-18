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
        
    }
    public Dictionary<int, Integrante> devolverIntegrantes()
    {
        return dicIntegrantes;
    }

    public Integrante GetIntegrante(int dni)
    {
        if(dicIntegrantes[dni] == null)
        {
            return null;
        }
        else
        {
            return dicIntegrantes[dni];
        }
    }


}