using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTechniques : MonoBehaviour
{
    public GameObject LeftRoundhouse;
    public GameObject RightRoundhouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) // Pressed 1
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // Pressed 2
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) // Pressed 3
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) // Pressed 4
        {

        }

        if (Input.GetMouseButtonDown(0)) // Left click
        {
            LeftRoundhouse.SetActive(true);
            Invoke("ResetAttacks", 1);
        }
        if (Input.GetMouseButtonDown(1)) // Right click
        {
            RightRoundhouse.SetActive(true);
            Invoke("ResetAttacks", 1);
        }
    }
    void ResetAttacks()
    {
        LeftRoundhouse.SetActive(false);
        RightRoundhouse.SetActive(false);
    }
}
