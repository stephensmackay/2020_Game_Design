using UnityEngine;

public class DoorBehaviorScript : MonoBehaviour
{

    public bool canOpen = false;

    public Collections list;
    public void OpenDoor(Collectible obj)
    {
        if (list.collectablesList.Contains(obj))
        {
            canOpen = true;
            Debug.Log("can open");

        }
        else
        {
            Debug.Log("You must obtain Key 1 Before proceeding");
        }
    }

    public void DisableDoor(GameObject obj)
    {
        if (canOpen == true)
        {
            obj.SetActive(false);
            Debug.Log("opening door");
        }
        else
        {
            Debug.Log("Door Locked");
            return;
        }
    }
}
