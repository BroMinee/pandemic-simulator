using System;
using System.Collections.Generic;
using System.Text;

namespace PandemicSimulator
{
    public class PandemicSimulator
    {
        public static List<Human> infectious;

        /// <summary>
        /// initialize pandemic by infecting a random human by the corona virus in given location.
        /// </summary>
        /// <param name="location">location where the pandemic is simulated</param>
        public static void InitializePandemic(Location location)
        {
            infectious = new List<Human>();
            Human patientZero = location.GetHumans()[Form1.rng.Next(location.GetHumans().Count)];
            patientZero.SetVirus(new Virus("Covid-19", 0.6, 3, 14));
            patientZero.SetSir(Human.SIR.INFECTIOUS);
            infectious.Add(patientZero);
        } 

        /// <summary>
        /// move/travel given human to a neighboring spot according to their
        /// travelling rate.
        /// </summary>
        /// <param name="human">human to move (or not)</param>
        static void MoveAround(Human human)
        {
            /*
             * Exemple : 0.25 * 100 = 25
             * Random = 80
             * comme 80 > 25 il bouge pas 
             */
            if (human.GetTravellingRate() * 100 > Form1.rng.Next(100)) // random entre 0 et 99 (inclus)
                // On le fait bouger
            {
                // ==== on remove l'humain de son ancien spot
                human.GetCurrentSpot().GetHumans().Remove(human);

                // === On defini son nouveau spot parmi les voisins de son anciens spot
                var neighbours = human.GetCurrentSpot().GetNeighbors();
                human.SetCurrentSpot(neighbours[Form1.rng.Next(neighbours.Count)]);

                // === On ajout l'ajout a la liste des personnes deja presente sur le spot 
                human.GetCurrentSpot().GetHumans().Add(human);
            }
        }

        /// <summary>
        /// try to infect susceptible humans at the transmitter's spot.
        /// the following factors are taken into account:
        ///     - the virus' infection range
        ///     - the virus's transmission rate
        ///     - the average hygiene between the transmitter and the susceptible human
        ///     - the distance between the transmitter and the susceptible human (also average of social distance)
        /// </summary>
        /// <param name="transmitter">the human carrying the virus</param>
        /// <param name="justGotInfected">the list of humans to update when someone gets infected</param>
        static void InfectOthers(Human transmitter, List<Human> justGotInfected)
        {
            List<Human> humanOnSpot = transmitter.GetCurrentSpot().GetHumans();

            int nbIteraction = transmitter.GetVirus().GetInfectionRange();
            if (nbIteraction > humanOnSpot.Count - 1)
            {
                nbIteraction = humanOnSpot.Count - 1;
            }




            for (int i = 0; i < nbIteraction; i++)
            {
                if (transmitter.GetVirus().GetTransmissionRate() * 100 > Form1.rng.Next(100))
                {
                    int pos = Form1.rng.Next(humanOnSpot.Count);
                    if (humanOnSpot[pos].GetSir() == Human.SIR.SUSCEPTIBLE && humanOnSpot[pos] != transmitter)
                    {
                        var moyenneHygiene = (transmitter.GetHygiene() + humanOnSpot[pos].GetHygiene()) / 2;
                        var moyenneDistanceSociale = (transmitter.GetSocialDistance() + humanOnSpot[pos].GetSocialDistance()) / 2;

                        if (moyenneHygiene * 100 < Form1.rng.Next(100) && moyenneDistanceSociale * 100 < Form1.rng.Next(100))// Possiblement infecte
                        {
                            humanOnSpot[pos].SetVirus(new Virus("Covid-19", 0.6,3, 14)); // On reprend pas les valeurs du transmetteur
                            humanOnSpot[pos].SetSir(Human.SIR.INFECTIOUS);
                            justGotInfected.Add(humanOnSpot[pos]);
                        }
                    }
                    else if (humanOnSpot[pos] == transmitter)
                    {
                        nbIteraction++;
                    }
                }
            }
        }

        /// <summary>
        /// update pandemic by a unit of time at given location.
        ///     - infectious humans will infect around them
        ///     - some of the infectious humans will heal/die if enough days have passed
        ///     - some humans will travel to a neighboring spot
        /// the infectious list should be updated as well
        /// </summary>
        /// <param name="location">location where the pandemic is simulated</param>
        /// <returns>return number of infectious humans at this round</returns>
        public static int UpdatePandemic(Location location)
        {
            List<Human> newCovid = new List<Human>();
            for (int i = 0; i < infectious.Count; i++)
            {
                Human CovidCases = infectious[i];
                // === On reduit le lifetime du virus de 1
                CovidCases.GetVirus().SetLifetime(CovidCases.GetVirus().GetLifetime() - 1);

                if (CovidCases.GetVirus().GetLifetime() < 0) // Plus Covid
                {
                    CovidCases.SetSir(Human.SIR.REMOVED);
                    CovidCases.SetVirus(null);
                    infectious.Remove(CovidCases); // on le retire de la liste
                }
                else // Toujours Covid
                {
                    InfectOthers(CovidCases, newCovid);
                }
            }
            foreach (Human NewCovidCases in newCovid)
            {
                infectious.Add(NewCovidCases);
            }

            // == Tout le monde se deplace dans le spot
            foreach (Human humain in location.GetHumans())
            {
                MoveAround(humain);
            }

            return infectious.Count;
        }
    }
}
