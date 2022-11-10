using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : Zone
{
    [SerializeField] protected Text _winnerText;
    protected static List<GameObject> _winners;

    protected void Start()
    {
        if (_winners == null)
        {
            _winners = new List<GameObject>();
        }
        _winnerText.text = "";
    }
    protected void DisplayWinningText(string MarbleName)
    {
        _winnerText.text += MarbleName + "\n";
    }

    protected override void ZoneTrigger(GameObject Marble)
    {
        if (!_winners.Contains(Marble))
        {
            _winners.Add(Marble);
        }
        DisplayWinningText(Marble.name);
        //optional
        //Marble.SetActive(false);
        StartCoroutine(DisableWithDelay(Marble));
    }

}