using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Vector2 direction;

	public GameObject gameOverText, restartButton, youWinText, objective;

	// Use this for initialization
	void Start () {
		gameOverText.SetActive (false);
		restartButton.SetActive (false);
        objective.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		GetInpu ();
		Move ();

	}

	public void Move ()
	{

		transform.Translate (direction * speed * Time.deltaTime);

	}
	private void GetInpu()
	{
		direction = Vector2.zero;

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
				direction += Vector2.up;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
				direction += Vector2.left;
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
				direction += Vector2.right;
		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
				direction += Vector2.down;
		}
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Enemy")) 
		{

			gameOverText.SetActive (true);
			restartButton.SetActive (true);
            youWinText.SetActive (false);
			gameObject.SetActive (false);
		}


    }
   
}
