using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWarManager : MonoBehaviour
{

    public Texture2D g_fogTexture;
    private Color[] g_colours;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 64 * 64; i++)
        {
            Color c = g_colours[i];
            c.r = c.r * (1f - 0.2f * Time.deltaTime);
            g_colours[i] = c;
        }

        g_fogTexture.SetPixels(g_colours);
        g_fogTexture.Apply();
    }

    private void Initialize()
    {
        g_colours = g_fogTexture.GetPixels();

        for (int i = 0; i < 64 * 64; i++)
        {
            g_colours[i] = Color.white;
        }
    }
}
