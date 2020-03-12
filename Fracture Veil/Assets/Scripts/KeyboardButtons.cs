using UnityEngine;
using UnityEngine.Events;

public class KeyboardButtons : MonoBehaviour
{
    public UnityEvent enterButtonDown, enterButtonDown2, enterButtonDown3, buttonUp3;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            enterButtonDown.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            enterButtonDown2.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            enterButtonDown3.Invoke();
        }
        
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            buttonUp3.Invoke();
        }
        
    }

}
