using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> toSpawn;
    public float time = 0.5f;
    public bool canSpawn,spawnEnemys=false,spawnPlayer=false;
    public bool canSSaber=true, canSCaster=true, canSAlchemist=true,canSShield=true;
    private void Start()
    
    {
        if (canSpawn)
        {
         StartCoroutine(Spawn(time));
        }
    }
    public void GenerateCaster()
    {
        if (canSCaster)
        {
          Instantiate(toSpawn[1],transform.position,Quaternion.identity);
            canSCaster = false;
            StartCoroutine(Toggle( 1.5f,2));
        }
    }
    public void GenerateSaber()
    {
        if (canSSaber)
        {
          Instantiate(toSpawn[0], transform.position, Quaternion.identity);
            canSSaber = false;
            StartCoroutine(Toggle( 1f,1));
        }
    }
    public void GenerateAlchemist()
    {
        if (canSAlchemist)
        {
          Instantiate(toSpawn[2], transform.position, Quaternion.identity);
            canSAlchemist = false;
        StartCoroutine(Toggle(1.5f,3));
        }
    }
    public void GenerateShield()
    {
        if (canSShield)
        {
            Instantiate(toSpawn[3], transform.position, Quaternion.identity);
            canSShield = false;
            StartCoroutine(Toggle(2f, 4));
        }
    }
    IEnumerator Spawn(float timeToSpawn)
    {
        while(canSpawn)
        {
            if (spawnEnemys)
            {
                int range = Random.Range(0, toSpawn.Count);
                 Instantiate(toSpawn[range], transform.position, Quaternion.identity);
            }
            if (spawnPlayer)
            {
                int range = Random.Range(0, toSpawn.Count);
                 Instantiate(toSpawn[range], transform.position, Quaternion.identity);
            }
            yield return new WaitForSecondsRealtime(timeToSpawn);
        }   
        yield break;
    }
    IEnumerator Toggle( float timeToggle,int index)
    {
        
        yield return new WaitForSecondsRealtime(timeToggle);
        switch (index)
        {
            case 1:canSSaber = true;break;
            case 2:canSCaster = true; break;
            case 3:canSAlchemist = true; break;
            case 4:canSShield = true;break;

            default: Debug.Log("error en switch de corrutina toggle, se ha ingresado un index incorrecto");
                break;
        }
        yield break;
    }
}
