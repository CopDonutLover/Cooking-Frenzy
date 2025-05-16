using UnityEngine;

public class OrderEvents : MonoBehaviour
{
    public delegate void OrderComplete();
    public static event OrderComplete OnOrderComplete;
}