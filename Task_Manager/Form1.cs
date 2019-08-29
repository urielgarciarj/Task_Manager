using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task_Manager
{
    public partial class Task_Manager : Form
    {
        public Task_Manager()
        { 
            InitializeComponent();
        }

        public static class GlobalData
        {
            public static string[] series = new string[10];
            public static int[] puntos = new int[10];
            public static string[] cpu = new string[10];
        }

        private void Task_Manager_Load(object sender, EventArgs e)
        {
            //Los vectores con los datos
            //string[] series = { "eduardo", "jorge", "chris", "pedro" };
            //int[] puntos = { 30, 10, 70, 120};

            //Cambiar la combinacion de colores
            chart1.Palette = ChartColorPalette.Berry;

            chart1.Titles.Add("Memoria");


            /*for(int i=0; i < series.Length; i++)
            {
                //Titulos
                Series serie = chart1.Series.Add(series[i]);
                //Cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);

            }*/

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            txtProceso.Text = GlobalData.series[i];
            txtMemoria.Text = GlobalData.puntos[i].ToString();
            txtCpu.Text = GlobalData.cpu[i];


            for (int j = 0; i < GlobalData.series.Length; j++)
            {
                //Titulos
                Series serie = chart1.Series.Add(GlobalData.series[j]);
                //Cantidades
                serie.Label = GlobalData.puntos[j].ToString();
                serie.Points.Add(GlobalData.puntos[j]);
                chart1.Update();
            }
            i++;
        }

        public void CargarGrafico()
        {
            chart1.Titles.Clear();

        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chart1_DoubleClick(object sender, EventArgs e)
        {
            chart1.DataBind();
            for(int i=0; i < GlobalData.series.Length; i++)
            {
                //Titulos
                Series serie = chart1.Series.Add(GlobalData.series[i]);
                //Cantidades
                serie.Label = GlobalData.puntos[i].ToString();
                serie.Points.Add(GlobalData.puntos[i]);
            }
        }
    }
}
