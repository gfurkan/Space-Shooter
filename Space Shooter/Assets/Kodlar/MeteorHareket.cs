using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorHareket : MonoBehaviour
{
    Rigidbody fizik;
    public int meteorhizi;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward*meteorhizi;
    }

}