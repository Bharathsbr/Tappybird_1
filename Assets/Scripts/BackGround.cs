using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private MeshRenderer mr;
    public float animateSpeed=1f;


    private void Awake()
    {
        mr=GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        mr.material.mainTextureOffset += new Vector2(animateSpeed*Time.deltaTime,0f);
    }
}
