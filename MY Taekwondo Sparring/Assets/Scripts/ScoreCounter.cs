using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If player uses roundhouse kick and hits on chest guard “sensor spot”, award 2 points
        //If player uses roundhouse kick and hits on head gear, award 3 points
        //If player uses punch / jab and hits on chest guard “sensor spot”, award 1 point
        //If player uses reverse hook kick, back kick, or tornado kick and hits on chest guard “sensor spot”, award 4 points
        //If player uses reverse hook kick, back kick, or tornado kick and hits on head gear, award 6 points
    }
}
