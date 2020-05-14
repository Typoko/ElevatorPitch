using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class checkpoints : MonoBehaviour {

    //public static Vector3[] v3_cp_spots = new Vector3[10];
    //public static GameObject[] go_checkpoints = new GameObject[10];
    public static List<Vector3> v3_cpSpots = new List<Vector3>();
    public static List<GameObject> go_checkpoints = new List<GameObject>();
    public static List<GameObject> go_checkpointsFiller = new List<GameObject>();
    public static Material cp_material;

    // Use this for initialization
    void Start () {
        cp_material = Resources.Load("Material/mat_checkpoint", typeof(Material)) as Material;
    }
    
    public static void createCheckpoints()
    {

        clearCheckpoints();
        //v3_cpSpots = game_map.v3_track_spots;
        foreach (Vector3 v3_ts in game_map.v3_track_spots)
        {
            v3_cpSpots.Add(new Vector3(v3_ts.x, v3_ts.y, v3_ts.z));
        }

        // Change arrays to lists so there are no empty coordinates
        for (int i = 0; i < game_map.n_track_spots; i++)
        {
            //go_checkpoints[i] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            go_checkpoints.Add(GameObject.CreatePrimitive(PrimitiveType.Cylinder));
            go_checkpoints[i].transform.position = v3_cpSpots[i];
            go_checkpoints[i].transform.Rotate(new Vector3(-90, 0, 0));
            go_checkpoints[i].transform.localScale = new Vector3(game_map.n_track_scale * 1.6f, game_map.n_track_scale, game_map.n_track_scale * 1.6f);
            go_checkpoints[i].GetComponent<Renderer>().material = cp_material;

            //go_checkpoints[i+ game_map.n_track_spots] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            go_checkpointsFiller.Add(GameObject.CreatePrimitive(PrimitiveType.Cylinder));
            go_checkpointsFiller[i].transform.position = v3_cpSpots[i];
            go_checkpointsFiller[i].transform.Rotate(new Vector3(-90, 0, 0));
            go_checkpointsFiller[i].transform.localScale = new Vector3(game_map.n_track_scale, game_map.n_track_scale*1.1f, game_map.n_track_scale);
            go_checkpointsFiller[i].GetComponent<Renderer>().material = game_map.track_material;
        }
    }

    public static void refreshCheckpoints()
    {

    }

    public static void removeCheckpoint(int int_removeCP)
    {
        v3_cpSpots.Remove(v3_cpSpots[int_removeCP]);
        Destroy(go_checkpoints[int_removeCP]);
        go_checkpoints.Remove(go_checkpoints[int_removeCP]);
        Destroy(go_checkpointsFiller[int_removeCP]);
        go_checkpointsFiller.Remove(go_checkpointsFiller[int_removeCP]);
    }


    private static void clearCheckpoints()
    {

        v3_cpSpots.Clear();

        for (int i = go_checkpoints.Count; i > 0; i--)
        {
            Destroy(go_checkpoints[0]);
            go_checkpoints.Remove(go_checkpoints[0]);
            Destroy(go_checkpointsFiller[0]);
            go_checkpointsFiller.Remove(go_checkpointsFiller[0]);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
