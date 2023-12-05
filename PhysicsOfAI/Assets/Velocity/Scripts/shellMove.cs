using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellMove : MonoBehaviour
{
    float speed = 1.0f;
    void Update()
    {
        this.transform.Translate(0, (Time.deltaTime * speed)/2.0f, Time.deltaTime * speed);
    }
}
