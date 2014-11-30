using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBdb.EpubReader;
using System.IO;

namespace ePubApp
{
    public partial class ListarItems : Form
    {
        private string[] epubFiles;
        public ListarItems()
        {
            InitializeComponent();
            epubFiles = Directory.GetFiles("D:\\Escola\\1ºSemestre\\IS\\Projecto_IS\\Projecto_IS\\bin\\Debug", "*.epub").
                Select(path => Path.GetFileName(path)).ToArray();
            listBox1.DataSource = epubFiles.ToList();
        }

    }
}

