﻿using System;
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

    public GameTree(string fileName)
    {
        List<string> preorderList = FileToList(fileName);
        Stack<PeopleNode> stck = new Stack<PeopleNode>();
        PeopleNode current = new PeopleNode(preorderList[0]);
        GameTree gameTree = new GameTree(current);
        stck.Push(current);
        for (int i = 1; i < preorderList.Count; i++)
        {
            char temp = preorderList[i][0];
            if (preorderList[i][0] == '*')
            {
                if (current.yesNode == null)
                {
                    current.yesNode = new PeopleNode(preorderList[i].Substring(1));
                }
                else if (current.noNode == null)
                {
                    current.noNode = new PeopleNode(preorderList[i].Substring(1));
                }
                else
                {
                    while (stck.Count > 0)
                    {
                        current = stck.Peek();
                        stck.Pop();
                        if (current.yesNode == null)
                        {
                            current.yesNode = new PeopleNode(preorderList[i].Substring(1));
                        }
                        else if (current.noNode == null)
                        {
                            current.noNode = new PeopleNode(preorderList[i].Substring(1));
                        }
                    }
                }
            }
            else
            {
                if (current.yesNode == null)
                {
                    current.yesNode = new PeopleNode(preorderList[i]);
                    stck.Push(current);
                    current = current.MoveLeft();
                }
                else if (current.noNode == null)
                {
                    current.noNode = new PeopleNode(preorderList[i]);
                    stck.Push(current);
                    current = current.MoveRight();
                }
            }
        }
        root = gameTree.root;
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

    private List<string> FileToList(string fileName)
    {
        List<string> PreOrderList = new List<string>();
        string path = "Assets/Resources/" + fileName + ".txt";
        StreamReader reader = new StreamReader(path);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            PreOrderList.Add(line);
        }
        reader.Close();
        return PreOrderList;
    }
}
