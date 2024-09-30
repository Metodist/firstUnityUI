using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour
{
    public Transform hat;

    // Update is called once per frame
    void Update()
    {
        transform.position = hat.position;
        transform.rotation = hat.rotation;
    }
}
