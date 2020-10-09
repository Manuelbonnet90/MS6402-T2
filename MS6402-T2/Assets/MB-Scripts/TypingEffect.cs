
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect : MonoBehaviour
{
    public string sentences;
    public float letterPause = 0.2f;
    public AudioSource typeSound1;


    public Text storyText;

    public Text countdownText;
    public float currentTime;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

        typeSound1 = GetComponent<AudioSource>();
        //startTime = Time.time;
        animator = GetComponent<Animator>();
        animator.SetBool("IsOpen", true);

        typeSound1.Play();

        StartCoroutine(TypeSentence());

        
    }
    private void Update()
    {
        TimerMenu();
    }
    IEnumerator TypeSentence ()
    {
        //Debug.Log("Work");
        foreach(char letter in sentences.ToCharArray())
        {
            
            storyText.text += letter;
            yield return new WaitForSeconds(letterPause);
        }
     
    }

    void TimerMenu()
    {
        countdownText.GetComponent<Text>().enabled = true; // turn on the timer
        currentTime -= 1 * Time.deltaTime; // create a countdown for the shotgun pick up, each pick is 10 second.
        countdownText.text = currentTime.ToString("0"); // only display two numbers from the countdown.
        if (currentTime <= 0)
        {
            countdownText.GetComponent<Text>().enabled = false;
            animator.SetBool("IsOpen", false);
            GM.StartTime();
            StopAllCoroutines();
        }
    }
}
