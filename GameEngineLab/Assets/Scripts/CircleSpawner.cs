using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircleSpawner : MonoBehaviour
{
    public float spawnDelay = 2.0f;
    public float repeatRate = 2.0f;
    // Varables for target spawning cycles

    public Vector3 randomPos;
    // Setting up a Vector3 to be used for random position generation in the Game Manager
    public abstract TargetClick Spawn();
   
}
