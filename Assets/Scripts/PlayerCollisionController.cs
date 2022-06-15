using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
    public List<string> tagsToAllowCollisionWith;

    // Called when colliders bounds intersect with another
    void OnCollisionEnter(Collision other)
    {
        if (tagsToAllowCollisionWith.Contains(other.gameObject.tag))
        {
            Debug.Log("Player collided with: " + other.gameObject.name);

            // Add Collision behaviour here
            // For example, should the player respawn? Is it game over?
        }
    }
}
