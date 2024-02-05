using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSoul : MonoBehaviour
{
    void Start()
{
ScoringSystem.theScore = 0;
}

    void OnTriggerEnter2D(Collider2D other)
    {
        ScoringSystem.theScore += 1;
        Destroy(gameObject);
    }

}