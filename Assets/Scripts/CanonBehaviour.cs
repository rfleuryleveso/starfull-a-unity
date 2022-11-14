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

    public void Shoot(GameObject target)
    {
        
        GameObject instantiatedObject = Instantiate(projectilePrefab, this.transform);
        // If instantiatedObject is not null, set the initial transform of the project to look at the target
        // when AddRelativeForce is invoked, the projectile will go toward the target
        if (target != null)
        {
            instantiatedObject.transform.LookAt(target.transform);
        }   
    }
}