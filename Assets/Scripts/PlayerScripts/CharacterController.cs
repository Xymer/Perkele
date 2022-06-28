using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody playerBody = null;
    private void Awake()
    {
        playerBody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Jump()
    {
        playerBody.AddForce(0, 100, 0);
    }
    public void Move(InputAction.CallbackContext context)
    {

        Vector2 moveVector = context.ReadValue<Vector2>();
        Debug.Log(moveVector);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
