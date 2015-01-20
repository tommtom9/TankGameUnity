using UnityEngine;
using System.Collections;

public class rotateTurret : baseRotateTurret 
{
    public float rotationSpeedTurret = 0.8f;

    public Camera cam;


    // Update is called once per frame
    override protected void  Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = cam.transform.position.y - turret.transform.position.y;

        Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);

        targetPos = worldPos;
        base.Update();

    }
}