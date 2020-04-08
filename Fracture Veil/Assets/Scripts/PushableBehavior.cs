using System;
using UnityEngine;

public class PushableBehavior : MonoBehaviour
{
    public bool inPushRange = false;
    public bool buttonPushed = false; 
    public bool beingPushed = false;
    public GameObject player;
    
    public void PushOrStop(GameObject player)
    {
        if (inPushRange == true && buttonPushed == true && beingPushed == false)
        {
            transform.parent = player.transform;
            beingPushed = true;
            Debug.Log("push");
        }
        else if (beingPushed == true && buttonPushed == true)
        {
            transform.parent = null;
            beingPushed = false;
        }
        else
        {
            return;
        }
    }

    public void EnterRange()
    {
        inPushRange = true;
    }

    public void ExitRange()
    {
        inPushRange = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (inPushRange == true && beingPushed == false)
            {
                buttonPushed = true;
                PushOrStop(player);
                buttonPushed = false;
            }
            else if (inPushRange == true && beingPushed == true)
            {
                buttonPushed = true;
                PushOrStop(player);
                buttonPushed = false;
            }
            else
            {
                buttonPushed = false;
                return;
            }
        }
    }
}
