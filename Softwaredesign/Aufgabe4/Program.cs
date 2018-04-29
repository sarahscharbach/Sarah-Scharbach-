
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child1");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

            root.PrintTree(); 
            
        }
    }

    public class Tree<T>
    {
       public T _theObjects;
        public List<Tree<T>> _objectList = new List<Tree<T>>();
        
     public Tree<T> CreateNode(T theObjects)
        {
           Tree<T> node = new Tree<T>
            {
                _theObjects = theObjects
            };

           return node; 
        } 

       public void AppendChild(Tree<T> child)
        {
            _objectList.Add(child); 
             
             
        }

        public void RemoveChild(Tree<T> child)
        {
           _objectList.Remove(child);
        }

        public void PrintTree(String print = "")
        {
            Console.WriteLine(print + _theObjects);
            foreach (Tree<T> child in _objectList)
            {
                child.PrintTree(print + "*");
            }
        } 
    } 
}