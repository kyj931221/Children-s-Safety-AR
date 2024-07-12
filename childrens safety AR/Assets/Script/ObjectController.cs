// 0번 카드 : 빨간불일때 사람은 멈춰있고 차가 지나간다.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private Rigidbody CarRb;
    public int MoveForce = 0;
    public AudioClip CarAudio;
    private AudioSource CarAudioSource;
    private MeshRenderer CarMr;

    private void Start()
    {
        CarRb = GetComponent<Rigidbody>();
        CarAudioSource = GetComponent<AudioSource>();
        CarMr = GetComponent<MeshRenderer>();
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
        CarMr.gameObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Stop");
        if(other.tag == "StopZone")
        {
            Debug.Log("Stop Stop");
            Stop();
        }
    }
}
