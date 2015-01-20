using UnityEngine;
using System.Collections;

public class enmeyRotateTurret : baseRotateTurret
{
    public Transform player;
	
	// Update is called once per frame
	override protected void Update () {
        if (player != null)
        {
            targetPos = player.position + Vector3.up * 0.8f;
            base.Update();
        }
	}
}
