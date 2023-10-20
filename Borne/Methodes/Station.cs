using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borne.Methodes
{
    public class Station
    {
        #region Attributs


        public static List<Station> CollClasse = new List<Station>();

        private int _idStation;
        private string _libelle;
        private List<Borne> _bornes;


        #endregion

        #region Constructeurs
        public Station(int idStation, string libelle, List<Borne> bornes)
        {
            _idStation = idStation;
            _libelle = libelle;
            _bornes = bornes;

            Station.CollClasse.Add(this);
        }
        #endregion

        #region Getters/Setters

        public int IdStation { get => _idStation; set => _idStation = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public List<Borne> Bornes { get => _bornes; set => _bornes = value; }

        #endregion

        #region Methodes



        #endregion
    }
}
