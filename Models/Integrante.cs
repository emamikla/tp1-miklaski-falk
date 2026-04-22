namespace tp1_miklaski_falk.Models;

public class Integrante{
    private int dni;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;

    private List<string> familiares;
    private List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = familiares;
        this.intereses = intereses;
    }

    public int getDni()
    {
        return dni;
    }
    public string getNombre()
    {
        return nombre;
    }
    public DateTime getFechaNacimiento()
    {
        return fechaNacimiento;
    }
    public string getFoto()
    {
        return foto;
    }
    public List<string> getFamiliares()
    {
        return familiares;
    }
    public List<string> getIntereses()
    {
        return intereses;
    }
}