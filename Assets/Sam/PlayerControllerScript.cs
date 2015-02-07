using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour 
{
	public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () 
	{

		Vector3 movement = new Vector3(0F, 0F, 0F);

		if(Input.GetKey (KeyCode.W))
		{
			movement.z = speed;
		}
		if(Input.GetKey (KeyCode.S))
		{
			movement.z = speed * -1;
		}
		if(Input.GetKey (KeyCode.A))
		{
			movement.x = speed * -1;
		}
		if(Input.GetKey (KeyCode.D))
		{
			movement.x = speed;
		}


		transform.Translate (movement * Time.deltaTime);

	}
}
