using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public GameObject text;
    public float timeToChange = 0.4f;
    private float timeSinceChange = 0f;
    

    // Update is called once per frame
    void Update()
    {
        timeSinceChange += Time.deltaTime;
        if (timeSinceChange > timeToChange)
        {
            text.GetComponent<Text>().color = new Color(Random.value, Random.value, Random.value);
            timeSinceChange = 0f;
        }
    }
}
