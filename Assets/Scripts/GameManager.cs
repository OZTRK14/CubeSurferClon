using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Transform> CubeList=new List<Transform>();
    public static GameManager instance;
    public bool Fail;
    public int Diamond;
 
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

}
