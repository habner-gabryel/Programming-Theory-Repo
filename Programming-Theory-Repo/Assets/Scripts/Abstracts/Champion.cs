using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champion : Character
{
    protected Weapon standardWeapon { get; private set; }
    protected Weapon currentWeapon { get; private set; }

    void LateUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
        Vector3 direction = (mousePos - transform.position).normalized;
        
        if (Input.GetKey(KeyCode.W)){
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S)){
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A)){
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D)){
            direction += Vector3.right;
        }
        
        transform.position += direction * forceMovementSpeed * Time.deltaTime;

    }

}
