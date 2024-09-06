namespace Cajero_automatico
{
    public class Cliente
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Genero { get; set; }
        public string Dni { get; set; }
        public string Contrasenia { get; set; }
        public bool Vigente { get; set; }

        public string NombreCompleto
        {
            get { return $"{Nombres} {ApellidoPaterno} {ApellidoMaterno}"; }
        }

    }
}
