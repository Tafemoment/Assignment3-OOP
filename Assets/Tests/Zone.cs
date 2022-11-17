using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Polymorphism / inheritance
//Zone --> WinZone 
//     --> LoseZone
//     --> PowerUp

//Abstract means, we cant create a instance/component of this class
public abstract class Zone : MonoBehaviour
{
    //Code for this function is written in child/derived classes
    protected abstract void ZoneTrigger(GameObject Marble);

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Marble")
        {
            ZoneTrigger(other.gameObject);
        }
    }

    protected bool isDeactivating = false;

    protected IEnumerator DisableWithDelay(GameObject go, float delay, float returnDelay)
    {
        isDeactivating = true;

        float timer = 0;
        while (timer<delay)
        {
            timer += Time.deltaTime;
            yield return null;
        }
        go.SetActive(false);

        yield return new WaitForSeconds(returnDelay);
        go.SetActive(true);

        isDeactivating = false;
    }

    protected IEnumerator DisableWithDelay(GameObject go, float delay = 1f)
    {
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }
}