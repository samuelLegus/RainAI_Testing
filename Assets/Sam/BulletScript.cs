using UnityEngine;
using System.Collections;


//All motion of the bullet is controlled by rigidbody.
//Bullets need to be contained in a "Projectiles" physics layer , and the physics later needs to be setup so that the projectiles 
//do not collide with themselves.

[RequireComponent(typeof(Rigidbody))]
public class BulletScript : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, 7);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void OnCollisionEnter(Collision col)
	{
		Destroy(gameObject);
	}
}
