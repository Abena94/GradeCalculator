using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        CarnetNotes Rel = new CarnetNotes();
        List<Notes> RelvesDeNotes = new List<Notes>();
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void CreerEtudiant_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant(Int32.Parse(EtNumeroEtudiant.Text), EtNom.Text, EtPrenom.Text);
            EtRes.Items.Add(et.ToString());
        }

        private void CreerCours_Click(object sender, EventArgs e)
        {
            Cours co = new Cours(Int32.Parse(CoNumeroCours.Text), Int32.Parse(CoCode.Text), CoTitre.Text);
            CoRes.Items.Add(co.ToString());
        }

        private void CreerNote_Click(object sender, EventArgs e)
        {
            Notes no = new Notes(Int32.Parse(NoNumeroEtudiant.Text), Int32.Parse(NoNumeroCours.Text), Int32.Parse(NoNotes.Text));
            NoRes.Items.Add(no.ToString());
            Rel.AddNote(no);
        }

        private void AfficherReleves_Click(object sender, EventArgs e)
        {
            //List<string> Res = new List<string>();
            string Res = "";
           RelvesDeNotes=Rel.FindNotes(Int32.Parse(NumeroEtudiant.Text));
           foreach(Notes p in RelvesDeNotes)
            {
                Res = "  *Numero Etudiant : " + p.NumeroEtudiant + " ||| " + "  *Numero Du Cours : " + p.NumeroCours + " ||| "
                   + "  *Note : " + p.Note + " ||| ";
                RelevesDeNotes.Items.Add(Res);
            }
            

        }

        private void SaveToTxtFile_Click(object sender, EventArgs e)
        {
            string Res = "";
            RelvesDeNotes = Rel.FindNotes(Int32.Parse(NumeroEtudiant.Text));
            foreach (Notes p in RelvesDeNotes)
            {
                if (p.NumeroEtudiant == Int32.Parse(EtNumeroEtudiant.Text))
                {
                    Res += p.ToString() ;
                }
            }
            SaveEvent(Res);

        }
        public void SaveEvent(string ch1)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save file?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (NoRes!=null)
                    {
                        saveFile(ch1);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }
        public void saveFile(string ch)
        {


            // Save File to .txt
            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(ch);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }
    }
}
