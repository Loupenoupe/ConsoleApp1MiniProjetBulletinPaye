namespace ConsoleApp1BulletinPaye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taux de cotisations salariales
            const decimal tauxVieillesse = 0.073m;
            const decimal tauxRetraiteComple = 0.0315m;
            const decimal tauxContribEquilibre = 0.0086m;
            const decimal tauxCsgDeductible = 0.068m;
            const decimal tauxCsgNonDeductible = 0.024m;
            const decimal tauxCrds = 0.005m;

            // Taux de cotisations patronales
            const decimal tauxMaladie = 0.073m;
            const decimal tauxCotisationAccidentMaladie = 0.0224m;
            const decimal tauxVieillessePatro = 0.1045m;
            const decimal tauxRetraitComplePatro = 0.0472m;
            const decimal tauxContribEquilibrePatro = 0.0129m;
            const decimal tauxAlloc = 0.0345m;
            const decimal tauxCfnal = 0.001m;
            const decimal tauxChomage = 0.0405m;
            const decimal tauxCotisationGarantiSalaire = 0.0015m;
            const decimal tauxFormation = 0.0055m;
            const decimal tauxApprentissage = 0.0068m;
            const decimal tauxContribSociale = 0.0002m;
            const decimal tauxExoneration = 0.32m;

            // Informations employé
            string nomEntreprise = "Association ADD";

            Console.WriteLine("Quel est votre Nom et Prénom ?");
            string nomPrenom = Console.ReadLine();

            Console.WriteLine("De quel mois/année voulez-vous votre bulletin de paye ? (MM/AAAA)");
            string moisAnnee = Console.ReadLine();

            Console.WriteLine("Combien d'heures/semaines avez-vous travaillées ?");
            decimal heuresSemaineTravail = Convert.ToDecimal(Console.ReadLine());
            decimal heuresTravail = 151.67m;

            // Valeurs monétaires
            decimal salaireHoraire = 12.31m;
            decimal salaireBrut = salaireHoraire * heuresTravail;

            // Cotisations salariales
            const decimal complementaireSante = 20m;

            decimal vieillesse = tauxVieillesse * salaireBrut;
            decimal retraiteComple = tauxRetraiteComple * salaireBrut;
            decimal contribEquilibre = tauxContribEquilibre * salaireBrut;

            decimal csgDeductible = tauxCsgDeductible * salaireBrut;
            decimal csgNonDeductible = tauxCsgNonDeductible * salaireBrut;
            decimal crds = tauxCrds * salaireBrut;

            decimal totalCotisationSalariale =
                complementaireSante
                + vieillesse
                + retraiteComple
                + contribEquilibre
                + csgDeductible
                + csgNonDeductible
                + crds;

            // Cotisations patronales
            decimal maladie = tauxMaladie * salaireBrut;
            decimal cotisationAccidentMaladie = tauxCotisationAccidentMaladie * salaireBrut;
            decimal vieillessePatro = tauxVieillessePatro * salaireBrut;
            decimal retraitComplePatro = tauxRetraitComplePatro * salaireBrut;
            decimal contribEquilibrePatro = tauxContribEquilibrePatro * salaireBrut;
            decimal alloc = tauxAlloc * salaireBrut;
            decimal cfnal = tauxCfnal * salaireBrut;
            decimal chomage = tauxChomage * salaireBrut;
            decimal cotisationGarantiSalaire = tauxCotisationGarantiSalaire * salaireBrut;
            decimal formation = tauxFormation * salaireBrut;
            decimal tauxApprentissageMontant = tauxApprentissage * salaireBrut;
            decimal contribSociale = tauxContribSociale * salaireBrut;

            decimal totalCotisationPatronale =
                maladie
                + complementaireSante
                + cotisationAccidentMaladie
                + vieillessePatro
                + retraitComplePatro
                + contribEquilibrePatro
                + alloc
                + cfnal
                + chomage
                + cotisationGarantiSalaire
                + formation
                + tauxApprentissageMontant
                + contribSociale;

            decimal exoneration = tauxExoneration * salaireBrut;

            // Calculs finaux
            decimal salaireNet = salaireBrut - totalCotisationSalariale;
            decimal montantVerser = salaireBrut + totalCotisationPatronale - exoneration;

            // Affichage du bulletin
            Console.Clear();
            Console.WriteLine(
                $"**** Fiche de Paye {nomEntreprise} ****\n" +
                $"Nom et Prénom : {nomPrenom}\n" +
                $"Mois : {moisAnnee}\n" +
                $"Nombre d'heures travaillées : {heuresTravail:F2}\n" +
                $"Taux horaire : {salaireHoraire:F2} EUR\n" +

                $"\nSalaire Brut : {salaireBrut:F2} EUR\n" +

                $"\nCotisations salariales :\n" +
                $"    Complémentaire Santé : {complementaireSante:F2} EUR\n" +
                $"    Vieillesse : {vieillesse:F2} EUR\n" +
                $"    Retraite Complémentaire : {retraiteComple:F2} EUR\n" +
                $"    Contribution d'équilibre général : {contribEquilibre:F2} EUR\n" +
                $"    CSG déductible : {csgDeductible:F2} EUR\n" +
                $"    CSG non déductible : {csgNonDeductible:F2} EUR\n" +
                $"    CRDS : {crds:F2} EUR\n" +
                $"Total cotisations salariales : {totalCotisationSalariale:F2} EUR\n" +

                $"\nCotisations patronales :\n" +
                $"    Complémentaire Santé : {complementaireSante:F2} EUR\n" +
                $"    Maladie : {maladie:F2} EUR\n" +
                $"    Accidents du Travail et maladies professionnelles : {cotisationAccidentMaladie:F2} EUR\n" +
                $"    Vieillesse : {vieillessePatro:F2} EUR\n" +
                $"    Retraite Complémentaire : {retraitComplePatro:F2} EUR\n" +
                $"    Contribution d'équilibre général : {contribEquilibrePatro:F2} EUR\n" +
                $"    Allocations familiales : {alloc:F2} EUR\n" +
                $"    Contribution au Fonds National d'Aide au Logement : {cfnal:F2} EUR\n" +
                $"    Chômage : {chomage:F2} EUR\n" +
                $"    Cotisation au Régime de Garantie des Salaires : {cotisationGarantiSalaire:F2} EUR\n" +
                $"    Formation professionnelle : {formation:F2} EUR\n" +
                $"    Taxe d'apprentissage : {tauxApprentissageMontant:F2} EUR\n" +
                $"    Contribution au dialogue social : {contribSociale:F2} EUR\n" +
                $"Exonération cotisations patronales : {exoneration:F2} EUR\n" +
                $"Total cotisations patronales : {totalCotisationPatronale - exoneration:F2} EUR\n" +

                $"\nSalaire Net : {salaireNet:F2} EUR\n" +
                $"Montant total employeur : {montantVerser:F2} EUR"
            );
        }
    }
}