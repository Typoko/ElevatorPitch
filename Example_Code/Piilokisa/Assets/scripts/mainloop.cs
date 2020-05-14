using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class mainloop : MonoBehaviour {

    public GameObject go_player;
    public Material mat_fade;
    public Color col_Fade;
    private int int_nearCP = -1;
    private float fl_alphaChange;

    private int int_lapCount;
    public Text txt_lapCount;
    private int int_lapRecord;
    public Text txt_lapRecord;

    private bool bl_gameCanPlay;

    // Use this for initialization
    void Start () {
        newStart();
    }

    public void newStart()
    {
        int_lapRecord = 0;
        setDefaultValues();
        game_map.newTrack();
        checkpoints.createCheckpoints();
        setPlayerToStart();
        
    }

    public void resetMap()
    {
        if (int_lapRecord < int_lapCount) int_lapRecord = int_lapCount;
        setDefaultValues();
        checkpoints.createCheckpoints();
        setPlayerToStart();
    }

    public void setDefaultValues()
    {
        player_movement.max_player_speed = 0.06f;

        col_Fade = mat_fade.color;
        col_Fade.a = 0f;
        mat_fade.color = col_Fade;

        fl_alphaChange = 0;//0.001f;

        int_lapCount = 0;
        txt_lapCount.text = "Laps: " + int_lapCount.ToString();

        txt_lapRecord.text = "Record: " + int_lapRecord.ToString();

        bl_gameCanPlay = true;
        player_movement.bl_canMove = true;
    }
    
    public void setPlayerToStart()
    {
        go_player.transform.position = new Vector3 (game_map.v3_track_spots[0].x, game_map.v3_track_spots[0].y,-7);
    }

    private int playerOnCheckpoint()
    {
        // If player is on a certain checkpoint it will be returned
        // foreach (Vector3 v3_ts in game_map.v3_track_spots) Cant use due extra spots on array, needs to be converted to list to have modular tracks
        for (int i = 0; i < checkpoints.v3_cpSpots.Count; i++)
        {   
            if ((Mathf.Pow(go_player.transform.position.x - checkpoints.v3_cpSpots[i].x,2)+Mathf.Pow(go_player.transform.position.y - checkpoints.v3_cpSpots[i].y,2))<0.7f)
            {
                return i;                
            }
        }
        return -1;
    }

    private void checkPointReached(int int_cpReached)
    {
        checkpoints.removeCheckpoint(int_cpReached);

        if (checkpoints.v3_cpSpots.Count == 0)
        {
            checkpoints.createCheckpoints();
            player_movement.max_player_speed += 0.005f;
            fl_alphaChange += 0.0008f;

            col_Fade = mat_fade.color;
            col_Fade.a = 0f;
            mat_fade.color = col_Fade;

            int_lapCount++;
            txt_lapCount.text = "Laps: " + int_lapCount.ToString();
        }
    }

    private void isPlayerOnTrack()
    {
        

        if(!playerDistanceFromTrack(0.65f))
        {
            bl_gameCanPlay = false;
            player_movement.bl_canMove = false;
        }
    }

    private bool playerDistanceFromTrack(float fl_playerFromTrack)
    {
        // [PROBLEM]Calculates whole vector and not only between points

        float x0 = go_player.transform.position.x;
        float y0 = go_player.transform.position.y;

        float x1;
        float y1;

        float x2;
        float y2;


        for (int i = 0;i<3;i++)
        {
            x1 = game_map.v3_track_spots[i].x;
            y1 = game_map.v3_track_spots[i].y;

            x2 = game_map.v3_track_spots[i+1].x;
            y2 = game_map.v3_track_spots[i+1].y;
            // This is to check that if the player is in between the two points
            if(((x1- fl_playerFromTrack <= x0 && x0<=x2+ fl_playerFromTrack) || (x2- fl_playerFromTrack <= x0 && x0 <= x1+ fl_playerFromTrack)) && ((y1- fl_playerFromTrack <= y0 && y0 <= y2+ fl_playerFromTrack) || (y2- fl_playerFromTrack <= y0 && y0 <= y1+ fl_playerFromTrack)))
            { 
                // Calcualte distance of a point from a lane created by two points
                if ((Mathf.Abs((y2-y1)*x0 -(x2-x1)*y0 + x2*y1 - y2*x1) / (Mathf.Sqrt( Mathf.Pow(y2-y1,2)+Mathf.Pow(x2-x1,2)))) < fl_playerFromTrack)
                {
                    return true;
                }
            }


        }

        x1 = game_map.v3_track_spots[3].x;
        y1 = game_map.v3_track_spots[3].y;

        x2 = game_map.v3_track_spots[0].x;
        y2 = game_map.v3_track_spots[0].y;

        if (((x1 - fl_playerFromTrack <= x0 && x0 <= x2 + fl_playerFromTrack) || (x2 - fl_playerFromTrack <= x0 && x0 <= x1 + fl_playerFromTrack)) && ((y1 - fl_playerFromTrack <= y0 && y0 <= y2 + fl_playerFromTrack) || (y2 - fl_playerFromTrack <= y0 && y0 <= y1 + fl_playerFromTrack)))
        {
            if ((Mathf.Abs((y2 - y1) * x0 - (x2 - x1) * y0 + x2 * y1 - y2 * x1) / (Mathf.Sqrt(Mathf.Pow(y2 - y1, 2) + Mathf.Pow(x2 - x1, 2)))) < fl_playerFromTrack)
            {
                return true;
            }
        }

        return false;
    }

    public void exitGame()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("f5"))
        {
            newStart();
        }
        if (Input.GetKeyDown("space"))
        {
            resetMap();
        }
        if (Input.GetKey("escape"))
        { 
            Application.Quit();
        }

        if (bl_gameCanPlay)
        {
            // [TODO]If player goes off the road the game stops
            
            int_nearCP = playerOnCheckpoint();
            if (int_nearCP != -1)
            {
                checkPointReached(int_nearCP);
            }

            if(mat_fade.color.a<1)
            { 
                col_Fade = mat_fade.color;
                col_Fade.a += fl_alphaChange;
                mat_fade.color = col_Fade;
            }

            isPlayerOnTrack();
        }
    }
    
}
