using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Enemy : Character
{
    protected Weapon weapon { get; set; }
    public float detectionRange = 5f;

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, detectionRange))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                Vector3 pos = hit.collider.gameObject.transform.position;

                Vector3 direction = pos- transform.position;
                direction.Normalize();

                rb.AddForce(direction * forceMovementSpeed);
            }
        }
    }
}
