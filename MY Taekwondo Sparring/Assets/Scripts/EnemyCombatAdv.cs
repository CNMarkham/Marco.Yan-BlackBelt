using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatAdv : MonoBehaviour
{
    public float actionTimer;
    public GameObject blockArms;
    public GameObject player; //Reference to the player so the enemy knows about the player

    // Start is called before the first frame update
    void Start()
    {
        actionTimer = 5;
    }

    // Update is called once per frame
    void Update()
    {
        actionTimer -= Time.deltaTime; // Constantly reduces the actionTimer value

        if(actionTimer <= 0) // Random System to decide the Enemy's next action when the action timer reaches 0
        {
            Action();
        }


    }

    public void Action()
    {
        actionTimer = 5; // Reset action timer back to 5
        if(Vector3.Distance(player.transform.position, transform.position) < 5 ) // Opponent has more options the closer the target
        {
            int choice = Random.Range(0, 6); // Picks a random number from 0 to 5
            if (choice == 0) // Block if the random number landed on 0
            {
                blockArms.SetActive(true);
            }
            if (choice == 1) // Attacks if the number landed on 1
            {
                //Punch
            }
            if (choice == 2)
            {
                //Slide back
            }
            if (choice == 3)
            {
                //Reverse hook kick
            }
            if (choice == 4)
            {
                //Back kick
            }
            if (choice == 5)
            {
                //Fading Roundhouse kick
            }
        }
        else if(Vector3.Distance(player.transform.position, transform.position) > 5) // fewer options the further target is
        {
            int choice = Random.Range(0, 3); // Picks a random number from 0 to 2
            if (choice == 0) 
            {
                //Step forward
            }
            if (choice == 1) 
            {
                //Slide roundhouse kick forward
            }
            if (choice == 2)
            {
                //Cut kick
            }


        }

    }
}
