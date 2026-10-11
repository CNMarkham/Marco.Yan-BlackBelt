using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    public float actionTimer;
    public GameObject blockLeftArm;
    public GameObject blockRightArm;
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
        int choice = Random.Range(0, 5); // Picks a random number from 0 to 4
        if(choice == 0) // Block if the random number landed on 0
        {
            blockLeftArm.SetActive(true);
            blockRightArm.SetActive(true);
            Invoke("ResetMoves", 1);
        }
        if(choice == 1) // Punch with any hand
        {
            //Punch
        }
        if(choice == 2)
        {
            //Step back
        }
        if (choice == 3) // Roundhouse kick with back leg
        {
            //Roundhouse kick
        }
        if (choice == 4) // Back kick
        {
            //Back kick
        }

    }
    void ResetMoves()
    {
        blockLeftArm.SetActive(false);
        blockRightArm.SetActive(false);
    }
}
