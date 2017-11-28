using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosDeTransporte
{

    public partial class FormGenerarTabla : Form
    {

        public FormGenerarTabla(int numeroOrigenes, int numeroDestinos)
        {
            InitializeComponent();
            int numeroFilas = numeroOrigenes + 1;
            int numeroColumnas = numeroDestinos + 1;
            crearTabla(numeroFilas, numeroColumnas);
            Limpiar();
        }

        private void crearTabla(int numeroFilas, int numeroColumnas)
        {
            Tabla.RowCount = numeroFilas;
            Tabla.ColumnCount = numeroColumnas;
            int j = 0, i = 0;
            //Añade Título a las Filas de la Tabla
            while (i < Tabla.RowCount)
            { 
                Tabla.Rows[i].HeaderCell.Value = "ORIGEN" + (i + 1).ToString();
                i++;
            }
            Tabla.RowHeadersWidth = 95;
            Tabla.Rows[i - 1].HeaderCell.Value = "DEMANDA";

            //Añade Título a las Columnas de la Tabla
            while (j < Tabla.ColumnCount)
            {

                Tabla.Columns[j].Width = 80;
                Tabla.Columns[j].HeaderText = "DESTINO" + (j + 1).ToString();
                j++;
            }
            Tabla.Columns[j - 1].Width = 60;
            Tabla.Columns[j - 1].HeaderText = "OFERTA";
        }

        private bool validarEntradas()
        {
            bool matrizCompleta = true;
            bool LetraNoPresente = true;
            float valorCelda;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                for (int j = 0; j < Tabla.ColumnCount; j++)
                {
                    if (Tabla.Rows[i].Cells[j].Value == null)
                    {
                        matrizCompleta = false;
                        break;
                    } else if (!float.TryParse(Tabla.Rows[i].Cells[j].Value.ToString(), out valorCelda))
                    {
                        LetraNoPresente = false;
                        break;
                    }
                }
            }
            if (!matrizCompleta) {
                MessageBox.Show("Todos los costos deben estar ingresados!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!LetraNoPresente)
            {
                MessageBox.Show("Debe ingresar solo datos numéricos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (matrizCompleta && LetraNoPresente);
        }

        private bool verificarEquilibrio(List<float> listaOfertas, List<float> listaDemandas)
        {
            float totalOfertas = 0;
            float totalDemandas = 0;
            foreach (float n in listaOfertas)
            {
                totalOfertas += n;
            }
            foreach (float n in listaDemandas)
            {
                totalDemandas += n;
            }
            if (totalOfertas==totalDemandas)
            {
                return true;
            }
            return false;
        }

        private void Limpiar()
        {
            labeltotalAsignaciones.Text = "";
            labelCostoTotal.Text = "";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                for (int j = 0; j < Tabla.ColumnCount; j++)
                {
                    Tabla.Rows[i].Cells[j].Value = null; //Limpiar Todas las Celdas
                }
            }
        }

        private void calcularENO()
        {
            //Organizando datos obtenidos de la Tabla
            float[,] matrizCostos = new float[Tabla.RowCount - 1, Tabla.ColumnCount - 1];
            float[,] matrizFlujos = new float[Tabla.RowCount - 1, Tabla.ColumnCount - 1];
            List<float> listaOfertas = new List<float>();
            List<float> listaDemandas = new List<float>();
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                for (int j = 0; j < Tabla.ColumnCount; j++)
                {
                    float valor = float.Parse(Tabla.Rows[i].Cells[j].Value.ToString());
                    if (i < Tabla.RowCount - 1 && j < Tabla.ColumnCount - 1)
                    {
                        matrizCostos[i, j] = valor;
                    }
                    if (i == (Tabla.RowCount - 1))
                    {
                        listaDemandas.Add(valor);
                    }
                    if (j == (Tabla.ColumnCount - 1))
                    {
                        listaOfertas.Add(valor);
                    }
                }
            }
            listaOfertas.RemoveAt(listaOfertas.Count - 1);
            listaDemandas.RemoveAt(listaDemandas.Count - 1);
            if(!(verificarEquilibrio(listaOfertas, listaDemandas)))
            {
                MessageBox.Show("Los totales de demandas y ofertas no están balanceadas!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Aplicando Algoritmo de Método ENO
            int indiceOfertas = 0;
            int indiceDemandas = 0;
            int a = 0, b = 0;
            while (a < matrizFlujos.GetLength(0))
            {
                while (b < matrizFlujos.GetLength(1))
                {
                    if (listaOfertas[indiceOfertas] == listaDemandas[indiceDemandas])
                    {
                        Random aleatorio = new Random();
                        matrizFlujos[a, b] = aleatorio.Next(2)==1 ? listaOfertas[indiceOfertas] : listaDemandas[indiceDemandas];
                    }
                    else if(listaOfertas[indiceOfertas] < listaDemandas[indiceDemandas])
                    {
                        matrizFlujos[a, b] = listaOfertas[indiceOfertas];
                    }
                    else
                    {
                        matrizFlujos[a, b] = listaDemandas[indiceDemandas];
                    }

                    listaOfertas[indiceOfertas] -= matrizFlujos[a, b];
                    listaDemandas[indiceDemandas] -= matrizFlujos[a, b];
                    if (listaOfertas[indiceOfertas]==0)
                    {
                        indiceOfertas++;
                        a++;
                        break;
                    }
                    else if(listaDemandas[indiceDemandas] == 0)
                    {
                        indiceDemandas++;
                        b++;
                    }
                }
            }
            mostrarResultado(matrizCostos, matrizFlujos);
        }


        private int[,] obtenerPosicionCostoMenor(float[,] matrizCostos, List<int> listaIndicesFilas, List<int> listaIndicesColumnas)
        {
            int[,] posicionCostoMenor = new int[1, 2];
            float costoMenor = matrizCostos[listaIndicesFilas[0], listaIndicesColumnas[0]];
            for (int indiceFila=0; indiceFila<listaIndicesFilas.Count; indiceFila++)
            {
                for (int indiceColumna=0; indiceColumna<listaIndicesColumnas.Count; indiceColumna++)
                {
                    if (matrizCostos[listaIndicesFilas[indiceFila], listaIndicesColumnas[indiceColumna]] <= costoMenor)
                    {
                        costoMenor = matrizCostos[listaIndicesFilas[indiceFila], listaIndicesColumnas[indiceColumna]];
                        posicionCostoMenor[0, 0] = listaIndicesFilas[indiceFila];
                        posicionCostoMenor[0, 1] = listaIndicesColumnas[indiceColumna];
                    }
                }
            }
            return posicionCostoMenor;
        }

        private void calcularCostoMinimo()
        {
            #region datosorganizados
            //Organizando datos obtenidos de la Tabla
            float[,] matrizCostos = new float[Tabla.RowCount - 1, Tabla.ColumnCount - 1];
            float[,] matrizFlujos = new float[Tabla.RowCount - 1, Tabla.ColumnCount - 1];
            List<float> listaOfertas = new List<float>();
            List<float> listaDemandas = new List<float>();
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                for (int j = 0; j < Tabla.ColumnCount; j++)
                {
                    float valor = float.Parse(Tabla.Rows[i].Cells[j].Value.ToString());
                    if (i < Tabla.RowCount - 1 && j < Tabla.ColumnCount - 1)
                    {
                        matrizCostos[i, j] = valor;
                    }
                    if (i == (Tabla.RowCount - 1))
                    {
                        listaDemandas.Add(valor);
                    }
                    if (j == (Tabla.ColumnCount - 1))
                    {
                        listaOfertas.Add(valor);
                    }
                }
            }
            listaOfertas.RemoveAt(listaOfertas.Count - 1);
            listaDemandas.RemoveAt(listaDemandas.Count - 1);
            if (!(verificarEquilibrio(listaOfertas, listaDemandas)))
            {
                MessageBox.Show("Los totales de demandas y ofertas no están equilibradas!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion datosorganizados

            //Aplicando Algoritmo de Método Costo Mínimo
            List<int> listaIndicesFilas = new List<int>();
            List<int> listaIndicesColumnas = new List<int>();
            int[,] posicionCostoMenor = new int[1, 2];
            for (int fila=0; fila<matrizCostos.GetLength(0); fila++)
            {
                listaIndicesFilas.Add(fila);
            }
            for (int columna = 0; columna < matrizCostos.GetLength(1); columna++)
            {
                listaIndicesColumnas.Add(columna);
            }

            posicionCostoMenor = obtenerPosicionCostoMenor(matrizCostos, listaIndicesFilas, listaIndicesColumnas);
            while (listaIndicesFilas.Count>0 && listaIndicesColumnas.Count>0)
            {
                posicionCostoMenor = obtenerPosicionCostoMenor(matrizCostos, listaIndicesFilas, listaIndicesColumnas);
                int a = posicionCostoMenor[0, 0];
                int b = posicionCostoMenor[0, 1];
                if (listaOfertas[a] == listaDemandas[b])
                {
                    Random aleatorio = new Random();
                    matrizFlujos[a, b] = aleatorio.Next(2) == 1 ? listaOfertas[a] : listaDemandas[b];
                }
                else if (listaOfertas[a] < listaDemandas[b])
                {
                    matrizFlujos[a, b] = listaOfertas[a];
                }
                else
                {
                    matrizFlujos[a, b] = listaDemandas[b];
                }

                listaOfertas[a] -= matrizFlujos[a, b];
                listaDemandas[b] -= matrizFlujos[a, b];
                if (listaOfertas[a] == 0)
                {
                    listaIndicesFilas.Remove(a);
                }
                else if (listaDemandas[b] == 0)
                {
                    listaIndicesColumnas.Remove(b);
                }
            }
            mostrarResultado(matrizCostos, matrizFlujos);
        }

        void mostrarResultado(float[,] matrizCostos, float[,] matrizFlujos)
        {
            string sumatoria = "";
            float costoTotal = 0;
            int totalAsignaciones = 0;
            for (int i = 0; i < matrizFlujos.GetLength(0); i++)
            {
                for (int j = 0; j < matrizFlujos.GetLength(1); j++)
                {
                    if (matrizFlujos[i,j]!=0)
                    {
                        Tabla.Rows[i].Cells[j].Value = matrizCostos[i, j].ToString() + "(" + matrizFlujos[i, j].ToString() + ")";
                        sumatoria += matrizCostos[i, j].ToString() + "(" + matrizFlujos[i, j].ToString() + ") + ";
                        costoTotal += matrizCostos[i, j] * matrizFlujos[i, j];
                        totalAsignaciones++;
                    }
                }
            }
            sumatoria = sumatoria.Remove(sumatoria.Length-2,2);
            labelCostoTotal.Text = sumatoria + "= " + costoTotal.ToString();
            labeltotalAsignaciones.Text = totalAsignaciones.ToString() + " asignaciones";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOptimizar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                if (radioCM.Checked)
                {
                    calcularCostoMinimo();
                }
                else if (radioENO.Checked)
                {
                    calcularENO();
                }
            }
        }

        private void radioENO_CheckedChanged(object sender, EventArgs e)
        {
            labeltotalAsignaciones.Text = "";
            labelCostoTotal.Text = "";
        }

        private void radioCM_CheckedChanged(object sender, EventArgs e)
        {
            labeltotalAsignaciones.Text = "";
            labelCostoTotal.Text = "";
        }

        private void labelCostoTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

