# President Guessing Game

Messed up the old repo because I changed direction, so I had to copy files into this one. I liked the idea of a fun looking 2D President guessing game where an image of the correct president is displayed when the president is guessed. Will also add basic requirements of making the game customizable, with new tree creation, loading saved files, and the "demo" president game.

## Completed For Virtual Checkin:
---
- PeopleNode class
string content
PeopleNode yesNode
PeopleNode noNode
bool isLeaf
PeopleNode()
PeopleNode(string content)
PeopleNode MoveLeft()
PeopleNode MoveRight()

- GameTree class : PeopleNode
PeopleNode root
GameTree()
GameTree(PeopleNode nootNode)
GameTree(string fileName)
void WritePreorderTraversal(string fileName)
List<string> FileToList(string fileName)
