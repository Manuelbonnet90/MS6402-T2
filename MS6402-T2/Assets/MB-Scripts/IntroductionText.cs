using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroductionText : MonoBehaviour
{

    public string sentences;
    public float letterPause = 0.2f;
    public AudioSource typeSound1;


    public Text storyText;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        typeSound1 = GetComponent<AudioSource>();
        //startTime = Time.time;
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TypeSentence()
    {
        //Debug.Log("Work");
        foreach (char letter in sentences.ToCharArray())
        {

            storyText.text += letter;
            yield return new WaitForSeconds(letterPause);
        }

    }
    public void HowToPlay() 
    {

        animator.SetBool("IsOpen", true);
        StartCoroutine(TypeSentence());
        typeSound1.Play();
    }
}
