using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CanonType
{
    Gun,
    Rocket
};

public class CanonBehaviour : MonoBehaviour
{
    [SerializeField] private CanonType canonType;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Rigidbody vesselRigidbody;

    public void Shoot()
    {
        Instantiate(projectilePrefab, this.transform);
    }
}