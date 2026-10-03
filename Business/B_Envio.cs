using Entities;

namespace Business
{
    public class B_Envio
    {
        private readonly EnvioFactory factory;
        
        public B_Envio(EnvioFactory facto)
        {
            factory = facto;
        }

        public E_Envio Procesar(string tipo, string nombre, decimal peso)
        {
            ValidarDatos(nombre, peso);
            return factory.Crear(tipo, nombre, peso);
        }

        private void ValidarDatos(string nombre, decimal peso)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }
            if(peso <= 0)
            {
                throw new ArgumentException("El peso no puede ser menor a 0");
            }
        }
    }
}
