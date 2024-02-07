using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Game_Manager : MonoBehaviour
{
    public GameObject _astroid;
    public Vector3 _randomPos;
    public TMP_Text _scoreText;
    public TMP_Text _oyunBittiText;
    public TMP_Text _yenidenBaslaText;
    public TMP_Text _anamenuD�nText;

    int score ;

    bool oyunBittiKontrol=false;
    bool yenidenBaslaKontorl = false;
    void Start()
    {
       
        _scoreText.text = "Score : 0";
        score = 0;
        StartCoroutine(olustur());

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && yenidenBaslaKontorl)
        {
            Debug.Log("r bas�ld�");
            print("R BASILD");
            SceneManager.LoadScene(1);
        }

       else if(Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(0);

        }
    }


    IEnumerator olustur()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-_randomPos.x, _randomPos.x), 0, _randomPos.z);
                Instantiate(_astroid, vec, Quaternion.identity);

                yield return new WaitForSeconds(2);
                if (oyunBittiKontrol)
                {
                    _yenidenBaslaText.text = "Yeniden Ba�lamk i�n 'R' ye bas�n";
                    _anamenuD�nText.text="Anamen�ye d�nmek i�in 'G' tu�una Bas�n";
                    yenidenBaslaKontorl = true;
                    break;
                }


            }

            if (oyunBittiKontrol)
            {
                
                break;
            }

        }
       

        
    }


    public void scorArtt�r(int gelenSkore)
    {
        score += gelenSkore;
        _scoreText.text = "Score : " + score;
    }



   public void gameOver()
    {
        oyunBittiKontrol = true;

        _oyunBittiText.text = "Game Over";
    }
}
