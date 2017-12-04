using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour {

    private Rigidbody rigidBody;
    private AudioSource audioSource;
    public AudioClip audioClipHit;
    public ParticleSystem ps;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        //ps = transform.FindChild();
    }

    public void Shoot(Vector3 director) {
        Start();
        rigidBody.AddForce(director, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision) {
        ps.Play();
        audioSource.PlayOneShot(audioClipHit);
    }
}
