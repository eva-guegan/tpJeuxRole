using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            Personnage hero = null;
            Personnage hero2 = null;
            int persoGuerrier = 0;
            int persoMage = 0;
            int persoChaman = 0;
            int persoVoleur = 0;
            bool verification = true;
            #endregion

            #region Création du premier personnage
            while (verification == true)
            {
                Console.WriteLine("Choissisez un nom à votre personnage : ");
                string choixName = Console.ReadLine();

                if (choixName == "")
                {
                    Console.WriteLine("Vous n'avez pas rentrez de nom");
                    verification = true;
                } else
                {
                    while (verification == true)
                    {
                        Console.WriteLine("Choissisez une classe : (1: Guerrier, 2: Mage, 3: Chaman ou 4: Voleur)");
                        string choixClasse = Console.ReadLine();

                        switch (choixClasse)
                        {
                            case "1":
                                hero = new Guerrier(choixName);
                                persoGuerrier = 1;
                                verification = false;
                                break;
                            case "2":
                                hero = new Mage(choixName);
                                persoMage = 1;
                                verification = false;
                                break;
                            case "3":
                                hero = new Chaman(choixName);
                                persoChaman = 1;
                                verification = false;
                                break;
                            case "4":
                                hero = new Voleur(choixName);
                                persoVoleur = 1;
                                verification = false;
                                break;
                            default:
                                Console.WriteLine("Il n'existe pas d'autre classe \n");
                                verification = true;
                                break;
                        }
                    }
                }
            }
            #endregion

            hero.display();
            Console.WriteLine("Vous avez un maximum de " + hero.getNbSacMax() + " sacs \n");
            verification = true;

            #region Ajouter un objet dans un sac
            while (verification == true)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Voulez-vous ajouter un objet dans un sac ? \n");
                    string rep = Console.ReadLine();

                    if (rep == "Oui" || rep == "oui")
                    {
                        Console.WriteLine("Choissisez dans quel sac vous voulez ajouter un objet : entre 1 et " + hero.getNbSacMax() + "\n");
                        string repSac = Console.ReadLine();

                        // Faire boucler 
                        if (Convert.ToInt32(repSac) > hero.getNbSacMax() || Convert.ToInt32(repSac) < 1)
                        {
                            Console.WriteLine("Vous ne possédez pas ce nombre de sacs \n");
                            //verification = false;
                            break;
                        } //options si texte rentrer

                        Console.WriteLine("Quel objet voulez-vous ajouter ? \n");
                        string repObjet = Console.ReadLine();

                        hero.AjouterObjetChoisi(Convert.ToInt32(repSac), new Objet(repObjet));

                    }

                    else if (rep == "Non" || rep == "non")
                    {
                        verification = false;
                    }
                    else
                    {
                        Console.WriteLine("Vous devez répondre oui ou non");
                        verification = true;
                    }
                }

            }

            Console.Clear();
            #endregion

            #region Afficher un sac
            verification = true;
            while (verification == true)
            {
                Console.WriteLine("Quel sac voulez-vous afficher le contenu ? (taper 0 pour ne rien afficher) \n");
                string numSac = Console.ReadLine();

                if (numSac == "0")
                {
                    Console.WriteLine("Vous avez choisi de ne rien afficher");
                    verification = false;
                }
                else if (Convert.ToInt32(numSac) < hero.getNbSacMax()+1 && Convert.ToInt32(numSac) > 0)
                {
                    //Si le sac est vide affiché une phrase
                    hero.AfficherSacs(Convert.ToInt32(numSac));
                    verification = false;
                } else
                {
                    Console.WriteLine("Vous ne possédez pas ce sac");
                    verification = true;
                }
            }
            #endregion

            #region préparation tournoi
            verification = true;

            while (verification == true)
            {
                Console.WriteLine("Voulez-vous attaquer un autre personnage ?");
                string repCombat = Console.ReadLine();

                if (repCombat == "oui" || repCombat == "Oui")
                {
                    Console.WriteLine("Vous avez accepter \n");

                    Console.WriteLine("Choississez le nom de votre adversaire");
                    string choixName2 = Console.ReadLine();

                    Console.WriteLine("Création aléatoire d'un personnage ... \n");
                    if (persoGuerrier == 1 || persoVoleur == 1)
                    {
                        hero2 = new Guerrier(choixName2);
                    } else if (persoMage == 1 || persoChaman == 1)
                    {
                        hero2 = new Mage(choixName2);
                    }

                    Console.WriteLine("Voici votre adversaire : ");
                    hero2.display();

                    Console.WriteLine("Taper une touche pour continuer");
                    Console.ReadKey();

                    Console.Clear();
                    //stocker le nom du perso 2 dans le sorted set / utile ?
                    Console.WriteLine("\nVoici les participants au tournoi :  \n");
                    hero.afficherPersoTrier(choixName2);

                    verification = false;
                }
                else if (repCombat == "non" || repCombat == "Non")
                {
                    Console.WriteLine("Vous êtes obligé d'affronter votre adversaire");   
                }
            }
            #endregion

            ArrayList listePerso = new ArrayList() { hero, hero2 };

            /*Accéder au tableau
            var perso1 = listePerso[0];
            var perso2 = listePerso[1];*/
            /*
            #region tournoi

            if (persoGuerrier == 1 || persoVoleur == 1)
            {
                Console.WriteLine("Voulez vous attaquer ?");
                string repAttaque = Console.ReadLine();

                if (repAttaque == "Oui" || repAttaque == "oui")
                {
                    Console.WriteLine("Quel arme voulez-vous utiliser ? (1:Epée ou 2:Masse");
                    string repArme = Console.ReadLine();

                    var armeHero2 = "Epée";

                    var IAttaquantArme1 = IAttaquantArme(repArme, hero);
                    var IAttaquantArme2 = IAttaquantArme(armeHero2, hero2);

                    Tournoi.accepterTournoiArme(IAttaquantArme1, IAttaquantArme2);
                }
            }
            else if (persoMage == 1 || persoChaman == 1)
            {
                Console.WriteLine("Voulez vous attaquer ?");
                string repAttaque = Console.ReadLine();

                if (repAttaque == "Oui" || repAttaque == "oui")
                {
                    Console.WriteLine("Quel arme voulez-vous utiliser ? (1:Sort 1 ou 2:Sort 2");
                    string repSort = Console.ReadLine();

                    //random entre sort 1 et sort 2
                    var sortHero2 = "Sort 1";

                    var IAttaquantMagie1 = IAttaquantMagie(repSort, hero);
                    var IAttaquantMagie2 = IAttaquantMagie(sortHero2, hero2);

                    Tournoi.accepterTournoiArme(IAttaquantMagie1, IAttaquantMagie2);
                } else
                {
                    Console.WriteLine("Vous êtes obliger d'attaquer");
                }
            }
            #endregion
            */
            Console.ReadKey();
        }
    }
}
