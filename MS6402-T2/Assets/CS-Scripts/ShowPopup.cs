using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopup : MonoBehaviour
{
    public GameObject goPlayer;
    public GameObject goPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goPanel != null && goPlayer != null)
        {
            if (Vector2.Distance(goPlayer.transform.position, gameObject.transform.position) < 2)
            {
                goPanel.SetActive(true);
            }
            else
            {
                goPanel.SetActive(false);
            }
        }

    }


}
