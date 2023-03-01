using UnityEngine.SceneManagement;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _delayToLoadScene = 3;
    [SerializeField] private GameObject _particleSystem;
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
            StartParticleEffect();
            Invoke("ReLoadTheScene", _delayToLoadScene);
        }   
    }

    private void ReLoadTheScene()
    {
        SceneManager.LoadScene("GamePlay");
    }

    private void StartParticleEffect() => _particleSystem.SetActive(true);
}

