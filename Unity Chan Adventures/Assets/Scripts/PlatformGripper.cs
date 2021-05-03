using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;

    void OnTriggerEnter()
    
    {
        // setting the PlatformGrip parent of the player 
        thePlayer.transform.parent = theLedge.transform;    
    }

    void OnTriggerExit()
    {
        // setting the parent of the player to null
        thePlayer.transform.parent = null;
    }
}
