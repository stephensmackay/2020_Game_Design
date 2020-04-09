using UnityEngine;
using UnityEngine.Events;

public class StartBehaviors : MonoBehaviour
{
    public UnityEvent startEvent;
    public UnityEvent updateEvent;
    void Start()
    {
        startEvent.Invoke();
    }

    private void Update()
    {
        if (BoolData.oneActive == true && BoolData.twoActive == true && BoolData.threeActive == true && BoolData.fourActive == true)
        {
            BoolData.allActive = true;
        }
        else
        {
            return;
        }
        
        if (BoolData.allActive == true)
        {
            updateEvent.Invoke();    
        }
        else
        {
            return;
        }
        
    }
}
