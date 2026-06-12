using UnityEngine;

public class Controller : MonoBehaviour
{
    private void Start()
    {
        var a = 1;
        var b = 2;
        var c = a + b;
        
        Debug.Log($"Result: {c}");
    }
}
