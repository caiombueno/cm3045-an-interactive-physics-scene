using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyPropertiesChanger : MonoBehaviour
{
    public float newMass = 1.0f;
    public float newDrag = 0.5f;
    public float newAngularDrag = 0.05f;

    public bool useGravity = false;

    void Start()
    {
        // Get all Rigidbody components in this object and its children
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        // Loop through each Rigidbody and change its properties
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.mass = newMass;
            rb.drag = newDrag;
            rb.angularDrag = newAngularDrag;
            rb.useGravity = useGravity;
        }
    }
}

