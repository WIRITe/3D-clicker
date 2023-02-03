using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject Object;
    public float X;
    public float Y;
    public float Z;

    // Update is called once per frame
    void Update()
    {
        Object.transform.localPosition = new Vector3(X, Y, Z);
    }
}
