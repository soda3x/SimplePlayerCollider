# SimplePlayerCollider

Unity project showing how OnCollisionEnter and OverlapSphere can be used with GameObject tags.

!["Screenshot"](https://github.com/soda3x/SimplePlayerCollider/blob/cc1da1e269b4a8a4a15c9187b8093caad34e5923/screenshot.png)
  
## Usage

This repo contains two different scripts for handling collision.

### PlayerCollisionController and ColliderScene

This basic Unity scene demonstrates an example of using the `OnCollisionEnter` method.

The 'Player' in this scene has the `PlayerCollisionController` script which allows the configuration of which Colliders should be ignored and which should be acted on via the colliding object's `tag`.

### PlayerRaycastController and RaycastScene

This basic Unity scene demonstrates an example of using the `Physics.OverlapSphere` method.

The 'Player' in this scene has the `PlayerRaycastController` script which allows the configuration of which Colliders should be ignored and which should be acted on via the colliding object's `tag`.

The difference between this script and the `PlayerCollisionController` script is that this script allows collision detection without requiring a rigidbody.

## Licence

Just use it :)
