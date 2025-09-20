# GameEngineLab1

Aaron Tran: 100825433



#### GameEngineLab (name pending)

Simple project where every time you click on different colored circles, you get points. The points are tracked with a simple counter in the UI managed by the Game Manager. Game Manager will also include a timer.



Currently you have 30 seconds to click on two types of targets:



Red Targets - Bigger and decay more slowly, count for only 1 point

Orange Targets - About half as big and decay almost twice as fast, but worth 3 points



Once those 30 seconds are up, you get a Game Over screen and that's the game for now



#### Questions

What system within your project uses a Singleton, and why did you choose this system to adopt the pattern?

* Main system is the Game Manager, and it's mainly because the game manager itself shouldn't have more then one instance
  other then itself. It is also in charge of handling many of the operations such as score and time for the game.
* If I had more time, I would have added more levels, and allowed you to retain you score throughout multiple scenes. 
  I would also would have implemented a high score system, and both these ideas would require the Game Manager to be
  active through the game's process.
    

Do you think this design pattern is beneficial for this purpose? Explain why or why not.

* I think it's pretty good, though I definitely need to practice more to both better understand how to properly use it.
  From what I do know, having a Singleton is just a good thing to have as a central source of the game's mechanics and 
  important data.
  





#### References

* Simpleton script was based off of the Lecture Slides. 
* Factory Scripts and Game Manager script were heavily based on the Lecture Slides as well, but were obviously changed for the project
* Other sites used to find code for reference/usage
* https://discussions.unity.com/t/how-to-detect-mouse-click-on-a-gameobject/59449
* https://learn.unity.com/course/2d-beginner-game-sprite-flight/tutorial/add-a-scoring-system?version=6.0
* https://docs.unity3d.com/6000.2/Documentation/ScriptReference/Object.Instantiate.html
* https://discussions.unity.com/t/random-range-vector3/103279


Finally used Google to help figure out any remaining aspects of code.
Overall though, I'm very sorry in advance and will try to get better with my programming to keep up with the class.

