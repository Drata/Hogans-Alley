using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDie : MonoBehaviour {

    float max, min;
    public float pointsWhenDie;
    public float pointsWhenHit;

    private Animator animator;
    private float timeWhenStart;
    private float waitTime;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
        timeWhenStart = Time.realtimeSinceStartup;
        waitTime = Random.Range(4f, 10f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.realtimeSinceStartup > waitTime + timeWhenStart) {
            animator.SetTrigger("EndNow");
        }
	}

    public void HeColisionado() {
        animator.SetTrigger("EndNow");
    }
}
