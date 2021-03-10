using System;
using System.Collections.Generic;
using System.IO;

namespace PandemicSimulator
{
    public class Graph // undirected graph
    {
        // Attributes
        private string name;
        private List<Node> nodes; // spots
        private List<Edge> edges; // paths

        // Methods
        // - constructor
        public Graph(string name)
        {
            this.name = name;
            nodes = new List<Node>();
            edges = new List<Edge>();
        }

        // - getters
        public string GetName()
        {
            return name;
        }

        public List<Node> GetNodes()
        {
            return nodes;
        }

        public List<Edge> GetEdges()
        {
            return edges;
        }

        /// <summary>
        /// try to create and add node to this graph.
        /// if a node with the same label already exists, then return existing node.
        /// return created node otherwise.
        /// </summary>
        /// <param name="label">label of the node to add</param>
        /// <returns>created/existing node</returns>
        Node AddNode(string label)
        {
            Node sommet = new Node(label);
            foreach (var s in nodes)
            {
                if (sommet == s) // == de Node
                {
                    return s; // on return celui qui existe deja
                }
            }
            // Il existe pas encore
            nodes.Add(sommet);
            return sommet; // on return le nouveau

        }

        /// <summary>
        /// try to create and add edge to this graph.
        /// if this edge already exists, then return false because no edges were added.
        /// return true otherwise.
        /// </summary>
        /// <param name="source">source node of the edge to add</param>
        /// <param name="destination">destination node of the edge to add</param>
        /// <returns>a boolean of whether an edge was added or not</returns>
        bool AddEdge(Node source, Node destination)
        {
            Edge bord = new Edge(source, destination);
            foreach (var s in edges)
            {
                if (bord == s) // == de Edge
                {
                    return false; // il existe deja donc on return false
                }
            }
            // Il existe pas encore
            edges.Add(bord);
            return true; // il n'existe pas donc on return true
        }

        /// <summary>
        /// extract the graph's name of the first line in a DOT file. (first line of a graph declaration)
        /// 
        /// example of a first line: "graph Epita {".
        /// In this example, the string "Epita" should be returned.
        /// </summary>
        /// <param name="firstLine">first line of a DOT file</param>
        /// <returns>the name of the graph</returns>
        public static string ExtractNameFromLine(string firstLine)
        {
            return firstLine.Split(' ')[1]; // apres split on a ["graph", "Epita", "{"] et nous on veut le 2eme element 
        }

        /// <summary>
        /// extract nodes and edge from a given edge line in DOT file and add them
        /// to given 'graph'.
        /// The format of edgeLine's string is the same as the ToString() method
        /// in Edge.cs without the newline character.
        /// 
        /// example of edgeLine: "    VA302 -- VA303;".
        /// In this example, the nodes of respective labels "VA302" and "VA303" as well
        /// as the edge linking those two should be added to the graph.
        /// </summary>
        /// <param name="edgeLine">string in DOT language describing an edge</param>
        /// <param name="graph">graph to update</param>
        /// <exception cref="Exception">an exception should be raised if the edge already exists</exception>
        public static void UpdateGraphFromLine(string edgeLine, Graph graph)
        {
            string[] stringSeparators = new string[] { " ", ";", "-", "\t" };
            string[] words = edgeLine.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            Node source = graph.AddNode(words[0]);
            Node dest = graph.AddNode(words[1]);

            if (graph.AddEdge(source, dest) == false)
            {
                throw new Exception("UpdateGraphFromLine : Dans le graph \"" + graph.name + "\",il existe deja l'arrete > " + new Edge(source, dest));
            }
            else // Update les voisins seulement si l'arrete existe pas deja avant
            {
                source.GetNeighbors().Add(dest); //Update ses voisins
                dest.GetNeighbors().Add(source);
            }


        }

        /// <summary>
        /// generate graph from file written in simple DOT language.
        /// </summary>
        /// <param name="filepath">path of file in DOT language</param>
        /// <returns>created graph</returns>
        public static Graph FromFile(string filepath)
        {
            // On part du principe que le syntaxe du DOT est correct

            StreamReader sr = new StreamReader(filepath);
            Graph graph = new Graph(ExtractNameFromLine(sr.ReadLine()));  // Le nom est toujours sur la 1er ligne du file

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                if (line != "}") // normalement un fichier fini par } sans retour a la ligne ni espace apres
                {
                    try
                    {
                        UpdateGraphFromLine(line, graph);
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            sr.Close();
            return graph;
        }
    }
}