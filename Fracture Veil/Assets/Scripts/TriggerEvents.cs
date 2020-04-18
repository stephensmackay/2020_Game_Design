using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;
    public float holdTime = 3f;
    public WaitForSeconds waitObj;

    private void Awake()
    {
        waitObj = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        yield return waitObj; 
        triggerExitEvent.Invoke();
    }
}
