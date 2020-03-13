using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class PeopleNode
{
    public string content { get; set; }
    public PeopleNode yesNode { get; set; }
    public PeopleNode noNode { get; set; }
    public bool isLeafNode
    {
        get
        {
            return yesNode == null && noNode == null;
        }
    }
    public PeopleNode()
    {
        // empty constructor
    }
    public PeopleNode(string nodecontent)
    {
        content = nodecontent;
        yesNode = null;
        noNode = null;
    }

    public PeopleNode MoveLeft()
    {
        return yesNode;
    }

    public PeopleNode MoveRight()
    {
        return noNode;
    }
}
