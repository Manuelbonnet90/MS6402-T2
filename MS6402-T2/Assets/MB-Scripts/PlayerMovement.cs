using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    private GameObject mainCamera;
    public GameObject cursor;
    

    Vector2 movement;
    Vector2 mousePos;

    private Vector3 mouseTarget; // used to calculate in the 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = GameObject.Find("Main Camera"); // get the reference of the main camre to be used later
        cursor = GameObject.Find("Cursor"); // find the game object with name cursor

    }

    // Update is called once per frame
    void Update()
    {
        mouseTarget = mainCamera.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y)); // this will get get the position of the mouse inside our Camera
        cursor.transform.position = new Vector2(mouseTarget.x, mouseTarget.y); // transform the position of the mouse inside our camera using the GO cursor.

        movement.x = Input.GetAxisRaw("Horizontal"); // Controls for the player movement
        movement.y = Input.GetAxisRaw("Vertical");
        //transform.Translate(Vector3.forward * moveSpeed * Time.fixedDeltaTime* Input.GetAxis("Vertical"));
        //transform.Translate(Vector3.left * moveSpeed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));

        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // move the player position with rigidbody, plus the movespeed assigned in the variable using a fixer deltatime

        Vector2 lookDir = mousePos - rb.position; // update the player position to face the cursor.
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; // calculate the angle of the object 
        rb.rotation = angle; // rorate the object with based on the angle calculated earlier

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
       
       
    }
  

}
