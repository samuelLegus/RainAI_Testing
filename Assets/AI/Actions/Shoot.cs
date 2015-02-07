using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Shoot : RAINAction
{
	private WeaponScript _weaponScript;
	private GameObject _sightedPlayer;

    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		_weaponScript = ai.Body.GetComponent<WeaponScript>(); //Retrieve the weapon script from our AI's Unity GameObject
	}

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		_sightedPlayer = ai.WorkingMemory.GetItem<GameObject>("sightedPlayer");
		if(_sightedPlayer != null)
		{
			_weaponScript._Target = _sightedPlayer.transform;
			//Debug.DrawRay ( ai.Body.transform.position, 
			_weaponScript.Fire ();
		}
		return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}