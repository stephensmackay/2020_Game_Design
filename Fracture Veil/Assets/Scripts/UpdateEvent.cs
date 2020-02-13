using UnityEngine;
using UnityEngine.Events;

public class UpdateEvent : MonoBehaviour
{

    public UnityEvent updateEvent;
    void Update()
    {
        updateEvent.Invoke();
    }
}
