using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopBubble : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem[] particles;

    public bool bubbleIsPopping;

    IEnumerator Pop()
    {
        bubbleIsPopping = true;
        //play pop sound!
        foreach (ParticleSystem p in particles)
        {
            p.Play();
        }
        this.gameObject.GetComponent<Renderer>().enabled = false;//set bubble renderer false
        yield return new WaitForSeconds(1);
        foreach (ParticleSystem p in particles)
        {
            p.Stop();
        }
        Destroy(this.gameObject);
        bubbleIsPopping = false;
    }
}
