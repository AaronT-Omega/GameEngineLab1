using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetClick : MonoBehaviour
{

    public int pointsOnClicked;
    public float targetDecayTime;

    private void Awake()
    {
        Destroy(gameObject, targetDecayTime); // If target is not clicked on within a set amount of time, the target disappears
    }

    void OnMouseDown()
    {
        // If clicked however, it add points to the score through the Game Manager, and destroys the object
        GameManager.Instance.AddPoints(pointsOnClicked);
        Destroy(gameObject);
    }


}
