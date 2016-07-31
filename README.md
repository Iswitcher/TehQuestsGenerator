# TehQuestsGenerator
The very basic WinForm app to simplify quest XML's creation process

So, tl;dr: I've had to manually create 2 XML documents: Quest XML list and QuestLinks XML list.

Quest XML list lists all Quests for the game, while QuestLinks XML list is a list of triggers, defining which quest drops which or under what circumstances a new quest is dropped.
I had a lot of pain of manually creating those lists because:
1) Human errors (duh!)
2) Having to manually check the ID's for the game entities to post in XML takes too much time and actions.

So, my big and not so great plan involves:
1) Making platform for entering and editing new quests and questLinks
2) Serializing that data into XML documents
3) Automating the process for creating new game UID's by using web requests.
4) Visualizing the entering process by showing what entered ID actually means as a game entity
5) Possibly, automate the process for creating new localization strings where I couldn'd find a already preexisting ones.
