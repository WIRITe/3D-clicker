using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountOfPoints : MonoBehaviour
{
    public GameObject Button;

    public int count;

    public Text textt;

    // Update is called once per frame
    void FixedUpdate()
    {
        count = Button.GetComponent<MainButton>().count;
        textt.text = count.ToString();
    }
}
