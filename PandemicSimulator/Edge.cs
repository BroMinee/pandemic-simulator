using System;
using System.Collections.Generic;
using System.Text;

namespace PandemicSimulator
{
    public class Edge
    {
        // Attributes
        private (Node source, Node destination) endpoints; // source and destination
                                                           // can be interchanged because we're working with undirected graphs

        // Methods
        // - constructor
        public Edge(Node source, Node destination)
        {
            endpoints = (source, destination);
        }

        // - getters

        public (Node source, Node destination) Endpoints
        {
            get { return endpoints; }
            
        }

        // - == and != operators overload
        public static bool operator ==(Edge edge1, Edge edge2)
        {
            // on utilise ici les operations overwrite de Node
            if ((object)edge1 == null && (object)edge2 == null) // arete nulles = identique // on le cast en object pour avoir le egal classique
                return true;

            if ((object)edge1 == null || (object)edge2 == null) // null != non null
                return false;

            //Si les nodes sont vides c'est deja gerer
            return (edge1.endpoints.source == edge2.endpoints.source &&
                    edge1.endpoints.destination == edge2.endpoints.destination // A--B et A--B
                    || edge1.endpoints.source == edge2.endpoints.destination &&
                    edge1.endpoints.destination == edge2.endpoints.source); // A--B et B--A

        }

        public static bool operator !=(Edge edge1, Edge edge2)
        {
            // on return l'inverse car -> partition de l'ensemble
            return !(edge1 == edge2);
        }

        /// <summary>
        /// represent edge by its end points in DOT language
        /// </summary>
        /// <returns>string describing this edge in DOT language followed by a newline character</returns>
        public override string ToString()
        {
            return "\t" + endpoints.source + " -- " + endpoints.destination + ";\n";
        }
    }
}
