using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCircleSpawn : CircleSpawner
{
    public GameObject redTarget;
    

    private void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, repeatRate);
    }

    public override TargetClick Spawn()
    {
        GameObject spawnTarget = Instantiate(redTarget, randomPos, Quaternion.identity);
        return spawnTarget.GetComponent<TargetClick>();
    }
}
