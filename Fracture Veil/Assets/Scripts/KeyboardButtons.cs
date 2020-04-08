using UnityEngine;
using UnityEngine.Events;

public class KeyboardButtons : MonoBehaviour
{
    public UnityEvent enterButtonDown, enterButtonDown2, enterButtonDown3, enterButtonDown4, buttonUp3;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            enterButtonDown.Invoke();
        }
        
        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    enterButtonDown2.Invoke();
        //    Debug.Log("push");
        //}
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            enterButtonDown3.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            enterButtonDown4.Invoke();
        }
        
        if (Input.GetKeyUp(KeyCode.K))
        {
            buttonUp3.Invoke();
        }
        
    }

}
