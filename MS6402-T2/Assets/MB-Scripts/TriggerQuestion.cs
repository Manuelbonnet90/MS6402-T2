using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerQuestion : MonoBehaviour
{
    public GameObject Question;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Question.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Question.SetActive(true);
    }
}
