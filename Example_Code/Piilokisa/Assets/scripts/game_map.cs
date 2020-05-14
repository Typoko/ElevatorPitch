using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class game_map : MonoBehaviour {

    public static int n_track_spots = 4;
    public static float n_track_scale = 0.8f;
    public static Material track_material;

    //public static Vector3[] v3_track_spots = new Vector3[10];
    //public static GameObject[] go_track_spots = new GameObject[10];
    //public static GameObject[] go_track_roads = new GameObject[10];

    public static List<Vector3> v3_track_spots = new List<Vector3>();
    public static List<GameObject> go_track_spots = new List<GameObject>();
    public static List<GameObject> go_track_roads = new List<GameObject>();


    // Use this for initialization
    void Start () {
        track_material = Resources.Load("Material/mat_road", typeof(Material)) as Material;
        
    }

    public static void newTrack()
    {
        clearTrackObjects();
        // generate random points for the track
        // minimum amount of points is four so every quadrant will have one spot
        //v3_track_spots[0] = new Vector3(Random.Range(-4.5f, 1), Random.Range(-4.5f, 1), -4);
        //v3_track_spots[1] = new Vector3(Random.Range(-4.5f, 1), Random.Range(1, 4.5f), -4);
        //v3_track_spots[2] = new Vector3(Random.Range(1, 4.5f), Random.Range(1, 4.5f), -4);
        //v3_track_spots[3] = new Vector3(Random.Range(1, 4.5f), Random.Range(-4.5f, 1), -4);

        v3_track_spots.Add(new Vector3(Random.Range(-4.3f, 1.2f), Random.Range(-4.3f, 1.2f), -4));
        v3_track_spots.Add(new Vector3(Random.Range(-4.3f, 1.2f), Random.Range(1.2f, 4.3f), -4));
        v3_track_spots.Add(new Vector3(Random.Range(1.2f, 4.3f), Random.Range(1.2f, 4.3f), -4));
        v3_track_spots.Add(new Vector3(Random.Range(1.2f, 4.3f), Random.Range(-4.3f, 1.2f), -4));

        // Generate cylinders for spots
        for (int i = 0; i < n_track_spots; i++)
        {
            //v3_track_spots[i] = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), -4);
            //go_track_spots[i] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            go_track_spots.Add(GameObject.CreatePrimitive(PrimitiveType.Cylinder));
            go_track_spots[i].transform.position = v3_track_spots[i];
            go_track_spots[i].transform.Rotate(new Vector3(-90, 0, 0));
            go_track_spots[i].transform.localScale = new Vector3(n_track_scale, n_track_scale, n_track_scale);
            go_track_spots[i].GetComponent<Renderer>().material = track_material;
        }

        // generate connecting roads between spots
        for (int i = 0; i < n_track_spots; i++)
        {
            //go_track_roads[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go_track_roads.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
            go_track_roads[i].transform.position = setRoadPosition(i, i + 1);
            go_track_roads[i].transform.Rotate(new Vector3(0, 0, setRoadRotation(i, i + 1)));
            go_track_roads[i].transform.localScale = new Vector3(n_track_scale, setRoadLength(i, i + 1), 0.2f);
            go_track_roads[i].GetComponent<Renderer>().material = track_material;
        }
    }

    private static void clearTrackObjects()
    {
        v3_track_spots.Clear();

        for (int i = go_track_spots.Count; i > 0; i--)
        {
            Destroy(go_track_roads[0]);
            go_track_roads.Remove(go_track_roads[0]);
            Destroy(go_track_spots[0]);
            go_track_spots.Remove(go_track_spots[0]);
        }
    }

    private void shuffleSpots(Vector3[] ss_spots)
    {
        //No shuffle atm

    }

    private static Vector3 setRoadPosition(int spot1, int spot2)
    {
        if (spot2 == n_track_spots) spot2 = 0;
        return (v3_track_spots[spot1] + v3_track_spots[spot2])/2;
    }

    private static float setRoadLength(int spot1, int spot2)
    {
        if (spot2 == n_track_spots) spot2 = 0;
        
        return Vector3.Distance(v3_track_spots[spot1], v3_track_spots[spot2]);
    }

    private static float setRoadRotation(int spot1, int spot2)
    {
        if (spot2 == n_track_spots) spot2 = 0;
        //float dot = Vector3.Angle(v3_track_spots[spot1], v3_track_spots[spot2]);

        Vector3 diff = v3_track_spots[spot2] - v3_track_spots[spot1];

        float fixed_rot = Vector3.Angle(Vector3.right, diff) - 90;
        if (v3_track_spots[spot2].y < v3_track_spots[spot1].y) fixed_rot = fixed_rot * (-1);

        return fixed_rot;
    }
    

    // Update is called once per frame
    void Update () {

	}
}
