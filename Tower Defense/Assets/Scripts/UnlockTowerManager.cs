using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockTowerManager : MonoBehaviour
{
    public GameObject UnlockTowerContainer1, UnlockTowerContainer2, UnlockTowerContainer3;

    void Update()
    {
        if (LevelManager.Instance._enemyCounter <= 14)
        {
            UnlockTowerContainer1.SetActive(false);
        }

        if(LevelManager.Instance._enemyCounter <= 10)
        {
            UnlockTowerContainer2.SetActive(false);
        }

        if(LevelManager.Instance._enemyCounter <= 3)
        {
            UnlockTowerContainer3.SetActive(false);
        }
    }
}
