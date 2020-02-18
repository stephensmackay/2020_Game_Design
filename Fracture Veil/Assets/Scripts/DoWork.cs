using UnityEngine;
using UnityEngine.Events;

public abstract class DoWork : ScriptableObject
{
    public NameID nameIDObj { get; set; }
    public UnityEvent workEvent;
    public abstract void Work();
}
