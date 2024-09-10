using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSword : Weapon
{
    private float initialAngleX { get; set; }
    private float initialAngleY { get; set; }
    private float initialAngleZ { get; set; }

    public ShortSword() {
        this.weaponName = "Short Sword";
        this.damage = 2;
        this.range = 1;
        this.angleAttack = 90;
        this.attackSpeed = 5F;
    }

    void Start(){
        CalculateInitialAngle();
        SetRotation();
    }

    public override void Attack(Vector3 position) {
        SetPosition(position);
        StartCoroutine(Move());        
    }

    private void SetRotation() {
        transform.rotation = Quaternion.Euler(initialAngleX, initialAngleY, initialAngleZ);
    }

    private void CalculateInitialAngle() {
        initialAngleX = 120F;
        initialAngleY = 0F;
        initialAngleZ = transform.rotation.z - (angleAttack/2);
    }

    IEnumerator<object> Move() {
        float lastAngleZ = initialAngleZ + angleAttack;
        float actualAngleZ = initialAngleZ;

        while(actualAngleZ < lastAngleZ) {
            yield return new WaitForSeconds(0.02f);
            transform.Rotate(0, 0, 5F);
            actualAngleZ += 5F;
        }

        if(actualAngleZ == lastAngleZ) {
            yield return new WaitForSeconds(1.8f);
            AutoDestroy();
        }
        
        yield return null;
    }

}