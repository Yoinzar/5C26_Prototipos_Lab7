using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAttack : MonoBehaviour, IAttack
{
    public GameObject explosionPrefab;
    public Camera mainCamera;

    public void Attack(Vector2 mousePosition)
    {
        Ray ray = mainCamera.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Instantiate(explosionPrefab, hit.point, Quaternion.identity);
        }
    }
}
