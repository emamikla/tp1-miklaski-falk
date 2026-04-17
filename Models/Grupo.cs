namespace tp1_miklaski_falk.Models;

public class Grupo
{
    private Dictionary<int, Integrante> integrantes;

    public Grupo()
    {
        integrantes = new Dictionary<int, Integrante>();
    }

    public void CargaDatosManual()
    {
        
    }
    public Dictionary<int, Integrante> devolverIntegrantes()
    {
        
    }

    public Integrante GetIntegrante(int dni)
    {
        if(dicAlumnos[dni] == null)
        {
            return null;
        }
        else
        {
            return dicAlumnos[dni];
        }
    }


}