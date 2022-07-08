using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropper : MonoBehaviour
{
    // Add the variables
    SpriteRenderer Renderer;
    Rigidbody2D rigidBody;
    [SerializeField] float TimeToWait = 30f;
    AudioSource audioData;
	int points = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // Disable at the start of the game
        Renderer = GetComponent<SpriteRenderer>();
        //Invisible at start
        Renderer.enabled = false;
        
        //Audio Component
        audioData = GetComponent<AudioSource>();

        // Rigidbody 2D
        rigidBody = GetComponent<Rigidbody2D>();
        // false means the potential energy is 0
        rigidBody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if (Time.time > TimeToWait)
        {
            //Debug.Log("Seconds Passed : " + TimeToWait); [Redacted]
            
            Renderer.enabled = true;
            rigidBody.isKinematic = false;
        }
    }

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.name.Equals ("Player"))
        {
            Debug.Log ("Ball fell on You!");
            audioData.Play(0);
            points += 100;
            scoreText.text = points.ToString();
        }
	}
}
