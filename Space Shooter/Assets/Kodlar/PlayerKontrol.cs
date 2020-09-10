using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKontrol : MonoBehaviour
{
    public int hiz;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;

    Rigidbody fizik;

    public float minX;
    public float minZ;
    public float maxX;
    public float maxZ;

    public int egim;

    float atesSuresi=0;
    public float atesGecenSure;

    public GameObject Kursun;
    public Transform KursunCikisNoktasi;

    AudioSource Audio;
        
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        Audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time>atesSuresi)
        {
            atesSuresi = Time.time + atesGecenSure;
            Instantiate(Kursun, KursunCikisNoktasi.position, Quaternion.identity);
            Audio.Play();
        }
    }
        void FixedUpdate()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            vec = new Vector3(horizontal, 0, vertical);
            fizik.velocity = vec * hiz;

            fizik.position = new Vector3(Mathf.Clamp(fizik.position.x, minX, maxX), 0.0f, Mathf.Clamp(fizik.position.z, minZ, maxZ));
            fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x * (-egim));
        }
    }
