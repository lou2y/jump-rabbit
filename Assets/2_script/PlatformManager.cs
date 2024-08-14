
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class PlatformManger: MonoBehaviour
{
    [SerializeField] private Transform spawnPosTrf;
    [SerializeField] private Platform[] LargePlatformArr;
    [SerializeField] private Platform[] MiddlePlatformArr;
    [SerializeField] private Platform[] SmallPlatformArr;

    Dictionary<int, Platform[]>PlatformArrDic = new Dictionary<int, Platform[]>();

    internal void init()
    {
        PlatformArrDic.Add(0, SmallPlatformArr);
        PlatformArrDic.Add(1, MiddlePlatformArr);
        PlatformArrDic.Add(2, LargePlatformArr);

    }
    internal void Active()
    {
        Platform[] platforms = PlatformArrDic[2];

        int randID = Random.Range(0, platforms.Length);
        Platform randomPlatform = platforms[randID];

        Platform platform = Instantiate(randomPlatform);
        platform.Active(spawnPosTrf.position);
    }

}
