namespace Entities
{
    public class E_Envio
    {
        public string NombreDestinatario { get; set; }

        public decimal Peso { get; set; }

        public virtual int EntregaDias
        {
            get { return 0; }
        }

        public virtual decimal CostoEnvio()
        {
            return 0m;
        }

        public virtual string ObtenerEnvio()
        {
            return "Invalido";
        }
    }

    public class Estandar : E_Envio
    {
        public override int EntregaDias => 5;

        public override decimal CostoEnvio()
        {
            return 30 + (8 * Peso);
        }

        public override string ObtenerEnvio()
        {
            return "Estandar";
        }
    }

    public class Express : E_Envio
    {

        public override int EntregaDias => 2;
        public override decimal CostoEnvio()
        {
            return 80 + (15 * Peso);
        }

        public override string ObtenerEnvio()
        {
            return "Express";
        }
    }

    public class MismoDia : E_Envio
    {
        public override int EntregaDias => 0;
        public override decimal CostoEnvio()
        {
            return 150 + (25 *  Peso);
        }

        public override string ObtenerEnvio()
        {
            return "Mismo Día";
        }
    }
}
