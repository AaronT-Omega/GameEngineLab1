using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCircleSpawn : CircleSpawner
{
    public GameObject orangeTarget; // Gets the prefab for the Orange Target

    private void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, repeatRate); //Sets it up so that it keeps creating targets within a certain timeframe
    }

    public override TargetClick Spawn()
    {
        GameObject spawnTarget = Instantiate(orangeTarget, randomPos, Quaternion.identity); //Creates the actual target at a random position
        return spawnTarget.GetComponent<TargetClick>();
    }
}
