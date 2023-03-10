using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _delayToLoadScene=3;
    [SerializeField] private GameObject _particleSystem;
    // Start is called before the first frame update
    [SerializeField] private AudioHandler _audioHandler;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            _audioHandler.PlayFinishSound();
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
