using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData {
    private static int[] playerStats, enemyStats;
    private static bool playerInit = false, enemyInit = false;
    
    public static bool GetPlayerInit()
    {
        return playerInit;
    }
    public static bool GetEnemyInit()
    {
        return enemyInit;
    }

    public static void SetPlayerInit()
    {
        playerInit = true;
    }
    public static void SetEnemyInit()
    {
        enemyInit = true;
    }

    public static int[] GetPlayerStats()
    {
        return playerStats;
    }

    public static void SetPlayerStats(int[] playerData)
    {
        playerStats = playerData;
        for(int i = 0; i < playerData.Length; i++)
        {
            playerStats[i] = playerData[i];
        }
        
    }
    public static int[] GetEnemyStats()
    {
        return enemyStats;
    }

    public static void SetEnemyStats(int[] enemyData)
    {
        enemyStats = enemyData;
        for (int i = 0; i < enemyData.Length; i++)
        {
            enemyStats[i] = enemyData[i];
        }
    }
}
