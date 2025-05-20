using BibliothequeFonctionsDeBase;
namespace Projet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialiser l'affichage
            FonctionsDeBase.AfficherTitre("CONVERSION D'UNE MESURE EN POUCES", 50);

            //Déclarer et assigner les variables
            int mesureSaisie = 0;
            FonctionsDeBase.AfficherLigne("\nBienvenue au convertisseur de mesure.",ConsoleColor.Green);
            FonctionsDeBase.AfficherLigne("Entrez une mesure en pouce, ou entrez '0' pour quitter.",ConsoleColor.Red);

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                mesureSaisie = FonctionsDeBase.LireEntier("\nSaisissez la quantité à convertir : ");
                Console.ResetColor();

                //Convertir la mesure aux formats désirés
                double mesureCm = convertirPoToCm(mesureSaisie);
                string mesurePiPo = convertirPoToPiPoTxt(mesureSaisie);
                double mesureM = convertirCmToM(mesureCm);

                //Afficher le résultat
                AfficherConversionPouceMetreCM(mesureSaisie, mesurePiPo, mesureCm, mesureM);
            } while (mesureSaisie != 0);

            //Annoncer la fin du programme
            FonctionsDeBase.AfficherEtoiles(100);
            FonctionsDeBase.AfficherLigne("Fin du programme.", ConsoleColor.Red);
            FonctionsDeBase.MasquerTexte();
        }
        static void AfficherConversionPouceMetreCM(int mesurePouces, string mesurePiPo, double mesureCm, double mesureM)
        {
            Console.Write("\n");
            FonctionsDeBase.AfficherEtoiles(50);

            FonctionsDeBase.AfficherLigne($"Valeur de base en pouces : ",ConsoleColor.Gray);
            FonctionsDeBase.AfficherLigne($"{mesurePouces} pouces\n",ConsoleColor.DarkGray);

            FonctionsDeBase.AfficherLigne($"Valeur en pied, pouces : ");
            FonctionsDeBase.AfficherLigne(mesurePiPo+"\n",ConsoleColor.Magenta);

            FonctionsDeBase.AfficherLigne($"Valeur en centimètres : ");
            FonctionsDeBase.AfficherLigne($"{mesureCm:F2} cm\n",ConsoleColor.Green);

            FonctionsDeBase.AfficherLigne($"Valeur en mètres : ",ConsoleColor.Blue);
            FonctionsDeBase.AfficherLigne($"{mesureM:F4} m", ConsoleColor.Green);

            FonctionsDeBase.AfficherEtoiles(50);
        }
        static double convertirPoToCm(double mesurePo)
        {
            return mesurePo * 2.54;
        }
        static double convertirCmToM(double mesureCm)
        {
            return mesureCm / 100;
        }
        static string convertirPoToPiPoTxt(double mesurePo)
        {
            double nbPouces  = mesurePo % 12;
            return $"{Math.Floor(mesurePo / 12)} pieds, {nbPouces} pouces";
        }
    }
}
