namespace TP01MVC_FINAL.Models;

public class Integrante
{
    private int DNI;
    private string nombre; 
    private DateTime fechaNacimiento;
    private string foto;
    private List<string> familiares;
    private List<string> intereses;

    public Integrante (int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        this.DNI = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = familiares;
        this.intereses = intereses;
    }

    public int GetDni()
    {
        return this.DNI;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public string GetFoto()
    {
        return this.foto;
    }
}