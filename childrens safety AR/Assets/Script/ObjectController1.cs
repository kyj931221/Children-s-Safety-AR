using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController1 : MonoBehaviour
{
    private Rigidbody ChRb;
    public float MoveForce = 0;
    //public AudioClip ChAudio;
    //private AudioSource ChAudioSource;
    private Animator animator;
    private void Start()
    {
        ChRb = GetComponent<Rigidbody>();
        //ChAudioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        ChRb.velocity = Vector3.zero;
        ChRb.AddForce(new Vector3(0, 0, MoveForce));
        //ChAudioSource.clip = ChAudio;
        //ChAudioSource.Play();
    }


    private void Stop()
    {
        ChRb.velocity = Vector3.zero;
        MoveForce = 0;
        animator.SetTrigger("Completion");
        //ChAudioSource.Stop();

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Stop");
        if (other.tag == "StopZone")
        {
            Debug.Log("Stop Stop");
            Stop();
        }
    }
}
