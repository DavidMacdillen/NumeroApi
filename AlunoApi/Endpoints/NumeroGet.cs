using NumeroApi.Entities;
using NumeroApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace NumeroApi.Endpoints
{
    public class NumeroGet
    {
        public static string Template => "/numero/{id:int}";
        public static string[] Metodo => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Func => Acao;

        public static IResult Acao([FromRoute] int id)
        {
            NumeroRepository numeroCarga = new NumeroRepository();
            numeroCarga.Carga();

            Numero numeroEcontrado = NumeroRepository.BancoDeDados.FirstOrDefault(n => n.Id.Equals(id));

            if(numeroEcontrado != null)
            {
                return Results.Ok(numeroEcontrado);
            }
            else
            {
                return Results.NotFound();
            }
        }
    }
}
