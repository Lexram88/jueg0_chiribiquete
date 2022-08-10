using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPos : MonoBehaviour
{
    public Transform tarjet;

    private void Update()
    {
        transform.position = tarjet.position;
    }
}
