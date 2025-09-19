using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircleSpawner : MonoBehaviour
{
    public float spawnDelay = 2.0f;
    public float repeatRate = 2.0f;

    public Vector3 randomPos;
    public abstract TargetClick Spawn();
   
}
