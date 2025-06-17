using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutScript : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer rend;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        
    }

    IEnumerator FadeIn(){
        for(float f = 1f;f>=-0.05f;f-=0.05f){
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading(){
        StartCoroutine("Fade In");
    }
}
