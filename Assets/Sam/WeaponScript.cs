using UnityEngine;
using System.Collections;
using System;

public class WeaponScript : MonoBehaviour 
{
	public Transform _LaunchPoint;
	public Transform _Target;
	public GameObject _BulletPrefab;
	public float _LaunchSpeed;
	

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Fire()
	{
		//transform.LookAt (_Target);
		GameObject bullet = Instantiate (_BulletPrefab, _LaunchPoint.position, _LaunchPoint.rotation) as GameObject;
		if(bullet.rigidbody != null)
		{
			bullet.rigidbody.AddForce ( transform.forward * _LaunchSpeed, ForceMode.Impulse);
		}
	}
}
