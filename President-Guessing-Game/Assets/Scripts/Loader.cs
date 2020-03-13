using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Loader
{
    public static List<string> FileToList(string fileName)
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
    public static GameTree LoadTreeFile(string fileName)
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
        return gameTree;
    }
}
