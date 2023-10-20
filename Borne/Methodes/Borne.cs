using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borne.Methodes
{
    public class Borne
    {
        #region Attributs

        public static List<Borne> CollClasse = new List<Borne>();

        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnite;
        private TypeBorne _leType;   // Fait appel à la classe TypeBorne 

        #endregion

        #region Constructeurs

        public Borne(int idBorne, DateTime dateDerniereRevision, int indiceCompteurUnite, TypeBorne leType)
        {
            _idBorne = idBorne;
            _dateDerniereRevision = dateDerniereRevision;
            _indiceCompteurUnite = indiceCompteurUnite;
            _leType = leType;

            Borne.CollClasse.Add(this);
        }


        #endregion

        #region Getters/Setters
        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnite { get => _indiceCompteurUnite; set => _indiceCompteurUnite = value; }
        public TypeBorne LeType { get => _leType; set => _leType = value; }

        #endregion

        #region Methodes
        public TypeBorne GetMonTypeBorne()
        {
            TypeBorne resultat = null;

            resultat = this.LeType;

            return resultat;
        }

        public int GetCodeTypeBorne()
        {
            int resultat = 0;
            resultat = this.LeType.CodeTypeBorne;
            return resultat;

        }

        #endregion
    }
}
