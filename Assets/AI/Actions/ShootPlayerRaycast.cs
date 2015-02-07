using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;
using System;

[RAINAction]
public class ShootPlayerRaycast : RAINAction
{
	/// <summary>
	/// This RAINAction will cast a ray to the target (obtained from its memory), and deal damage on a set interval.
	/// </summary>

	#region Variables

	private GameObject _target;
	private int _damage = 10;

	#endregion

	#region Events

    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		_target = ai.WorkingMemory.GetItem<GameObject>("sightedPlayer");	
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		Vector3 _toTarget = Vector3.Normalize (_target.transform.position - ai.Body.transform.position);

		Debug.DrawRay (ai.Body.transform.position, _toTarget * ai.WorkingMemory.GetItem<int>("maxFiringRange"));

		RaycastHit hit;
		if(Physics.Raycast (ai.Body.transform.position, _toTarget, out hit, ai.WorkingMemory.GetItem<int>("maxFiringRange")))
		{
			if(_target.GetComponent<PlayerHealth>() != null)
			{
				_target.GetComponent<PlayerHealth>().ApplyDamage (_damage);
			}
			else
			{
				Debug.Log ("Warning! Player health component not found, are you _target was assigned to the player?");
			}
		}
		
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }

	#endregion
}