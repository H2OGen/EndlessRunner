using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float LeftBoundary = -3.5f;
    public static float RightBoundary = 3.5f;
    public float InternalLeft;
    public float InternalRight;
    void Update()
    {
        InternalLeft = LeftBoundary;
        InternalRight = RightBoundary;
    }
}
