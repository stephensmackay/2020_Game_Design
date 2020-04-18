using UnityEngine;
using UnityEngine.Events;



public class GameActionHandler : MonoBehaviour
{
    public GameAction action;
    public UnityEvent Event;

    private void OnEnable()
    {
        //action.raiseNoArgs += Respond;
    }

    private void Respond()
    {
        Event.Invoke();
    }
}
