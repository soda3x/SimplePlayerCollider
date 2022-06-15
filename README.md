# SimplePlayerCollider

Example Unity project showing how OnCollisionEnter can be used with GameObject tags.

!["Screenshot"](https://github.com/soda3x/SimplePlayerCollider/blob/cc1da1e269b4a8a4a15c9187b8093caad34e5923/screenshot.png)
  
## Usage

This basic Unity project demonstrates an example of using the  `OnCollisionEnter()` method.

The 'Player' in this project has the `PlayerCollisionController` script which allows the configuration of which Colliders should be ignored and which should be acted on via the colliding object's 'tag'.

In the example, the car drives toward its goal, the flag, and will collide with the 'human' on its way.
