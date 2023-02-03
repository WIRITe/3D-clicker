using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontFall : MonoBehaviour
{
    public Transform Pos;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = Pos.position;
    }
}
