//https://leetcode.com/problems/clone-graph/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CloneGraph
{
    class Program
    {
        static void Main(string[] args)
        {
          var linklist = new LinkedList<int>();
          linklist.AddLast(3);
          linklist.AddLast(4);
          linklist.AddLast(5);

          var x = linklist.First;

          Console.WriteLine(String.Join(',',linklist.ToList()));
        }
    }
}
/*        private Dictionary<Node,Node> map = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node) {
          if (map.TryGetValue(node, out var c)){
            return c;
          }

          var result = new Node(node.val);
          map.Add(node, result);

          foreach(var tmp in node.neighbors){
            var new_node = CloneGraph(tmp);
            result.neighbors.Add(new_node);
          }

          return result;
        }

        public Node RecursiveCheck(Node node){
          if (node.neighbors != null)
            return node.neighbors;
          
          return new Node(node.val);
        }
    }

    public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
  }
}


/***
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/