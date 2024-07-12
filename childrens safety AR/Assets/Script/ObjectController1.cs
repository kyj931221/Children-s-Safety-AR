using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController1 : MonoBehaviour
{
    private Rigidbody CarRb;
    public int MoveForce = 0;
    public AudioClip CarAudio;
    private AudioSource CarAudioSource;
    private void Start()
    {
        CarRb = GetComponent<Rigidbody>();
        CarAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        CarRb.velocity = Vector3.zero;
        CarRb.AddForce(new Vector3(MoveForce, 0, 0));
        CarAudioSource.clip = CarAudio;
        CarAudioSource.Play();
    }


    private void Stop()
    {
        CarRb.velocity = Vector3.zero;
        MoveForce = 0;
        CarAudioSource.Stop();

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
