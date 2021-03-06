﻿using UnityEngine;

public class DoorBehaviorScript : MonoBehaviour
{

    public bool canOpen = false;

    public Collections list;

    public GameObject textCanvas;
    public void OpenDoor(Collectible obj)
    {
        if (list.collectablesList.Contains(obj))
        {
            canOpen = true;
        }
        else
        {
            textCanvas.SetActive(true);
        }
    }

    public void DisableDoor(GameObject obj)
    {
        if (canOpen == true)
        {
            obj.SetActive(false);
        }
        else
        {
            return;
        }
    }
}
