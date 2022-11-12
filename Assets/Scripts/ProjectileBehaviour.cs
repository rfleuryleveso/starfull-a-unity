using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroySelfAfterTime(20));
        Rigidbody projectileObjectBody = this.GetComponent<Rigidbody>();
        projectileObjectBody.AddRelativeForce(Vector3.up * 100, ForceMode.Impulse);
    }
    
    IEnumerator DestroySelfAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this);
        yield break; //Is this even needed?
    }

}
