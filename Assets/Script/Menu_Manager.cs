using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Menu_Manager : MonoBehaviour
{
    public TMP_Text _bilgiText;
    GameObject tutuoryýl;
    bool aktifse = true;

    private void Start()
    {
        tutuoryýl = GameObject.Find("Bilgi");
        tutuoryýl.SetActive(false);

    }
    public void oyunaBasla()
    {
        SceneManager.LoadScene(1);
    }
    public void oyunNasýlOynanýr()
    {
        if (!aktifse)
        {
            tutuoryýl.SetActive(false);
            aktifse = true;
        }
        else if (aktifse)
        {
            tutuoryýl.SetActive(true);
            aktifse = false;
        }

    }

    public void oyundanÇýk()
    {
        Application.Quit();
    }
}
