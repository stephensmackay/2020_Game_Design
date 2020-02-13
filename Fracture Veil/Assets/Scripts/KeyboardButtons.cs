using UnityEngine;
using UnityEngine.Events;

public class KeyboardButtons : MonoBehaviour
{
    public UnityEvent enterButtonDown, enterButtonDown2;


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
        
        
        
    }

}
