using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathZone : Zone
{
    protected static List<GameObject> _dead;
    protected void Start()
    {
        if (_dead == null)
        {
            _dead = new List<GameObject>();
        }
    }

    protected override void ZoneTrigger(GameObject Marble)
    {

        if (!_dead.Contains(Marble))
        {
            _dead.Add(Marble);
        }
        Marble.SetActive(false);
    }
}
