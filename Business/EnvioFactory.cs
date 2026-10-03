using Entities;

namespace Business
{
    public class EnvioFactory
    {
        public E_Envio Crear(string tipo, E_Envio env)
        {
            E_Envio envio;

            if(tipo == "estandar")
            {
                envio = new Estandar();
            }
            else if (tipo == "express")
            {
                envio = new Express();
            }
            else if (tipo == "mismodia")
            {
                envio = new MismoDia();
            }
            else
            {
                throw new ArgumentException("No existe ese tipo de envio");
            }

            envio.NombreDestinatario = env.NombreDestinatario;
            envio.Peso = env.Peso;

            return envio;
        }
    }
}
