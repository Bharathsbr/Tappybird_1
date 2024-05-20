using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float delay=1f;
    public float mih=-1f;
    public float mah=1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),delay,delay);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes=Instantiate(prefab,transform.position,Quaternion.identity);
        pipes.transform.position+=Vector3.up * Random.Range(mih,mah);
    }

}
