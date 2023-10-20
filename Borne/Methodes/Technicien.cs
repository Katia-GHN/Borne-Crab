using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borne.Methodes
{
    public class Technicien
    {
        #region Attributs

        public static List<Technicien> CollClasse = new List<Technicien>();

        private int _Matricule;
        private string _Nom;
        private string _Prenom;
        private List<Visite> _lesVisites;

        #endregion

        #region Constructeurs

        public Technicien(int matricule, string nom, string prenom, List<Visite> lesVisites)
        {
            _Matricule = matricule;
            _Nom = nom;
            _Prenom = prenom;
            _lesVisites = lesVisites;
            
            Technicien.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public int Matricule { get => _Matricule; set => _Matricule = value; }
        public string Nom { get => _Nom; set => _Nom = value; }
        public string Prenom { get => _Prenom; set => _Prenom = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
