using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [SerializeField] private float moveSpeed;
    private Vector2 axis;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate() {
        Movement();
    }

    void Movement(){
        if (Input.GetKey(upKey)){
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(downKey)){
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }
}
