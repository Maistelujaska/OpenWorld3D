using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics.IgnoreLayerCollision(11, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
