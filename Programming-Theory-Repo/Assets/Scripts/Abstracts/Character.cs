using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string name { get; private set; }
    public int maxLife { get; private set; }
    protected float forceMultiplier { get; private set; }
    protected float forceMovementSpeed { get; private set; }
    protected float standardRange { get; private set; }
    private Rigidbody characterRb { get; private set; }
    private Animator characterAnimation { get; private set; }
    private AudioSource characterDamageAudio { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        characterRb = GetComponent<Rigidbody>();
        characterAnimation = GetComponent<Animator>();
        characterDamageAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
