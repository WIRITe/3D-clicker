using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiButtons : MonoBehaviour
{
    public GameObject p;
    public GameObject Player;

    public void ReturnButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Player.GetComponent<PlayerRotation>().lookSpeed = 1;
        p.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
