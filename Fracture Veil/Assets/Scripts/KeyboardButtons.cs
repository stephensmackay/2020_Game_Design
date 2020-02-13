using UnityEngine;
using UnityEngine.Events;

public class KeyboardButtons : MonoBehaviour
{
    public UnityEvent enterButtonDown, enterButtonDown2, enterButtonDown3, buttonUp3;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            enterButtonDown.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            enterButtonDown2.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            enterButtonDown3.Invoke();
        }
        
        if (Input.GetKeyUp(KeyCode.C))
        {
            buttonUp3.Invoke();
        }
        
    }

}
