using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_FogOfWar : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// Used to store the plane set as FOW
    /// </summary>
    public GameObject g_fogOfWar;

    /// <summary>
    /// Store the player
    /// </summary>
    public Transform g_player;

    public LayerMask g_fogLayer;

    [SerializeField]
    float g_radius = 5f;

    float g_radiusSqr { get { return g_radius * g_radius; } }

    private Mesh g_mesh;
    private Vector3[] g_vertices;
    private Color[] g_colours;

    /// <summary>
    /// Max distance of the raycast
    /// </summary>
    private const int MAXDIST = 1000;

    #endregion

    #region Base Methods
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Custom Methods

    /// <summary>
    /// Used to initialize Fog of War
    /// </summary>
    private void Initialize()
    {
        g_mesh = g_fogOfWar.GetComponent<MeshFilter>().mesh;
        g_vertices = g_mesh.vertices;
        g_colours = new Color[g_vertices.Length];

        for (int i = 0; i < g_colours.Length; i++)
        {
            g_colours[i] = Color.black;
        }
        UpdateColour();
    }

    /// <summary>
    /// Used to update colour of fog of war
    /// </summary>
    private void UpdateColour()
    {
        g_mesh.colors = g_colours;
    }

    /// <summary>
    /// Method used to cast ray setting center of fog of war dispersion
    /// </summary>
    private void Raycasting()
    {
        Ray r = new Ray(transform.position, g_player.position - transform.position);
        RaycastHit hit;
        if (Physics.Raycast(r, out hit, MAXDIST, g_fogLayer, QueryTriggerInteraction.Collide))
        {
            for (int i = 0; i <= g_vertices.Length; i++)
            {
                Vector3 v = g_fogOfWar.transform.TransformPoint(g_vertices[i]);
                float m_dist = Vector3.SqrMagnitude(v - hit.point);

                if (m_dist < g_radiusSqr)
                {
                    //Alpha can not increase because of use of the Min fucntion
                    float m_alpha = Mathf.Min(g_colours[i].a, m_dist / g_radiusSqr);
                    g_colours[i].a = m_alpha;
                }
            }
            UpdateColour();
        }
    }

    #endregion
}
