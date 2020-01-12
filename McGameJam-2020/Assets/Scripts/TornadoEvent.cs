using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoEvent : MonoBehaviour
{
    [System.Serializable]
    public class SpawnPoint
    {
        public string name;
        public Transform point;
        public GameObject tornado;
        public float init_time;
        public bool isActive = false;
    }

    private GameManager gm;

    public SpawnPoint[] spawnPoints;

    public void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
       foreach (var each_spawnpoint in spawnPoints)
       {
            Debug.Log("isActive" + !each_spawnpoint.isActive);
            Debug.Log("timer" + (gm.g_timer >= each_spawnpoint.init_time) );

            if (!each_spawnpoint.isActive && ( gm.g_timer >= each_spawnpoint.init_time) ){

                Debug.Log("Spawn Tornado");
                each_spawnpoint.isActive = true;
                Instantiate(each_spawnpoint.tornado, each_spawnpoint.point.position, each_spawnpoint.point.rotation);
            }
       }
    }
}
