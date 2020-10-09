using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story1 : MonoBehaviour
{
    public GameObject goQ1;
    public GameObject goQ2;
    public GameObject goQ3;

    public GameObject goPC;

    public bool blFinalDoor = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goQ1==null && goQ2==null && goQ3 == null)
        {
            if(blFinalDoor == true)
            {
                GM.Victory = true;
            }
            if (!blFinalDoor)
            {
                Camera.main.transform.position = new Vector3(0, 10, -10);
                goPC.transform.position = new Vector3(-0.2f, 10, 0);
            }
            GM.Timer += 10;
            Destroy(gameObject);
        }
    }

    
}
