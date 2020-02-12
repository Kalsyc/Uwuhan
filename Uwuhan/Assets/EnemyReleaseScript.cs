using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReleaseScript : MonoBehaviour
{
    public GameObject releaseWalls;

    private void OnTriggerEnter(Collider other) 
    {
        Destroy(releaseWalls);
    }
}
