# AI-Assignment

12/12/22 

Unity Version: Unity2021.3.11f1 

Tested on: Oculus Quest 2 

Assignment 5: AI of the VR MSc for Swansea University 

### “A Dramatic Day out in the Park”

![image](https://user-images.githubusercontent.com/115563114/207161524-e76cb203-3060-486b-ae38-c64a2123d462.png)


## Explanation of the purpose and features of the Dialogue 
in my AI Assignment “A Robbery in the Park” I have 4 dialogue scripts where each script is attached to a different NPC in my scene. The intro dialogue has a purpose of setting the scene, it also has the first decision a player can make: “Yes start exploring” this will continue the dialogue and the story to the player or “No to Exploring” this will give the player the opportunity to leave the scene. Each script from there on is attached to an NPC that takes the player through tasks they have to complete. The runner dialogue script is what activates the robbery, this script gives the player the choice of helping the victim and progressing or not helping the victim and leaving the story. The police dialogue script gives the player the chance to help the victim and give the police a description of the robber to avoid going to jail for wasting police time. The final script is attached to an NPC who is at a picnic the player gets the choice of whether they want to stay at the picnic and chat with friends or to not sit at the picnic and just explore the park. The reason I kept the ending of my game open and not a “game over” scenario is so that the player can choose to explore the park, they can also go back to NPCs they have already seen and change their answers to the questions asked withing the dialogue. 

## Explanation of the purpose and features of the Crowd:
the crowd and their behaviors and movements have been made through the use of state machines. They will all rush to the scene of the robbery once a tip has been sent to the police and their actions and animations will try to replicate a real-life situation, shocked and all stood still watching in disbelief. Before this their behaviors replicate those typical to what you would see in a park, walking dogs, chatting, kids playing and dancing together. I think that the crowd behavior is vital to the scene, you wouldn’t typically find yourself in an empty park and if there was a robbery then people wouldn’t typically ignore the situation, they would all rush to try and help. That is what I have tried to create through my crowd behavior. 

## Explanation of the purpose and features of the Story:
The storyline is that you are going to meet your friends in the park for a picnic, however not long after you get there, there is a robbery in the park and as the player you are asked to help. You can choose yes or no to helping with the robbery event however based on the decision you pick is what happens next in the story. If you select no then people in the park are not happy with you. If you pick yes then you must send a tip to the police (by pressing the trigger button on your left controller) which then notifies the police department and dispatches a police officer. You will then need to speak to the police officer however be careful with the choices you make. If you are cooperative then the police man will take your statement and let you get on with your day after thanking you for all of your help, you are then free to join your friends on the picnic you were invite to. However if you don’t cooperate then the police man will not be as considering and could take you to jail for wasting police time. Once this has happened if you get to go free and go to the picnic, you can choose whether you are ready to sit with your friends or if you want to look around the park a bit more, who knows maybe you will find some clues to the robbery.  

