using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(menuName = "Actions/Game Action")]
public class GameAction : ScriptableObject
{
    public UnityAction<object> raise;
    public UnityAction<Coroutine> raiseCoroutine;
    public UnityAction raiseNoArgs;
    public object action;

    //Overloading
    public void RaiseAction()
    {
        raiseNoArgs();
    }

    public void RaiseAction(Object obj)
    {
        raise(obj);
    }

    public void RaiseAction(float obj)
    {
        raise(obj);
    }
    
    public void RaiseAction(int obj)
    {
        raise(obj);
    }

    public void RaiseAction(Transform obj)
    {
        raise(obj);
    }

    public void RaiseAction(Coroutine obj)
    {
        raiseCoroutine(obj);
    }
}
