using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiiEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem skii;
        void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.tag=="Ground")
            {
               skii.Play();
            }
        }
        void OnCollisionExit2D(Collision2D other) {
            if (other.gameObject.tag=="Ground")
            {
                skii.Stop();
            }
        }
    }

