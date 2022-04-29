using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa : EspacioConsumo
    {
        public Mesa () : base ()
        {
            this.tipo = "MESA";
        }

        public Mesa(EspacioConsumo espacio) : base (espacio)
        {
        }

        public override void AgregarConsumo(Consumision consumision, int cantidadPedida)
        {
            if (consumision.Cantidad >= cantidadPedida)
            {
                if (this.Consumisiones == consumision)
                {
                    Consumision.SumarStock(consumision, this.Consumisiones, cantidadPedida);
                    
                } else
                {
                    this.consumisiones.Add(new Consumision(consumision, cantidadPedida));
                }

                this.saldo += (consumision.PrecioUnitario * cantidadPedida);
            }
        }
    }
}
