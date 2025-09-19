using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetClick : MonoBehaviour
{

    public int pointsOnClicked;

    void OnMouseDown()
    {
        // Add points to the score manager
        GameManager.Instance.AddPoints(pointsOnClicked);

        // Optional: Destroy the object after clicking
        Destroy(gameObject);
    }


}
