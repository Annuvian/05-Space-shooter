using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private void Start()
    {
        Physics2D.IgnoreLayerCollision(0, 9);
    }
}