class Empleado
{
    private int categoria;
    private string nif;
    private string nombre;
    private int numHijos;
    private int numTrienios;

    public int Categoria { get { return categoria; } set { categoria = value; } }
    public string Nif { get { return nif; } set { nif = value; } }
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public int NumHijos { get { return numHijos; } set { numHijos = value; } }
    public int NumTrienios { get { return numTrienios; } set { numTrienios = value; } }

    public Empleado()
    {

    }

    public Empleado(int categoria, string nif, string nombre, int numHijos, int numTrienios)
    {
        this.categoria = categoria;
        this.nif = nif;
        this.nombre = nombre;
        this.numHijos = numHijos;
        this.numTrienios = numTrienios;
    }
}