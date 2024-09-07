using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Champion
{
    public Weapon knightBaseWeapon;
    public Knight() {
        this.characterName = "Knight";
        this.maxLife = 5;
        this.forceMultiplier = 1.4F;
        this.forceMovementSpeed = 3F;
    }

    void Start() {
        standardWeapon = knightBaseWeapon;
    }
}