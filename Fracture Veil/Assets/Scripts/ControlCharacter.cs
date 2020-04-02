using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class ControlCharacter : MonoBehaviour
{

    public CharacterController controller;

    public Vector3 Location, Orientation;

    public float speed = 12f, orientSpeed = 4f, gravity = -9.81f, jumpSpeed = 80f;

    public FloatData health;

    public GameObject endGameCanvas;
    
   
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            Location.x = (Input.GetAxis("Vertical")*speed);
            Location.z = 0;
            Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
            controller.transform.Rotate(Orientation);
            Location = controller.transform.TransformDirection(Location);
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Location.y = jumpSpeed;
        }
        
        
        Location.y += gravity;
        
        controller.Move(Location * Time.deltaTime);

        if (health.value <= 0)
        {
            TurnOnAndOff(endGameCanvas);
        }
        else
        {
            return;
        }

        void TurnOnAndOff(GameObject obj)
        {
            obj.SetActive(true);
        }

       
    }
    
    

}
