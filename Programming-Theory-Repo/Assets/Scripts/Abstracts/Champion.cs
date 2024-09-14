using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION”
public abstract class Champion : Character
{
    // INHERITANCE”
    // ENCAPSULATION”
    protected Weapon standardWeapon { get; set; }
    protected Weapon currentWeapon { get; set; }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        if (direction.magnitude >= 0.1f)
        {
            direction.Normalize();

            Vector3 moveDirection = transform.rotation * direction;

            transform.Translate(moveDirection * forceMovementSpeed * Time.deltaTime, Space.World);

            standardWeapon.SetPosition(transform.position);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(currentWeapon != null) {
                
            } else {
                standardWeapon.Attack(transform.position);
            }
        }

    }

}
