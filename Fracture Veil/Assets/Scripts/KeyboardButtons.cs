using UnityEngine;
using UnityEngine.Events;

public class KeyboardButtons : MonoBehaviour
{
    public UnityEvent enterButtonDown;

    void update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Name");
            enterButtonDown.Invoke();
        }

    }

}
