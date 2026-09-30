using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float movementSpeed;
    public GameObject opponent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(opponent.transform.position.x, transform.position.y, opponent.transform.position.z));
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.position += transform.forward * vertical * movementSpeed * Time.deltaTime; // forward & backward movement
        transform.position += transform.right * horizontal * movementSpeed * Time.deltaTime; // left and right movement
    }
}
