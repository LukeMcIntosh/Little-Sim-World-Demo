# Little-Sim-World-Demo
Demo of a shopping / equipping system in a 2D sprite game.

This project contains the functionally correct clothing system for a sprite-based, top down game. In the demo scene, the player can move around the avatar using the W,A,S and D keys, and has access to items through the bottom left-hand button. This button changes functionally as the user enters a proximity of the storekeeper.
	When the user opens the item inventory, they may equip the items they own. When the user opens the shop, they may purchase items they do not own, or sell items they do own but do not have currently equipped. 

The clothing system assumes the following:
There is at least one sprite of clothing for each direction the avatar may face
A walking and an idle looping unity animation for each direction, with a unity event at each sprite change of the base avatar.

The system works by adhering to the following steps.
 A clothing item has a scriptable object created for it inside the unity project. Here there must be a unique ID, and appropriate sprites assigned for each direction.
This scriptable object is linked to the ClothingData script’s list.

Each item slot has its own renderer so layering can be managed as they have their equipped sprites assigned. Each animation clip calls to an event which has an index passed. This is used to pull the appropriate sprite from the equipped item’s scriptable object to match the point in the animation the avatar is in.
	For example, the avatar is walking UP and is on frame 2. As frame 3 triggers, the unity animation event calls to the script managing current equipment and finds the scriptable objects of the currently equipped items. From this result, the 3rd frame of the walking UP animation from that item is placed on the appropriate renderer. The animation event takes the current frame as a parameter.

How I have done.

This project was heavily dependent on which art I could find, as the design as to how to make it work in the limited amount of time would change. Considering this, I am happy with the system of managing clothing sprites on an avatar. I believe the clothing system to be easy to understand, expandable and should require little technical skill to add more items. I had intended to add a feature which sorted objects’ sprite rendering layers by ‘y’ height, allowing me to give the illusion of depth dynamically.

I also acknowledge the ‘bare-bones’ of the UI menus and the scene set-up itself. It struck me that if there was something I should focus on above all else, it should be functionality over a presented aesthetic. I understand that this realisation is only due to my personal context while taking this test, and don’t wish it to reflect my overall attitudes towards my work with Unity in general. However in the interest of fairness, this must be looked at with an even regard and therefore I must reflect poorly about my efforts.

