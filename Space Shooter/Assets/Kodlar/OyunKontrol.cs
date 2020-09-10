using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    int score;
    public GameObject Meteor;
    public Vector3 randomPos;
    public Text text;
    public Text oyunBittiText;
    public Text yenidenBaslaText;
    bool oyunBittiKontrol = false;
    bool yenidenBaslaKontrol = false;

    void Start()
    {
      
        score = 0;
        text.text = "score =" + score;
        StartCoroutine (Olustur());

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && yenidenBaslaKontrol)
        {
            SceneManager.LoadScene("level1");
        }
    }
    IEnumerator Olustur()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for (int i = 0; i < 10; i++) {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x,randomPos.x), 0, randomPos.z);
                Instantiate(Meteor, vec, Quaternion.identity);
                yield return new WaitForSeconds(3);
                if (oyunBittiKontrol)
                {

                    break;
                }
            }
            yield return new WaitForSeconds(4);
            if (oyunBittiKontrol)
            {
                yenidenBaslaText.text = ("Yeniden Başlamak İçin R Tuşuna Basın");
                yenidenBaslaKontrol = true;
                break;
            }
        }
    }
  public void ScoreArttir(int gelenScore)
    {
        score += gelenScore;
        text.text = "score =" + score;

    }
    public void OyunBitir()
    {
        oyunBittiText.text = ("OYUN BİTTİ");
        oyunBittiKontrol = true;
    }
}
