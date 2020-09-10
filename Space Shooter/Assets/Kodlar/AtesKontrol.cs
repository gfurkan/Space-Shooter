using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int ateshizi;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward * ateshizi;
    }
   
    }



