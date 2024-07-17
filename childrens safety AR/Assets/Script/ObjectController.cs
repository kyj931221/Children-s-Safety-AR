// 0번 카드 : 빨간불일때 사람은 멈춰있고 차가 지나간다.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private Rigidbody CarRb;
    public int MoveForce = 0;
    //public AudioClip CarAudio;
    public AudioSource CarAudioSource;
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
        //CarAudioSource.clip = CarAudio;
        CarAudioSource.Play();
    }

    private void CarFalse()
    {
        CarMr.gameObject.SetActive(false);
        CarAudioSource.Stop();

    }
    private void Stop()
    {
        CarRb.velocity = Vector3.zero;
        MoveForce = 0;
        CarAudioSource.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("CarFalse");
        if(other.tag == "FalseZone")
        {
            Debug.Log("False False");
            CarFalse();
        }
        Debug.Log("Stop");
        if (other.tag == "StopZone")
        {
            Debug.Log("Stop Stop");
            Stop();
        }
    }
}
