using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _NET_Senac_Forms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());
        }
        
            public class Formulario : Form{
                Label label_id;
                Label label_senha;
                TextBox textBox_id;
                TextBox textBox_senha;
                Button btn_Confirmar;
                Button btn_Cancelar;
                public Formulario(){
                    this.Text = "Meu formulário";
                    
                    label_id = new Label();
                    label_id.Text = "ID:";
                    label_id.Location = new Point(20,5);

                    textBox_id = new TextBox();
                    textBox_id.Size = new Size(155,18);
                    textBox_id.Location = new Point(20,28);

                    label_senha = new Label();
                    label_senha.Text = "Senha:";
                    label_senha.Location = new Point(20,60);

                    textBox_senha = new TextBox();
                    textBox_senha.Size = new Size(155,18);
                    textBox_senha.Location = new Point(20,83);

                    btn_Confirmar = new Button();
                    btn_Confirmar.Text = "Entrar";
                    btn_Confirmar.Location = new Point(20,113);

                    btn_Cancelar = new Button();
                    btn_Cancelar.Text = "Cancelar";
                    btn_Cancelar.Location = new Point(100,113);

                    this.Controls.Add(label_id);
                    this.Controls.Add(label_senha);
                    this.Controls.Add(textBox_id);
                    this.Controls.Add(textBox_senha);
                    this.Controls.Add(btn_Confirmar);
                    this.Controls.Add(btn_Cancelar);
                    
                    //Propriedades da janela
                    this.Size = new Size(220,200);
                    this.MaximizeBox = false;
                    this.MinimizeBox = false;
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.StartPosition = FormStartPosition.CenterScreen;

                    
                }
            }
    }
}
