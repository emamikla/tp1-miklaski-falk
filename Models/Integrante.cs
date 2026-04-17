namespace tp1_miklaski_falk.Models;

public class Integrante{
    private int dni;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;

    private List<string> familiares;
    private List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        familiares = new List<string>();
        intereses = new List<string>();
    }
}