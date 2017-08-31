using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LaboratorioRepaso_1037214
{
    public partial class Form1 : Form
    {
        Dictionary<string, csCancion> PlayList = new Dictionary<string, csCancion>();

        csCancion nuevaCancion = null;
        List<csCancion> nuevaPlayList = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarPlaylist = new OpenFileDialog();
            string linea = "";
            string nombreCancion = "";
            string artistaCancion = "";
            double tiempoCancion = 0;



            if (buscarPlaylist.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    StreamReader Lector = new StreamReader(buscarPlaylist.FileName);

                    linea = Lector.ReadLine();

                    while (linea != null)
                    {
                        
                        String[] infoCancion = linea.Split('-');
                        nombreCancion = infoCancion[0];
                        artistaCancion = infoCancion[1];
                        tiempoCancion = Convert.ToDouble(infoCancion[2]);

                        nuevaCancion = new csCancion(nombreCancion, artistaCancion, tiempoCancion);

                        PlayList.Add(nombreCancion, nuevaCancion);
                        linea = Lector.ReadLine();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la operación. " + ex.Message);
                }
            }

            btn_Search.Enabled = true;
            tbx_searchsong.Enabled = true;
            btn_newPlaylist.Enabled = true;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string cancionBuscada = tbx_searchsong.Text;

            try
            { 
                if(PlayList.ContainsKey(cancionBuscada))
                {
                    csCancion cancion = PlayList[cancionBuscada];
                    MessageBox.Show("Nombre de la canción: " + cancion.Nombre + "\n" + "Autor: " + cancion.Artista + "\n" + "Dura: " + cancion.Tiempo.ToString() + " minutos");
                }
                else
                {
                    MessageBox.Show("No existe información para dicha canción");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación. " + ex.Message);
            }
        }

        private void btn_newPlaylist_Click(object sender, EventArgs e)
        {
            btn_AscName.Enabled = true;
            btn_AscTime.Enabled = true;
            btn_DescName.Enabled = true;
            btn_DescTime.Enabled = true;
            btn_Add.Enabled = true;
            btn_Playlist.Enabled = false;
            btn_Search.Enabled = false;
            tbx_searchsong.Enabled = false;
            tbx_addAutor.Enabled = true;
            tbx_addName.Enabled = true;
            tbx_addLenght.Enabled = true;
            btn_Create.Enabled = true;

            nuevaPlayList = new List<csCancion>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog guardar = new SaveFileDialog();

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                if (guardar.FileName != null)
                {
                    StreamWriter nuevoArchivo = new StreamWriter(guardar.FileName);

                    foreach (csCancion item in nuevaPlayList)
                    {
                        nuevoArchivo.WriteLine(item.Nombre + "-" + item.Artista + "-" + Convert.ToString(item.Tiempo));
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre");
                }
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(tbx_addName.Text == "" && tbx_addAutor.Text == "" && tbx_addLenght.Text == "")
            {
                MessageBox.Show("Llene al menos un campo");
            }
            else
            {
                csCancion nuevaCancion = new csCancion(tbx_addName.Text, tbx_addAutor.Text, Convert.ToDouble(tbx_addLenght.Text));
                nuevaPlayList.Add(nuevaCancion);
               
            }
        }

        private void btn_AscName_Click(object sender, EventArgs e)
        {
            foreach (csCancion item in nuevaPlayList)
            {
                item.criterio = cOrdenar.NOMBRE;
                item.criterioD = cOrdenarD.ASC;
            }

            nuevaPlayList.Sort();
        }

        private void btn_DescName_Click(object sender, EventArgs e)
        {
            foreach (csCancion item in nuevaPlayList)
            {
                item.criterio = cOrdenar.NOMBRE;
                item.criterioD = cOrdenarD.DESC;
            }

            nuevaPlayList.Sort();
        }

        private void btn_AscTime_Click(object sender, EventArgs e)
        {
            foreach (csCancion item in nuevaPlayList)
            {
                item.criterio = cOrdenar.TIEMPO;
                item.criterioD = cOrdenarD.ASC;
            }

            nuevaPlayList.Sort();
        }

        private void btn_DescTime_Click(object sender, EventArgs e)
        {
            foreach (csCancion item in nuevaPlayList)
            {
                item.criterio = cOrdenar.TIEMPO;
                item.criterioD = cOrdenarD.DESC;
            }

            nuevaPlayList.Sort();
        }
    }
}
