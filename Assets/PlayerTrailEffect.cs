using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrailEffect : MonoBehaviour
{
    [SerializeField]private ParticleSystem _trailParticle;

    private void OnCollisionExit2D(Collision2D collision)
    {
    if(collision.gameObject.tag=="surface")
        {
            _trailParticle.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "surface")
        {
            _trailParticle.Play();
        }
    }
}
