using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : Move
{
    public GameObject nextBG;

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        
    }
    private void LateUpdate()
    {
        if (pos.x <= -30) pos.x = nextBG.transform.position.x+30;
    }

}
