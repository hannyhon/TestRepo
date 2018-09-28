using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckQuacker : MonoBehaviour
{
    public AudioSource myAudioSource;

    public float pitch = 1f;
    public float sizeScalar = 1f;

	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        myAudioSource.pitch = pitch;
            transform.localScale = new Vector2(sizeScalar, sizeScalar);

	        pitch = pitch + 0.1f;
            sizeScalar = sizeScalar - 0.1f;

            myAudioSource.Play();
        }
	}
}
