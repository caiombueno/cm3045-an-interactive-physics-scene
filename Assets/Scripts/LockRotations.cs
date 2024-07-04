using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get all Rigidbody components in this object and its children

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // Loop through each Rigidbody and lock its X and Z rotations
        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
