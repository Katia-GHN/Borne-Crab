using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borne.Methodes
{
    public class TypeBorne
    {
        #region Attributs

        public static List<TypeBorne> CollClasse = new List<TypeBorne>();

        private int _codeTypeBorne;
        private TimeSpan _dureeRevision; //Utiliser pour une durée ou intervale de temps
        private int _nbJoursEntreRevisions;
        private int _nbUniteEntreRevision;

        #endregion

        #region Constructeurs

        public TypeBorne(int codeTypeBorne, TimeSpan dureeRevision, int nbJoursEntreRevisions, int nbUniteEntreRevision)
        {
            _codeTypeBorne = codeTypeBorne;
            _dureeRevision = dureeRevision;
            _nbJoursEntreRevisions = nbJoursEntreRevisions;
            _nbUniteEntreRevision = nbUniteEntreRevision;

            TypeBorne.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int CodeTypeBorne { get => _codeTypeBorne; set => _codeTypeBorne = value; }
        public TimeSpan DureeRevision { get => _dureeRevision; set => _dureeRevision = value; }
        public int NbJoursEntreRevisions { get => _nbJoursEntreRevisions; set => _nbJoursEntreRevisions = value; }
        public int NbUniteEntreRevision { get => _nbUniteEntreRevision; set => _nbUniteEntreRevision = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
