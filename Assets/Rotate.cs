using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotate = 100;
    private void Update()
    {
        transform.Rotate(0, rotate * Time.deltaTime, 0);
    }
}
