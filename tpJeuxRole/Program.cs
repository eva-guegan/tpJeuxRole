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
            int persoPaladin = 0;
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
                        Console.WriteLine("Choissisez une classe : (1: Guerrier, 2: Mage, 3: Chaman ou 4: Paladin)");
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
                                hero = new Paladin(choixName);
                                persoPaladin = 1;
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
                //for (int i = 0; i < 2; i++)
                //{
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
                //}
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

            #region Ajout + affichage d'équipe

            if (persoGuerrier == 1 || persoPaladin == 1)
            {
                hero2 = new Guerrier("Florian");
            }
            else if (persoMage == 1 || persoChaman == 1)
            {
                hero2 = new Mage("Florian");
            }

            Equipe.AjouterPerso(hero);
            Equipe.AjouterPerso(hero2);

            //Equipe.AfficherEquipe();
            #endregion

            #region Tournoi
            verification = true;

            while (verification == true)
            {
                Console.WriteLine("Voulez-vous attaquer un autre personnage ?");
                string repCombat = Console.ReadLine();

                if (repCombat == "oui" || repCombat == "Oui")
                {
                    Console.WriteLine("Vous avez accepter de combattre \n");

                    Console.WriteLine("Voici votre adversaire : ");
                    hero2.display();

                    Console.WriteLine("Taper une touche pour continuer");
                    Console.ReadKey();
                    Console.Clear();

                    #region attaque
                    if (persoGuerrier == 1 || persoPaladin == 1)
                    {
                        //Tournoi arme
                        Tournoi t1 = new Tournoi();
                        t1.TournoiArme(hero, hero2);
                    }
                    else if (persoMage == 1 || persoChaman == 1 || persoPaladin == 1)
                    {
                        //Tournoi magie
                        Tournoi t2 = new Tournoi();
                        t2.TournoiMagie(hero, hero2);
                    }
                    #endregion
                    verification = false;
                }
                else if (repCombat == "non" || repCombat == "Non")
                {
                    Console.WriteLine("Vous avez choisi de ne pas combattre");
                    verification = false;
                    Console.ReadKey();
                }
            }
            #endregion

            Console.WriteLine("Le programme est fini ! \n");
            Console.ReadKey();
        }
    }
}
