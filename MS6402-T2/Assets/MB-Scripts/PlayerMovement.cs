using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // PC Properties
    private Rigidbody2D RB_PC;
    public float fl_PC_Move_Speed = 3;
    public float fl_PC_Rot_speed = 90;

    // Movement Properties
    public bool bl_mouse_control;
    // Start is called before the first frame update
    void Start()
    {
        // Get the attached RigidBody 2D
        RB_PC = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePC();
        MovePC2();
    }
    void MovePC2()
    {
        // Rotate with H axis    
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * fl_PC_Rot_speed * Time.deltaTime);
        // Move with V axis
        transform.Translate(Vector2.right * fl_PC_Move_Speed * Time.deltaTime * Input.GetAxis("Vertical"));
        // Reset force
        RB_PC.velocity = Vector2.zero;

    }//-----
    void MovePC()
    {
        if (bl_mouse_control)
        {
            // Mouse Movement - check current mouse position compared to the last a move the PC accordingly
            if (Input.mousePosition.y > (Camera.main.WorldToViewportPoint(transform.position).y * Screen.height) + 20) RB_PC.velocity = new Vector2(0, fl_PC_Move_Speed);
            else if (Input.mousePosition.y < (Camera.main.WorldToViewportPoint(transform.position).y * Screen.height) - 20) RB_PC.velocity = new Vector2(0, -fl_PC_Move_Speed);
            else RB_PC.velocity = new Vector2(0, 0);
        }
        else
        {
            // cursor movement - set velocity based on key input
            RB_PC.velocity = new Vector2(Input.GetAxis("Horizontal") * fl_PC_Move_Speed, Input.GetAxis("Vertical") * fl_PC_Move_Speed);
        }

    }//-----
}
