using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatPlayer : MonoBehaviour {

    #region statPlayer
    public static StatPlayer statPlayer;
    private void Awake()
    {
        statPlayer = this;
    }
    #endregion

    public int PVPlayerMax;
    public int PVPlayer;
    public int LVL;
    public int XP;
    public int force;

    public BarScript bar;

    private void Start()
    {
        PVPlayerMax = 65 + 5 * LVL;
        force = 5 * LVL;
        PVPlayer = PVPlayerMax;
        bar.MaxValue = PVPlayerMax;
    }

    private void Update()
    {
        bar.Value = PVPlayer;
    }

    public void LVLUP()
    {
        //add feedback
        LVL += 1;
        PVPlayerMax = PVPlayerMax + 5 * LVL;
        force = force + 5 * LVL;
    }

    public void XPGain(int XPpoints)
    {
        XP = XP + XPpoints;
        
        if(XP >= LVL*150)
        {
            LVLUP();
        }
    }
}
