using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starte : MonoBehaviour
{
    public Text T;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        T.text = PlayerPrefs.GetInt("Points").ToString();
    }
}
