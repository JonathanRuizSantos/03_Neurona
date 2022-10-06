using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Neurona
{
    public partial class Form1 : Form
    {
        int entradasColumnasX;
        double filas; //Filas 2^n
        double umbral;
        double aux_ceros;
        double aux_ceros2;
        int avanzaCelda;
        string valor2;
        string valor1;
        double valor1_doble = 0;
        double valor2_doble = 0;
        double salidaY = 0;
        int ultimoRenglon;

        public Form1()
        {
            InitializeComponent();
        }

        private void bTGeneraTabla_Click(object sender, EventArgs e)
        {
            Limpiar();
            Entrada_Datos();


            try
            {
                TablaPesos(entradasColumnasX);
                TablaDeVerdad(entradasColumnasX, filas);

                // Ciclo para generar todas las combinaciones posibles con 1's y 0's
                // En la tabla de verdad
                for (int i = 0; i < filas; i++)
                {
                    // Ciclo que pone 0 en el Datagrid de la tabla de verad
                    for (int j = 0; j < aux_ceros; j++)
                    {
                        dGVTablaVerdad.Rows[i].Cells[avanzaCelda].Value = "0";
                        i++;
                    }

                    // Ciclo que pone 1 en el Datagrid de la tabla de verdad
                    for (int b = 0; b < aux_ceros; b++)
                    {

                        dGVTablaVerdad.Rows[i].Cells[avanzaCelda].Value = "1";
                        i++;
                    }

                    i--;

                    if (i == filas - 1 && avanzaCelda != 0)
                    {
                        i = -1;
                        avanzaCelda--;
                        aux_ceros = Math.Pow(2, aux_ceros2);
                        aux_ceros2++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            } 
        }

        private void bTNeurona_Click(object sender, EventArgs e)
        {
            Salidas_Y();
        }

        private void btLimpia_Click(object sender, EventArgs e)
        {
            Limpiar();
            tBEnt.Clear();
            tBUmbral.Clear();
        }

        // --------------------------------------------------------------- FUNCIONES
        public void Entrada_Datos()
        {  
            entradasColumnasX = int.Parse(tBEnt.Text);
            filas = Math.Pow(2, entradasColumnasX); // Numero de filas
            aux_ceros = 1;
            aux_ceros2 = 1;
            avanzaCelda = entradasColumnasX - 1;
        }

        public void TablaPesos(int n1)
        {
            dGVPesos.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Pesos" });

            for (int i = n1; i > 0; i--)
            {
                dGVPesos.Rows.Add();
            }
        }

        public void TablaDeVerdad(double n, double filas)
        {
            for (int i = 0; i < n; i++)
            {
                dGVTablaVerdad.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "X" + (i + 1).ToString() });
            }

            for (int j = 1; j < filas; j++)
            {
                j = dGVTablaVerdad.Rows.Add(new DataGridViewRow());
            }

            dGVTablaVerdad.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Y" });
        }

        public void Limpiar()
        {
            dGVPesos.Rows.Clear();
            dGVPesos.Columns.Clear();
            dGVTablaVerdad.Rows.Clear();
            dGVTablaVerdad.Columns.Clear();
        } 

        public void Salidas_Y()
        {
            umbral = double.Parse(tBUmbral.Text);
            ultimoRenglon = entradasColumnasX;

            // Este ciclo recorre las filas
            for (int a = 0; a < filas; a++)
            {
                // Este ciclo recorre las columnas
                for (int i = 0; i < entradasColumnasX; i++)
                {
                    // Obtencion de los valores del datagrid de Pesos
                    valor1 = (string)dGVPesos.Rows[i].Cells[0].Value;
                    valor2 = (string)dGVTablaVerdad.Rows[a].Cells[i].Value;
                    valor1_doble = double.Parse(valor1);
                    valor2_doble = double.Parse(valor2);

                    // Obtencion del valor de la suma por renglon
                    salidaY = salidaY + (valor1_doble * valor2_doble);

                }

                // Evalua el estado del umbral
                if (salidaY > umbral)
                {
                    dGVTablaVerdad.Rows[a].Cells[ultimoRenglon].Value = "1";
                    salidaY = 0;
                }
                else
                {
                    dGVTablaVerdad.Rows[a].Cells[ultimoRenglon].Value = "0";
                    salidaY = 0;
                }
            }
        }
    }
}