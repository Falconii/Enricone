using AppSped.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace AppSped
{
    public partial class FormArquivos : Form
    {

        List<Historico> lsRegistros = new List<Historico>();

        public ToolStripMenuItem menu { get; internal set; }

        public FormArquivos()
        {
            InitializeComponent();
        }

        private void FormArquivos_Load(object sender, EventArgs e)
        {

        }

        private void FormArquivos_Activated(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void FormArquivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Enabled = true;
        }

        private void ConfiguraDataHistorico()
        {
            
            dataHistorico.AutoResizeColumns();
            dataHistorico.Columns[00].HeaderText = "COD PACIENTE";
            dataHistorico.Columns[00].Width = 100;
            dataHistorico.Columns[00].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataHistorico.Columns[01].HeaderText = "DATA CONSULTA";
            dataHistorico.Columns[01].Width = 100;
            dataHistorico.Columns[02].HeaderText = "ATRIBUTO";
            dataHistorico.Columns[02].Width = 400;
            dataHistorico.Columns[03].HeaderText = "OBSERVAÇÃO";
            dataHistorico.Columns[03].Width = 400;
            dataHistorico.Columns[03].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataHistorico.Columns[04].HeaderText = "COD MEDICO";
            dataHistorico.Columns[04].Width = 100;
            dataHistorico.Columns[05].HeaderText = "HISTORICO";
            dataHistorico.Columns[05].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataHistorico.Columns[05].Width = 400;
            //dataHistorico.Columns[05].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataHistorico.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataHistorico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataHistorico.BorderStyle = BorderStyle.Fixed3D;
            dataHistorico.EnableHeadersVisualStyles = false;
            dataHistorico.ShowEditingIcon = false;

        }

        private void LoadDataHistorico()
        {
            var bindingList = new BindingList<Historico>(lsRegistros);
            var source = new BindingSource(bindingList, null);
            dataHistorico.DataSource = source;
            ConfiguraDataHistorico();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leArquivo()
        {
            int ContadorLinhas    = 0;
            bool RegistroStatus = false;
            Tags tag;
            string line = "";
            string conteudo = "";
            string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
            string replacement = "";
            Historico Registro = new Historico();
            lsRegistros.Clear();

            // Read the file and display it line by line.  
            StreamReader file = new StreamReader(@"C:\Arquivos Enricone\HISTORIC.xml");
            while ( (line = file.ReadLine()) != null)
            {   if ((ContadorLinhas == 0) && (line != "<?xml version=\"1.0\" standalone=\"yes\" ?>"))
                {
                    break;
                }
                if ((ContadorLinhas == 1) && (line != "<Doctors>"))
                {
                    break;
                }
                if (line == "</Doctors>")
                {
                    Console.WriteLine($"Fim Do Arquivo!!");

                    break;
                }
                if (ContadorLinhas > 1 && (line != "/Doctors")) {

                    if (line == "<HISTORIC>")
                    {
                        RegistroStatus = true;

                        Registro = new Historico();

                        continue;

                    }

                    if (line == "</HISTORIC>")
                    {
                        RegistroStatus = false;

                        lsRegistros.Add(Registro);

                        continue;
                    }

                    if (RegistroStatus)
                    {
                        conteudo += line;

                        tag = conteudo.GetTag();

                        if (tag.EndTag == "")
                        {
                            continue;
                        }
                        conteudo = conteudo.Replace(tag.Tag, "").Replace(tag.EndTag, "");
                        Console.WriteLine($"{line}");
                        Console.WriteLine($"Tag: {tag.Tag} EndTag: {tag.EndTag}");
                        Console.WriteLine($"Conteudo: {conteudo} ");

                        Regex rgx = new Regex(pattern);
                        conteudo = rgx.Replace(conteudo, replacement);
                        Console.WriteLine($"Result => {conteudo}");

                        if (tag.Tag.ToUpper() == "<CODPACIENTE>")
                        {
                            Registro.CodPaciente = conteudo;
                        }
                        if (tag.Tag.ToUpper() == "<DATACONSULTA>")
                        {
                            Registro.DataConsulta = conteudo.StringToDate();
                        }
                        if (tag.Tag.ToUpper() == "<ATRIBUTO>")
                        {
                            Registro.Atributo = conteudo;
                        }
                        if (tag.Tag.ToUpper() == "<OBSERVACAO>")
                        {
                            Registro.Observacao = conteudo;
                        }
                        if (tag.Tag.ToUpper() == "<CODMEDICO>")
                        {
                            Registro.CodMedico = conteudo;
                        }
                        if (tag.Tag.ToUpper() == "<HISTORICO>")
                        {
                            Registro.Hist = conteudo;
                        }
                        conteudo = "";
                    }

                    if (lsRegistros.Count() > 3000)
                    {
                        break;
                    }
                }
               

                ContadorLinhas++;  
            }

            file.Close();
        }

        private void tbOk_Click(object sender, EventArgs e)
        {

            leArquivo();

            LoadDataHistorico();


        }

        private void leXML()
        {
            string arquivo = @"D:\hist\HISTORIC.xml";

            using (XmlReader xmlHistorico = XmlReader.Create(arquivo))
            {
                while (xmlHistorico.Read())
                {
                    if (xmlHistorico.NodeType == XmlNodeType.Element && xmlHistorico.Name == "HISTORIC")
                    {
                        Console.WriteLine("Inicio");
                    }
                    if (xmlHistorico.NodeType == XmlNodeType.EndElement && xmlHistorico.Name == "HISTORIC")
                    {
                        Console.WriteLine("Fim");
                    }

                }
            }

        }
    }
}
