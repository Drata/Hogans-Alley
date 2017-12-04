using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CameraController : MonoBehaviour {

    private Vector3 lastMouse = new Vector3(255, 255, 255);
    public GameObject bullet;
    public float cameraSens = 0.50f;
    public float impulse = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!XRSettings.enabled) {
            CameraMovement();
        }

        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
	}

    void CameraMovement() {
        lastMouse = Input.mousePosition - lastMouse;
        lastMouse = new Vector3(-lastMouse.y * cameraSens, lastMouse.x * cameraSens, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;
    }

    void Shoot() {
        GameObject cloneBullet = Instantiate(bullet, transform.position, transform.rotation);
        BulletHandler script = cloneBullet.GetComponent<BulletHandler>();
        script.Shoot(transform.forward * impulse);
        Destroy(cloneBullet, 3f);
    }
}
