using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Barra : EspacioConsumo
    {
        public Barra() : base()
        {
            this.tipo = "BARRA";
        }

        public Barra(EspacioConsumo espacio) : base(espacio)
        {
        }

        public override void AgregarConsumo(Consumision consumision, int cantidadPedida)
        {
            if (consumision.Tipo == Consumision.ECategoria.Bebida && consumision.Cantidad >= cantidadPedida)
            {
                if (this.Consumisiones == consumision)
                {
                    Consumision.SumarStock(consumision, this.Consumisiones, cantidadPedida);
                }
                else
                {
                    this.consumisiones.Add(new Consumision(consumision, cantidadPedida));
                }

                this.saldo += (consumision.PrecioUnitario * cantidadPedida);
            }
        }
    }
}
