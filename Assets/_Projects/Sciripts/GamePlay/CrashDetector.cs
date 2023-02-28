
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.tag=="surface")
    {
        Debug.Log("Collided on surface");
    }
    }
}
