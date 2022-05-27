using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica.UC
{
    public partial class ResumenUC : UserControl
    {

        private List<PedidoDTO> listaPedidos;

        public ResumenUC(List<PedidoDTO> listaPedidos)
        {
            InitializeComponent();
            double gastos = 0.0;

            // TODO: Añade los campos que se piden al eje X e Y
            List<DateTime> x1 = new List<DateTime>();
            List<double> y1 = new List<double>();

            for(int i = 0; i < listaPedidos.Count; i++)
            {
                x1.Add(listaPedidos[i].FechaPedido);
                y1.Add(listaPedidos[i].PrecioEnvio);
                gastos += listaPedidos[i].PrecioEnvio;
            }

            chart_Pedidos.Series["Gastos Envio"].Points.DataBindXY(x1 , y1);

            // TODO: suma los gastos
            lab_SumaEnvio.Text = "Suma Gastos:" + gastos;
        }


    }
}
