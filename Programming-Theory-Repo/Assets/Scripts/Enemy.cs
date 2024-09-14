using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION”
public abstract class Enemy : Character
{
    // INHERITANCE”
    // ENCAPSULATION”
    protected Weapon weapon { get; set; }
    protected float detectionRange { get; set;}

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, detectionRange))
        {
            Debug.Log("Detect is run");
            if (hit.collider.gameObject.tag == "Player")
            {
                Vector3 pos = hit.collider.gameObject.transform.position;

                Vector3 direction = pos- transform.position;
                direction.Normalize();

                characterRb.AddForce(direction * forceMovementSpeed);
            }
        }
    }
}
