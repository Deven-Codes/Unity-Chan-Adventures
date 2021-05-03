using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public float rotateSpeed = 2f;

    private void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.timeScale, 0f, Space.World);
    }
}
