using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSword : Weapon
{
    public ShortSword() {
        this.weaponName = "Short Sword";
        this.damage = 2;
        this.range = 1;
        this.angleAttack = 90;
        this.attackSpeed = 5F;
    }

    public override void Attack(Vector3 basePosition) {
        StartCoroutine(Move(basePosition));
    }

    IEnumerator<object> Move(Vector3 basePosition) {
        // Vector3 initialPosition = basePosition;

        while(true) {

            transform.rotation = Quaternion.Euler(90, transform.rotation.y + angleAttack/2, 0);

            Vector3 direcaoObjeto = transform.forward;
            
            Vector3 direcaoAlvo = new Vector3(90, transform.rotation.y - angleAttack, 0);

            float angulo = Vector3.Angle(direcaoObjeto, direcaoAlvo);

            while(angulo > 0) {
                transform.Rotate(0, -10, 0);
            }

            // if(angulo > 0) {
            //     for(float i = direcaoObjeto.y; i > direcaoAlvo.y;){
            //         i -= 5F;
            //     }
            // }

            
            yield return null;
        }

        // while (Vector3.Distance(transform.position, basePosition) > 0.1f) {
        //     // Calcula a direção aleatória, mas garante que o movimento seja em relação à basePosition
        //     Vector3 direction = basePosition;
        //     direction.y = 0;
        //     direction = Quaternion.Euler(0, 90, 0) * direction;

        //     weaponRigidbody.AddForce(direction.normalized * attackSpeed, ForceMode.VelocityChange);

        //     // Verifica a distância em relação à posição inicial
        //     if (Vector3.Distance(transform.position, initialPosition) > range) {
        //         break;
        //     }


        //     // // Calcula a direção para a basePosition
        //     // Vector3 directionToBase = basePosition - transform.position;
        //     // C.AddForce(directionToBase.normalized * attackSpeed, ForceMode.VelocityChange);
        //     yield return null;
        // }
    }

}