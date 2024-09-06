using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSword : Weapon
{
    public ShortSword() {
        this.weaponName = "Short Sword";
        this.damage = 2;
        this.range = 1;
        this.angleAttack = 45;
        this.attackSpeed = 5F;
    }

    public override void Attack() {
        StartCoroutine(Move());
    }

    IEnumerator<object> Move() {
        while (true) {
            
            Vector3 direction = Random.insideUnitSphere;
            direction.y = 0;
            direction = Quaternion.Euler(0, Random.Range(-angleAttack, angleAttack), 0) * direction;

            weaponRigidbody.AddForce(direction * attackSpeed, ForceMode.VelocityChange);

            if (weaponRigidbody.position.magnitude > range) {
                break;
            }

            yield return null;
        }
    }

}