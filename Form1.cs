using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos_Json
{
    public partial class Form1 : Form
    {
        List<int> notasTemporales = new List<int>();
        List<NotasAlumno> listaNotas = new List<NotasAlumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(textBoxNota.Text);
            notasTemporales.Add(nota);
        }
        private void Grabar()
        {
            string json = JsonConvert.SerializeObject(listaNotas);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }
        private void buttonGuadar_Click(object sender, EventArgs e)
        {
            //Guardar notas del alumno
            NotasAlumno notasAlumno = new NotasAlumno();
            notasAlumno.NombreAlumno = textBoxNombre.Text;
            notasAlumno.Notas = notasTemporales.GetRange(0,notasTemporales.Count);
            //guardar a ese almno en el listado de notas de alumnos
            listaNotas.Add(notasAlumno);   
            Grabar();
            notasTemporales.Clear();
        }
    }
}
