using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IAttack
{
    public string weaponName {get; protected set;}
    public float damage {get; protected set;}
    private float calculatedDamage {get; set;}
    public int range {get; protected set;}
    public int angleAttack {get; protected set;}
    public float attackSpeed {get; protected set;}
    protected Rigidbody weaponRigidbody {get; set;}


    void Start()
    {
        weaponRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (other.CompareTag("Enemy"))
        // {
        //     other.GetComponent<Enemy>().TakeDamage(calculatedDamage);
        // }
    }

    public void CalculateDamage(float forceMultiplier) {
        calculatedDamage = damage * forceMultiplier;
    }

    public abstract void Attack();
}