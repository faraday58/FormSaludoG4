using System;
using System.Drawing;
using System.Windows.Forms;
namespace FormSaludoG4
{
    partial class FormSaludo:Form
    {
        #region Atributos o Campos
        private Label etIntroNombre;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Button btnLimpiar;
        #endregion

        
        private void IniciarComponentes()
        {

            this.Size = new Size(400, 300);
            this.Text = "FormSaludo";
            this.StartPosition = FormStartPosition.CenterScreen;

            etIntroNombre = new Label();
            etIntroNombre.Location = new Point(100, 50);
            etIntroNombre.Size = new Size(200,50);
            etIntroNombre.Text = "Introduce tu nombre";



            this.Controls.Add(etIntroNombre);

        }

    }
}
