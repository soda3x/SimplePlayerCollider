using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycastController : MonoBehaviour
{
    public List<string> tagsToAllowCollisionWith;
    public float raycastSphereRadius;

    void FixedUpdate()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, raycastSphereRadius);
        foreach (Collider c in hitColliders)
        {
            if (tagsToAllowCollisionWith.Contains(c.gameObject.tag))
            {
                Debug.Log("Player collided with: " + c.gameObject.name);

                // Add Collision behaviour here
                // For example, should the player respawn? Is it game over?
            }
        }
    }
}
