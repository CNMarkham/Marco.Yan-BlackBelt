using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefereeCalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Set each round timer to 90 seconds
        //Set each rest timer to 60 seconds
    }

    // Update is called once per frame
    void Update()
    {
        //Check for fighter with the most round victories at end of match to decide winner
        //Constantly follow player and bot at the side
        //If player or bot is touching the outline, stop the match and give gam-jeom, 1 point to person that didn’t step out of bounds
        //If player or bot hits each other in the head with punch, stop match and give gam-jeom, 1 point to person that got hit in the head
        //If player or bot falls, stop the match and give gam-jeom, 1 point to person that didn’t fall
        //If player or bot achieves 5 gam - jeoms in 1 round, end round and give opposing person 1 round win
        //If player or bot achieves 10 gam - jeoms in 1 match, automatically disqualify them
        //When timer ends, referee announce fighter with most points as the winner
        //When round starts, also start round timer
        //When round ends, start rest timer
        //When rest timer ends, bring back fighters to competition area and start round timer
    }
}
