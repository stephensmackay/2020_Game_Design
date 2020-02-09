using UnityEngine;
using UnityEngine.Events;

public class KeyboardButtons : MonoBehaviour
{
    public UnityEvent enterButtonDown;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            enterButtonDown.Invoke();
        }
        
    }

}
