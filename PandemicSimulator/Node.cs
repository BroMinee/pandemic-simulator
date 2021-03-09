using System;
using System.Collections.Generic;
using System.Text;

namespace PandemicSimulator
{
    public class Node
    {
        // Attributes
        private string label; // spot's/node's name
        private List<Human> humans; // list of humans currently at this spot/node
        private List<Node> neighbors; // list of neighboring nodes (there exists a direct edge)

        // Methods
        // - constructor
        public Node(string label)
        {
            this.label = label;
            humans = new List<Human>();
            neighbors = new List<Node>();
        }

        // - getters
        public string GetLabel()
        {
            return label;
        }

        public List<Human> GetHumans()
        {
            return humans;
        }

        public List<Node> GetNeighbors()
        {
            return neighbors;
        }

        // - == and != operators overload
        public static bool operator ==(Node node1, Node node2)
        {
            if ((object)node1 == null && (object)node2 == null) // 2 null = identiques // on le cast en object pour avoir le egal classique
                return true;

            if ((object)node1 == null) // l'autre est forcement non null
                return false;

            return (node1.label == node2.label);
        }

        public static bool operator !=(Node node1, Node node2)
        {
            // on return l'inverse car -> partition de l'ensemble
            return !(node1 == node2);
        }

        /// <summary>
        /// count amount of humans of given 'sir' at this node/spot.
        /// </summary>
        /// <param name="sir">type of SIR to count</param>
        /// <returns>number of humans of type 'sir'</returns>
        public int GetSIRCount(Human.SIR sir)
        {
            int count = 0;
            foreach (var humain in humans)
            {
                if (humain.GetSir() == sir)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// represent node by label.
        /// </summary>
        /// <returns>label of node</returns>
        public override string ToString()
        {
            return label;
        }

        /// <summary>
        /// translate node in dot language so it could be used in generated DOT file
        /// with desired format. 
        /// </summary>
        /// <returns>string of dot language that represents this node</returns>
    }
}
