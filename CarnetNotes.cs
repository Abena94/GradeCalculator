using System.Collections.Generic;

namespace GradeCalculator
{
    public class CarnetNotes
    {
        public List<Notes> CaNotes { get; private set; } = new List<Notes>();

        //garder le constructeur par defaut

        public void AddNote(Notes c) { this.CaNotes.Add(c); }
       

      
        public Notes FindNote(int IDetudiant)
        {
           Notes cRes = null;
            foreach (Notes c in CaNotes)
                if (c.NumeroEtudiant == IDetudiant) { cRes = c; break; }
            return cRes;
        }

      

        public List<Notes> FindNotes(int IDetudiant)
        {
            List<Notes> cRes = new List<Notes>();
            foreach (Notes c in CaNotes)
                if (c.NumeroEtudiant == IDetudiant) { cRes.Add(c); }
            return cRes;
        }

        public void DeleteEtudiant(int IDetudiant)
        {
            this.CaNotes.Remove(this.FindNote(IDetudiant));
        }

        public string ToString()
        {
            string cRes = "";
            foreach (Notes c in CaNotes)
                cRes += c.ToString() + "\n";
            return cRes;
        }
    }
}
