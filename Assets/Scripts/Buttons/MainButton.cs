using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    public bool pressed;

    public int count = 0;
    public int nextButton;

    public GameObject Prefs;
    public GameObject Prefs1;
    public GameObject Prefs2;
    public GameObject Player;

    public GameObject Bu1;
    public GameObject Bu2;
    public GameObject Bu3;
    public GameObject Bu4;

    private void Start()
    {
        NewButton();
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && count < 4)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            Player.GetComponent<PlayerRotation>().lookSpeed = 0;
            Prefs2.SetActive(true);
        }

        if(count >= 4)
        {
            Prefs.SetActive(true);
            Prefs1.SetActive(true);
        }
        if (pressed == true)
        {
            NewButton();
            count += 1;
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + 1);
            pressed = false;
        }
    }

    public void NewButton()
    {
        nextButton = Random.Range(1, 5);
        Debug.Log(nextButton);
        if (nextButton == 1)
        {
            Bu1.GetComponent<Button>().needToBePressed = true;
        }
        else if (nextButton == 2)
        {
            Bu2.GetComponent<Button>().needToBePressed = true;
        }
        else if (nextButton == 3)
        {
            Bu3.GetComponent<Button>().needToBePressed = true;
        }
        else if (nextButton == 4)
        {
            Bu4.GetComponent<Button>().needToBePressed = true;
        }
    }
}
