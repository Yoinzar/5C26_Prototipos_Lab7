using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePlayerController : MonoBehaviour
{
    [SerializeField] protected Rigidbody myRigidBody;

    protected Vector2 _aimPosition;

    protected virtual void Awake()
    {
        Debug.Log("Parent Awake");
    }


    protected virtual void Start()
    {
        Debug.Log("Parent Start");

        if (myRigidBody == null)
        {
            myRigidBody = GetComponent<Rigidbody>();
        }
    }
}
