using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AulaAPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triangulo":
                    SelecionarTriangulo();
                    break;
                case "Retângulo":
                    SelecionarRetangulo();
                    break;
                case "Circunferência":
                    SelecionarCircunferencia();
                    break;
                default:
                    break;
            }
            if (cmbForma.SelectedItem.ToString().Equals("Triângulo"))
            {
                cmbTriangulo.Visible = true;
            }
            else
            {
                cmbTriangulo.Visible = false;
            }
        }
        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbTriangulo.Text)
            {
                case "Equilátero":
                    TriEquilatero();
                    break;
                case "Isósceles":
                    TriIsosceles();
                    break;
                case "Reto":
                    TriReto();
                    break;
            }
            
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            //cmbTriangulo.Visible = false;
        }


        private void SelecionarTriangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            //cmbTriangulo.Visible = true;
           
        }
        private void SelecionarRetangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            cmbTriangulo.Visible = false;
        }
        private void SelecionarCircunferencia()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(true);
            //cmbTriangulo.Visible = false;
        }
        private void TriEquilatero()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
        }
        private void TriReto()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }
        private void TriIsosceles()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }
        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }


        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Quadrado"))//verifica se a forma selecionada é quadrado
            {
                FormaGeometrica quadrado = new Quadrado(){//cria um novo objeto da classe quadrado 
                    Lado = Convert.ToDouble(txtBase.Text) //iguala "Lado" ao valor que for escrito no txtBase
                };
                cmbObjetos.Items.Add(quadrado);
            } 
            else if (cmbForma.Text.Equals("Circunferência"))
            {
                FormaGeometrica circulo = new Circunferencia()
                {
                    Raio = Convert.ToDouble(txtRaio.Text)   
                };
                cmbObjetos.Items.Add(circulo);
            }
            else if (cmbForma.Text.Equals("Retângulo"))
            {
                FormaGeometrica retang = new Retangulo()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text)
                
                };
                cmbObjetos.Items.Add(retang);
            }
            else if (cmbTriangulo.Text.Equals("Equilátero"))
            {
                FormaGeometrica triEquila = new TrianguloEquilatero()
                {
                    Base = Convert.ToDouble(txtBase.Text)
                }; 
                cmbObjetos.Items.Add (triEquila);
            }
            else if (cmbTriangulo.Text.Equals("Isósceles"))
            {
                FormaGeometrica triIsosceles = new TrianguloIsosceles()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text)
                };
                cmbObjetos.Items.Add(triIsosceles);
                
            }
            else if (cmbTriangulo.Text.Equals("Reto"))
            {
                FormaGeometrica triReto = new TrianguloReto()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text)
                };
                cmbObjetos.Items.Add(triReto);
            }
          
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;//tenta converter o item selecionado em um objeto da classe formasGeometricas
            //obj significa o objeto que foi selecionado no comboBox
            txtArea.Text = obj.CalcularArea().ToString();//faz calcular a área (chama o método calcular área e exibe o result na txtArea)
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();//faz calcular o perímetro(chama o método calcular perímetro e bota o result no txtPerimetro)
        }

    }
}
