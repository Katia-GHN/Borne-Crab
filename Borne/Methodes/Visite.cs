using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borne.Methodes
{
    public class Visite
    {
        #region Attributs

        public static List<Visite> CollClasse = new List<Visite>();

        private string _etat;
        private int _dureeTotale;
        private Station _laStation;
        private List<Borne> _lesBornes;

        #endregion

        #region Constructeurs

        public Visite(string etat, int dureeTotale, Station laStation, List<Borne> lesBornes)
        {
            _etat = etat;
            _dureeTotale = dureeTotale;
            _laStation = laStation;
            _lesBornes = lesBornes;

            Visite.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public string Etat { get => _etat; set => _etat = value; }
        public int DureeTotale { get => _dureeTotale; set => _dureeTotale = value; }
        public Station LaStation { get => _laStation; set => _laStation = value; }
        public List<Borne> LesBornes { get => _lesBornes; set => _lesBornes = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
