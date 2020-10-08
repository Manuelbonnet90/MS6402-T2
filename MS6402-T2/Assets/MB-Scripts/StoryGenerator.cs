using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryGenerator : MonoBehaviour
{
    public Text storyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TypeSentence (string sentence)
    {
        storyText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            storyText.text += letter;
            yield return 1;
        }
     
    }
}
