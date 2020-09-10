using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorTemasYokEt : MonoBehaviour
{

    public GameObject playerPatlama;
    public GameObject patlama;

    GameObject OyunKontrol;
    OyunKontrol kontrol;

    void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkont");
        kontrol = OyunKontrol.GetComponent<OyunKontrol> ();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag !="zemin")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.ScoreArttir (10);

        }
        if (other.tag == "Player")
        {
            Instantiate(playerPatlama,other.transform.position,other.transform.rotation);
            kontrol.OyunBitir();
        }
       
    }
}
