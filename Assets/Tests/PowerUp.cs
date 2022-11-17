using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : Zone
{
    protected abstract void PowerUpActivate(GameObject Marble);
    protected override void ZoneTrigger(GameObject Marble)
    {
        if (!isDeactivating)
        {
            StartCoroutine(DisableWithDelay(gameObject, 0.2f, 2f));
        }
        PowerUpActivate(Marble);
    }
}
