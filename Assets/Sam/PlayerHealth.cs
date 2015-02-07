using UnityEngine;
using System.Collections;

/// <summary>
/// This script controls the player's health, if the players dies its gameObject becomes inactive
/// this script has one public method "ApplyDamage" which should be accessed by other MonoBehaviours or RAINActions
/// </summary>
public class PlayerHealth : MonoBehaviour
{
	[SerializeField] private int _health = 100;
	[SerializeField] private bool _alive = true;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(_health <= 0)
		{
			_alive = false;
		}
		if(!_alive)
		{
			gameObject.SetActive (false);
		}
	}

	public void ApplyDamage(int damage)
	{
		_health -= damage;
	}
}
