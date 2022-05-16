using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploySheep : MonoBehaviour
{
    public GameObject theSheep;
    public float respawnTime;

    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(sheepWave());     
    }

    private void spawnSheep()
    {
        Instantiate(theSheep, transform.position, theSheep.transform.rotation);
    }

    IEnumerator sheepWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnSheep();
        }
    }
}
