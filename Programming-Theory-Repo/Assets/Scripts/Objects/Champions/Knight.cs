using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Champion
{
    public GameObject knightBaseWeapon;
    public Knight() {
        this.characterName = "Knight";
        this.maxLife = 5;
        this.forceMultiplier = 1.4F;
        this.forceMovementSpeed = 3F;
    }

    void Start() {

        Instantiate(knightBaseWeapon, transform.position, transform.rotation);

        standardWeapon = knightBaseWeapon.GetComponent<Weapon>();
    }
}