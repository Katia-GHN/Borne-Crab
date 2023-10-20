using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borne.Methodes
{
    public class Maintenance
    {
        #region Attributs

        public static List<Maintenance> CollClasse = new List<Maintenance>();

        private List<Station> _lesStations;
        private List<Technicien> _lesTechniciens;
        private List<Visite> _lesVisite;

        #endregion

        #region Constructeurs

        public Maintenance(List<Station> lesStations, List<Technicien> lesTechniciens, List<Visite> lesVisite)
        {
            _lesStations = lesStations;
            _lesTechniciens = lesTechniciens;
            _lesVisite = lesVisite;

            Maintenance.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public List<Station> LesStations { get => _lesStations; set => _lesStations = value; }
        public List<Technicien> LesTechniciens { get => _lesTechniciens; set => _lesTechniciens = value; }
        public List<Visite> LesVisite { get => _lesVisite; set => _lesVisite = value; }


        #endregion

        #region Methodes

        #endregion
    }
}
