using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoaquinPlayer : BasePlayerController, IAimable, IMoveable, IAttackable
{
    private float velocity = 5;
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform firePoint;

    public Vector2 Position
    {
        get
        {
            return _aimPosition;
        }

        set
        {
            _aimPosition = value;
            Debug.Log("Aim from " + this.name);
        }
    }

    protected override void Awake()
    {
        base.Awake();
        Debug.Log("Child Awake");
    }

    protected override void Start()
    {
        base.Start();
        Debug.Log("Child Start");
    }

    public void Move(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            Vector3 movement = new Vector3(direction.x, 0, direction.y) * velocity;
            myRigidBody.velocity = movement;
        }
        else
        {
            myRigidBody.velocity = Vector2.zero;
        }
    }

    public void Attack(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(position.x, position.y, 0));

        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            Vector3 spawnPoint = hitInfo.point;
            Quaternion rotation = Quaternion.LookRotation(firePoint.forward);
            Instantiate(projectilePrefab, spawnPoint, rotation, firePoint);
        }
    }


}
