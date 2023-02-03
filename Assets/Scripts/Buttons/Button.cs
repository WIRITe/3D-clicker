using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool needToBePressed;

    public GameObject MainOfButton;

    public GameObject Canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (needToBePressed == true)
            {
                needToBePressed = false;
                Canvas.SetActive(false);
                MainOfButton.GetComponent<MainButton>().pressed = true;
            }
        }
    }

    private void Update()
    {
        if (needToBePressed == true)
        {
            Canvas.SetActive(true);
        }
    }

    void OnGUI()
    {
        if (needToBePressed)
        {
            GUI.Label(new Rect(), "Press here!!!");
        }
    }
}
