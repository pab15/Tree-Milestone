using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class GameTree : PeopleNode
{
    public PeopleNode root;

    public GameTree()
    {
        // empty constructor
    }

    public GameTree(PeopleNode rootNode)
    {
        root = rootNode;
    }

    public void WritePreOrderTraversal(string fileName)
    {
        string path = "Assets/Resources/" + fileName + ".txt";
        StreamWriter writer = new StreamWriter(path, true);
        if (root == null)
        {
            return;
        }
        Stack<PeopleNode> stck = new Stack<PeopleNode>();
        stck.Push(root);
        while (stck.Count > 0)
        {
            PeopleNode current = stck.Peek();
            if (current.isLeafNode)
            {
                writer.WriteLine("*" + current.content);
            }
            else
            {
                writer.WriteLine(current.content);
            }
            stck.Pop();

            if (current.noNode != null)
            {
                stck.Push(current.noNode);

            }
            if (current.yesNode != null)
            {
                stck.Push(current.yesNode);
            }
        }
        writer.Close();
    }
}
