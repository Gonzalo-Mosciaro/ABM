namespace Clases
{
    public class Empleado
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private string sector;
        private double sueldo;

        public Empleado()
        {

        }

        public Empleado(int legajo, string nombre, string apellido, string sector, double sueldo)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sector = sector;
            this.sueldo = sueldo;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sector { get => sector; set => sector = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }


        public override string ToString()
        {
            return $"Nombre: {this.Nombre} - Apellido: {this.Apellido} - Sector: {this.Sector} - Sueldo: {this.Sueldo}";
        }
    }
}