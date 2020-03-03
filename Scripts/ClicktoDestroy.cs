using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicktoDestroy : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy (gameObject);

    }
}