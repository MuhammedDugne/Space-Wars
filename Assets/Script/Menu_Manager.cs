using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Menu_Manager : MonoBehaviour
{
    public TMP_Text _bilgiText;
    GameObject tutuory�l;
    bool aktifse = true;

    private void Start()
    {
        tutuory�l = GameObject.Find("Bilgi");
        tutuory�l.SetActive(false);

    }
    public void oyunaBasla()
    {
        SceneManager.LoadScene(1);
    }
    public void oyunNas�lOynan�r()
    {
        if (!aktifse)
        {
            tutuory�l.SetActive(false);
            aktifse = true;
        }
        else if (aktifse)
        {
            tutuory�l.SetActive(true);
            aktifse = false;
        }

    }

    public void oyundan��k()
    {
        Application.Quit();
    }
}
