  
using UnityEngine;

public abstract class CharacterBase : ScriptableObject
{
    public CharacterController Controller { get; set; }

    protected Vector3 Location;
    protected Vector3 Orientation;
    public float speed = 40f;
    public float orientSpeed = .5f;
    public float gravity = -9.81f;
    public float jumpSpeed = 75f;
    public abstract void Move();
    public abstract void Jump();
    protected Vector3 Position;

}
