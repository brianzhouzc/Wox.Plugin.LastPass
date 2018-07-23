using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using LastPass;
using System.Threading;

namespace Wox.Plugin.LastPass
{
    public partial class Authenticate : MaterialForm
    {
        public Vault vault { get; set; }
        public TwoFactor twofactor { get; set; }

        private void Authenticate_Load(object sender, EventArgs e)
        {
            usernameTextField.Text = Properties.Settings.Default.username;
            passwordTextField.Text = Properties.Settings.Default.password;
            rememberUsernameCheckBox.Checked = Properties.Settings.Default.saveusername;
            rememberPasswordCheckBox.Checked = Properties.Settings.Default.savepassword;
        }

        public Authenticate()
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextField.Text != "" && passwordTextField.Text != "")
            {
                var id = "060b5cde8c3d11e89eb6529269fb1459";
                var description = "LastPass for Wox";
                try
                {
                    var thread = new Thread(
                       () =>
                       {
                           vault = Vault.Open(usernameTextField.Text,
                                            passwordTextField.Text,
                                            new ClientInfo(Platform.Desktop, id, description, false),
                                            new TwoFactorUI());
                       });

                    thread.Start();
                    thread.Join();

                    if (rememberUsernameCheckBox.Checked)
                        Properties.Settings.Default.username = usernameTextField.Text;
                    else
                        Properties.Settings.Default.username = "";

                    if (rememberPasswordCheckBox.Checked)
                        Properties.Settings.Default.password = passwordTextField.Text;
                    else
                        Properties.Settings.Default.password = "";

                    Properties.Settings.Default.saveusername = rememberUsernameCheckBox.Checked;
                    Properties.Settings.Default.savepassword = rememberPasswordCheckBox.Checked;
                    Properties.Settings.Default.Save();

                    
                    Main.form.twofactor.Close();
                    Main.form.twofactor.Dispose();

                    Main.form.Close();
                    Main.form.Dispose();
                    MessageBox.Show("You have successfully logged in.");
                }
                catch (Exception ex)
                {
                    vault = null;
                    MessageBox.Show("Something went wrong, maybe wrong username or password?", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("You are missing some information!", "You are missing some information!", MessageBoxButtons.OK);
            }
        }


        private class TwoFactorUI : Ui
        {
            public override string ProvideSecondFactorPassword(SecondFactorMethod method)
            {
                string code = "";
                var thread = new Thread(
                       () =>
                       {
                           Main.form.twofactor = new TwoFactor();
                           var result = Main.form.twofactor.ShowDialog();

                           if (result == DialogResult.OK)
                           {
                               code = Main.form.twofactor.authcode;
                           }
                           else
                           {
                               code = "";
                           }
                       });

                thread.Start();
                thread.Join();
                return code;
            }

            public override void AskToApproveOutOfBand(OutOfBandMethod method)
            {
                var thread = new Thread(
                    () =>
                    {
                        Main.form.twofactor = new TwoFactor();
                        Main.form.twofactor.showConfirmOnApp();
                        Main.form.twofactor.ShowDialog();
                    });
                thread.Start();
            }
        }
    }
}
