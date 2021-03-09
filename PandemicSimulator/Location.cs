using System;
using System.Collections.Generic;
using System.Text;

namespace PandemicSimulator
{
    public class Location
    {
        // Attributes
        private Graph map; // Marauder's map
        private List<Human> humans; // students, teachers, staff, ...

        // Methods
        // - constructor
        public Location(Graph map, int numberOfHumans, bool randomValues)
        {
            this.map = map;
            humans = new List<Human>();

            for (int i = 0; i < numberOfHumans; i++)
            {
                AddHuman(randomValues);
            }
        }

        // - getters
        public List<Human> GetHumans()
        {
            return humans;
        }

        /// <summary>
        /// create a human and add it to 'humans' list.
        /// if given parameter randomValues is set to true,
        /// then set hygiene, socialDistance and travellingRate attributes to random values.
        /// set them to the predefined constants in Human.cs otherwise (e.g. GLOBAL_HYGIENE).
        /// </summary>
        /// <param name="randomValues">boolean that decides whether random values are used or not</param>
        void AddHuman(bool randomValues)
        {
            Human humain;
            
            if (randomValues)
            {
                humain = new Human(Form1.rng.NextDouble(), Form1.rng.NextDouble(), Form1.rng.NextDouble());
            }
            else
            {
                humain = new Human(Human.GLOBAL_HYGIENE, Human.GLOBAL_SOCIAL_DISTANCE, Human.GLOBAL_TRAVELLING_RATE);
            }
            // === Ajout l'humain a la listes des humains
            humans.Add(humain);

            // === Definit la position de l'humain de facon random dans le graph
            List<Node> listNode = map.GetNodes();
            int pos = Form1.rng.Next(listNode.Count);
            humain.SetCurrentSpot(listNode[pos]);

            // === Ajout l'humain a la liste d'humain du sommet
            map.GetNodes()[pos].GetHumans().Add(humain);
        }
    }
}
