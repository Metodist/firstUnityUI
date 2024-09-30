using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    public Transform eye;

    // Update is called once per frame
    void Update()
    {
        transform.position = eye.position;
        transform.rotation = eye.rotation;
    }
}
