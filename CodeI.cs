using RAMQ.Domaine.Abstractions;

namespace RAMQ.Domaine.Entites.Piloter.CodesInterventionExclus
{
    public class CodeInterventionExclus : Entite<CodeInterventionExclusId>
    {
        public string Login { get; private set; }
        public int NoSeqCodeInterventionExclus { get; private set; }
        public int NoSeqSystemeClassification { get; private set; }
        public DateTime DateDebutCodInterventionExclus { get; private set; }
        public DateTime? DateFinCodInterventionExclus { get; private set; }
        public string CodeInterExclus { get; private set; }
        public string SchemaCodage { get; private set; }
        private CodeInterventionExclus() { }
        public CodeInterventionExclus(string login,int noSeqCodInterExclu, string codeSchemCodag, string codeInterExclu) {
            Login = login;
            NoSeqCodeInterventionExclus = noSeqCodInterExclu;
            SchemaCodage = codeSchemCodag;
            CodeInterExclus = codeInterExclu;
        }
        public CodeInterventionExclus(string login, 
            int noSeqSystemeClassification, 
            DateTime dateDebutCodInterventionExclus,
            DateTime? dateFinCodInterventionExclus,
            string codeInterExclus,
            string schemaCodage
            )
        {
            Login = login;
            NoSeqSystemeClassification = noSeqSystemeClassification;
            DateDebutCodInterventionExclus = dateDebutCodInterventionExclus;
            DateFinCodInterventionExclus = dateFinCodInterventionExclus;
            CodeInterExclus = codeInterExclus;
            SchemaCodage = schemaCodage;
        }

    }
}
