using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaDatos_LorealPro;

namespace Loreal_Profesional
{
    public partial class Frm_Proveedores : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Proveedores()
        {
            InitializeComponent();
        }
        private void CargarPerfiles(int? Valor)
        {
            Cat_TipoPersona Perf = new Cat_TipoPersona() { IdTipoPersona = 0 };
            Perf.MtdSeleccionar();
            if (Perf.Exito)
            {
                CargarCombo(Perf.Datos, Valor);
            }
        }
        private void CargarCombo(DataTable Datos, int? Valor)
        {
            lkUpTipoPersona.Properties.DisplayMember = "Nombre";
            lkUpTipoPersona.Properties.ValueMember = "IdTipoPersona";
            lkUpTipoPersona.EditValue = Valor;
            lkUpTipoPersona.Properties.DataSource = Datos;
        }

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            CargarPerfiles(null);
        }
    }
}