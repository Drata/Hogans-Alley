using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CameraController : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip audioClipShoot;
    public float cameraSens = 0.50f;

    private SteamVR_TrackedObject trackedObject;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObject.index); }
    }

    private void Awake()
    {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {

        if (Controller.GetHairTriggerDown())
        {
            Shoot();
        }

    }

    void Shoot() {

        audioSource.PlayOneShot(audioClipShoot);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {

            if (hit.collider != null)
            {
                // Find the hit reciver (if existant) and call the method
                var hitReciver = hit.collider.gameObject.GetComponent<HitReciver>();
                if (hitReciver != null)
                {
                    hitReciver.OnRayHit();
                }
            }
        }

    }
}
