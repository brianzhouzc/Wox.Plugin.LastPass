using LastPass;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wox.Plugin.LastPass
{
    public partial class TwoFactor : MaterialForm
    {
        public string authcode { get; set; }

        public TwoFactor()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        public void showConfirmOnApp()
        {
            materialLabel2.Visible = true;
            materialFlatButton1.Visible = false;
            materialLabel1.Visible = false;
            materialSingleLineTextField1.Visible = false;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            authcode = materialSingleLineTextField1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
