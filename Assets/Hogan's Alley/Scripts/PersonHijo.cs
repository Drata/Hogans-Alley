using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonHijo : MonoBehaviour {

    public PersonDie personScript;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Bullet(Clone)") {
            personScript.HeColisionado();
        }
    }
}
