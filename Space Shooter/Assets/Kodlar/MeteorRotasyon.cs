using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorRotasyon : MonoBehaviour
{
    public int hiz;
    Rigidbody fizik;
    private void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere*hiz;
    }
}
