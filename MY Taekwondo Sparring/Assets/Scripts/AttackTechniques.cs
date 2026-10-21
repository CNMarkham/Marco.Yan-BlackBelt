using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTechniques : MonoBehaviour
{
    public GameObject LeftRoundhouse;
    public GameObject RightRoundhouse;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) // Pressed 1
        {
            anim.SetTrigger("hit");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // Pressed 2
        {
            anim.SetTrigger("LJab");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) // Pressed 3
        {
            //Back kick with back leg
            anim.SetTrigger("RBack");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) // Pressed 4
        {
            //flying side kick
            anim.SetTrigger("LFlyKick");
        }
        if (Input.GetKeyDown(KeyCode.F)) // Pressed F
        {
            //Punch with back hand
            //anim.SetTrigger("LJab");
        }

        if (Input.GetMouseButtonDown(0)) // Left click
        {
            anim.SetTrigger("LKick");
            LeftRoundhouse.SetActive(true);
            Invoke("ResetAttacks", 1);
        }
        if (Input.GetMouseButtonDown(1)) // Right click
        {
            anim.SetTrigger("RKick");
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