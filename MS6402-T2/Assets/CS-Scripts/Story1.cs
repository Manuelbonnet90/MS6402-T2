﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story1 : MonoBehaviour
{
    public GameObject goQ1;
    public GameObject goQ2;
    public GameObject goQ3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goQ1==null && goQ2==null && goQ3 == null)
        {
            Destroy(gameObject);
        }
    }

    
}
