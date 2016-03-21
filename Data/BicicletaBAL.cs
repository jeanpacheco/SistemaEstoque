using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Data
{
    public class BicicletaBAL
    {
        public List<Bicicleta> Listar()
        {
            List<Bicicleta> bicicletas = new List<Bicicleta>();
            BicicletasDataContext db = new BicicletasDataContext();
            var resultado = from b in db.ListBicicletas() select b;

            foreach (var b in resultado)
            {
                Bicicleta bicicleta = new Bicicleta();
                bicicleta.Id = b.Id;
                bicicleta.Modelo = b.Modelo;
                bicicleta.PrecoProposto = b.PrecoProposto;
                bicicleta.Quantidade = b.Quantidade;
            
                bicicletas.Add(bicicleta);
            }

            return bicicletas;
        }

        public void Adicionar(Bicicleta bicicleta)
        {
            BicicletasDataContext db = new BicicletasDataContext();
            db.AddBicicleta(bicicleta.Modelo, bicicleta.PrecoProposto, bicicleta.Quantidade);
        }

        public void Alterar(Bicicleta bicicleta)
        {
            BicicletasDataContext db = new BicicletasDataContext();
            db.UpdateBicicleta(bicicleta.Id, bicicleta.Modelo, bicicleta.PrecoProposto, bicicleta.Quantidade);
        }

        public void Excluir(Bicicleta bicicleta)
        {
            BicicletasDataContext db = new BicicletasDataContext();
            db.DeleteBicicleta(bicicleta.Id);
        }
    }
}
