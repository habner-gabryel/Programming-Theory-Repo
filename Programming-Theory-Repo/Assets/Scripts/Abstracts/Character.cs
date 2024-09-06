using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public string characterName { get; protected set; }
    public int maxLife { get; protected set; }
    protected float forceMultiplier { get; set; }
    protected float forceMovementSpeed { get; set; }
    protected Rigidbody characterRb { get; set; }
    protected Animator characterAnimation { get; set; }
    protected AudioSource characterDamageAudio { get; set; }

    void Start()
    {
        characterRb = GetComponent<Rigidbody>();
        characterAnimation = GetComponent<Animator>();
        characterDamageAudio = GetComponent<AudioSource>();
    }
}
