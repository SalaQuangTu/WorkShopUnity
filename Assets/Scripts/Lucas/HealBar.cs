using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBar : MonoBehaviour {

    void Update()
    {
        //Demonstrates the usage of each bar
        //Takes the stats and reduces or increases it for demonstration
        if (Input.GetKeyDown(KeyCode.W))
        {
            StatPlayer.statPlayer.PVPlayer += 10;
            if (StatPlayer.statPlayer.PVPlayer >= StatPlayer.statPlayer.PVPlayerMax)
            {
                StatPlayer.statPlayer.PVPlayer = StatPlayer.statPlayer.PVPlayerMax;
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            StatPlayer.statPlayer.PVPlayer -= 10;
            if (StatPlayer.statPlayer.PVPlayer <= 0)
            {
                StatPlayer.statPlayer.PVPlayer = 0;
            }
        }
    }
}
