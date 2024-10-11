using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour, IMovement

{
    public float speed = 5f;

    public void Move(Vector2 direction)
    {
        Vector3 move = new Vector3(direction.x, 0, direction.y);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
