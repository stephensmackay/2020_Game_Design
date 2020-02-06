using UnityEngine;


public class JumpTest : MonoBehaviour
{

    public CharacterController controller;

    public Vector3 Location, Orientation;

    public float speed = 10f, orientSpeed = 10f, gravity = -9.81f, jumpSpeed = 15f;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            Location = new Vector3(Input.GetAxis("Vertical")*speed,0,0);       
            Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
            controller.transform.Rotate(Orientation);
            Location = controller.transform.TransformDirection(Location);
        }
        //Location.y += gravity;
        
        controller.Move(Location * Time.deltaTime);

        if (Input.GetButton("Jump"))
        {
            Location.y += jumpSpeed;
        }
        else
        {
            Location.y += gravity;
        }
    }

}
