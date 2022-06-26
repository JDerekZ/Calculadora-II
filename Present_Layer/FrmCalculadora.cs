using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic_Layer;

namespace Present_Layer
{

    //Enum para saber de cual operador se trata
    public enum Operaciones
    {
        Indefinida = 0,
        Suma = 1,
        Resta = 2,
        Multiplicacion = 3,
        Division = 4
    }


    public partial class FrmCalculadora : Form
    {
        public double num1 = 0;
        public double num2 = 0;
        Operaciones operador = Operaciones.Indefinida;//Empieza de esta forma y modifica su valor mas adelante
        public double resultadoTotal = 0;
        public bool calculoRealizado = false;

        //Instancia de nuestra capa Lógica
        Calcular iniciarCalculo = new Calcular();



        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        //Metodo reutilizable para generar los números
        private void PressNumber(string number)
        {
            calculoRealizado=true;

            if (tbxResult.Text == "0" && tbxResult.Text != null)
            {
                tbxResult.Text = number;
            }
            else
            {
                tbxResult.Text += number;
            }

        }
        
        //Números
        private void btnCero_Click(object sender, EventArgs e)
        {
            calculoRealizado=true;

            if (tbxResult.Text == "0")//Si lo que estaba ya era 0, entonces que no siga añadiendo(return), de lo contrario, pues que si pueda añadir 0's
            {
                return;
            }
            else
            {
                tbxResult.Text += "0";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            PressNumber("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            PressNumber("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            PressNumber("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            PressNumber("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            PressNumber("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            PressNumber("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            PressNumber("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            PressNumber("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            PressNumber("9");
        }
        //End Números


        //Para poder definir los operadores que vamos a utilizar y guardar lo asignado al primer número
        public void ObtenerOperador(string tipoDeOperador)
        {
            num1 = Convert.ToDouble(tbxResult.Text);
            LblHistorial.Text = tbxResult.Text + tipoDeOperador;
            tbxResult.Text = "0";
        }

        //Buttons Operacionales
        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Division;
            ObtenerOperador("÷");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Multiplicacion;
            ObtenerOperador("×");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Resta;
            ObtenerOperador("–");
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Suma;
            ObtenerOperador("+");
         }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (tbxResult.Text.Contains("."))
            {
                return;
            }
           
                tbxResult.Text += ".";
            
        }

        //Boton Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (num2==0 && calculoRealizado)
            {
                num2 = Convert.ToDouble(tbxResult.Text);
                LblHistorial.Text += num2 + "=";
                resultadoTotal = Calculo();
                num1=0;
                num2=0;
                calculoRealizado = false;
                tbxResult.Text = Convert.ToString(resultadoTotal);
            }
        }

        //Boton de Clear o Reset
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "0";
            LblHistorial.Text = "";
        }

        //Boton Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxResult.Text.Length > 1)
            {
                string NumActual = tbxResult.Text;
                //para eliminar elementos del número 1 a 1, y si llega a 1 automáticamente se volverá 0
                NumActual = NumActual.Substring(0, NumActual.Length - 1);

                if (NumActual.Length == 1 && NumActual.Contains("–"))//controlar las operaciones con negativos(que lñuego de una resta no se quede un negativo en pantalla y al querer operar de nuevo explote)
                {
                    tbxResult.Text = "0";
                }
                else
                {
                    tbxResult.Text = NumActual;
                }
            
            }
            else
            {
                tbxResult.Text = "0";
            }
        }


        //Función que sincroniza ambas capas
        private double Calculo()
        {

            resultadoTotal = 0;
            switch (operador)
            {
                case Operaciones.Suma:
                        resultadoTotal = iniciarCalculo.sumar(num1, num2);
                    break;

                case Operaciones.Resta:
                        resultadoTotal = iniciarCalculo.restar(num1, num2);
                    break;

                case Operaciones.Multiplicacion:
                        resultadoTotal = iniciarCalculo.multiplicar(num1, num2);
                    break;

                case Operaciones.Division:
                    if (num2 == 0)
                    {
                        LblHistorial.Text = "No se puede dividir entre 0 presione C";
                        //MessageBox.Show("No se puede dividir entre 0");
                        resultadoTotal=0;
                    }
                    else
                    {
                        resultadoTotal = iniciarCalculo.dividir(num1, num2);
                    }
                    break;
            }

            return resultadoTotal;

        }
        
    }
}
