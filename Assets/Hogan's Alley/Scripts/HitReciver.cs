using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitReciver : MonoBehaviour
{
    public PersonDie personScript;

    // Called when the player ray hits this object
    public void OnRayHit()
    {
        personScript.HeColisionado();
        return;
    }
}