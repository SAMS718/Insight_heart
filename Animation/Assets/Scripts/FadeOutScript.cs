using System.Collections;
using UnityEngine;

public class FadeOutScript : MonoBehaviour
{
    private Renderer rend;
    private Material mat;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend != null)
        {
            mat = rend.material;
            // Ensure the shader supports transparency
            mat.SetFloat("_Mode", 2); // Use Transparent mode
            mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            mat.SetInt("_ZWrite", 0);
            mat.DisableKeyword("_ALPHATEST_ON");
            mat.EnableKeyword("_ALPHABLEND_ON");
            mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            mat.renderQueue = 3000;
        }
    }

    IEnumerator FadeIn()
    {
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            if (mat != null)
            {
                Color c = mat.color;
                c.a = f;
                mat.color = c;
            }
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        StartCoroutine(FadeIn());
    }
}
