using NumeroApi.Entities;

namespace NumeroApi.Repository
{
    public class NumeroRepository
    {
        public static List<Numero> BancoDeDados { get; set; } = new List<Numero>();

        public void Carga()
        {
            Numero numero1 = new Numero(1);
            Numero numero2 = new Numero(2);
            Numero numero3 = new Numero(3);
            Numero numero4 = new Numero(4);

            BancoDeDados.Add(numero1);
            BancoDeDados.Add(numero2);
            BancoDeDados.Add(numero3);
            BancoDeDados.Add(numero4);
        }
    }
}
