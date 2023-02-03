using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject p;
    public GameObject Player;

    public void Return()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Player.GetComponent<PlayerRotation>().lookSpeed = 1;
        p.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
